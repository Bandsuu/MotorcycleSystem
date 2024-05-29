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
    public partial class KAWASAKI : Form
    {
        public KAWASAKI()
        {
            InitializeComponent();
        }

        private void KAWASAKI_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox5_Click(object sender, EventArgs e)
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
            barakocarb bcarb = new barakocarb();
            bcarb.Show();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            barakofi bfi = new barakofi();
            bfi.Show();
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ct150 c150 = new ct150();
            c150.Show();
            this.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ns200 ns = new ns200();
            ns.Show();
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            w175 w = new w175();
            w.Show();
            this.Close();
        }
    }
}
