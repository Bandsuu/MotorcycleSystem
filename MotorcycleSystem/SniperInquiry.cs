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
    public partial class SniperInquiry : Form
    {
        private string connectionString = "server=localhost; uid=root; pwd=\"\"; database=motorcyclesystem_db;";
        public SniperInquiry()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sniper sniper = new sniper();
            sniper.Show();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string model = "Sniper 155";
            string price = "125900";
            string downpayment = guna2TextBoxDP.Text;
            string name = guna2TextBoxName.Text;
            string age = guna2TextBoxAge.Text;
            string gender = guna2TextBoxGender.Text;
            string nationality = guna2TextBoxNationality.Text;
            string occupation = guna2TextBoxOccupation.Text;
            string contactnumber = guna2TextBoxNumber.Text;
            string address = guna2TextBoxAddress.Text;

            if (!string.IsNullOrEmpty(downpayment) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(age) && !string.IsNullOrEmpty(gender) && !string.IsNullOrEmpty(nationality)
                && !string.IsNullOrEmpty(occupation) && !string.IsNullOrEmpty(contactnumber) && !string.IsNullOrEmpty(address))
            {
                SaveData(model, price, downpayment, name, age, gender, nationality, occupation, contactnumber, address);
            }
            else
            {
                MessageBox.Show("Please fill in all the boxes.");
            }
        }

        private void SaveData(string model, string price, string downpayment, string name, string age, string gender, string nationality, string occupation, string contactnumber, string address)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO sniper_tbl (Model, Price, Downpayment, Name, Age, Gender, Nationality, Occupation, ContactNumber, Address) VALUES (@Model, @Price, @Downpayment, @Name, @Age, @Gender, @Nationality, @Occupation, @ContactNumber, @Address)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Downpayment", downpayment);
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Nationality", nationality);
                    cmd.Parameters.AddWithValue("Occupation", occupation);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactnumber);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inquiry sent successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void SniperInquiry_Load(object sender, EventArgs e)
        {

        }
    }
}
