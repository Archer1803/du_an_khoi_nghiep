namespace du_an_khoi_nghiep
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 126);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 7;
            label1.Text = "Voice Conversion";
            // 
            // button1
            // 
            button1.Location = new Point(30, 159);
            button1.Name = "button1";
            button1.Size = new Size(120, 44);
            button1.TabIndex = 8;
            button1.Text = "Voice Conversion";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(212, 126);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 9;
            label2.Text = "Pronunciation Timer";
            // 
            // button2
            // 
            button2.Location = new Point(212, 159);
            button2.Name = "button2";
            button2.Size = new Size(151, 44);
            button2.TabIndex = 10;
            button2.Text = "Pronunciation Timer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(212, 266);
            button3.Name = "button3";
            button3.Size = new Size(151, 44);
            button3.TabIndex = 14;
            button3.Text = "Convert audio to text";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(212, 233);
            label3.Name = "label3";
            label3.Size = new Size(155, 21);
            label3.TabIndex = 13;
            label3.Text = "Convert audio to text";
            // 
            // button4
            // 
            button4.Location = new Point(30, 266);
            button4.Name = "button4";
            button4.Size = new Size(120, 44);
            button4.TabIndex = 12;
            button4.Text = "Voice translation";
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 233);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 11;
            label4.Text = "Voice Translation";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 465);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Label label3;
        private Button button4;
        private Label label4;
    }
}