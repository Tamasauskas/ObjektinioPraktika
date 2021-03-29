﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    public partial class frmStudentas : Form
    {
        clsStudentas Studentas = new clsStudentas();
        clsHelper Helper = new clsHelper();

        public frmStudentas(string Std_vardas, string Std_Pavarde, string Std_Id)
        {
            InitializeComponent();
            Text = Std_vardas + Std_Pavarde;
            Studentas.Vardas = Std_vardas;
            Studentas.Pavarde = Std_Pavarde;
            Studentas.StudentoId = Std_Id;
        }

     

        private void btn_Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIn frmLogIn = new frmLogIn();
            frmLogIn.Show();
        }

        private void frmStudentas_Load(object sender, EventArgs e)
        {
          
        }
    }
}
