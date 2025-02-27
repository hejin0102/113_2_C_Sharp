namespace Tutorial_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kmtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton1_Click(object sender, EventArgs e)
        {
            double distance, gas, average; // 宣告區域變數

            if (double.TryParse(kmtextBox1.Text, out distance))
            {
                if (double.TryParse(gasTextBox2.Text, out gas))
                {
                    // 判斷是否為數字
                    average = distance / gas; // 計算平均值
                    averageLabel4.Text = average.ToString("f2") + "公里/公升"; // 顯示平均值
                    logListBox1.Items.Add(average.ToString("f2") + "公里/公升"); // 加入紀錄
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                    gasTextBox2.Focus(); // 將游標移至gasTextBox
                    gasTextBox2.Text = ""; // 清空TextBox
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
                kmtextBox1.Focus(); // 將游標移至kmTextBox
                kmtextBox1.Text = ""; // 清空TextBox
            }
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            this.Close(); // 關閉視窗
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logListBox1.Items.Clear(); // 清空ListBox
            logListBox1.Items.Add("平均油耗紀錄");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0; // 宣告區域變數
            if (logListBox1.Items.Count > 1)
            {
                for (int i = 1; i < logListBox1.Items.Count; i++)
                {
                    sum += double.Parse(logListBox1.Items[i].ToString().Replace("公里/公升", "")); // 累加平均油耗
                }
                logListBox1.Items.Add("平均油耗：" + (sum / (logListBox1.Items.Count - 1)).ToString("f2") + "公里/公升"); // 顯示平均油耗
            }
            else
            {
                MessageBox.Show("沒有紀錄");
            }
        }
    }
}
