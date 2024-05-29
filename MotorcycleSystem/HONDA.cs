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
    public partial class HONDA : Form
    {
        public HONDA()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox7_Click(object sender, EventArgs e)
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
            adv adv = new adv();
            adv.Show();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            click125 c125 = new click125();
            c125.Show();
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            click160 c160 = new click160();
            c160.Show();
            this.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            pcx pcx = new pcx();
            pcx.Show();
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            winnerx wnnrx = new winnerx();
            wnnrx.Show();
            this.Close();
        }
    }
}
