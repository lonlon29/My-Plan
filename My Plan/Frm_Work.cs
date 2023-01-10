﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Plan
{
    public partial class Frm_Work : Form
    {
        public Frm_Work()
        {
            InitializeComponent();
        }

        private void btn_AutoDesk_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_AutoDesk frm1 = new Frm_AutoDesk();
            frm1.Show();
        }

       
        private void btn_Telecom_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_ChinaTelecom frm2 = new Frm_ChinaTelecom();
            frm2.Show();
        }

        private void btn_RiskRaider_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_RiskRaider frm4 = new Frm_RiskRaider();
            frm4.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Select frm3 = new Frm_Select();
            frm3.Show();
        }

        
    }
}
