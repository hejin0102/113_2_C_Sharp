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

namespace Phonebook
{
    // 結構 PhoneBookEntry 用來儲存每一筆聯絡人資料，包括姓名與電話號碼
    struct PhoneBookEntry
    {
        public string name;   // 聯絡人姓名
        public string phone;  // 聯絡人電話號碼
    }

    public partial class Form1 : Form
    {
        // 用來儲存所有聯絡人資料的清單，每一筆資料為 PhoneBookEntry 結構
        private List<PhoneBookEntry> phoneList =
            new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        // 讀取 PhoneList.txt 檔案內容，將每一行資料分割為姓名與電話號碼，
        // 並存入 phoneList 清單中。如果檔案不存在，顯示錯誤訊息。
        private void ReadFile()
        {
            StreamReader inputFile; // 宣告檔案讀取物件
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 開啟檔案並讀取內容
                    inputFile = File.OpenText(openFile.FileName); //開啟檔案
                    string line;
                    while (!inputFile.EndOfStream) // 讀取檔案直到結尾
                    {
                        // 將每一行資料分割為姓名與電話號碼
                        line = inputFile.ReadLine().Trim();
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            // 將姓名與電話號碼存入 phoneList 清單中
                            PhoneBookEntry entry;
                            entry.name = parts[0].Trim();
                            entry.phone = parts[1].Trim();
                            phoneList.Add(entry);
                        }
                        else
                        {
                            MessageBox.Show("資料格式錯誤: ");
                        }
                    }
                    inputFile.Close(); // 關閉檔案
                }
                catch (Exception ex) // 如果發生例外狀況，顯示錯誤訊息
                {
                    MessageBox.Show("無法讀取檔案: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("未選擇檔案");
            }
        }

        // 將 phoneList 清單中的所有聯絡人姓名顯示在 nameListBox 控制項中。
        // 若清單為空，顯示提示訊息。
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name); // 將姓名加入到 listbox 中
            }
        }

        // 表單載入時執行，會呼叫 ReadFile 讀取資料並顯示所有聯絡人姓名。
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile(); //讀取電話簿資料

            DisplayNames(); //顯示所有聯絡人姓名，在lilstbox中
        }

        // 當使用者在 nameListBox 選取不同的姓名時，顯示對應的電話號碼。
        // 若選取的項目無對應資料，則清空電話號碼欄位。
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex; // 取得選取的索引
            if ( index != -1)
            {
                phoneLabel.Text = phoneList[index].phone; // 顯示對應的電話號碼
            }
            else
            {
                phoneLabel.Text = "無資料"; // 沒有選擇任何姓名則清空電話號碼欄位
            }
        }

        // 按下「離開」按鈕時，關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhonebookEntry entry;
            entry.name = textBox1.Text;
        }
    }
}
