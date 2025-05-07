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
    public partial class NewMashurt : Form
    {
        public NewMashurt()
        {
            InitializeComponent();
        }
        string conn = ConfigurationManager.ConnectionStrings["DataBaseConn"].ConnectionString;
        private void NewMashurt_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    MessageBox.Show("Ulanish muvaffaqiyatli!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ulanishda xato: " + ex.Message);
            }
        }

        private void AddTripBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = StartDateTimePicker.Value;
            DateTime endDate = EndDateTimePicker.Value;
            DateTime currentDate = DateTime.Now.Date;
            StartDateTimePicker.MinDate = currentDate;
            EndDateTimePicker.MinDate = currentDate;
            if (startDate < currentDate || endDate < currentDate)
            {
                MessageBox.Show("Sanalar hozirgi vaqtdan oldin bo'lishi mumkin emas.", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (endDate <= startDate)
            {
                MessageBox.Show("Tugash sanasi boshlanish sanasidan keyin bo'lishi kerak.", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tripName = TripNametxt.Text;
            decimal budget = BudgetNumeric.Value;
            if (string.IsNullOrEmpty(tripName))
            {
                MessageBox.Show("Sayohat nomi kiritilishi kerak.", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    string query = "INSERT INTO trips (trip_name, start_date, end_date, budget) VALUES (@trip_name, @start_date, @end_date, @budget)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@trip_name", tripName);
                    command.Parameters.AddWithValue("@start_date", startDate);
                    command.Parameters.AddWithValue("@end_date", endDate);
                    command.Parameters.AddWithValue("@budget", budget);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sayohat muvaffaqiyatli qo'shildi!", "Muvaffaqiyat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xato: " + ex.Message, "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
