using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetPhoneData method accepts a CellPhone object
        // as an argument. It assigns the data entered by the
        // user to the object's properties.
        private void GetPhoneData(CellPhone phone)
        {
            decimal price;

            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;

            //嘗試將價格從文字轉換為十進位數字。
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                //如果轉換成功，將價格設定到 phone 物件的 Price 屬性。
                phone.Price = price;
            }
            else
            {
                //如果轉換失敗，顯示錯誤訊息並清除價格欄位。
                MessageBox.Show("請輸入有效的價格。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                priceTextBox.Clear();
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellPhone myphone = new CellPhone();

            //呼叫 GetPhoneData 方法，將 myphone 物件傳遞給它。
            GetPhoneData(myphone);

            //將 myphone 物件的資料顯示在訊息方塊中。
            brandLabel.Text = myphone.Brand;
            modelLabel.Text = myphone.Model;
            priceLabel.Text = myphone.Price.ToString("C2");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
