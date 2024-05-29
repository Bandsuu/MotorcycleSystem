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
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost; uid=root; pwd=\"\"; database=motorcyclesystem_db;";
        
        public Form1()
        {
            InitializeComponent();
            ;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void yamahabtn_Click(object sender, EventArgs e)
        {
            YAMAHA ymh = new YAMAHA();
            ymh.Show();
            this.Hide();
        }

        private void hondabtn_Click(object sender, EventArgs e)
        {
            HONDA hnd = new HONDA();
            hnd.Show();
            this.Hide();
        }

        private void suzukibtn_Click(object sender, EventArgs e)
        {
            SUZUKI szk = new SUZUKI();
            szk.Show();
            this.Hide();
        }

        private void kawasaki_Click(object sender, EventArgs e)
        {
            KAWASAKI kwsk = new KAWASAKI();
            kwsk.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Brakeshoe brakeshoe = new Brakeshoe();
            brakeshoe.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            EngineOil engineOil = new EngineOil();
            engineOil.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Chain chain = new Chain();
            chain.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Flyball flyball = new Flyball();
            flyball.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            BrakePads brakepads = new BrakePads();
            brakepads.Show();
            this.Hide();
        }
    }
}
