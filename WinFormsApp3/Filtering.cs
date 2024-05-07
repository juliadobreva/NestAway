using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static WinFormsApp3.authenticate;


namespace WinFormsApp3
{
    public partial class Filtering : Form
    {
        private User authenticatedUser;

        public Filtering(User user)
        {
            InitializeComponent();

            authenticatedUser = user;
            label1.Text = $"Welcome, {authenticatedUser.Username}! Let's find the perfect apartment for you!";
        }

        private void Filtering_Load_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=NestAway; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM aptinfo WHERE 1 = 1";

                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (comboBox1.SelectedItem != null)
                    conditions.Add("maxguests = @maxguests");

                if (comboBox2.SelectedItem != null)
                    conditions.Add("kitchen = @kitchen");

                if (comboBox3.SelectedItem != null)
                    conditions.Add("other = @other");

                if (comboBox4.SelectedItem != null)
                    conditions.Add("availability_status = @availability_status");

                // combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values
                cmd.Parameters.AddWithValue("@maxguests", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@kitchen", comboBox2.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@other", comboBox3.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@availability_status", comboBox4.SelectedItem.ToString());


                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Booking userInputForm = new Booking())
            {
                // Display the form as a dialog
                userInputForm.ShowDialog();

            }
        }
    }
}
