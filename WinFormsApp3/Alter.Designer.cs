namespace WinFormsApp3
{
    partial class Alter
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
            textBox1 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(113, 30);
            label1.Name = "label1";
            label1.Size = new Size(547, 62);
            label1.TabIndex = 2;
            label1.Text = "PLEASE PROVIDE THE NAME OF THE RESERVATION\r\n              YOU WANT TO VIEW OR CHANGE:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ControlDarkDark;
            textBox1.Location = new Point(33, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 31);
            textBox1.TabIndex = 9;
            textBox1.Text = "Name & Surname";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkBlue;
            button2.Location = new Point(490, 116);
            button2.Name = "button2";
            button2.Size = new Size(253, 33);
            button2.TabIndex = 19;
            button2.Text = "SEARCH FOR BOOKING";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(710, 223);
            dataGridView1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(434, 414);
            label7.Name = "label7";
            label7.Size = new Size(309, 34);
            label7.TabIndex = 21;
            label7.Text = "        YOU CAN EDIT YOUR RESERVATION BY \r\nSIMPLY CORRECTING THE VALUES IN THE TABLE :)";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(33, 413);
            button1.Name = "button1";
            button1.Size = new Size(253, 33);
            button1.TabIndex = 22;
            button1.Text = "CANCEL RESERVATION";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Alter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FINAL;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(781, 475);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Alter";
            Text = "Alter";
            Load += Alter_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label7;
        private Button button1;
    }
}