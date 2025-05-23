﻿using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        string conn = ConfigurationManager.ConnectionStrings["DataBaseConn"].ConnectionString;
        private void Dashboard_Load(object sender, EventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
            NewCustumers frm = new NewCustumers();
            frm.TopLevel = false;
            panel3.Controls.Clear();
            frm.BringToFront();
            panel3.Controls.Add(frm);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewCustumers frm = new ViewCustumers();
            panel3.Controls.Clear();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateCustumers frm = new UpdateCustumers();
            panel3.Controls.Clear();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewMashurt frm = new NewMashurt();
            panel3.Controls.Clear();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewMashurt frm = new ViewMashurt();
            panel3.Controls.Clear();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateMashurt frm = new UpdateMashurt();
            panel3.Controls.Clear();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NewCosts frm = new NewCosts();
            panel3.Controls.Clear();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            About frm = new About();
            panel3.Controls.Clear();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
