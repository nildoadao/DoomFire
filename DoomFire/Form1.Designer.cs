namespace DoomFire
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirePicture = new System.Windows.Forms.PictureBox();
            this.DebugCheckBox = new System.Windows.Forms.CheckBox();
            this.IncreaseFireButton = new System.Windows.Forms.Button();
            this.DecreaseFireButton = new System.Windows.Forms.Button();
            this.NoWindRadioButton = new System.Windows.Forms.RadioButton();
            this.RightWindRadioButton = new System.Windows.Forms.RadioButton();
            this.LeftWindRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InitFireButton = new System.Windows.Forms.Button();
            this.StopFireButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FirePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // FirePicture
            // 
            this.FirePicture.Location = new System.Drawing.Point(29, 27);
            this.FirePicture.Name = "FirePicture";
            this.FirePicture.Size = new System.Drawing.Size(500, 500);
            this.FirePicture.TabIndex = 0;
            this.FirePicture.TabStop = false;
            // 
            // DebugCheckBox
            // 
            this.DebugCheckBox.AutoSize = true;
            this.DebugCheckBox.Location = new System.Drawing.Point(535, 29);
            this.DebugCheckBox.Name = "DebugCheckBox";
            this.DebugCheckBox.Size = new System.Drawing.Size(58, 17);
            this.DebugCheckBox.TabIndex = 1;
            this.DebugCheckBox.Text = "Debug";
            this.DebugCheckBox.UseVisualStyleBackColor = true;
            this.DebugCheckBox.CheckedChanged += new System.EventHandler(this.DebugCheckBox_CheckedChanged);
            // 
            // IncreaseFireButton
            // 
            this.IncreaseFireButton.Location = new System.Drawing.Point(535, 64);
            this.IncreaseFireButton.Name = "IncreaseFireButton";
            this.IncreaseFireButton.Size = new System.Drawing.Size(31, 23);
            this.IncreaseFireButton.TabIndex = 2;
            this.IncreaseFireButton.Text = "+";
            this.IncreaseFireButton.UseVisualStyleBackColor = true;
            this.IncreaseFireButton.Click += new System.EventHandler(this.IncreaseFireButton_Click);
            // 
            // DecreaseFireButton
            // 
            this.DecreaseFireButton.Location = new System.Drawing.Point(535, 93);
            this.DecreaseFireButton.Name = "DecreaseFireButton";
            this.DecreaseFireButton.Size = new System.Drawing.Size(31, 23);
            this.DecreaseFireButton.TabIndex = 3;
            this.DecreaseFireButton.Text = "-";
            this.DecreaseFireButton.UseVisualStyleBackColor = true;
            this.DecreaseFireButton.Click += new System.EventHandler(this.DecreaseFireButton_Click);
            // 
            // NoWindRadioButton
            // 
            this.NoWindRadioButton.AutoSize = true;
            this.NoWindRadioButton.Location = new System.Drawing.Point(536, 123);
            this.NoWindRadioButton.Name = "NoWindRadioButton";
            this.NoWindRadioButton.Size = new System.Drawing.Size(77, 17);
            this.NoWindRadioButton.TabIndex = 4;
            this.NoWindRadioButton.TabStop = true;
            this.NoWindRadioButton.Text = "Sem Vento";
            this.NoWindRadioButton.UseVisualStyleBackColor = true;
            this.NoWindRadioButton.CheckedChanged += new System.EventHandler(this.NoWindRadioButton_CheckedChanged);
            // 
            // RightWindRadioButton
            // 
            this.RightWindRadioButton.AutoSize = true;
            this.RightWindRadioButton.Location = new System.Drawing.Point(536, 147);
            this.RightWindRadioButton.Name = "RightWindRadioButton";
            this.RightWindRadioButton.Size = new System.Drawing.Size(93, 17);
            this.RightWindRadioButton.TabIndex = 5;
            this.RightWindRadioButton.TabStop = true;
            this.RightWindRadioButton.Text = "Vento a direita";
            this.RightWindRadioButton.UseVisualStyleBackColor = true;
            this.RightWindRadioButton.CheckedChanged += new System.EventHandler(this.RightWindRadioButton_CheckedChanged);
            // 
            // LeftWindRadioButton
            // 
            this.LeftWindRadioButton.AutoSize = true;
            this.LeftWindRadioButton.Location = new System.Drawing.Point(536, 171);
            this.LeftWindRadioButton.Name = "LeftWindRadioButton";
            this.LeftWindRadioButton.Size = new System.Drawing.Size(109, 17);
            this.LeftWindRadioButton.TabIndex = 6;
            this.LeftWindRadioButton.TabStop = true;
            this.LeftWindRadioButton.Text = "Vento a esquerda";
            this.LeftWindRadioButton.UseVisualStyleBackColor = true;
            this.LeftWindRadioButton.CheckedChanged += new System.EventHandler(this.LeftWindRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Aumentar Fogo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Diminuir Fogo";
            // 
            // InitFireButton
            // 
            this.InitFireButton.Location = new System.Drawing.Point(536, 205);
            this.InitFireButton.Name = "InitFireButton";
            this.InitFireButton.Size = new System.Drawing.Size(115, 23);
            this.InitFireButton.TabIndex = 9;
            this.InitFireButton.Text = "Ascender Fogo";
            this.InitFireButton.UseVisualStyleBackColor = true;
            this.InitFireButton.Click += new System.EventHandler(this.InitFireButton_Click);
            // 
            // StopFireButton
            // 
            this.StopFireButton.Location = new System.Drawing.Point(536, 235);
            this.StopFireButton.Name = "StopFireButton";
            this.StopFireButton.Size = new System.Drawing.Size(115, 23);
            this.StopFireButton.TabIndex = 10;
            this.StopFireButton.Text = "Apagar Fogo";
            this.StopFireButton.UseVisualStyleBackColor = true;
            this.StopFireButton.Click += new System.EventHandler(this.StopFireButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.StopFireButton);
            this.Controls.Add(this.InitFireButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftWindRadioButton);
            this.Controls.Add(this.RightWindRadioButton);
            this.Controls.Add(this.NoWindRadioButton);
            this.Controls.Add(this.DecreaseFireButton);
            this.Controls.Add(this.IncreaseFireButton);
            this.Controls.Add(this.DebugCheckBox);
            this.Controls.Add(this.FirePicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FirePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FirePicture;
        private System.Windows.Forms.CheckBox DebugCheckBox;
        private System.Windows.Forms.Button IncreaseFireButton;
        private System.Windows.Forms.Button DecreaseFireButton;
        private System.Windows.Forms.RadioButton NoWindRadioButton;
        private System.Windows.Forms.RadioButton RightWindRadioButton;
        private System.Windows.Forms.RadioButton LeftWindRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InitFireButton;
        private System.Windows.Forms.Button StopFireButton;
    }
}

