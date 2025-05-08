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
    public partial class ViewMashurt : Form
    {
        public ViewMashurt()
        {
            InitializeComponent();
        }
        string conn = ConfigurationManager.ConnectionStrings["DataBaseConn"].ConnectionString;
        private int currentTripId = -1;
        private void ViewMashurt_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    MessageBox.Show("Ulanish muvaffaqiyatli!");
                    LoadTripsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ulanishda xato: " + ex.Message);
            }
        }
        private void LoadTripsData()
        {
            try
            {
                ViewMashurtDataGridView.Rows.Clear();

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string selectQuery = "SELECT id, trip_name, start_date, end_date, budget FROM trips";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int tripId = reader.GetInt32(0); 
                                string tripName = reader.GetString(1); 
                                DateTime startDate = reader.GetDateTime(2); 
                                DateTime endDate = reader.GetDateTime(3);
                                decimal budget = reader.GetDecimal(4);
                                int rowIndex = ViewMashurtDataGridView.Rows.Add();
                                DataGridViewRow row = ViewMashurtDataGridView.Rows[rowIndex];
                                row.Cells["TripsIDColumn"].Value = tripId;
                                row.Cells["TripNameColumn"].Value = tripName;
                                row.Cells["StartDateColumn"].Value = startDate.ToString("yyyy-MM-dd");
                                row.Cells["EndDateColumn"].Value = endDate.ToString("yyyy-MM-dd");
                                row.Cells["BudgetColumn"].Value = budget.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data loading error: " + ex.Message);
            }
        }
        private void ViewMashurtDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ViewMashurtDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = ViewMashurtDataGridView.SelectedRows[0];
                string tripName = selectedRow.Cells["TripNameColumn"].Value.ToString();
                TripNameTxt.Text = tripName;
                DeleteTripBtn.Enabled = true;
                currentTripId = Convert.ToInt32(selectedRow.Cells["TripsIDColumn"].Value);
            }
            else
            {
                DeleteTripBtn.Enabled = false;
            }
        }

        private void DeleteTripBtn_Click(object sender, EventArgs e)
        {
            if (currentTripId > 0)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Sayohatchi ma'lumotlarini o'chirmoqchimisiz?",
                    "Tasdiqlash",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(conn))
                        {
                            string deleteQuery = "DELETE FROM trips WHERE id = @id";
                            SqlCommand command = new SqlCommand(deleteQuery, connection);
                            command.Parameters.AddWithValue("@id", currentTripId);

                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Sayohat o'chirildi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTripsData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting trip: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Iltimos, o'chirish uchun biror sayohatni tanlang.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
