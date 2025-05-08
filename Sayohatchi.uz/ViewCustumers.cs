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
    public partial class ViewCustumers : Form
    {
        public ViewCustumers()
        {
            InitializeComponent();
        }
        string conn = ConfigurationManager.ConnectionStrings["DataBaseConn"].ConnectionString;
        private void ViewCustumers_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    MessageBox.Show("Ulanish muvaffaqiyatli!");
                    LoadCustomers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ulanishda xato: " + ex.Message);
            }
        }
        private void LoadCustomers()
        {
            try
            {
                ViewCustumersDataGridView.Rows.Clear();

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string selectQuery = "SELECT id, full_name, email, phone_number, gender FROM travelers"; 
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int travelerId = reader.GetInt32(0);
                                string travelerFISH = reader.GetString(1);  
                                string travelerEmail = reader.GetString(2); 
                                string travelerPhoneNumber = reader.GetString(3);  
                                string travelerGender = reader.GetString(4); 
                                int rowIndex = ViewCustumersDataGridView.Rows.Add(); 
                                DataGridViewRow row = ViewCustumersDataGridView.Rows[rowIndex];
                                row.Cells["TravelerIDColumn"].Value = travelerId;
                                row.Cells["TravelerFISHColumn"].Value = travelerFISH; 
                                row.Cells["TravelerEmailColumn"].Value = travelerEmail;
                                row.Cells["TravelerPhoneNumberColumn"].Value = travelerPhoneNumber; 
                                row.Cells["TravelerGenderColumn"].Value = travelerGender;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xato: " + ex.Message);
            }
        }
        private void ViewCustumersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ViewCustumersDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = ViewCustumersDataGridView.SelectedRows[0];
                int travelerId = Convert.ToInt32(selectedRow.Cells["TravelerIDColumn"].Value);
                string fullName = selectedRow.Cells["TravelerFISHColumn"].Value.ToString();
                TravelersFISHTxt.Text = fullName;
                DeleteTravelerBtn.Enabled = true;
                currentTravelerId = travelerId;
            }
            else
            {
                
                DeleteTravelerBtn.Enabled = false;
            }
        }
        private int currentTravelerId = -1; 
        private void DeleteTravelerBtn_Click(object sender, EventArgs e)
        {
            if (currentTravelerId != -1)
            {
                DialogResult result = MessageBox.Show("Sayohatchi ma'lumotlarini o'chirmoqchimisiz?", "Tasdiqlash", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(conn))
                        {
                            connection.Open();
                            string deleteQuery = "DELETE FROM travelers WHERE id = @id";
                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@id", currentTravelerId); 
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Sayohatchi muvaffaqiyatli o'chirildi.", "O'chirish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadCustomers(); 
                                }
                                else
                                {
                                    MessageBox.Show("Sayohatchi o'chirilmadi. Iltimos, yana bir bor tekshiring.", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xato: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Iltimos, o'chirmoqchi bo'lgan sayohatchini tanlang.", "Ogohlantirish", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
