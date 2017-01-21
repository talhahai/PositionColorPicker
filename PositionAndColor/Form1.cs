using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PositionAndColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBPosX.Text = Cursor.Position.X.ToString();
            TBPosY.Text = Cursor.Position.Y.ToString();
            TBPosCombined.Text = Cursor.Position.X + ", " + Cursor.Position.Y;

            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(Cursor.Position, new Point(0, 0), new Size(1, 1));
                }

                int Red = Convert.ToInt32(bitmap.GetPixel(0, 0).R);
                int Green = Convert.ToInt32(bitmap.GetPixel(0, 0).G);
                int Blue = Convert.ToInt32(bitmap.GetPixel(0, 0).B);

                string ColorHex = "#" + Red.ToString("X2") + "" + Green.ToString("X2") + "" + Blue.ToString("X2"); ;

                TBColorHex.Text = ColorHex;
                TBColorRed.Text = Red.ToString();
                TBColorGreen.Text = Green.ToString();
                TBColorBlue.Text = Blue.ToString();
                TBColorCombined.Text = Red + ", " + Green + ", " + Blue;

                PanelColor.BackColor = bitmap.GetPixel(0, 0);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RBCombined_CheckedChanged(object sender, EventArgs e)
        {
            if (RBCombined.Checked)
            {
                TBPosCombined.Visible = true;
                TBColorCombined.Visible = true;

                TBPosX.Visible = false;
                TBPosY.Visible = false;
                TBColorRed.Visible = false;
                TBColorGreen.Visible = false;
                TBColorBlue.Visible = false;
            }
            else
            {
                TBPosX.Visible = true;
                TBPosY.Visible = true;
                TBColorRed.Visible = true;
                TBColorGreen.Visible = true;
                TBColorBlue.Visible = true;

                TBPosCombined.Visible = false;
                TBColorCombined.Visible = false;
            }
        }
    }
}
