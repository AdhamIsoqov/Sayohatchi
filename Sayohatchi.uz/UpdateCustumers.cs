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
    public partial class UpdateCustumers : Form
    {
        public UpdateCustumers()
        {
            InitializeComponent();
        }
        string conn = ConfigurationManager.ConnectionStrings["DataBaseConn"].ConnectionString;
        private void UpdateCustumers_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    MessageBox.Show("Ulanish muvaffaqiyatli!");
                    SqlCommand command = new SqlCommand("SELECT full_name FROM [dbo].[travelers]", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        FISHComboBox.Items.Add(reader["full_name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ulanishda xato: " + ex.Message);
            }
        }
        private void UpdateCustumersBtn_Click(object sender, EventArgs e)
        {
            string fullName = FISHComboBox.SelectedItem.ToString(); 
            string phoneNumber = Phonetxtmasked.Text;
            string email = Emailtxt.Text;
            string gender = Male.Checked ? "Erkak" : "Ayol"; 
            string updateQuery = "UPDATE [dbo].[travelers] SET full_name = @fullName, email = @email, phone_number = @phoneNumber, gender = @gender" +
                                 "WHERE full_name = @fullName";

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@gender", gender);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Mijoz ma'lumotlari muvaffaqiyatli yangilandi!");
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

        private void FISHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = FISHComboBox.SelectedItem.ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT full_name, phone_number, email, gender FROM [dbo].[travelers] WHERE full_name = @fullName", connection);
                    command.Parameters.AddWithValue("@fullName", selectedName);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Phonetxtmasked.Text = reader["phone_number"].ToString();
                        Emailtxt.Text = reader["email"].ToString();
                        string gender = reader["gender"].ToString();
                        if (gender == "Erkak")
                        {
                            Male.Checked = true;
                        }
                        else if (gender == "Ayol")
                        {
                            Famale.Checked = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Foydalanuvchi topilmadi.");
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
