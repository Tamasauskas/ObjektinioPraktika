using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    /// <summary>
    /// Forma darbui su destytojo duomenimis
    /// </summary>
    public partial class FrmAdminDestytojas : Form
    {

        #region
        SQLiteConnection con = new SQLiteConnection(ClsHelper.ConnectionString);
        ClsHelper Helper = new ClsHelper();
        ClsDalykas Dalykas = new ClsDalykas();
        ClsDestytojas Destytojas = new ClsDestytojas();
        #endregion

        /// <summary>
        /// Formos uzsikrovimo veiksmai
        /// </summary>
        public FrmAdminDestytojas()
        {
            InitializeComponent();
            FillComboDalykas();
            FillComboGrupe();
            DestytojasDataGridView.DataSource = FillDatagrid();
            DestytojasDataGridView.Columns["DestytojoId"].Visible = false;
            DestytojasDataGridView.Columns["DalykoId"].Visible = false;

        }
 
        /// <summary>
        /// Nurodo formos varda
        /// </summary>
        private void frmAdminDestytojas_Load(object sender, EventArgs e)
        {
            this.Text = "Admininstratorius";
        }
        /// <summary>
        /// Uzpildo dalyko combobox
        /// </summary>
        private void FillComboDalykas()
        {

            Helper.Query = "Select DalykoPavadinimasId From tbl_DalykoPavadinimas;";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            SQLiteDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sName = myReader["DalykoPavadinimasId"].ToString();
                    ComboDalykas.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        /// <summary>
        /// Uzpildo grupes combobox
        /// </summary>
        private void FillComboGrupe()
        {

            Helper.Query = "Select GrupesId From tbl_Grupe;";
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
        /// <returns></returns>
        private DataTable FillDatagrid()
        {
            DataTable dt = new DataTable();
            Helper.Query = "SELECT tbl_Dalykas.DalykoId, tbl_Dalykas.DestytojoId, tbl_Destytojas.Vardas, tbl_Destytojas.Pavarde, tbl_Grupe.GrupesId As 'Grupe', tbl_DalykoPavadinimas.DalykoPavadinimasId As 'Dalyko Pavadinimas' from (((tbl_Dalykas INNER JOIN tbl_Destytojas ON tbl_Dalykas.DestytojoId = tbl_Destytojas.DestytojoId) INNER JOIN tbl_Grupe ON tbl_Dalykas.GrupesId = tbl_Grupe.GrupesId) INNER JOIN tbl_DalykoPavadinimas ON tbl_Dalykas.DalykoPavadinimasId = tbl_DalykoPavadinimas.DalykoPavadinimasId); ";
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
        /// Insert i tbl_Destytojas
        /// </summary>
        private void PridetiDestytoja()
        {
                Helper.Query = "Insert Into tbl_Destytojas (Vardas, Pavarde) values ('" + txtDestytojoVardas.Text + "', '" + txtDestytojoPavarde.Text + "');";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                SQLiteDataReader myReader;
                try
                {
                    con.Open();
                    myReader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida" + ex.Message);
                }
                con.Close();
        }
        /// <summary>
        /// Rasti DestytojoId
        /// </summary>
        private void RastiDestytojoId()
        {
                con.Open();
                Helper.Query = "Select DestytojoId From tbl_Destytojas where Vardas='" + txtDestytojoVardas.Text + "' and Pavarde= '" + txtDestytojoPavarde.Text + "'";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                Destytojas.DestytojoId = cmd.ExecuteScalar().ToString();
                con.Close();
        }
        /// <summary>
        /// Priskirti destytojui dalykus ir grupe kuriai destys
        /// </summary>
        private void IterptiDestomusDalykus()
        {
            Helper.Query = "Insert Into tbl_Dalykas (DestytojoId, GrupesId, DalykoPavadinimasId) values ('" + Destytojas.DestytojoId + "', '" + ComboGrupe.Text + "','" + ComboDalykas.Text + "');";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            SQLiteDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Išaugota sėkmingai");
            }
            catch (Exception)
            {
                MessageBox.Show("Klaida- negali viena grupe mokytis vienodu dalykų.");
            }
            con.Close();
            
        }
        /// <summary>
        /// Patikrinti ar irasas nesidubliuoja
        /// </summary>
        private void PatikrintiArjauYraToksDestytojas()
        {
            con.Open();
            Helper.Query = "Select Count(*) From tbl_Destytojas where Vardas='" + txtDestytojoVardas.Text + "' and Pavarde='" + txtDestytojoPavarde.Text + "'";
            SQLiteDataAdapter sda2 = new SQLiteDataAdapter(Helper.Query, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (dt2.Rows[0][0].ToString() == "0")
            {
                con.Close();
                PridetiDestytoja();
            }
            else
            {
                con.Close();
            }

        }
        /// <summary>
        /// Mygtukas Insert i tbl_Destytojas ir tbl_Dalykas
        /// </summary>
        private void btnPridėti_Click(object sender, EventArgs e)
        {
            if (txtDestytojoVardas.Text == "" || txtDestytojoPavarde.Text == "" || ComboGrupe.Text == "" || Destytojas.DestytojoId == "" || ComboDalykas.Text == "")
            {
                MessageBox.Show("Užpildykite visus laukus");
            }
            else
            {
                PatikrintiArjauYraToksDestytojas();
                RastiDestytojoId();
                IterptiDestomusDalykus();
                DestytojasDataGridView.DataSource = FillDatagrid();
            }
            
        }
        /// <summary>
        /// Priskirti teksto laukams vertes jei yra pasirinkimas is lenteles
        /// </summary>
        private void DestytojasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DestytojasDataGridView.Rows[e.RowIndex];
                txtDestytojoPavarde.Text = row.Cells["Pavarde"].Value.ToString();
                txtDestytojoVardas.Text = row.Cells["Vardas"].Value.ToString();
                ComboGrupe.Text = row.Cells["Grupe"].Value.ToString();
                ComboDalykas.Text = row.Cells["Dalyko Pavadinimas"].Value.ToString();
                Dalykas.DalykoId = row.Cells["DalykoId"].Value.ToString();
                Dalykas.DestytojoId = row.Cells["DestytojoId"].Value.ToString();
                //MessageBox.Show("Dalykas: " + Dalykas.DalykoId + "Destytojas " + Dalykas.DestytojoId);
            }
        }
        /// <summary>
        /// Update tbl_Destytojas
        /// </summary>
        private void DestytojasUpdate()
        {
            Destytojas.Vardas = txtDestytojoVardas.Text;
            Destytojas.Pavarde = txtDestytojoPavarde.Text;
            Destytojas.DestytojoId = Destytojas.DestytojoId;
            Helper.Query = "Update tbl_Destytojas Set Vardas = '" + Destytojas.Vardas + "', Pavarde= '" + Destytojas.Pavarde + "' Where DestytojoId='" + Destytojas.DestytojoId + "'";
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
                MessageBox.Show("Klaida destytojo atnaujinime: " + ex.Message);
            }
            con.Close();
            
        }
        /// <summary>
        /// Update tbl_Dalykas
        /// </summary>
        private void DalykasUpdate()
        {
           
            Helper.Query = "Update tbl_Dalykas Set DestytojoId= '" + Destytojas.DestytojoId + "', GrupesId= '" + ComboGrupe.Text + "', DalykoPavadinimasId= '" + ComboDalykas.Text + "' Where DalykoId='" + Dalykas.DalykoId + "'";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            SQLiteDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida dalyko atnaujinime: " + ex.Message);
            }
            con.Close();

        }
        /// <summary>
        /// Mygtukas Update ivykdymui
        /// </summary>
        private void btnAtnaujinti_Click(object sender, EventArgs e)
        {
            if (txtDestytojoPavarde.Text == "" || txtDestytojoVardas.Text == "" || ComboGrupe.Text == "" || Destytojas.DestytojoId == "" || ComboDalykas.Text=="" || Dalykas.DalykoId=="")
            {
                MessageBox.Show("Nepasirinktas įrašas.");
            }
            else 
            {
                PatikrintiArjauYraToksDestytojas();
                RastiDestytojoId();
                DestytojasUpdate();
                DalykasUpdate();
                DestytojasDataGridView.DataSource = FillDatagrid();
            }

        }
        /// <summary>
        /// Delete is tbl_Destytojas
        /// </summary>
        private void TrintiDestytoja()
        {
            if (txtDestytojoVardas.Text == "" || txtDestytojoPavarde.Text == "" || ComboGrupe.Text == "" || Destytojas.DestytojoId == "" || ComboDalykas.Text =="")
            {
                MessageBox.Show("Nepasirinktas įrašas.");
            }
            else
            {
                Helper.Query = "Delete From tbl_Destytojas Where DestytojoId='" + Dalykas.DestytojoId + "'";
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
                    MessageBox.Show("Klaida" + ex.Message);
                }
                con.Close();
            }
        }
        /// <summary>
        /// Delete is tbl_Dalykas
        /// </summary>
        private void TrintiDalyka()
        {
            Helper.Query = "Delete From tbl_Dalykas Where DalykoId='" + Dalykas.DalykoId + "'";
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
                MessageBox.Show("Klaida" + ex.Message);
            }
            con.Close();
        }
        /// <summary>
        /// Patikrinti ar paskutinis destytojo irasas ir jei taip pasalinti ir dalyka ir destytoja
        /// </summary>
        private void TikrintiArPaskutinisDestytojoIrasas()
        {
            con.Open();
            Helper.Query = "Select Count (DestytojoId) FROM tbl_Dalykas WHERE DestytojoId = '" + Dalykas.DestytojoId +" ';";
            SQLiteDataAdapter sda2 = new SQLiteDataAdapter(Helper.Query, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (dt2.Rows[0][0].ToString() == "1")
            {
                con.Close();
                TrintiDalyka();
                TrintiDestytoja();
                //MessageBox.Show("Yra tik vienas destytojas" );
            }
            else
            {
                con.Close();
                TrintiDalyka();
                //MessageBox.Show("Yra daugiau uz viena destytoja");

            }
        }
        /// <summary>
        /// Mygtukas destytojo ir/arba dalyko pasalinimui
        /// </summary>
        private void btnNaikinti_Click(object sender, EventArgs e)
        {
            TikrintiArPaskutinisDestytojoIrasas();
            DestytojasDataGridView.DataSource = FillDatagrid();
        }
        /// <summary>
        /// Mygtukas perejimui i forma grupiu ir dalyku pavadinimu valdymo forma
        /// </summary>
        private void BtnGrupesDalykai_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGrupesDalykai frmGrupesDalykai = new FrmGrupesDalykai();
            frmGrupesDalykai.Show();
        }
        /// <summary>
        /// Mygtukas perejimui i pazymiu verciu kontroles forma
        /// </summary>
        private void btnPazimiai_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPazimiai frmPazimiai = new FrmPazimiai();
            frmPazimiai.Show();
        }
        /// <summary>
        /// mygtukas perejimui i forma skirta darbui su studentu duomenimis
        /// </summary>
        private void btnStudentas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminStudentas frmAdminStudentas = new FrmAdminStudentas();
            frmAdminStudentas.Show();
        }
        /// <summary>
        /// Atsijungti ir grizti i LogIn forma
        /// </summary>
        private void btnAtsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.Show();
        }
    }
}
