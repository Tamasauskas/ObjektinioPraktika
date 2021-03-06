using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    /// <summary>
    /// Forma skirta Destytojams, kad valdyti studentu pazymius
    /// </summary>
    public partial class FrmDestytojas : Form
    {
        #region
        SQLiteConnection con = new SQLiteConnection(ClsHelper.ConnectionString);
        ClsDestytojas Destytojas = new ClsDestytojas();
        ClsHelper Helper = new ClsHelper();
        ClsDalykas Dalykas = new ClsDalykas();
        ClsGrupe Grupe = new ClsGrupe();
        ClsPazymys Pazymys = new ClsPazymys();
        ClsStudentas Studentas = new ClsStudentas();
        #endregion
        /// <summary>
        /// Formos uzsikrovimo veiksmai
        /// </summary>
        /// <param name="dst_vardas"></param>
        /// <param name="dst_Pavarde"></param>
        /// <param name="dst_Id"></param>
        public FrmDestytojas(string dst_vardas, string dst_Pavarde, string dst_Id)
        {
            InitializeComponent();
            Text = dst_vardas + " " + dst_Pavarde;
            Destytojas.Vardas = dst_vardas;
            Destytojas.Pavarde = dst_Pavarde;
            Destytojas.DestytojoId = dst_Id;
            FillComboGrupe();
            FillComboDalykas();
            FillComboPazymiai();
            DestytojasDataGridView.DataSource = FillDatagrid();
        }
        /// <summary>
        /// Lenteles uzpildymas
        /// </summary>
        private DataTable FillDatagrid()
        {
            DataTable dt = new DataTable();
            Helper.Query = " Select " +
                           " tbl_Studentas.GrupesId As Grupe," +
                           " tbl_Dalykas.DalykoPavadinimasId As Dalykas, " +
                           " tbl_Studentas.Vardas || ' ' || tbl_Studentas.Pavarde As Studentas, " +
                           " tbl_StudentoIvertinimas.PazymysId As Įvertinimas" +
                           " From " +
                           " ((tbl_StudentoIvertinimas " +
                           " Inner Join  tbl_Studentas On tbl_StudentoIvertinimas.StudentoId = tbl_Studentas.StudentoId) " +
                           " Inner Join tbl_Dalykas On tbl_StudentoIvertinimas.DalykoId = tbl_Dalykas.DalykoId) " +
                           " Where tbl_Dalykas.DestytojoId = '"+Destytojas.DestytojoId+"'; ";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            try
            {
                con.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Klaida studento pažymių lentelės atvaizdavime." + Ex.Message);
            }
            con.Close();
            return dt;

        }
        /// <summary>
        /// Combox grupe uzpildymas
        /// </summary>
        private void FillComboGrupe()
        {
            Helper.Query = "Select Distinct (tbl_Dalykas.GrupesId) From tbl_Dalykas Where DestytojoId= '" + Destytojas.DestytojoId + "' ;";
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
        /// Combobox dalykas uzpuldymas
        /// </summary>
        private void FillComboDalykas()
        {
            Helper.Query = "Select Distinct (tbl_Dalykas.DalykoPavadinimasId) From tbl_Dalykas Where DestytojoId= '" + Destytojas.DestytojoId + "' ;";
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
        /// Combobox pazymiai uzpildymas
        /// </summary>
        private void FillComboPazymiai()
        {
            Helper.Query = "Select PazymysId from tbl_Pazymys;";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            SQLiteDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sName = myReader["PazymysId"].ToString();
                    ComboIvertinimas.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        /// <summary>
        /// Combobox Studentas uzpildymas
        /// </summary>
        private void FillComboStudentai()
        {
            Helper.Query = "Select Vardas || ' ' || Pavarde As Studentas from tbl_Studentas Where GrupesId='" + Grupe.GrupesId + "' ;";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            SQLiteDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sName = myReader["Studentas"].ToString();
                    ComboStudentas.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        /// <summary>
        /// Atnaujinti studentu sarasa combobox studentas jei pasirinkta grupe
        /// </summary>
        private void ComboGrupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grupe.GrupesId = ComboGrupe.Text;
            ComboStudentas.Items.Clear();
            FillComboStudentai();
        }
        /// <summary>
        /// Priskirti pasirinkta irasa prie dalyko
        /// </summary>
        private void ComboDalykas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dalykas.DalykoPavadinimasId = ComboDalykas.Text;
        }
        /// <summary>
        /// Rasti pasirinkto DalykoPavadinimasId DalykoId
        /// </summary>
        private void RastiDalykoId()
        {

            Helper.Query = "Select DalykoId From tbl_Dalykas where DestytojoId='" + Destytojas.DestytojoId + "' and GrupesId='" + Grupe.GrupesId + "' and DalykoPavadinimasId = '" + Dalykas.DalykoPavadinimasId + "'";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            try
            {
                con.Open();
                Dalykas.DalykoId = cmd.ExecuteScalar().ToString();
                //MessageBox.Show(Dalykas.DalykoId);
                con.Close();
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Klaida DalykoId paieskoje." + Ex.Message);
            }



        }
        /// <summary>
        /// Priskirti pasirinkta dalyka prie PazymysId
        /// </summary>
        private void ComboIvertinimas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pazymys.PazymysId = ComboIvertinimas.Text;
        }
        /// <summary>
        /// Neleisti rinktis studentu jei nepasirinkta grupe
        /// </summary>
        private void ComboStudentas_MouseClick(object sender, MouseEventArgs e)
        {

            if (ComboStudentas.Items.Count == 0)
            {
                MessageBox.Show("Pasirinkite grupe");
            }

        }
        /// <summary>
        /// Rasti pasirinktam sudentui priklausanti StudentoId
        /// </summary>
        private void RastiStudentoId()
        {
            con.Open();
            Helper.Query = "Select Count(*) From tbl_Studentas where Vardas='" + Studentas.Vardas + "' and Pavarde='" + Studentas.Pavarde + "'";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(Helper.Query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Helper.Query = "Select StudentoId From tbl_Studentas where Vardas='" + Studentas.Vardas + "' and Pavarde= '" + Studentas.Pavarde + "'";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                Studentas.StudentoId = cmd.ExecuteScalar().ToString();
                //MessageBox.Show(Studentas.StudentoId);
                con.Close();
            }
            else
            {
                MessageBox.Show("Nepavyko rasti studento");
                con.Close();
            }

        }
        /// <summary>
        /// Isskaidyti pasirinkta varda ir pavarde ir rasti StudentoId
        /// </summary>
        private void ComboStudentas_SelectedIndexChanged(object sender, EventArgs e)
        {

            string PilnasVardas = ComboStudentas.Text;
            var Split = PilnasVardas.Split(' ');
            Studentas.Vardas = Split[0];
            Studentas.Pavarde = Split[1];
            RastiStudentoId();
        }
        /// <summary>
        /// Insert pazymi studentu i tbl_StudentoIvertinimas
        /// </summary>
        private void btnIrasytiPazymi_Click(object sender, EventArgs e)
        {
            
            if (ComboStudentas.Text == "" || ComboGrupe.Text == "" || ComboDalykas.Text == "" || ComboIvertinimas.Text == "" )
            {
                MessageBox.Show("Neužpildyti visi laukai");
            }
            else
            {
               
                RastiDalykoId();
                Helper.Query = "Insert Into tbl_StudentoIvertinimas (PazymysId, DalykoId, StudentoId) values ('" + Pazymys.PazymysId + "','" + Dalykas.DalykoId + "', '" + Studentas.StudentoId + "');";
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
                    MessageBox.Show("Klaida pažymio priskirime studentui, patikrinkite ar studentas jau neturi pažymio iš šio dalyko.");
                }
                con.Close();
                DestytojasDataGridView.DataSource = FillDatagrid();
            }


        }
        /// <summary>
        /// Update studento ivertinima tbl_StudentoIvertinimas
        /// </summary>
        private void btnPakeistiPazimi_Click(object sender, EventArgs e)
        {

            if (ComboStudentas.Text == "" || ComboGrupe.Text == "" || ComboDalykas.Text == "" || ComboIvertinimas.Text == "")
            {
                MessageBox.Show("Neužpildyti visi laukai");
            }
            else
            {
                RastiDalykoId();
                Helper.Query = "Update tbl_StudentoIvertinimas Set PazymysId = '" + ComboIvertinimas.Text + "' Where DalykoId='" + Dalykas.DalykoId + "' And StudentoId='" + Studentas.StudentoId + "' ";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                SQLiteDataReader myReader;
                try
                {
                    con.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Išaugota sėkmingai");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Klaida pažymio paketime." + Ex.Message);
                }
                con.Close();
                DestytojasDataGridView.DataSource = FillDatagrid();
            }
        }
        /// <summary>
        /// Priskirti lenteleje pasirinktus irasus teksto laukams
        /// </summary>
        private void DestytojasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DestytojasDataGridView.Rows[e.RowIndex];
                ComboGrupe.Text = row.Cells["Grupe"].Value.ToString();
                ComboDalykas.Text = row.Cells["Dalykas"].Value.ToString();
                ComboStudentas.Text = row.Cells["Studentas"].Value.ToString();

            }
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
