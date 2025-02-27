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
            double distance, gas, average; // �ŧi�ϰ��ܼ�

            if (double.TryParse(kmtextBox1.Text, out distance))
            {
                if (double.TryParse(gasTextBox2.Text, out gas))
                {
                    // �P�_�O�_���Ʀr
                    average = distance / gas; // �p�⥭����
                    averageLabel4.Text = average.ToString("f2") + "����/����"; // ��ܥ�����
                    logListBox1.Items.Add(average.ToString("f2") + "����/����"); // �[�J����
                }
                else
                {
                    MessageBox.Show("�п�J�Ʀr");
                    gasTextBox2.Focus(); // �N��в���gasTextBox
                    gasTextBox2.Text = ""; // �M��TextBox
                }
            }
            else
            {
                MessageBox.Show("�п�J�Ʀr");
                kmtextBox1.Focus(); // �N��в���kmTextBox
                kmtextBox1.Text = ""; // �M��TextBox
            }
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            this.Close(); // ��������
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logListBox1.Items.Clear(); // �M��ListBox
            logListBox1.Items.Add("�����o�Ӭ���");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0; // �ŧi�ϰ��ܼ�
            if (logListBox1.Items.Count > 1)
            {
                for (int i = 1; i < logListBox1.Items.Count; i++)
                {
                    sum += double.Parse(logListBox1.Items[i].ToString().Replace("����/����", "")); // �֥[�����o��
                }
                logListBox1.Items.Add("�����o�ӡG" + (sum / (logListBox1.Items.Count - 1)).ToString("f2") + "����/����"); // ��ܥ����o��
            }
            else
            {
                MessageBox.Show("�S������");
            }
        }
    }
}
