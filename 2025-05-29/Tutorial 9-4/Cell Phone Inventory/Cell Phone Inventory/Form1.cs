using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // List to hold CellPhone objects
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        // The GetPhoneData method accepts a CellPhone object
        // as an argument. It assigns the data entered by the
        // user to the object's properties.
        private void GetPhoneData(CellPhone phone)
        {
            // Temporary variable to hold the price.
            decimal price;

            // Get the phone's brand.
            phone.Brand = brandTextBox.Text;

            // Get the phone's model.
            phone.Model = modelTextBox.Text;

            // Get the phone's price.
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid price");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            CellPhone myphone = new CellPhone(); //建立新的 CellPhone 物件

            GetPhoneData(myphone); //取得使用者輸入資料

            //將新的手機物件加入到清單中
            phoneList.Add(myphone);

            //將新的手機物件顯示在 ListBox 中
            phoneListBox.Items.Add(myphone.Brand + " " + myphone.Model);
            //清空輸入欄位
            brandTextBox.Text = "";
            modelTextBox.Text = "";
            priceTextBox.Text = "";
            //將焦點設回品牌輸入欄位
            brandTextBox.Focus();
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = phoneListBox.SelectedIndex; //取得選取的索引

            MessageBox.Show(phoneList[index].Price.ToString("C")); //顯示選取手機的價格，格式化為貨幣格式
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
