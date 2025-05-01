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
            testScores.AddRange(new[] { 85, 90, 78, 92, 88 }); // 模擬讀取的分數

            // 更新 testScoresListBox
            testScoresListBox.Items.Clear();
            foreach (var score in testScores)
            {
                testScoresListBox.Items.Add(score);
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            // 清空排序後的 ListBox
            sortedScoresListBox.Items.Clear();

            // 將排序後的分數顯示在 sortedScoresListBox
            foreach (var score in testScores.OrderBy(x => x))
            {
                sortedScoresListBox.Items.Add(score);
            }
        }
    }
}
