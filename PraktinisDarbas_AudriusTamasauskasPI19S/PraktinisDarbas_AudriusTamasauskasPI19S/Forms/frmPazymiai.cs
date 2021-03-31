using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    /// <summary>
    /// Forma darbui su pazymiais
    /// </summary>
    public partial class FrmPazimiai : Form
    {
        #region
        SQLiteConnection con = new SQLiteConnection(ClsHelper.ConnectionString);
        ClsHelper Helper = new ClsHelper();
        ClsPazymys Pazymys = new ClsPazymys();
        #endregion
        /// <summary>
        /// Formos uzsikrovimo veiksmai
        /// </summary>
        public FrmPazimiai()
        {
            InitializeComponent();
            PazymiaiDataGridView.DataSource = FillPazymiaiDatagrid();
        }
        /// <summary>
        /// Uzpildyti pazymiu lentele
        /// </summary>
        private DataTable FillPazymiaiDatagrid()
        {
            DataTable dt = new DataTable();
            Helper.Query = "Select PazymysId As Pazymys From tbl_Pazymys";
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
        /// Formos pavadimino pakeitimas
        /// </summary>
        private void frmPazimiai_Load(object sender, EventArgs e)
        {
            this.Text = "Admininstratorius";
        }
        /// <summary>
        /// Priskirti lenteles pasirinkima teksto laukui ir nustatuti kaip PazymioId
        /// </summary>
        private void PazymiaiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.PazymiaiDataGridView.Rows[e.RowIndex];
                txtPazymys.Text = row.Cells["Pazymys"].Value.ToString();
                Pazymys.PazymysId = row.Cells["Pazymys"].Value.ToString();
            }
        }
        /// <summary>
        /// Mygtukas pazymio pridejimui
        /// </summary>
        private void btnPazimysPridėti_Click(object sender, EventArgs e)
        {
            Helper.Query = "Insert Into tbl_Pazymys (PazymysId) values ('" +txtPazymys.Text + "');";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            SQLiteDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Klaida tok pažymys jau yra.");
            }
            con.Close();
            PazymiaiDataGridView.DataSource = FillPazymiaiDatagrid();
        }
        /// <summary>
        /// Patikrinti ar pazymys naudojamas pries ji salinant
        /// </summary>
        private void PatikrintiArPazymysnaudojamas()
        {
            con.Open();
           
            Helper.Query = "Select Count (PazymysId) FROM tbl_StudentoIvertinimas Where PazymysId = '" + txtPazymys.Text + "'";
            SQLiteDataAdapter sda2 = new SQLiteDataAdapter(Helper.Query, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (dt2.Rows[0][0].ToString() == "0")
            {
                con.Close();
                SalintiPazymi();
            }
            else
            {
                con.Close();
                MessageBox.Show("Kalida- pazymys naudojamas");

            }
        }
        /// <summary>
        /// Delete pazymi is tbl_Pazymys
        /// </summary>
        private void SalintiPazymi()
        {
            if (txtPazymys.Text == "")
            {
                MessageBox.Show("Nepasirinktas pazymio įrašas.");
            }
            else
            {

                Helper.Query = "Delete From tbl_Pazymys Where PazymysId='" + txtPazymys.Text + "'";
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
                    MessageBox.Show("Klaida- pazymys naudojamas." + ex.Message);
                }
                con.Close();
                PazymiaiDataGridView.DataSource = FillPazymiaiDatagrid();
            }
        }
        /// <summary>
        /// Mygtukas pazymio pasalinimui is tbl_Pazymys
        /// </summary>
        private void btnPazymysNaikinti_Click(object sender, EventArgs e)
        {
            PatikrintiArPazymysnaudojamas();
        }
        /// <summary>
        /// Atnaujinti pazymio verte tbl_Pazymys
        /// </summary>
        private void AtnaujintiPazymi()
        {
            Helper.Query = "Update tbl_Pazymys Set PazymysId= '" + txtPazymys.Text + "' Where PazymysId= '" + Pazymys.PazymysId + "'";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            SQLiteDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida pazymio atnaujinime: " + ex.Message);
            }
            con.Close();
        }
        /// <summary>
        /// Atnaujinti pazymio pertes tbl_StudentoIvertinimas
        /// </summary>
        private void AtnaujintiPazymiIvertinimuose()
        {
            Helper.Query = "Update tbl_StudentoIvertinimas Set PazymysId= '" + txtPazymys.Text + "' Where PazymysId= '" + Pazymys.PazymysId + "'";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            MessageBox.Show("Pazymys text: " +txtPazymys.Text+ "Keicamas i: " +Pazymys.PazymysId);
            SQLiteDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida pazymio atnaujinime: " + ex.Message);
            }
            con.Close();
        }
        /// <summary>
        /// Mygtukas pazymio atnaujinimui tbl_Pazymys ir tbl_StudentoIvertinimas
        /// </summary>
        private void btnPazymysAtnaujinti_Click(object sender, EventArgs e)
        {
            AtnaujintiPazymiIvertinimuose();
            AtnaujintiPazymi();
            PazymiaiDataGridView.DataSource = FillPazymiaiDatagrid();

        }
        /// <summary>
        /// Pereiti i destytojo valdymo forma
        /// </summary>
        private void btnDestytojas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminDestytojas frmAdminDestytojas = new FrmAdminDestytojas();
            frmAdminDestytojas.Show();
        }
        /// <summary>
        /// Pereiti i studento valdymo forma
        /// </summary>
        private void btnStudentas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminStudentas frmAdminStudentas = new FrmAdminStudentas();
            frmAdminStudentas.Show();
        }
        /// <summary>
        /// Pereiti i grupiu ir dalyku valdymo forma
        /// </summary>
        private void btnGrupsDalykai_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGrupesDalykai frmGrupesDalykai = new FrmGrupesDalykai();
            frmGrupesDalykai.Show();
        }
        /// <summary>
        /// Pereiti i pradzios ekrana
        /// </summary>
        private void btnAtsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.Show();
        }
    }
}
