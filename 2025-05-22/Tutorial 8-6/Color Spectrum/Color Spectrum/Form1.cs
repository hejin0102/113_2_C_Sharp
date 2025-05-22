using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Spectrum
{
    enum Spectrum
    {
        Red, Orange, Yellow, Green,
        Blue, Indigo, Violet
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 將所有顏色相關的 Label 的 Text 屬性設為 null
            redLabel.Text = null;
            orangeLabel.Text = null;
            yellowLabel.Text = null;
            greenLabel.Text = null;
            blueLabel.Text = null;
            indigoLabel.Text = null;
            violetLabel.Text = null;
            colorLabel.Text = null;
        }

        // The DisplayColor method displays the
        // name of a color in Traditional Chinese.
        private void DisplayColor(Spectrum color)
        {
            switch (color)
            {
                case Spectrum.Red:
                    colorLabel.Text = "紅色";
                    break;
                case Spectrum.Orange:
                    colorLabel.Text = "橙色";
                    break;
                case Spectrum.Yellow:
                    colorLabel.Text = "黃色";
                    break;
                case Spectrum.Green:
                    colorLabel.Text = "綠色";
                    break;
                case Spectrum.Blue:
                    colorLabel.Text = "藍色";
                    break;
                case Spectrum.Indigo:
                    colorLabel.Text = "靛色";
                    break;
                case Spectrum.Violet:
                    colorLabel.Text = "紫色";
                    break;
                default:
                    colorLabel.Text = "未知顏色";
                    break;
            }
        }

        private void redLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Red);
        }

        private void orangeLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Orange);
        }

        private void yellowLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Yellow);
        }

        private void greenLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Green);
        }

        private void blueLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Blue);
        }

        private void indigoLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Indigo);
        }

        private void violetLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Violet);
        }
    }
}
