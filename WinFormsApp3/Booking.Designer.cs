namespace WinFormsApp3
{
    partial class Booking
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            customer_name = new TextBox();
            label2 = new Label();
            AptID = new ComboBox();
            numguests = new TextBox();
            checkindate = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            checkoutdate = new DateTimePicker();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(288, 56);
            label1.TabIndex = 2;
            label1.Text = "PLEASE FILL OUT THE DETAILS\r\n     OF YOUR RESERVATION!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 171);
            label3.Name = "label3";
            label3.Size = new Size(27, 32);
            label3.TabIndex = 4;
            label3.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSkyBlue;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 225);
            label4.Name = "label4";
            label4.Size = new Size(27, 32);
            label4.TabIndex = 5;
            label4.Text = "3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSkyBlue;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 288);
            label5.Name = "label5";
            label5.Size = new Size(28, 32);
            label5.TabIndex = 6;
            label5.Text = "4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSkyBlue;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(15, 361);
            label6.Name = "label6";
            label6.Size = new Size(27, 32);
            label6.TabIndex = 7;
            label6.Text = "5";
            // 
            // customer_name
            // 
            customer_name.ForeColor = SystemColors.ControlDarkDark;
            customer_name.Location = new Point(52, 115);
            customer_name.Name = "customer_name";
            customer_name.Size = new Size(252, 23);
            customer_name.TabIndex = 8;
            customer_name.Text = "Name & Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 110);
            label2.Name = "label2";
            label2.Size = new Size(24, 32);
            label2.TabIndex = 9;
            label2.Text = "1";
            // 
            // AptID
            // 
            AptID.ForeColor = SystemColors.ControlDarkDark;
            AptID.FormattingEnabled = true;
            AptID.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18" });
            AptID.Location = new Point(52, 172);
            AptID.Name = "AptID";
            AptID.Size = new Size(252, 23);
            AptID.TabIndex = 10;
            AptID.Text = "Apartment No";
            // 
            // numguests
            // 
            numguests.ForeColor = SystemColors.ControlDarkDark;
            numguests.Location = new Point(50, 232);
            numguests.Name = "numguests";
            numguests.Size = new Size(252, 23);
            numguests.TabIndex = 11;
            numguests.Text = "Number of guests";
            // 
            // checkindate
            // 
            checkindate.Location = new Point(52, 307);
            checkindate.Name = "checkindate";
            checkindate.Size = new Size(252, 23);
            checkindate.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSkyBlue;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(52, 287);
            label7.Name = "label7";
            label7.Size = new Size(93, 17);
            label7.TabIndex = 13;
            label7.Text = "Check-in date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightSkyBlue;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(52, 359);
            label8.Name = "label8";
            label8.Size = new Size(103, 17);
            label8.TabIndex = 15;
            label8.Text = "Check-out date:";
            label8.Click += label8_Click;
            // 
            // checkoutdate
            // 
            checkoutdate.Location = new Point(52, 379);
            checkoutdate.Name = "checkoutdate";
            checkoutdate.Size = new Size(252, 23);
            checkoutdate.TabIndex = 14;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkBlue;
            button3.Location = new Point(76, 436);
            button3.Name = "button3";
            button3.Size = new Size(205, 43);
            button3.TabIndex = 21;
            button3.Text = "FINALIZE BOOKING";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FINAL;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(356, 507);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(checkoutdate);
            Controls.Add(label7);
            Controls.Add(checkindate);
            Controls.Add(numguests);
            Controls.Add(AptID);
            Controls.Add(label2);
            Controls.Add(customer_name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Booking";
            Text = "Booking";
            Load += Booking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox customer_name;
        private Label label2;
        private ComboBox AptID;
        private TextBox numguests;
        private DateTimePicker checkindate;
        private Label label7;
        private Label label8;
        private DateTimePicker checkoutdate;
        private Button button3;
    }
}