using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayohatchi.uz
{
    public partial class UpdateMashurt : Form
    {
        public UpdateMashurt()
        {
            InitializeComponent();
        }
        string conn = ConfigurationManager.ConnectionStrings["DataBaseConn"].ConnectionString;
        private void UpdateMashurt_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    // MessageBox.Show("Ulanish muvaffaqiyatli!");
                    SqlCommand command = new SqlCommand("SELECT trip_name FROM [dbo].[trips]", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TripNameComboBox.Items.Add(reader["trip_name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ulanishda xato: " + ex.Message);
            }
        }
        private void UpdateTripBtn_Click(object sender, EventArgs e)
        {
            string tripName = TripNameComboBox.SelectedItem.ToString(); 
            DateTime startDate = StartDateTimePicker.Value; 
            DateTime endDate = EndDateTimePicker.Value; 
            decimal budget = decimal.Parse(BudgetNumeric.Text);
            string updateQuery = "UPDATE [dbo].[trips] SET start_date = @startDate, end_date = @endDate, budget = @budget " +
                                 "WHERE trip_name = @tripName";
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@tripName", tripName);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    command.Parameters.AddWithValue("@budget", budget);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sayohat ma'lumotlari muvaffaqiyatli yangilandi!");
                    }
                    else
                    {
                        MessageBox.Show("Yangilanishda xato yuz berdi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xato yuz berdi: " + ex.Message);
            }
        }
        private void TripNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTripName = TripNameComboBox.SelectedItem.ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT trip_name, start_date, end_date, budget FROM [dbo].[trips] WHERE trip_name = @tripName", connection);
                    command.Parameters.AddWithValue("@tripName", selectedTripName);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        StartDateTimePicker.Value = Convert.ToDateTime(reader["start_date"]);
                        EndDateTimePicker.Value = Convert.ToDateTime(reader["end_date"]);
                        BudgetNumeric.Text = reader["budget"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Sayohat topilmadi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xato yuz berdi: " + ex.Message);
            }
        }
    }
}
