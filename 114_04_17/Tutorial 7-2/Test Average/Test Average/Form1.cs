using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Average 方法接受一個 int 陣列參數
        // 並返回該陣列中值的平均值。
        private double Average(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The array is empty or null.");
            }
            return numbers.Average();
        }

        // Highest 方法接受一個 int 陣列參數
        // 並返回該陣列中的最大值。
        private int Highest(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The array is empty or null.");
            }
            return numbers.Max();
        }

        // Lowest 方法接受一個 int 陣列參數
        // 並返回該陣列中的最小值。
        private int Lowest(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The array is empty or null.");
            }
            return numbers.Min();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 48;
            int[] testScores = new int[SIZE];
            int index = 0;
            int highestScoer = 0;
            int lowestScore = 0;
            double averageScore = 0.0;
            StreamReader inputFile;
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    // 打開文件。  
                    inputFile = File.OpenText(openFile.FileName);
                    // 清空 ListBox。  
                    testScoresListBox.Items.Clear();
                    // 從文件中讀取測試分數。  
                    while (!inputFile.EndOfStream && index < SIZE)
                    {
                        testScores[index] = Convert.ToInt32(inputFile.ReadLine());
                        // 將分數添加到 ListBox。  
                        testScoresListBox.Items.Add(testScores[index]);
                        index++;
                    }
                    inputFile.Close();
                    // 計算平均分數、最高分數和最低分數。  
                    averageScore = Average(testScores);
                    highestScoer = Highest(testScores);
                    lowestScore = Lowest(testScores);
                    // 顯示結果。  
                    averageScoreLabel.Text = averageScore.ToString("n1");
                    highScoreLabel.Text = highestScoer.ToString();
                    lowScoreLabel.Text = lowestScore.ToString();
                }
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息。  
                MessageBox.Show(ex.Message, "錯誤");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
