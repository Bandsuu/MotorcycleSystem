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
    public partial class InquiryForm : Form
    {
        private string connectionString = "server=localhost; uid=root; pwd=\"\"; database=motorcyclesystem_db;";
        public InquiryForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
                try
                {
                    conn.Open();
                    DataTable inquiryTable = new DataTable();
                    inquiryTable.Columns.Add("Model");
                    inquiryTable.Columns.Add("Price");
                    inquiryTable.Columns.Add("Downpayment");
                    inquiryTable.Columns.Add("Name");
                    inquiryTable.Columns.Add("Age");
                    inquiryTable.Columns.Add("Gender");
                    inquiryTable.Columns.Add("Nationality");
                    inquiryTable.Columns.Add("Occupation");
                    inquiryTable.Columns.Add("ContactNumber");
                    inquiryTable.Columns.Add("Address");

                    string[] queries =
                    {
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM adv_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM aerox_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM avenis_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM barakocarb_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM barakofi_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM burgman_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM click125_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM click160_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM ct_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM fazzio_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM gravis_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM nmax_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM ns_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM pcx_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM raidercarb_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM raiderfi_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM smash_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM sniper_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM winner_tbl",
                        "SELECT Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address FROM w_tbl",
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

        private void InquiryForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminDashboard admd = new AdminDashboard();
            this.Hide();
            admd.Show();
        }
    }
}
