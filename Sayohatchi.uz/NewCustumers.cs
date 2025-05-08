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
    public partial class NewCustumers : Form
    {
        public NewCustumers()
        {
            InitializeComponent();
        }
        string conn = ConfigurationManager.ConnectionStrings["DataBaseConn"].ConnectionString;
        private void AddCustumersBtn_Click(object sender, EventArgs e)
        {
            string fullName = FISHtxt.Text;
            string phoneNumber = Phonetxtmasked.Text;
            string email = Emailtxt.Text;
            string gender = radioButton1.Checked ? "Erkak" : "Ayol";
            string insertQuery = "INSERT INTO [dbo].[travelers] (full_name, email, phone_number, gender) " +
                                 "VALUES (@fullName, @email, @phoneNumber, @gender)";
            try
            {
                string connectionString = conn;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@gender", gender);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Mijoz muvaffaqiyatli qo'shildi!");
                    }
                    else
                    {
                        MessageBox.Show("Mijoz qo'shilishda xato yuz berdi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xato yuz berdi: " + ex.Message);
            }
        }
        private void NewCustumers_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    // MessageBox.Show("Ulanish muvaffaqiyatli!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ulanishda xato: " + ex.Message);
            }
        }
    }
}
