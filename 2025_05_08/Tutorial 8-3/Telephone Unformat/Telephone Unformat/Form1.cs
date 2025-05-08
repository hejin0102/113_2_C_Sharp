using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // `IsValidFormat` 方法接受一個字串參數，並判斷該字串是否符合美國電話號碼的格式。
        // 格式要求如下：(XXX)XXX-XXXX，其中：
        // - `XXX` 是三位數字，括號包圍。
        // - `XXX` 是三位數字，緊接在括號後。
        // - `XXXX` 是四位數字，前面有一個連字符（-）。
        // 如果字串符合上述格式，則方法返回 `true`，否則返回 `false`。
        private bool IsValidFormat(string str)
        {
            // 檢查字串是否為空，並使用正則表達式判斷是否符合格式 (XXX)XXX-XXXX
            if (!string.IsNullOrEmpty(str) && System.Text.RegularExpressions.Regex.IsMatch(str, @"^\(\d{3}\)\d{3}-\d{4}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // `Unformat` 方法接受一個字串參數（以引用方式傳遞），該字串假設為格式化的電話號碼。
        // 格式為：(XXX)XXX-XXXX。
        // 此方法的功能是移除字串中的括號和連字符，將其轉換為純數字格式，例如：XXXXXXXXXX。
        private void Unformat(ref string str)
        {
            // 如果字串不為空，則移除括號和連字符
            if (!string.IsNullOrEmpty(str))
            {
                str = str.Replace("(", "")  // 移除左括號
                         .Replace(")", "")  // 移除右括號
                         .Replace("-", ""); // 移除連字符
            }
        }

        // `unformatButton_Click` 方法是當使用者按下「去格式化」按鈕時觸發的事件處理器。
        // 此方法會檢查使用者輸入的電話號碼是否符合格式要求。
        // 如果符合，則去除格式並顯示純數字的電話號碼。
        // 如果不符合，則顯示錯誤訊息。
        private void unformatButton_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入的電話號碼
            string phoneNumber = numberTextBox.Text;

            // 檢查電話號碼是否符合格式
            if (IsValidFormat(phoneNumber))
            {
                // 去除格式
                Unformat(ref phoneNumber);

                // 顯示去格式化後的電話號碼
                MessageBox.Show($"去格式化後的電話號碼為：{phoneNumber}", "結果");
            }
            else
            {
                // 顯示錯誤訊息
                MessageBox.Show("請輸入正確格式的電話號碼：(XXX)XXX-XXXX", "錯誤");
            }
        }

        // `exitButton_Click` 方法是當使用者按下「離開」按鈕時觸發的事件處理器。
        // 此方法會關閉表單，結束應用程式。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
