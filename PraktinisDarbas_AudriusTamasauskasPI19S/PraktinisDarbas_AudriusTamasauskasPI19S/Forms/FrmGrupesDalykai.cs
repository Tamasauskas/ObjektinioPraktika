using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    /// <summary>
    /// Forma skirta dalyku pridejimui ir salinimui
    /// </summary>
    public partial class FrmGrupesDalykai : Form
    {
        #region
        SQLiteConnection con = new SQLiteConnection(ClsHelper.ConnectionString);
        ClsHelper Helper = new ClsHelper();
        ClsDalykoPavadinimas DalykoPavadinimas = new ClsDalykoPavadinimas();
        ClsGrupe Grupe = new ClsGrupe();
        #endregion
        /// <summary>
        /// Formos uzsikrovimo veiksmai
        /// </summary>
        public FrmGrupesDalykai()
        {
            InitializeComponent();
            GrupeDataGridView.DataSource = FillGrupeDatagrid();
            DalykasDataGridView.DataSource = FillDalykasDatagrid();
        }
        /// <summary>
        /// Uzpildyti grupiu lentele
        /// </summary>
        private DataTable FillGrupeDatagrid()
        {
            DataTable dt = new DataTable();
            Helper.Query = "Select GrupesId As Grupe From tbl_Grupe";
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
        /// Uzpilsdyti dalyku lentele
        /// </summary>
        private DataTable FillDalykasDatagrid()
        {
            DataTable dt = new DataTable();
            Helper.Query = "Select DalykoPavadinimasId As Dalykas From tbl_DalykoPavadinimas";
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
        /// Priskirti lenteles pasirinkima grupes teksto laukui
        /// </summary>
        private void GrupeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GrupeDataGridView.Rows[e.RowIndex];
                txtGrupe.Text = row.Cells["Grupe"].Value.ToString();
            }
        }
        /// <summary>
        /// Priskirti lenteles pasirinkima dalyko teksto laukui
        /// </summary>
        private void DalykasGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DalykasDataGridView.Rows[e.RowIndex];
                txtDalykas.Text = row.Cells["Dalykas"].Value.ToString();
            }
        }
        /// <summary>
        /// Insert grupe i tbl_Grupe
        /// </summary>
        private void btnGrupePridėti_Click(object sender, EventArgs e)
        {
            Helper.Query = "Insert Into tbl_Grupe (GrupesId) values ('" + txtGrupe.Text + "');";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            SQLiteDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Išsaugota sėkmingai.");
            }
            catch (Exception)
            {
                MessageBox.Show("Klaida tokia grupe jau yra.");
            }
            con.Close();
            GrupeDataGridView.DataSource = FillGrupeDatagrid();
        }
        /// <summary>
        /// Insert dalyka i tbl_Dalykas
        /// </summary>
        private void btnDalykasPrideti_Click(object sender, EventArgs e)
        {
            Helper.Query = "Insert Into tbl_DalykoPavadinimas (DalykoPavadinimasId) values ('" + txtDalykas.Text + "');";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            SQLiteDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Išsaugota sėkmingai.");
            }
            catch (Exception)
            {
                MessageBox.Show("Klaida toks dalykas jau yra.");
            }
            con.Close();
            DalykasDataGridView.DataSource = FillDalykasDatagrid();
        }
        /// <summary>
        /// Patikrinti ar nesidubliuoja grupe
        /// </summary>
        private void PatikrintiArNeraGrupesDaluku()
        {
            con.Open();
            Grupe.GrupesId = txtGrupe.Text;
            //MessageBox.Show("Dabartinis grupes Id" + Grupe.GrupesId);
            Helper.Query = "Select Count (GrupesId) FROM tbl_Dalykas WHERE GrupesId = '" + Grupe.GrupesId + "'";
            SQLiteDataAdapter sda2 = new SQLiteDataAdapter(Helper.Query, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (dt2.Rows[0][0].ToString() == "0")
            {
                con.Close();
                SalintiGrupe();
            }
            else
            {
                con.Close();
                MessageBox.Show("Grupei yra priskirti dalykai");

            }
        }
        /// <summary>
        /// Patikrinti ar grupeje yra studentu
        /// </summary>
        private void PatikrintiArNeraStudentuGrupeje()
        {
            con.Open();
            Grupe.GrupesId = txtGrupe.Text;
            //MessageBox.Show("Dabartinis grupes Id" + Grupe.GrupesId);
            Helper.Query = "Select Count (GrupesId) FROM tbl_Studentas WHERE GrupesId = '"+ Grupe.GrupesId +"'";
            SQLiteDataAdapter sda2 = new SQLiteDataAdapter(Helper.Query, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (dt2.Rows[0][0].ToString() == "0")
            {
                con.Close();
                PatikrintiArNeraGrupesDaluku();
               
            }
            else
            {
                con.Close();
                MessageBox.Show("Klaida- grupei priklauso bent vienas");

            }
        }
        /// <summary>
        /// Delete grupe is tbl_Grupe
        /// </summary>
        private void SalintiGrupe()
        {
            if (txtGrupe.Text == "")
            {
                MessageBox.Show("Nepasirinktas grupes įrašas.");
            }
            else
            {
                Grupe.GrupesId = txtGrupe.Text;
                Helper.Query = "Delete From tbl_Grupe Where GrupesId='" + Grupe.GrupesId + "'";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                SQLiteDataReader myReader;
                try
                {
                    con.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Ištrinta sėkmingai");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida- grupe aktyvi." + ex.Message);
                }
                con.Close();
                GrupeDataGridView.DataSource = FillGrupeDatagrid();
            }
        }
        /// <summary>
        /// Mygtukas grupes pasalinimui
        /// </summary>
        private void btnGrupePasalinti_Click(object sender, EventArgs e)
        {
            PatikrintiArNeraStudentuGrupeje();
            GrupeDataGridView.DataSource = FillGrupeDatagrid();
        }
        /// <summary>
        /// Delete dalyka is tbl_DalykoPavadinimas
        /// </summary>
        private void SalintiDalyka()
        {
            if (txtDalykas.Text == "")
            {
                MessageBox.Show("Nepasirinktas dalyko įrašas.");
            }
            else
            {
                DalykoPavadinimas.DalykoPavadinimasId = txtDalykas.Text;
                Helper.Query = "Delete From tbl_DalykoPavadinimas Where DalykoPavadinimasId='" + DalykoPavadinimas.DalykoPavadinimasId + "'";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                SQLiteDataReader myReader;
                try
                {
                    con.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Ištrinta sėkmingai");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida- grupe aktyvi." + ex.Message);
                }
                con.Close();
                
            }
        }
        /// <summary>
        /// Mygtukas dalyko pasalinimui
        /// </summary>
        private void btnDalykasPašalinti_Click(object sender, EventArgs e)
        {
            PatikrintiArDalykoMokosi();
            DalykasDataGridView.DataSource = FillDalykasDatagrid();
        }
        /// <summary>
        /// Patikrinti ar dalyko kas nors mokosi
        /// </summary>
        public void PatikrintiArDalykoMokosi()
        {
            con.Open();
            DalykoPavadinimas.DalykoPavadinimasId = txtDalykas.Text;
            Helper.Query = "Select Count (DalykoPavadinimasId) FROM tbl_Dalykas WHERE DalykoPavadinimasId = '" + DalykoPavadinimas.DalykoPavadinimasId + "'";
            SQLiteDataAdapter sda2 = new SQLiteDataAdapter(Helper.Query, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (dt2.Rows[0][0].ToString() == "0")
            {
                con.Close();
                SalintiDalyka();
            }
            else
            {
                con.Close();
                MessageBox.Show("Klaida- dalyko mokosi grupe.");

            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void frmGrupesDalykai_Load(object sender, EventArgs e)
        {
            this.Text = "Admininstratorius";
        }
        /// <summary>
        /// Pereiti i pazymiu valdymo forma
        /// </summary>
        private void btnPazimiai_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPazimiai frmPazimiai = new FrmPazimiai();
            frmPazimiai.Show();
        }
        /// <summary>
        /// Mygtukas perejimui i studento valdymo forma
        /// </summary>
        private void btnStudentas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminStudentas frmAdminStudentas = new FrmAdminStudentas();
            frmAdminStudentas.Show();
        }
        /// <summary>
        /// Mygtukas perejimui i destytojo valdymo forma
        /// </summary>
        private void btnDestytojas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminDestytojas frmAdminDestytojas = new FrmAdminDestytojas();
            frmAdminDestytojas.Show();
        }
        /// <summary>
        /// Mygtukas grizimui i pradzios ekrana
        /// </summary>
        private void btnAtsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.Show();
        }
    }
}
