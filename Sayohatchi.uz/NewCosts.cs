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
        private int selectedExpenseId;
        private void NewCosts_Load(object sender, EventArgs e)
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 60000;
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
                    TripsBudget.Text = "Tanlanmagan";
                    ExpenseAmount.Text = "Tanlanmagan";
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
                            e.id,  -- Include the 'id' column
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
                    decimal totalExpenses = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        CostsDataGridView.Rows.Add(
                            row["trip_name"].ToString(),
                            row["full_name"].ToString(),
                            row["expense_name"].ToString(),
                            row["expense_amount"].ToString(),
                            row["id"].ToString()
                        );
                        totalExpenses += Convert.ToDecimal(row["expense_amount"]);
                    }
                    if (selectedTripId.HasValue)
                    {
                        string budgetQuery = "SELECT budget FROM trips WHERE id = @tripId";
                        SqlCommand budgetCmd = new SqlCommand(budgetQuery, connection);
                        budgetCmd.Parameters.AddWithValue("@tripId", selectedTripId.Value);
                        var budget = budgetCmd.ExecuteScalar();
                        TripsBudget.Text = budget != DBNull.Value ? budget.ToString() : "0";
                    }
                    else
                    {
                        TripsBudget.Text = "Tanlanmagan";
                    }

                    ExpenseAmount.Text = totalExpenses.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ma'lumotlarni yuklashda xatolik: " + ex.Message);
            }
        }
        private void AddNewCostBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string expenseName = ExpenseNameTxt.Text.Trim();
                decimal expenseAmount = ExpenseAmountNumericUpDown.Value;
                if (string.IsNullOrEmpty(expenseName))
                {
                    MessageBox.Show("Xarajat nomi bo'sh bo'lmasligi kerak.");
                    return;
                }
                int? selectedTripId = TripName.SelectedValue as int?;
                int? selectedTravelerId = TravelersFISH.SelectedValue as int?;

                if (selectedTripId.HasValue && selectedTravelerId.HasValue)
                {
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        string getTotalExpensesQuery = @"
                            SELECT SUM(expense_amount) 
                            FROM trip_expenses 
                            WHERE trip_id = @tripId";
                        SqlCommand getTotalExpensesCmd = new SqlCommand(getTotalExpensesQuery, connection);
                        getTotalExpensesCmd.Parameters.AddWithValue("@tripId", selectedTripId.Value);
                        decimal currentTotalExpenses = Convert.ToDecimal(getTotalExpensesCmd.ExecuteScalar() ?? 0);
                        string getBudgetQuery = "SELECT budget FROM trips WHERE id = @tripId";
                        SqlCommand getBudgetCmd = new SqlCommand(getBudgetQuery, connection);
                        getBudgetCmd.Parameters.AddWithValue("@tripId", selectedTripId.Value);
                        decimal tripBudget = Convert.ToDecimal(getBudgetCmd.ExecuteScalar() ?? 0);
                        if (currentTotalExpenses + expenseAmount > tripBudget)
                        {
                            MessageBox.Show("Xarajat qo'shish byudjetdan oshib ketdi! Iltimos, byudjetni tekshirib ko'ring.");
                            return;
                        }
                        else if (currentTotalExpenses + expenseAmount >= tripBudget * 0.9m)
                        {
                            MessageBox.Show("Ogohlantirish: Xarajatlar sayohat byudjetining 90% ni tashkil qilmoqda. Iltimos, ehtiyot bo'ling!");
                        }
                        string insertExpenseQuery = @"
                            INSERT INTO trip_expenses (trip_id, traveler_id, expense_name, expense_amount)
                            VALUES (@tripId, @travelerId, @expenseName, @expenseAmount)";
                        SqlCommand insertExpenseCmd = new SqlCommand(insertExpenseQuery, connection);
                        insertExpenseCmd.Parameters.AddWithValue("@tripId", selectedTripId.Value);
                        insertExpenseCmd.Parameters.AddWithValue("@travelerId", selectedTravelerId.Value);
                        insertExpenseCmd.Parameters.AddWithValue("@expenseName", expenseName);
                        insertExpenseCmd.Parameters.AddWithValue("@expenseAmount", expenseAmount);
                        insertExpenseCmd.ExecuteNonQuery();
                        MessageBox.Show("Xarajat qo'shildi!");
                        LoadCostsDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Iltimos, sayohat va sayohatchi tanlang.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xarajatni qo'shishda xato: " + ex.Message);
            }
        }
        private void TripName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCostsDataGridView();
        }

        private void TravelersFISH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCostsDataGridView();
        }

        private void CostsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CostsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = CostsDataGridView.SelectedRows[0];
                string expenseName = selectedRow.Cells["Column1"].Value.ToString();  
                string expenseAmount = selectedRow.Cells["Column2"].Value.ToString();  
                selectedExpenseId = Convert.ToInt32(selectedRow.Cells["ExpenseIdColum"].Value);  
                ExpenseNameTxt.Text = expenseName;
                ExpenseAmountNumericUpDown.Value = Convert.ToDecimal(expenseAmount);
            }
        }
        private void UpdateCostBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedExpenseId != 0)
                {
                    string expenseName = ExpenseNameTxt.Text.Trim();
                    decimal expenseAmount = ExpenseAmountNumericUpDown.Value;
                    int expenseId = selectedExpenseId;

                    if (string.IsNullOrEmpty(expenseName))
                    {
                        MessageBox.Show("Xarajat nomi bo'sh bo'lmasligi kerak.");
                        return;
                    }

                    int? selectedTripId = TripName.SelectedValue as int?;

                    if (selectedTripId.HasValue)
                    {
                        using (SqlConnection connection = new SqlConnection(conn))
                        {
                            connection.Open();
                            string getTotalExpensesQuery = @"
                        SELECT SUM(expense_amount) 
                        FROM trip_expenses 
                        WHERE trip_id = @tripId";
                            SqlCommand getTotalExpensesCmd = new SqlCommand(getTotalExpensesQuery, connection);
                            getTotalExpensesCmd.Parameters.AddWithValue("@tripId", selectedTripId.Value);
                            decimal currentTotalExpenses = Convert.ToDecimal(getTotalExpensesCmd.ExecuteScalar() ?? 0);

                            string getBudgetQuery = "SELECT budget FROM trips WHERE id = @tripId";
                            SqlCommand getBudgetCmd = new SqlCommand(getBudgetQuery, connection);
                            getBudgetCmd.Parameters.AddWithValue("@tripId", selectedTripId.Value);
                            decimal tripBudget = Convert.ToDecimal(getBudgetCmd.ExecuteScalar() ?? 0);

                            // Yangi xarajatni qo'shishdan oldin eski xarajatni olib tashlashni hisoblash
                            decimal newTotalExpenses = currentTotalExpenses - expenseAmount + ExpenseAmountNumericUpDown.Value;

                            // Agar yangi umumiy xarajat byudjetni oshsa
                            if (newTotalExpenses > tripBudget)
                            {
                                MessageBox.Show("Xarajat yangilanishi byudjetdan oshib ketdi! Iltimos, byudjetni tekshirib ko'ring.");
                                return;
                            }
                            else if (newTotalExpenses >= tripBudget * 0.9m)
                            {
                                MessageBox.Show("Ogohlantirish: Xarajatlar sayohat byudjetining 90% ni tashkil qilmoqda. Iltimos, ehtiyot bo'ling!");
                            }

                            string query = @"
                    UPDATE trip_expenses
                    SET expense_name = @expenseName, expense_amount = @expenseAmount
                    WHERE id = @expenseId";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@expenseName", expenseName);
                            cmd.Parameters.AddWithValue("@expenseAmount", expenseAmount);
                            cmd.Parameters.AddWithValue("@expenseId", expenseId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Xarajat yangilandi!");
                            LoadCostsDataGridView();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Iltimos, sayohat tanlang.");
                    }
                }
                else
                {
                    MessageBox.Show("Iltimos, biron bir xarajatni tanlang.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xarajatni yangilashda xato: " + ex.Message);
            }
        }
        private void DeleteCostBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedExpenseId != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Siz haqiqatan ham xarajatni o'chirmoqchimisiz?", "Tasdiqlash", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int expenseId = selectedExpenseId;  

                        using (SqlConnection connection = new SqlConnection(conn))
                        {
                            connection.Open();
                            string query = "DELETE FROM trip_expenses WHERE id = @expenseId";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@expenseId", expenseId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Xarajat o'chirildi!");
                            LoadCostsDataGridView();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Iltimos, biron bir xarajatni tanlang.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xarajatni o'chirishda xato: " + ex.Message);
            }
        }
    }
}