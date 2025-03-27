namespace File_To_Array
{
    partial class Form1
    {
        /// <summary>
        /// 必需的設計器變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放託管資源，則為 true；否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 設計器支持所需的方法 - 請勿使用代碼編輯器修改此方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.getValuesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(28, 12);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(179, 95);
            this.outputListBox.TabIndex = 0;
            // 
            // getValuesButton
            // 
            this.getValuesButton.Location = new System.Drawing.Point(39, 113);
            this.getValuesButton.Name = "getValuesButton";
            this.getValuesButton.Size = new System.Drawing.Size(75, 23);
            this.getValuesButton.TabIndex = 1;
            this.getValuesButton.Text = "取得數值";
            this.getValuesButton.UseVisualStyleBackColor = true;
            this.getValuesButton.Click += new System.EventHandler(this.getValuesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(120, 113);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 148);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getValuesButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.Text = "檔案到陣列";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button getValuesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

