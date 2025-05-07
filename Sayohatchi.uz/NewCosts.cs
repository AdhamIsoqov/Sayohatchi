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
    public partial class NewCosts : Form
    {
        public NewCosts()
        {
            InitializeComponent();
        }
        string conn = ConfigurationManager.ConnectionStrings["DataBaseConn"].ConnectionString;

        private void NewCosts_Load(object sender, EventArgs e)
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 5000;
            refreshTimer.Tick += (s, args) => LoadCostsDataGridView();
            refreshTimer.Start();
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    MessageBox.Show("Ulanish muvaffaqiyatli!");

                    using (SqlCommand cmd = new SqlCommand("SELECT id, trip_name FROM trips", connection))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        TripName.DataSource = dt;
                        TripName.DisplayMember = "trip_name";
                        TripName.ValueMember = "id";
                        TripName.SelectedIndex = -1;
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT id, full_name FROM travelers", connection))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        TravelersFISH.DataSource = dt;
                        TravelersFISH.DisplayMember = "full_name";
                        TravelersFISH.ValueMember = "id";
                        TravelersFISH.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ulanishda xato: " + ex.Message);
            }
        }
        private void LoadCostsDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    int? selectedTripId = TripName.SelectedValue as int?;
                    int? selectedTravelerId = TravelersFISH.SelectedValue as int?;

                    StringBuilder query = new StringBuilder(@"
                        SELECT 
                            t.trip_name,
                            tr.full_name,
                            e.expense_name,
                            e.expense_amount
                        FROM trip_expenses e
                        INNER JOIN trips t ON e.trip_id = t.id
                        INNER JOIN travelers tr ON e.traveler_id = tr.id
                        WHERE 1=1");

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    if (selectedTripId.HasValue)
                    {
                        query.Append(" AND e.trip_id = @tripId");
                        cmd.Parameters.AddWithValue("@tripId", selectedTripId.Value);
                    }

                    if (selectedTravelerId.HasValue)
                    {
                        query.Append(" AND e.traveler_id = @travelerId");
                        cmd.Parameters.AddWithValue("@travelerId", selectedTravelerId.Value);
                    }

                    cmd.CommandText = query.ToString();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    CostsDataGridView.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        CostsDataGridView.Rows.Add(
                            row["trip_name"].ToString(),
                            row["full_name"].ToString(),
                            row["expense_name"].ToString(),
                            row["expense_amount"].ToString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ma'lumotlarni yuklashda xatolik: " + ex.Message);
            }
        }
        private void AddNewCostBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void TripName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCostsDataGridView();
        }

        private void TravelersFISH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCostsDataGridView();
        }
    }
}
