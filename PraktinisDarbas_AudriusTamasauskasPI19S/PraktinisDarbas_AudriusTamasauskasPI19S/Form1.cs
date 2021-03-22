using System;
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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
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
    }
}
