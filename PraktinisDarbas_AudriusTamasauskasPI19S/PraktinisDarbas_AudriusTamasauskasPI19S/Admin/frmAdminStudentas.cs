﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    public partial class frmAdminStudentas : Form
    {
        public frmAdminStudentas()
        {
            InitializeComponent();
            
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.Text = "Admininstratorius";
        }

        private void btn_Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIn frmLogIn = new frmLogIn();
            frmLogIn.Show();
        }

        private void btnPridetiGrupe_Click(object sender, EventArgs e)
        {
            
        }
    }
}
