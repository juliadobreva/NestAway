using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Registration form = new Registration();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Login form = new Login();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Aboutus form = new Aboutus();
            form.Show();
        }
    }
}
