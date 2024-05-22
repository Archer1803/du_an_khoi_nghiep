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
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 21);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 11;
            label4.Text = "Timer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 270);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 15;
            label1.Text = "00:00:00";
            // 
            // button4
            // 
            button4.Location = new Point(65, 318);
            button4.Name = "button4";
            button4.Size = new Size(131, 23);
            button4.TabIndex = 16;
            button4.Text = "Starts";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(227, 318);
            button5.Name = "button5";
            button5.Size = new Size(137, 23);
            button5.TabIndex = 17;
            button5.Text = "Resert";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(308, 19);
            button6.Name = "button6";
            button6.Size = new Size(100, 27);
            button6.TabIndex = 28;
            button6.Text = "Stop";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(202, 19);
            button7.Name = "button7";
            button7.Size = new Size(100, 27);
            button7.TabIndex = 27;
            button7.Text = "Pause";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(96, 19);
            button8.Name = "button8";
            button8.Size = new Size(100, 27);
            button8.TabIndex = 26;
            button8.Text = "Starts";
            button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(99, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 195);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 425);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Micro Đa Năng ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox1;
    }
}