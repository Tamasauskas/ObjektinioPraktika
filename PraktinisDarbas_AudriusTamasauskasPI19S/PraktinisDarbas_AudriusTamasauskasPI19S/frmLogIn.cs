﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    public partial class frmLogIn : Form
    {
        SqlConnection con = new SqlConnection();
        
        public frmLogIn()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TD7BPIA\MSSQLSERVER01;Initial Catalog=Objektinis-Programavimas;Integrated Security=True";

        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtLonInName.Text.Equals("Prisijungimo vardas"))
            {
                txtLonInName.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtLonInName.Text.Equals(""))
            {
                txtLonInName.Text = "Prisijungimo vardas";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Slaptažodis"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Slaptažodis";
            } 
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From tbl_Admin where LogIn='"+txtLonInName.Text +"' and Password = '"+txtPassword.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Sucess");
                con.Close();
            }
            else
                MessageBox.Show("Patikrinkite prisijungimo vardą ir/arba slaptažodį");
            con.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}