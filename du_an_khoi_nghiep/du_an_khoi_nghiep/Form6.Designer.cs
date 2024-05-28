namespace du_an_khoi_nghiep
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            button4 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.ButtonHighlight;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tiếng Việt", "Tiếng Anh", "Tiếng Hàn ", "Tiếng Trung" });
            comboBox2.Location = new Point(428, 117);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 15;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(434, 93);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 14;
            label4.Text = "ngôn ngữ gốc";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ButtonHighlight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tiếng Việt", "Tiếng Anh", "Tiếng Hàn ", "Tiếng Trung" });
            comboBox1.Location = new Point(646, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(657, 93);
            label3.Name = "label3";
            label3.Size = new Size(78, 13);
            label3.TabIndex = 12;
            label3.Text = "ngôn ngữ đích";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(288, 21);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 16;
            label1.Text = "chuyển đổi âm thanh";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 255, 128);
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(167, 297);
            button4.Name = "button4";
            button4.Size = new Size(89, 29);
            button4.TabIndex = 31;
            button4.Text = "Dừng ghi ";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(434, 198);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 227);
            textBox1.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(222, 152);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 34;
            label2.Text = "lựa chọn";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 255);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(288, 211);
            button1.Name = "button1";
            button1.Size = new Size(92, 29);
            button1.TabIndex = 37;
            button1.Text = "xoá";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(12, 213);
            button3.Name = "button3";
            button3.Size = new Size(145, 27);
            button3.TabIndex = 38;
            button3.Text = "Tự động phát khi dịch xong";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Location = new Point(434, 171);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 39;
            label5.Text = "nội dung nghe được";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 329);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 40;
            label6.Text = "chạm 3 lần ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(299, 255);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 41;
            label7.Text = "chạm 2 lần";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 255);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 42;
            label8.Text = "chạm 1 lần";
            // 
            // button2
            // 
            button2.Location = new Point(635, 469);
            button2.Name = "button2";
            button2.Size = new Size(132, 30);
            button2.TabIndex = 43;
            button2.Text = "Về trang chủ";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 537);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            Text = "Micro Đa Năng ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private Label label1;
        private Button button4;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button button3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
    }
}