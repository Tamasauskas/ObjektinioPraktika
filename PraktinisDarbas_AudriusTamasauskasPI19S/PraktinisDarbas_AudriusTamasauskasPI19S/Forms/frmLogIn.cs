using System;
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
    public partial class frmLogIn : Form
    {
        SQLiteConnection con = new SQLiteConnection();
        clsHelper Helper = new clsHelper();
        private int i = 0;

        public frmLogIn()
        {
            InitializeComponent();
            con.ConnectionString = clsHelper.ConnectionString;
            btnLogIn.FlatStyle = FlatStyle.Standard;

        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtLonInName.Text.Equals("Prisijungimo vardas"))
            {
                txtLonInName.Text = "";
                txtLonInName.ForeColor = Color.Black;
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtLonInName.Text.Equals(""))
            {
                txtLonInName.Text = "Prisijungimo vardas";
                txtLonInName.ForeColor = Color.LightGray;
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
           
            btnLogIn.FlatStyle = FlatStyle.Flat;
            con.Open();
            Helper.Query = "Select Count(*) From tbl_Admin where LogIn='" + txtLonInName.Text + "' and Password='" + txtPassword.Text + "'";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(Helper.Query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Helper.Query = "Select AdminId from tbl_Admin where LogIn='" + txtLonInName.Text + "' and Password = '" + txtPassword.Text + "'";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                this.Hide();
                frmAdminStudentas frmAdmin = new frmAdminStudentas();
                frmAdmin.Show();
                con.Close();
                i = +1;
            }
            Helper.Query = "Select Count(*) From tbl_Studentas where Vardas='" + txtLonInName.Text + "' and Pavarde='" + txtPassword.Text + "'";
            SQLiteDataAdapter sda1 = new SQLiteDataAdapter(Helper.Query, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            if (dt1.Rows[0][0].ToString() == "1")
            {
                Helper.Query = "Select StudentoId From tbl_Studentas where Vardas='" + txtLonInName.Text + "' and Pavarde= '" + txtPassword.Text + "'";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                clsStudentas Studentas = new clsStudentas();
                Studentas.Vardas = txtLonInName.Text;
                Studentas.Pavarde = txtPassword.Text;
                Studentas.StudentoId = cmd.ExecuteScalar().ToString();
                //MessageBox.Show(Studentas.StudentoId);
                this.Hide();
                frmStudentas frmStudentas = new frmStudentas(Studentas.Vardas, Studentas.Pavarde, Studentas.StudentoId);
                frmStudentas.Show();
                con.Close();
                i = +1;
            }
            Helper.Query = "Select Count(*) From tbl_Destytojas where Vardas='" + txtLonInName.Text + "' and Pavarde='" + txtPassword.Text + "'";
            SQLiteDataAdapter sda2 = new SQLiteDataAdapter(Helper.Query, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (dt2.Rows[0][0].ToString() == "1")
            {
                Helper.Query = "Select DestytojoId From tbl_Destytojas where Vardas='" + txtLonInName.Text + "' and Pavarde= '" + txtPassword.Text + "'";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                clsDestytojas Destytojas = new clsDestytojas();
                Destytojas.Vardas = txtLonInName.Text;
                Destytojas.Pavarde = txtPassword.Text;
                Destytojas.DestytojoId = cmd.ExecuteScalar().ToString();
                //MessageBox.Show(Destytojas.DestytojoId);
                this.Hide();
                frmDestytojas frmDestytojas = new frmDestytojas(Destytojas.Vardas, Destytojas.Pavarde, Destytojas.DestytojoId);
                frmDestytojas.Show();
                con.Close();
                i = +1;
            }
            if (i==0)
            {
                MessageBox.Show("Patikrinkite prisijungimo vardą ir/arba slaptažodį");
                txtPassword.Text = "Slaptažodis";
                txtPassword.ForeColor = Color.LightGray;
                con.Close();
            }
 
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStudentoIvedimas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminStudentas frmAdminStudentas = new frmAdminStudentas();
            frmAdminStudentas.Show();
        }

        private void btnDestytojas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminDestytojas frmAdminDestytojas = new frmAdminDestytojas();
            frmAdminDestytojas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGrupesDalykai frmGrupesDalykai = new frmGrupesDalykai();
            frmGrupesDalykai.Show();
        }

        private void btnAdminPazymiai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPazimiai frmPazimiai = new frmPazimiai();
            frmPazimiai.Show();
        }
    }
}
