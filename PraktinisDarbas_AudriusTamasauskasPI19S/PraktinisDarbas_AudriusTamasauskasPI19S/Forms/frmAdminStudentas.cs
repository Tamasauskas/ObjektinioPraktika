using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    /// <summary>
    /// Forma skirta studentu valdymui
    /// </summary>
    public partial class FrmAdminStudentas : Form
    {
        #region
        SQLiteConnection con = new SQLiteConnection(ClsHelper.ConnectionString);
        ClsHelper Helper = new ClsHelper();
        ClsStudentas Studentas = new ClsStudentas();
        #endregion
        /// <summary>
        /// Formos uzsikrovimo veiksmai
        /// </summary>
        public FrmAdminStudentas()
        {
            InitializeComponent();
            FillComboGrupe();
            StudentasDataGridView.DataSource = FillDatagrid();
            StudentasDataGridView.Columns["StudentoId"].Visible = false;
        }
        /// <summary>
        /// Uzpildo grupes combobox
        /// </summary>
        private void FillComboGrupe()
        {

            Helper.Query = "Select * From tbl_Grupe;";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            SQLiteDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sName = myReader["GrupesId"].ToString();
                    ComboGrupe.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        /// <summary>
        /// Uzpildo lentele
        /// </summary>
        private DataTable FillDatagrid()
        {
            DataTable dt = new DataTable();
            Helper.Query = "Select StudentoId, Vardas, Pavarde, GrupesId as Grupe From tbl_Studentas";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            try
            {
                con.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida:" + ex.Message);
            }
            con.Close();
            return dt;

        }
        /// <summary>
        /// Nurodo kas prisijunges
        /// </summary>
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.Text = "Admininstratorius";

        }
        /// <summary>
        /// Pakeisti StudentoId i pasirinkta is combobox
        /// </summary>
        private void ComboGrupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Studentas.GrupeId = ComboGrupe.Text;
        }
        /// <summary>
        /// Mygtukas studento pridejimui i tbl_Studentas
        /// </summary>
        private void btnPrideti(object sender, EventArgs e)
        {

            if (txtStudentoVardas.Text == "")
            {
                MessageBox.Show("Įveskite vardą.");
            }
            else if (txtStudentoPavarde.Text == "")
            {
                MessageBox.Show("Įveskite pavardę.");
            }
            else if (ComboGrupe.Text == "") 
            {
                MessageBox.Show("Pasirinkite grupę");
            }
            else
	        {
                Helper.Query = "Insert Into tbl_Studentas (Vardas, Pavarde, GrupesId) values ('" + txtStudentoVardas.Text + "', '" + txtStudentoPavarde.Text + "','" + Studentas.GrupeId + "');";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                SQLiteDataReader myReader;
                try
                {
                    con.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Išaugota sėkmingai");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida" + ex.Message);
                }
                con.Close();
                StudentasDataGridView.DataSource = FillDatagrid();
            }
            
           
        }
        /// <summary>
        /// Pasirinkimo is lenteles verciu pridejimas i teksto laukus
        /// </summary>
        private void StudentasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = this.StudentasDataGridView.Rows[e.RowIndex];
                txtStudentoPavarde.Text = row.Cells["Pavarde"].Value.ToString();
                txtStudentoVardas.Text = row.Cells["Vardas"].Value.ToString();
                ComboGrupe.Text = row.Cells["Grupe"].Value.ToString();
                Studentas.StudentoId = row.Cells["StudentoId"].Value.ToString();
            }
        }
        /// <summary>
        /// Update Studento duomenis tbl_Studentas
        /// </summary>
        private void btnAtnaujinti_Click(object sender, EventArgs e)
        {
            
            if (txtStudentoVardas.Text == "" || txtStudentoPavarde.Text == "" || ComboGrupe.Text == "" || Studentas.StudentoId == "")
            {
                MessageBox.Show("Nepasirinktas studentas.");
            }
            else
            {
                Studentas.Vardas = txtStudentoVardas.Text;
                Studentas.Pavarde = txtStudentoPavarde.Text;
                Studentas.GrupeId = ComboGrupe.Text;
                Helper.Query = "Update tbl_Studentas Set Vardas = '" + Studentas.Vardas + "', Pavarde= '" + Studentas.Pavarde + "', GrupesId= '" + ComboGrupe.Text + "' Where StudentoId='" + Studentas.StudentoId + "'";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                SQLiteDataReader myReader;
                try
                {
                    con.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Išaugota sėkmingai");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida" + ex.Message);
                }
                con.Close();
                StudentasDataGridView.DataSource = FillDatagrid();
            }
           
        }
        /// <summary>
        /// Delete studento irasus is tbl_StudentoIvertinimai
        /// </summary>
        private void NaikintiStudentoIvertinimus()
        {
            Helper.Query = "Delete From tbl_StudentoIvertinimas Where StudentoId='" + Studentas.StudentoId + "'";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            SQLiteDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida salinant studento įrašus iš įvertinimų." + ex.Message);
            }
            con.Close();
        }
        /// <summary>
        /// Delete studenta is tbl_Studentas
        /// </summary>
        private void btnNaikinti_Click(object sender, EventArgs e)
        {
            if (txtStudentoVardas.Text == "" || txtStudentoPavarde.Text == "" || ComboGrupe.Text == "" || Studentas.StudentoId == "")
            {
                MessageBox.Show("Nepasirinktas studentas.");
            }
            else
            {
                Helper.Query = "Delete From tbl_Studentas Where StudentoId='" + Studentas.StudentoId + "'";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                SQLiteDataReader myReader;
                try
                {
                    
                    con.Open();
                    myReader = cmd.ExecuteReader();
                    con.Close();
                    NaikintiStudentoIvertinimus();
                    MessageBox.Show("Ištrinta sėkmingai");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida šalinant studenta." + ex.Message);
                }
               
                StudentasDataGridView.DataSource = FillDatagrid();
            }
        }
        /// <summary>
        /// Mygtukas perejimui i destytoju valdmo forma
        /// </summary>
        private void btnDestytojas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminDestytojas frmAdminDestytojas = new FrmAdminDestytojas();
            frmAdminDestytojas.Show();
        }
        /// <summary>
        /// Mygtukas perejimui i grupiu ir daluku valdymo forma
        /// </summary>
        private void btnGrupsDalykai_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGrupesDalykai frmGrupesDalykai = new FrmGrupesDalykai();
            frmGrupesDalykai.Show();
        }
        /// <summary>
        /// Mygtukas perejimui i pazymiu valdymo forma
        /// </summary>
        private void btnPazimiai_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPazimiai frmPazimiai = new FrmPazimiai();
            frmPazimiai.Show();
        }
        /// <summary>
        /// Mygtukas grizimui i pradzio ekrana
        /// </summary>
        private void btnAtsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.Show();
        }
    }
}

