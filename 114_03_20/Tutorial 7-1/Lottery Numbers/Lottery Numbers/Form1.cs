﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 5;  // 陣列的大小
            int[] lotteryNumbers = new int[SIZE];  // 用來儲存樂透號碼的陣列
            Random rand = new Random();  // 用來產生亂數的物件

            for (int i = 0; i < lotteryNumbers.Length; i++)
            {
                lotteryNumbers[i] = rand.Next(1, 43);
            }

            //firstLabel.Text = lotteryNumbers[0].ToString();
            //secondLabel.Text = lotteryNumbers[1].ToString();
            //thirdLabel.Text = lotteryNumbers[2].ToString();
            //fourthLabel.Text = lotteryNumbers[3].ToString();
            //fifthLabel.Text = lotteryNumbers[4].ToString();

            //使用迴圈來顯示樂透號碼
            Label[] showLabels = { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };
            for (int i = 0; i < showLabels.Length; i++)
            {
                showLabels[i].Text = lotteryNumbers[i].ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
