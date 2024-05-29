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
    public partial class YAMAHA : Form
    {
        public YAMAHA()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }



        private void YAMAHA_Load(object sender, EventArgs e)
        {

        }

        private void gearbtn_Click(object sender, EventArgs e)
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
            fazzio fzz = new fazzio();
            this.Hide();
            fzz.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Gravis_125 grvs = new Gravis_125();
            this.Hide();
            grvs.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MioAerox rox = new MioAerox();
            this.Hide();
            rox.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            nmax nmx = new nmax();
            this.Hide();
            nmx.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            sniper snpr = new sniper();
            this.Close();
            snpr.Show();
        }
    }
}
