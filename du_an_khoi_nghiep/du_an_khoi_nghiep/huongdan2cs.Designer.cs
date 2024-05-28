namespace du_an_khoi_nghiep
{
    partial class huongdan2cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(huongdan2cs));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(309, 53);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 2;
            label1.Text = "lựa chọn chức năng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(337, 28);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 3;
            label2.Text = "micro đa năng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(154, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(517, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(95, 251);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 63);
            textBox1.TabIndex = 6;
            textBox1.Text = "Micro có chức năng ghi âm và phát lại những gì đã được nói có nhiều công dụng hữu ích cho người nghe ";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(449, 251);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 63);
            textBox2.TabIndex = 7;
            textBox2.Text = "Micro có chức năng ghi âm và chuyển đổi giọng nói , tích hơp giọng AI để nói đa ngôn ngữ trong 1 nơi có người nghe thuộc đa ngôn ngữ";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(154, 337);
            button1.Name = "button1";
            button1.Size = new Size(135, 32);
            button1.TabIndex = 8;
            button1.Text = "chọn chức năng này";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(517, 337);
            button2.Name = "button2";
            button2.Size = new Size(137, 32);
            button2.TabIndex = 9;
            button2.Text = "chọn chức năng này";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(639, 399);
            button3.Name = "button3";
            button3.Size = new Size(132, 30);
            button3.TabIndex = 10;
            button3.Text = "Về trang chủ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // huongdan2cs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "huongdan2cs";
            Text = "huongdan2cs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}