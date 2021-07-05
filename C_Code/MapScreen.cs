using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace C_Code
{
    class MapScreen : Form
    {
        private float[,] pixels;
        private int Mul;
        public MapScreen(int sizeMul, float[,] pixelArray)
        {
            int Breedte = pixelArray.GetLength(0) * sizeMul;
            int Hoogte = pixelArray.GetLength(1) * sizeMul;
            this.Text = "MapScreen";
            this.BackColor = Color.White;
            this.ClientSize = new Size(Breedte, Hoogte);
            pixels = pixelArray;
            Mul = sizeMul;
            this.Paint += this.Tekenen;
        }

        void Tekenen(object obj, PaintEventArgs pea)
        {
            int xi = 0, yi = 0;
            Brush GradientBrush;

            // Squares
            for(int y = 0; y < pixels.GetLength(0); y++)
            {
                for(int x =0; x < pixels.GetLength(1); x++)
                {
                    /*Console.WriteLine(xi + " : " + yi + " : " + pixels[x,y] );*/
                    int value = (int)(255 * pixels[x, y]);
                    /*Console.WriteLine(value + " : " + pixels[x,y]);*/
                    GradientBrush = new SolidBrush(Color.FromArgb(value, value, value));
                    pea.Graphics.FillRectangle(GradientBrush, xi, yi, Mul, Mul);
                    yi += Mul;
                }
                yi = 0;
                xi += Mul;
            }
        }
    }
}
