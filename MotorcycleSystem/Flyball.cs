﻿using MySql.Data.MySqlClient;
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
    public partial class Flyball : Form
    {
        private string connectionString = "server=localhost; uid=root; pwd=\"\"; database=mcsystemorders_db;";
        public Flyball()
        {
            InitializeComponent();
        }

        private void Flyball_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Product = "Flyball";
            string Price = "300";
            string quantity = textBoxQuantity.Text;
            string name = texBoxName.Text;
            string address = textBoxAddress.Text;
            DateTime orderTime = DateTime.Now;

            if (!string.IsNullOrEmpty(quantity) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(address))
            {
                SaveData(Product, Price, quantity, name, address, orderTime);
            }
            else
            {
                MessageBox.Show("Please fill in all the boxes.");
            }
        }

        private void SaveData(string Product, string Price, string quantity, string name, string address, DateTime orderTime)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO flyball_tbl (Product, Price, Quantity, Name, Address, OrderTime) VALUES (@Product, @Price, @Quantity, @Name, @Address, @OrderTime)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Product", Product);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@OrderTime", orderTime);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inquiry sent successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }
    }
}