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
    public partial class FrmPazimiai : Form
    {
        SQLiteConnection con = new SQLiteConnection();
        ClsHelper Helper = new ClsHelper();
        ClsPazymys Pazymys = new ClsPazymys();

        public FrmPazimiai()
        {
            InitializeComponent();
            con.ConnectionString = ClsHelper.ConnectionString;
            PazymiaiDataGridView.DataSource = FillPazymiaiDatagrid();
        }

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

        private void frmPazimiai_Load(object sender, EventArgs e)
        {
            this.Text = "Admininstratorius";
        }

        private void BtnGrupsDalykai_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGrupesDalykai frmGrupesDalykai = new FrmGrupesDalykai();
            frmGrupesDalykai.Show();
        }

        private void btnDestytojas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminDestytojas frmAdminDestytojas = new FrmAdminDestytojas();
            frmAdminDestytojas.Show();
        }

        private void btnStudentas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminStudentas frmAdminStudentas = new FrmAdminStudentas();
            frmAdminStudentas.Show();
        }

        private void PazymiaiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.PazymiaiDataGridView.Rows[e.RowIndex];
                txtPazymys.Text = row.Cells["Pazymys"].Value.ToString();
                Pazymys.PazymysId = row.Cells["Pazymys"].Value.ToString();
            }
        }

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

        private void btnPazymysNaikinti_Click(object sender, EventArgs e)
        {
            PatikrintiArPazymysnaudojamas();
        }
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
        private void btnPazymysAtnaujinti_Click(object sender, EventArgs e)
        {
            AtnaujintiPazymiIvertinimuose();
            AtnaujintiPazymi();
            PazymiaiDataGridView.DataSource = FillPazymiaiDatagrid();

        }

        private void btn_Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.Show();
        }
    }
}
