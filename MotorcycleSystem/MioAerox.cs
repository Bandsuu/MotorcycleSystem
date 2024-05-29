﻿using System;
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
    public partial class MioAerox : Form
    {
        private readonly double givenNum = 123000;
        public MioAerox()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AeroxInquiry aeroxInquiry = new AeroxInquiry();
            aeroxInquiry.Show();
            this.Close();
        }

        private void MioAerox_Load(object sender, EventArgs e)
        {

        }

        private void dplbl_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(dplbl.Text, out double enteredNum))
            {
                double dp = givenNum - enteredNum;
                double result = dp / 12;
                result = Math.Round(result, 2, MidpointRounding.AwayFromZero);
                wantumos.Text = $"{result}";

                double dp2 = givenNum - enteredNum;
                double result2 = dp2 / 24;
                result2 = Math.Round(result2, 2, MidpointRounding.AwayFromZero);
                tuformos.Text = $"{result2}";

                double dp3 = givenNum - enteredNum;
                double result3 = dp3 / 36;
                result3 = Math.Round(result3, 2, MidpointRounding.AwayFromZero);
                trisixmos.Text = $"{result3}";
            }

            else
            {
                wantumos.Text = "";
                tuformos.Text = "";
                trisixmos.Text = "";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            YAMAHA ymh = new YAMAHA();
            ymh.Show();
            this.Close();
        }
    }
}
