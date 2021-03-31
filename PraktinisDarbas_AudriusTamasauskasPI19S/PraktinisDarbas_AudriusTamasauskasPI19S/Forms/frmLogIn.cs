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
    public partial class FrmLogIn : Form
    {
        SQLiteConnection con = new SQLiteConnection();
        ClsHelper Helper = new ClsHelper();
        private int i = 0;

        public FrmLogIn()
        {
            InitializeComponent();
            con.ConnectionString = ClsHelper.ConnectionString;
            btnLogIn.FlatStyle = FlatStyle.Standard;

        }
   
       #region
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
       #endregion
    
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
                FrmAdminStudentas frmAdmin = new FrmAdminStudentas();
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
                ClsStudentas Studentas = new ClsStudentas();
                Studentas.Vardas = txtLonInName.Text;
                Studentas.Pavarde = txtPassword.Text;
                Studentas.StudentoId = cmd.ExecuteScalar().ToString();
                //MessageBox.Show(Studentas.StudentoId);
                this.Hide();
                FrmStudentas frmStudentas = new FrmStudentas(Studentas.Vardas, Studentas.Pavarde, Studentas.StudentoId);
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
                ClsDestytojas Destytojas = new ClsDestytojas();
                Destytojas.Vardas = txtLonInName.Text;
                Destytojas.Pavarde = txtPassword.Text;
                Destytojas.DestytojoId = cmd.ExecuteScalar().ToString();
                //MessageBox.Show(Destytojas.DestytojoId);
                this.Hide();
                FrmDestytojas frmDestytojas = new FrmDestytojas(Destytojas.Vardas, Destytojas.Pavarde, Destytojas.DestytojoId);
                frmDestytojas.Show();
                con.Close();
                i = +1;
            }
            if (i==0)
            {
                MessageBox.Show("Patikrinkite prisijungimo vardą ir/arba slaptažodį");
             
                
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
            FrmAdminStudentas frmAdminStudentas = new FrmAdminStudentas();
            frmAdminStudentas.Show();
        }

        private void btnDestytojas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminDestytojas frmAdminDestytojas = new FrmAdminDestytojas();
            frmAdminDestytojas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGrupesDalykai frmGrupesDalykai = new FrmGrupesDalykai();
            frmGrupesDalykai.Show();
        }

        private void btnAdminPazymiai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPazimiai frmPazimiai = new FrmPazimiai();
            frmPazimiai.Show();
        }

        private void Studentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudentas frmStudentas = new FrmStudentas("TestV", "TestP", "5");
            frmStudentas.Show();
        }

        private void btnDestytojas_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmDestytojas frmDestytojas = new FrmDestytojas("Petras", "Petrauskas", "12");
            frmDestytojas.Show();
        }
    }
}
