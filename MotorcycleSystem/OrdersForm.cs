using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorcycleSystem
{
    public partial class OrdersForm : Form
    {
        private string connectionString = "server=localhost; uid=root; pwd=\"\"; database=mcsystemorders_db;";
        public OrdersForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            try
            {
                conn.Open();
                DataTable inquiryTable = new DataTable();
                inquiryTable.Columns.Add("Produc");
                inquiryTable.Columns.Add("Price");
                inquiryTable.Columns.Add("Quantity");
                inquiryTable.Columns.Add("Name");
                inquiryTable.Columns.Add("Address");
                inquiryTable.Columns.Add("OrderTime");

                string[] queries =
                {
                    "SELECT Product, Price, Quantity, Name, Address, OrderTime FROM brakeshoe_tbl", 
                        "SELECT Product, Price, Quantity, Name, Address, OrderTime FROM brakepads_tbl",
                        "SELECT Product, Price, Quantity, Name, Address, OrderTime FROM chain_tbl",
                        "SELECT Product, Price, Quantity, Name, Address, OrderTime FROM engineoil_tbl",
                        "SELECT Product, Price, Quantity, Name, Address, OrderTime FROM flyball_tbl"
                };

                foreach (string query in queries)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable tempTable = new DataTable();
                    adapter.Fill(tempTable);

                    foreach (DataRow row in tempTable.Rows)
                    {
                        inquiryTable.ImportRow(row);
                    }
                }
                dataGridView1.DataSource = inquiryTable;
            }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message);
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
