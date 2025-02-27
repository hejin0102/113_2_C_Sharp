namespace Tutorial_4_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            kmtextBox1 = new TextBox();
            gasTextBox2 = new TextBox();
            averageLabel4 = new Label();
            calculateButton1 = new Button();
            exitButton1 = new Button();
            logListBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F);
            label1.Location = new Point(44, 59);
            label1.Name = "label1";
            label1.Size = new Size(204, 35);
            label1.TabIndex = 0;
            label1.Text = "輸入行駛里程數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20F);
            label2.Location = new Point(44, 187);
            label2.Name = "label2";
            label2.Size = new Size(204, 35);
            label2.TabIndex = 1;
            label2.Text = "消耗油量公升數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20F);
            label3.Location = new Point(71, 316);
            label3.Name = "label3";
            label3.Size = new Size(177, 35);
            label3.TabIndex = 2;
            label3.Text = "您的平均油耗";
            // 
            // kmtextBox1
            // 
            kmtextBox1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            kmtextBox1.Location = new Point(359, 59);
            kmtextBox1.Name = "kmtextBox1";
            kmtextBox1.Size = new Size(216, 42);
            kmtextBox1.TabIndex = 3;
            kmtextBox1.TextChanged += kmtextBox1_TextChanged;
            // 
            // gasTextBox2
            // 
            gasTextBox2.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            gasTextBox2.Location = new Point(359, 184);
            gasTextBox2.Name = "gasTextBox2";
            gasTextBox2.Size = new Size(216, 42);
            gasTextBox2.TabIndex = 4;
            // 
            // averageLabel4
            // 
            averageLabel4.BorderStyle = BorderStyle.Fixed3D;
            averageLabel4.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            averageLabel4.Location = new Point(359, 301);
            averageLabel4.Name = "averageLabel4";
            averageLabel4.Size = new Size(216, 50);
            averageLabel4.TabIndex = 5;
            averageLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculateButton1
            // 
            calculateButton1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            calculateButton1.Location = new Point(100, 387);
            calculateButton1.Name = "calculateButton1";
            calculateButton1.Size = new Size(130, 51);
            calculateButton1.TabIndex = 6;
            calculateButton1.Text = "計算";
            calculateButton1.UseVisualStyleBackColor = true;
            calculateButton1.Click += calculateButton1_Click;
            // 
            // exitButton1
            // 
            exitButton1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            exitButton1.Location = new Point(385, 387);
            exitButton1.Name = "exitButton1";
            exitButton1.Size = new Size(130, 51);
            exitButton1.TabIndex = 7;
            exitButton1.Text = "離開";
            exitButton1.UseVisualStyleBackColor = true;
            exitButton1.Click += exitButton1_Click;
            // 
            // logListBox1
            // 
            logListBox1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            logListBox1.FormattingEnabled = true;
            logListBox1.ItemHeight = 24;
            logListBox1.Location = new Point(594, 72);
            logListBox1.Name = "logListBox1";
            logListBox1.Size = new Size(194, 244);
            logListBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(621, 334);
            button1.Name = "button1";
            button1.Size = new Size(130, 51);
            button1.TabIndex = 9;
            button1.Text = "總平均油耗";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(logListBox1);
            Controls.Add(exitButton1);
            Controls.Add(calculateButton1);
            Controls.Add(averageLabel4);
            Controls.Add(gasTextBox2);
            Controls.Add(kmtextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox kmtextBox1;
        private TextBox gasTextBox2;
        private Label averageLabel4;
        private Button calculateButton1;
        private Button exitButton1;
        private ListBox logListBox1;
        private Button button1;
    }
}
