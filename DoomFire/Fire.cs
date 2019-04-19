using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoomFire
{
    public class Fire
    {
        private int pixelWidth;
        private int pixelHeight;
        private int lines;
        private int columns;
        private int[,] fireArray;
        private bool isDebuging;
        private Color[] colorsPalette;
        private int baseDecay;
        private WindDirection windFlow;

        public enum WindDirection
        {
            Left,
            Right,
            NoWind
        }

        private void InitColorsPalette()
        {
            colorsPalette = new Color[36];
            colorsPalette[0] = Color.FromArgb(7, 7, 7);
            colorsPalette[1] = Color.FromArgb(31, 7, 7);
            colorsPalette[2] = Color.FromArgb(47, 15, 7);
            colorsPalette[3] = Color.FromArgb(71, 15, 7);
            colorsPalette[4] = Color.FromArgb(87, 23, 7);
            colorsPalette[5] = Color.FromArgb(103, 31, 7);
            colorsPalette[6] = Color.FromArgb(119, 31, 7);
            colorsPalette[7] = Color.FromArgb(143, 39, 7);
            colorsPalette[8] = Color.FromArgb(159, 47, 7);
            colorsPalette[9] = Color.FromArgb(175, 63, 7);
            colorsPalette[10] = Color.FromArgb(191, 71, 7);
            colorsPalette[11] = Color.FromArgb(199, 71, 7);
            colorsPalette[12] = Color.FromArgb(223, 79, 7);
            colorsPalette[13] = Color.FromArgb(223, 87, 7);
            colorsPalette[14] = Color.FromArgb(223, 87, 7);
            colorsPalette[15] = Color.FromArgb(215, 95, 7);
            colorsPalette[16] = Color.FromArgb(215, 103, 15);
            colorsPalette[17] = Color.FromArgb(207, 111, 15);
            colorsPalette[18] = Color.FromArgb(207, 119, 15);
            colorsPalette[19] = Color.FromArgb(207, 127, 15);
            colorsPalette[20] = Color.FromArgb(207, 135, 23);
            colorsPalette[21] = Color.FromArgb(199, 135, 23);
            colorsPalette[22] = Color.FromArgb(199, 143, 23);
            colorsPalette[23] = Color.FromArgb(199, 151, 31);
            colorsPalette[24] = Color.FromArgb(191, 159, 31);
            colorsPalette[25] = Color.FromArgb(191, 159, 31);
            colorsPalette[26] = Color.FromArgb(191, 167, 39);
            colorsPalette[27] = Color.FromArgb(191, 167, 39);
            colorsPalette[28] = Color.FromArgb(191, 175, 47);
            colorsPalette[29] = Color.FromArgb(183, 175, 47);
            colorsPalette[30] = Color.FromArgb(183, 183, 47);
            colorsPalette[31] = Color.FromArgb(183, 183, 55);
            colorsPalette[32] = Color.FromArgb(207, 207, 111);
            colorsPalette[33] = Color.FromArgb(223, 223, 159);
            colorsPalette[34] = Color.FromArgb(239, 239, 199);
            colorsPalette[35] = Color.FromArgb(255, 255, 255);
        }

        public Fire(int lines, int columns)
        {
            fireArray = new int[lines, columns];
            this.lines = lines;
            this.columns = columns;
            pixelHeight = 499/lines;
            pixelWidth = 499/columns;
            isDebuging = false;
            baseDecay = 3;
            windFlow = WindDirection.NoWind;
            InitColorsPalette();
            InitTable();
        }

        public void SetDebug(bool debug)
        {
            isDebuging = debug;
        }

        private void InitTable()
        {
            for (int line = 1; line < lines; line++)
            {
                for (int column = 0; column < columns; column++)
                    fireArray[line, column] =  0;
            }
        }

        public void DrawTable(Graphics graphics)
        {
            for (int line = 0; line < lines; line++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (isDebuging)
                    {
                        Rectangle pixel = new Rectangle(pixelWidth * column, pixelHeight * line, pixelWidth, pixelHeight);
                        graphics.DrawRectangle(Pens.Black, pixel);
                        graphics.DrawString(fireArray[line, column].ToString(), new Font("Arial", 5), new SolidBrush(colorsPalette[fireArray[line, column]]), pixel);
                    }
                    else
                    {
                        Rectangle pixel = new Rectangle(pixelWidth * column, pixelHeight * line, pixelWidth, pixelHeight);
                        SolidBrush color = new SolidBrush(colorsPalette[fireArray[line, column]]);
                        graphics.FillRectangle(color, pixel);
                    }
                }
            }
        }

        public void CalculateFirePropagation()
        {
            Random random = new Random();
            
            for(int column = 0; column < columns; column++)
            {
                for(int line = 0; line < lines - 1; line++)
                    UpdateFireCell(line, column, random);
            }
        }

        private void UpdateFireCell(int line, int column, Random random)
        {
            int decay = random.Next(0, baseDecay);
            int wind = random.Next(1, 100);

            switch (windFlow)
            {
                case WindDirection.Left:
                    if (wind >= 50 && column > 0)
                        fireArray[line, column - 1] = fireArray[line + 1, column] - decay > 0 ? fireArray[line + 1, column] - decay : 0;
                    else
                        fireArray[line, column] = fireArray[line + 1, column] - decay > 0 ? fireArray[line + 1, column] - decay : 0;
                    break;

                case WindDirection.Right:
                    if (wind >= 50 && column < columns - 1)
                        fireArray[line, column + 1] = fireArray[line + 1, column] - decay > 0 ? fireArray[line + 1, column] - decay : 0;
                    else
                        fireArray[line, column] = fireArray[line + 1, column] - decay > 0 ? fireArray[line + 1, column] - decay : 0;
                    break;

                case WindDirection.NoWind:
                    fireArray[line, column] = fireArray[line + 1, column] - decay > 0 ? fireArray[line + 1, column] - decay : 0;
                    break;
            }
        }

        public void IncreaseFire()
        {
            if(baseDecay > 2)
                baseDecay--;
        }

        public void DecreaseFire()
        {
            if (baseDecay < 14)
                baseDecay++;
        }

        public void SetFireDirection(WindDirection direction)
        {
            windFlow = direction;
        }

        public void StopFire()
        {
            for(int column = 0; column < columns; column++)
                fireArray[lines - 1, column] = 0;
        }

        public void StartFire()
        {
            for (int column = 0; column < columns; column++)
                fireArray[lines - 1, column] = 35;
        }
    }
}
