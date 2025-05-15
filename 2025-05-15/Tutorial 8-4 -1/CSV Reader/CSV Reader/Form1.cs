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

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = null; // Initialize inputFile to null  
            try
            {
                string line; //用來讀取的每一列資料  
                int count = 0; //計算每一列資料的數量  
                int total = 0; //計算每一列資料的總和  
                double average; //計算每一列資料的平均值  

                char[] delim = { ',',':' }; //分隔符號  

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Open the file.  
                    inputFile = File.OpenText(openFileDialog1.FileName);

                    while (!inputFile.EndOfStream)
                    {
                        //讀取每一列資料  
                        line = inputFile.ReadLine();
                        line = line.Trim(); //去除前後空白  
                        string[] tokens = line.Split(delim); //分隔每一列資料  
                        total = 0; //每一列資料的總和歸零

                        //將字串轉換為整數，並累加到總分數中  
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            //將字串轉換為整數，並累加到總分數中  
                            total += int.Parse(tokens[i]);
                        }
                        //計算平均值  
                        average = (double)total / (tokens.Length - 1);
                        //將平均值加入ListBox中  
                        averagesListBox.Items.Add(tokens[0] + " 平均分數為：" + average.ToString("F2"));
                    }
                }
                else
                {
                    //使用者位選擇任何檔案，顯示提示訊息  
                    MessageBox.Show("未選擇任何檔案。");
                }
            }
            catch (Exception ex)
            {
                // Display the error message.  
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close the file if it was opened.  
                if (inputFile != null)
                    inputFile.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.  
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
