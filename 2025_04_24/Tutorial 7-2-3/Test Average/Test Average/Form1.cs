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
        private List<int> testScores = new List<int>(); // 用於存放測試分數的清單

        public Form1()
        {
            InitializeComponent();
        }

        // Average 方法接受一個 List<int> 參數
        // 並返回該清單中值的平均值。
        private double Average(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("The list is empty or null.");
            }
            return numbers.Average();
        }

        // Highest 方法接受一個 List<int> 參數
        // 並返回該清單中的最大值。
        private int Highest(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("The list is empty or null.");
            }
            return numbers.Max();
        }

        // Lowest 方法接受一個 List<int> 參數
        // 並返回該清單中的最小值。
        private int Lowest(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("The list is empty or null.");
            }
            return numbers.Min();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            testScores.Clear(); // 清空清單
            int highestScore = 0;
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
                    sortedScoresListBox.Items.Clear();
                    // 從文件中讀取測試分數。
                    while (!inputFile.EndOfStream)
                    {
                        int score = Convert.ToInt32(inputFile.ReadLine());
                        testScores.Add(score);
                        // 將分數添加到 ListBox。
                        testScoresListBox.Items.Add(score);
                    }
                    inputFile.Close();
                    // 計算平均分數、最高分數和最低分數。
                    averageScore = Average(testScores);
                    highestScore = Highest(testScores);
                    lowestScore = Lowest(testScores);
                    // 顯示結果。
                    averageScoreLabel.Text = averageScore.ToString("n1");
                    highScoreLabel.Text = highestScore.ToString();
                    lowScoreLabel.Text = lowestScore.ToString();

                    // 將排序後的分數顯示在 sortedScoresListBox
                    foreach (var score in testScores.OrderBy(x => x))
                    {
                        sortedScoresListBox.Items.Add(score);
                    }
                }
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息。
                MessageBox.Show(ex.Message, "錯誤");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // 確認是否有選中項目
            if (testScoresListBox.SelectedIndex != -1)
            {
                // 取得選中項目的索引
                int selectedIndex = testScoresListBox.SelectedIndex;

                // 從 testScores 清單中移除對應的分數
                testScores.RemoveAt(selectedIndex);

                // 更新 testScoresListBox
                testScoresListBox.Items.RemoveAt(selectedIndex);

                // 更新 sortedScoresListBox
                sortedScoresListBox.Items.Clear();
                foreach (var score in testScores.OrderBy(x => x))
                {
                    sortedScoresListBox.Items.Add(score);
                }

                // 更新平均分數、最高分數和最低分數
                if (testScores.Count > 0)
                {
                    averageScoreLabel.Text = Average(testScores).ToString("n1");
                    highScoreLabel.Text = Highest(testScores).ToString();
                    lowScoreLabel.Text = Lowest(testScores).ToString();
                }
                else
                {
                    // 如果清單為空，清空顯示
                    averageScoreLabel.Text = string.Empty;
                    highScoreLabel.Text = string.Empty;
                    lowScoreLabel.Text = string.Empty;
                }
            }
            else
            {
                // 如果沒有選中項目，顯示提示訊息
                MessageBox.Show("請選擇要刪除的分數。", "提示");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
