using System;
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

            //使用迴圈生成5個1到42之間的隨機數，並存入lotteryNumbers 陣列中
            for (int i = 0; i < lotteryNumbers.Length; i++)
            {
                //產生1到42之間的亂數(包含1和42)，確認產生的亂數沒有與陣列中元素重複，再放入陣列中
                int number;
                do
                {
                    number = rand.Next(1,43);//產生1到42之間的隨機數
                }while (lotteryNumbers.Contains(number));//檢查是否存在陣列中
                lotteryNumbers[i] = number;//將隨機數存入陣列
            }

            //將lotteryNumbers 陣列中的數字由小到大排序
            Array.Sort(lotteryNumbers); //使用Array.Sort 方法將 lotteryNumbers 陣列中的數字進行排列

            //註解掉的原始碼程式碼，逐一將樂透號碼顯示在對應的標籤上
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
