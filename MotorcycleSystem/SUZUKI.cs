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
    public partial class SUZUKI : Form
    {
        public SUZUKI()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void SUZUKI_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            avenis avns = new avenis();
            this.Close();
            avns.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            burgmanstreet brgmnstrt = new burgmanstreet();
            this.Close();
            brgmnstrt.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            raidercarb rcarb = new raidercarb();
            this.Close();
            rcarb.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            raiderfi rfi = new raiderfi();
            this.Close();
            rfi.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            smash smsh = new smash();
            this.Close();
            smsh.Show();
        }
    }
}
