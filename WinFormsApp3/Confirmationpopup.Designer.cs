namespace WinFormsApp3
{
    partial class Confirmationpopup
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(265, 112);
            label1.TabIndex = 3;
            label1.Text = "            Thank you!\r\nYour booking is confirmed. \r\n Expect an email with your \r\n     confirmation in a bit!";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources._766182_people_512x512;
            pictureBox1.Location = new Point(-40, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.YellowGreen;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkBlue;
            button3.Location = new Point(30, 138);
            button3.Name = "button3";
            button3.Size = new Size(234, 43);
            button3.TabIndex = 20;
            button3.Text = "BACK TO HOMEPAGE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(116, 221);
            label2.Name = "label2";
            label2.Size = new Size(168, 100);
            label2.TabIndex = 21;
            label2.Text = "  Want to review \r\n your booking or\r\n make a change? \r\nNo problem at all!";
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkBlue;
            button2.Location = new Point(116, 336);
            button2.Name = "button2";
            button2.Size = new Size(168, 64);
            button2.TabIndex = 22;
            button2.Text = "ALTER RESERVATION";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Confirmationpopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FINAL;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(296, 432);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Confirmationpopup";
            Text = "Confirmationpopup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label2;
        private Button button2;
    }
}