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

namespace WinFormsApp3
{
    public partial class Alter : Form
    {
        private string connectionString = @"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=NestAway; Integrated Security=True; Encrypt=False;";
        private DataTable originalDataTable;
        public Alter()
        {
            InitializeComponent();
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alter_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchname = textBox1.Text;

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=NestAway; Integrated Security=True; Encrypt=False;"))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM Bookings WHERE customer_name LIKE @customer_name";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                    adapter.SelectCommand.Parameters.AddWithValue("@customer_name", "%" + searchname + "%");
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to delete.");
                return;
            }

            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            int AptID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["AptID"].Value);

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=NestAway; Integrated Security=True; Encrypt=False;"))
            {
                try
                {
                    sqlCon.Open();
                    string query = "DELETE FROM Bookings WHERE AptID = @AptID";
                    SqlCommand command = new SqlCommand(query, sqlCon);
                    command.Parameters.AddWithValue("@AptID", AptID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking deleted successfully.");
                        button1_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow editedRow = dataGridView1.Rows[e.RowIndex];
            int AptID = Convert.ToInt32(editedRow.Cells["AptID"].Value);
            string updatedCustomerName = Convert.ToString(editedRow.Cells["customer_name"].Value);
            string updatedNumberGuests = Convert.ToString(editedRow.Cells["numguests"].Value);
            string updatedCheckinDate = Convert.ToString(editedRow.Cells["checkindate"].Value);
            string updatedCheckoutDate = Convert.ToString(editedRow.Cells["checkoutdate"].Value);

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE Bookings SET customer_name = @customer_name, numguests = @numguests, checkindate = @checkindate, checkoutdate = @checkoutdate WHERE AptID = @AptID";
                    SqlCommand command = new SqlCommand(query, sqlCon);
                    command.Parameters.AddWithValue("@customer_name", updatedCustomerName);
                    command.Parameters.AddWithValue("@numguests", updatedNumberGuests);
                    command.Parameters.AddWithValue("@checkindate", updatedCheckinDate);
                    command.Parameters.AddWithValue("@checkoutdate", updatedCheckoutDate);
                    command.Parameters.AddWithValue("@AptID", AptID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update booking.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


    }
}
