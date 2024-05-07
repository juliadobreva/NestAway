namespace WinFormsApp3
{
    partial class Registration
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
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            length = new Label();
            capital = new Label();
            number = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(227, 32);
            label1.Name = "label1";
            label1.Size = new Size(208, 28);
            label1.TabIndex = 0;
            label1.Text = "REGISTRATION FORM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(28, 95);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 23);
            textBox1.TabIndex = 2;
            textBox1.Validating += textBox1_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(28, 172);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 3;
            label3.Text = "E-mail:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 23);
            textBox2.TabIndex = 4;
            textBox2.Validating += textBox2_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSkyBlue;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(28, 259);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(28, 279);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(279, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Validating += textBox3_Validating;
            // 
            // length
            // 
            length.AutoSize = true;
            length.BackColor = Color.LightSkyBlue;
            length.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            length.Location = new Point(28, 322);
            length.Name = "length";
            length.Size = new Size(243, 12);
            length.TabIndex = 7;
            length.Text = "Your password should include more than 8 characters.";
            // 
            // capital
            // 
            capital.AutoSize = true;
            capital.BackColor = Color.LightSkyBlue;
            capital.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            capital.Location = new Point(28, 345);
            capital.Name = "capital";
            capital.Size = new Size(247, 12);
            capital.TabIndex = 8;
            capital.Text = "Your password should include at least one capital letter.";
            // 
            // number
            // 
            number.AutoSize = true;
            number.BackColor = Color.LightSkyBlue;
            number.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            number.Location = new Point(28, 368);
            number.Name = "number";
            number.Size = new Size(230, 12);
            number.TabIndex = 9;
            number.Text = "Your password should include at least one number.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSkyBlue;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(363, 95);
            label5.Name = "label5";
            label5.Size = new Size(103, 17);
            label5.TabIndex = 11;
            label5.Text = "Phone number:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(363, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(279, 23);
            textBox4.TabIndex = 12;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.LightSkyBlue;
            checkBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.DarkBlue;
            checkBox1.Location = new Point(351, 192);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(311, 21);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "I agree with NestAway's Terms and Conditions.";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.LightSkyBlue;
            checkBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.DarkBlue;
            checkBox2.Location = new Point(300, 237);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(362, 21);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "I would like to be notified about promotions via e-mail.";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(377, 304);
            button1.Name = "button1";
            button1.Size = new Size(226, 43);
            button1.TabIndex = 17;
            button1.Text = "CREATE ACCOUNT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(429, 350);
            label6.Name = "label6";
            label6.Size = new Size(112, 13);
            label6.TabIndex = 18;
            label6.Text = "BACK TO HOMEPAGE";
            label6.Click += label6_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FINAL;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(688, 429);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(number);
            Controls.Add(capital);
            Controls.Add(length);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label length;
        private Label capital;
        private Label number;
        private Label label5;
        private TextBox textBox4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private Label label6;
    }
}