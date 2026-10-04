namespace A90Winlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Location = new Point(11, 209);
            label1.Name = "label1";
            label1.Size = new Size(572, 140);
            label1.TabIndex = 0;
            label1.Text = "Your files have\r\n been encrypted by a virus known as ransomware; \r\nenter the code into the window to unlock the system.\r\n\r\nSupport the creator:https://www.donationalerts.com/r/1mmst1off";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ransom_idle;
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 177);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(375, 82);
            label2.Name = "label2";
            label2.Size = new Size(176, 81);
            label2.TabIndex = 2;
            label2.Text = "02:00";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 397);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 33);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(585, 397);
            button1.Name = "button1";
            button1.Size = new Size(103, 33);
            button1.TabIndex = 4;
            button1.Text = "Unblock";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(715, 468);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Ransom";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}
