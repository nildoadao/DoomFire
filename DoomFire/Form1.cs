using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoomFire
{
    public partial class Form1 : Form
    {
        private Fire fire;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fire = new Fire(120, 80);
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
            FirePicture.Paint += FirePicture_Paint;
            NoWindRadioButton.Checked = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            fire.CalculateFirePropagation();
            FirePicture.Invalidate();
        }

        private void FirePicture_Paint(object sender, PaintEventArgs e)
        {
            fire.DrawTable(e.Graphics);
        }

        private void DebugCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fire.SetDebug(DebugCheckBox.Checked);
        }

        private void IncreaseFireButton_Click(object sender, EventArgs e)
        {
            fire.IncreaseFire();
        }

        private void DecreaseFireButton_Click(object sender, EventArgs e)
        {
            fire.DecreaseFire();
        }

        private void NoWindRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NoWindRadioButton.Checked)
                fire.SetFireDirection(Fire.WindDirection.NoWind);
        }

        private void RightWindRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RightWindRadioButton.Checked)
                fire.SetFireDirection(Fire.WindDirection.Right);
        }

        private void LeftWindRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LeftWindRadioButton.Checked)
                fire.SetFireDirection(Fire.WindDirection.Left);
        }

        private void InitFireButton_Click(object sender, EventArgs e)
        {
            fire.StartFire();
        }

        private void StopFireButton_Click(object sender, EventArgs e)
        {
            fire.StopFire();
        }
    }
}
