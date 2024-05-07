using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=NestAway; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Check if the room is available
                string availabilityQuery = "SELECT availability_status FROM aptinfo WHERE AptID = @AptID";

                SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, sqlCon);
                availabilityCmd.Parameters.AddWithValue("@AptID", AptID.Text);
                string availabilityResult = availabilityCmd.ExecuteScalar().ToString().Trim();

                if (availabilityResult.Equals("Available", StringComparison.OrdinalIgnoreCase))
                {
                    string insertQuery = "INSERT INTO Bookings VALUES (@AptID, @customer_name, @numguests, @checkindate, @checkoutdate)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                    // Set parameters based on selected values
                    insertCmd.Parameters.AddWithValue("@AptID", AptID.Text);
                    insertCmd.Parameters.AddWithValue("@customer_name", customer_name.Text);
                    insertCmd.Parameters.AddWithValue("@numguests", numguests.Text);
                    insertCmd.Parameters.AddWithValue("@checkindate", checkindate.Value);
                    insertCmd.Parameters.AddWithValue("@checkoutdate", checkoutdate.Value);

                    insertCmd.ExecuteNonQuery();

                    // Update room availability status
                    string updateAvailabilityQuery = "UPDATE aptinfo SET availability_status = 'Not Available' WHERE AptID = @AptID";
                    SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sqlCon);
                    updateAvailabilityCmd.Parameters.AddWithValue("@AptID", AptID.Text);
                    updateAvailabilityCmd.ExecuteNonQuery();

                    Hide();
                    Confirmationpopup form = new Confirmationpopup();
                    form.Show();
                }
                else
                {
                    // Room is not available
                    MessageBox.Show("Sorry, the room is not available for booking.");
                }
            }
        }
    }
}
