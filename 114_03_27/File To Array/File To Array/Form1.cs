﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace File_To_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getValuesButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 建立一個陣列來存放從檔案中讀取的項目，陣列大小為5
                const int SIZE = 5;
                int[] numbers = new int[SIZE];

                // 用於迴圈的計數變數
                int index = 0;

                // 宣告一個 StreamReader 變數，用於讀取檔案
                StreamReader inputFile;

                // 開啟檔案並取得 StreamReader 物件
                inputFile = File.OpenText("Values.txt");

                // 將檔案內容讀取到陣列中，直到陣列填滿或檔案結束
                while (index < numbers.Length && !inputFile.EndOfStream)
                {
                    numbers[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                // 關閉檔案
                inputFile.Close();

                // 將陣列元素顯示在列表框中
                foreach (int value in numbers)
                {
                    outputListBox.Items.Add(value);
                }
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
