using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    /// <summary>
    /// Forma prsijungimui prie sistemos
    /// </summary>
    public partial class FrmLogIn : Form
    {
        #region
        SQLiteConnection con = new SQLiteConnection(ClsHelper.ConnectionString);
        ClsHelper Helper = new ClsHelper();
        private int i = 0;
        #endregion
        /// <summary>
        /// Formos uzsikrovimo veiksmai
        /// </summary>
        public FrmLogIn()
        {
            InitializeComponent();
            btnLogIn.FlatStyle = FlatStyle.Standard;
        }
       #region
        /// <summary>
        /// Prisijungimo vardo teksto lauko anuliavimas kai nuspaudziama
        /// </summary>
        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtLonInName.Text.Equals("Prisijungimo vardas"))
            {
                txtLonInName.Text = "";
                txtLonInName.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Prisijungimo vardo teksto lauko pakeitimas kai nieko neivesta
        /// </summary>
        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtLonInName.Text.Equals(""))
            {
                txtLonInName.Text = "Prisijungimo vardas";
                txtLonInName.ForeColor = Color.LightGray;
            }
        }
        /// <summary>
        /// Slaptazodzio teksto lauko anuliavimas kai nuspaudziama
        /// </summary>
        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Slaptazodzio teksto lauko pakeitimas kai nieko neivesta
        /// </summary>
        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.LightGray;
            }
        }
       #endregion
        /// <summary>
        /// Prisijungusio naudotojo nustatymas ir perejimas i jam piklausancia forma
        /// </summary>
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
        /// <summary>
        /// Programos uzdarymas
        /// </summary>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Skirta testavimui, pereiti i studento valdymo forma
        /// </summary>
        private void btnStudentoIvedimas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminStudentas frmAdminStudentas = new FrmAdminStudentas();
            frmAdminStudentas.Show();
        }
        /// <summary>
        /// Skirta testavimui, pereiti i destytojo valdymo forma
        /// </summary>
        private void btnDestytojas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminDestytojas frmAdminDestytojas = new FrmAdminDestytojas();
            frmAdminDestytojas.Show();
        }
        /// <summary>
        /// Skirta testavimui, pereiti i grupiu ir dalyku valdymo forma
        /// </summary>
        private void btnGrupesDalykai(object sender, EventArgs e)
        {
            this.Hide();
            FrmGrupesDalykai frmGrupesDalykai = new FrmGrupesDalykai();
            frmGrupesDalykai.Show();
        }
        /// <summary>
        /// Skirta testavimui, pereiti i pazymiu valdymo forma
        /// </summary>
        private void btnAdminPazymiai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPazimiai frmPazimiai = new FrmPazimiai();
            frmPazimiai.Show();
        }
        /// <summary>
        /// Skirta testavimui, pereiti i studento forma
        /// </summary>
        private void btnStudentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudentas frmStudentas = new FrmStudentas("TestV", "TestP", "5");
            frmStudentas.Show();
        }
        /// <summary>
        /// Skirta testavimui, pereiti i destytojo forma
        /// </summary>
        private void btnDestytojas_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmDestytojas frmDestytojas = new FrmDestytojas("Petras", "Petrauskas", "12");
            frmDestytojas.Show();
        }

    }
}
