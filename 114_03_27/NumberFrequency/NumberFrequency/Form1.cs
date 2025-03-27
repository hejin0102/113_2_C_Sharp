namespace NumberFrequency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int SIZE = 100;
            int num;
            double frequency;
            Random random = new Random();
            int[] numbers = new int[SIZE];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }

            if (int.TryParse(NumbertextBox1.Text, out num))
            {
                frequency = (double)frequencyOfNumber(numbers, num) / SIZE;
                MessageBox.Show("�Ʀr " + num + " �X�{�����v�� " + (frequency * 100).ToString("F2") + "%");
            }
            else
            {
                MessageBox.Show("���A���~�G��J������");
            }
        }

        private int frequencyOfNumber(int[] numbers, int num)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
