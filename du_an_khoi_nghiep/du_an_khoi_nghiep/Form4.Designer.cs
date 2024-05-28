namespace du_an_khoi_nghiep
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(340, 41);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 11;
            label4.Text = "Phát lại âm thanh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(425, 283);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 15;
            label1.Text = "00:00:00";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 128, 255);
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.ImageAlign = ContentAlignment.BottomRight;
            button4.Location = new Point(97, 199);
            button4.Name = "button4";
            button4.Size = new Size(177, 34);
            button4.TabIndex = 16;
            button4.Text = "bắt đầu phát lại ghi âm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 192, 128);
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.ImageAlign = ContentAlignment.BottomRight;
            button5.Location = new Point(102, 295);
            button5.Name = "button5";
            button5.Size = new Size(169, 34);
            button5.TabIndex = 17;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 255, 128);
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(273, 85);
            button7.Name = "button7";
            button7.Size = new Size(150, 27);
            button7.TabIndex = 27;
            button7.Text = "Pause/Stop";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 128, 128);
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(91, 85);
            button8.Name = "button8";
            button8.Size = new Size(150, 27);
            button8.TabIndex = 26;
            button8.Text = "Starts / continue";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button2
            // 
            button2.Location = new Point(647, 72);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 30;
            button2.Text = "giọng nam (AI)";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(647, 118);
            button3.Name = "button3";
            button3.Size = new Size(100, 40);
            button3.TabIndex = 31;
            button3.Text = "giọng nữ (AI)";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 32;
            textBox1.Text = "nhấn cảm ứng 1 lần";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(291, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 33;
            textBox2.Text = "nhấn cảm ứng 2 lần";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(510, 91);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 50);
            textBox3.TabIndex = 34;
            textBox3.Text = "lựa chọn ngôn ngữ khác (nếu cần)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(533, 176);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 57);
            textBox4.TabIndex = 35;
            textBox4.Text = "lưu ý : nếu chuyển ngôn ngữ khác phải đợi phần mềm chuyển đổi thành công mới bất đầu ghi lại";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(121, 239);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(120, 23);
            textBox5.TabIndex = 36;
            textBox5.Text = "nhấn cảm ứng 3 lần";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(121, 335);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 23);
            textBox6.TabIndex = 37;
            textBox6.Text = "nhấn cảm ứng 4 lần";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}