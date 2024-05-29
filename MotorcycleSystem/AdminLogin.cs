using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MotorcycleSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            if (user == "admin" && pass == "admin")
            {
                AdminDashboard acct = new AdminDashboard();
                username.Clear();
                password.Clear();
                acct.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME OR PASSWORD, PLEASE TRY AGAIN");
                username.Clear();
                password.Clear();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
