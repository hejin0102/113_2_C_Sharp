using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_List
{
    struct Automobile
    {
        public string make;
        public int year;
        public double mileage;
    }

    public partial class Form1 : Form
    {
        // 建立一個汽車清單（List），用來儲存所有汽車資料
        private List<Automobile> carList = new List<Automobile>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取得使用者輸入的資料，並指派給傳入的 Automobile 結構參數
        /// </summary>
        /// <param name="auto">要填入資料的 Automobile 結構參數（以 ref 傳遞）</param>
        private void GetData(ref Automobile auto)
        {
            try
            {
                // 從三個 TextBox 取得使用者輸入的廠牌、年份與里程數
                auto.make = makeTextBox.Text;
                auto.year = int.Parse(yearTextBox.Text);
                auto.mileage = double.Parse(mileageTextBox.Text);
            }
            catch (Exception ex)
            {
                // 若發生例外（如格式錯誤），顯示錯誤訊息（以繁體中文顯示）
                MessageBox.Show("輸入資料格式錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 當使用者按下「新增汽車」按鈕時執行
        /// 1. 建立一個新的 Automobile 結構
        /// 2. 取得使用者輸入的資料
        /// 3. 將汽車資料加入清單
        /// 4. 清空輸入欄位並將游標移回廠牌欄位
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            // 建立一個新的 Automobile 結構實例
            Automobile car = new Automobile();

            // 取得使用者輸入的資料，填入 car 結構
            GetData(ref car);

            // 將 car 物件加入汽車清單
            carList.Add(car);

            // 清空所有輸入欄位
            makeTextBox.Clear();
            yearTextBox.Clear();
            mileageTextBox.Clear();

            // 將游標移回廠牌輸入欄位，方便繼續輸入
            makeTextBox.Focus();
        }

        /// <summary>
        /// 當使用者按下「顯示清單」按鈕時執行
        /// 1. 清空 ListBox 內容
        /// 2. 將所有汽車資料以格式化字串顯示於 ListBox
        /// </summary>
        private void displayButton_Click(object sender, EventArgs e)
        {
            // 宣告一個字串變數，用來儲存每一行要顯示的內容
            string output;

            // 清空 ListBox 目前的內容
            carListBox.Items.Clear();

            // 逐一將汽車清單中的每一筆資料格式化後加入 ListBox
            foreach (Automobile aCar in carList)
            {
                // 將年份、廠牌與里程數組合成一行顯示字串（以繁體中文顯示）
                output = aCar.year + " 年 " + aCar.make +
                    "，里程數：" + aCar.mileage + " 英里";

                // 將格式化後的字串加入 ListBox
                carListBox.Items.Add(output);
            }
        }
    }
}
