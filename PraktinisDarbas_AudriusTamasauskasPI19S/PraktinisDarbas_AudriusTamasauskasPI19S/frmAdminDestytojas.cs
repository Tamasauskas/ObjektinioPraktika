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
    public partial class frmAdminDestytojas : Form
    {
        SQLiteConnection con = new SQLiteConnection();
        clsHelper Helper = new clsHelper();
        clsDalykas Dalykas = new clsDalykas();
        clsDestytojas Destytojas = new clsDestytojas();

        public frmAdminDestytojas()
        {
            InitializeComponent();
            con.ConnectionString = clsHelper.ConnectionString;
            FillComboDalykas();
            FillComboGrupe();
            DestytojasDataGridView.DataSource = FillDatagrid();
            DestytojasDataGridView.Columns["DestytojoId"].Visible = false;
            DestytojasDataGridView.Columns["DalykoId"].Visible = false;

        }

        private void btnStudentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminStudentas frmAdminStudentas = new frmAdminStudentas();
            frmAdminStudentas.Show();
        }

        private void frmAdminDestytojas_Load(object sender, EventArgs e)
        {
            this.Text = "Admininstratorius";
        }

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

        private void btn_Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIn frmLogIn = new frmLogIn();
            frmLogIn.Show();
        }

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
                DestytojasDataGridView.DataSource = FillDatagrid();  
        }
        private void RastiDestytojoId()
        {
                con.Open();
                Helper.Query = "Select DestytojoId From tbl_Destytojas where Vardas='" + txtDestytojoVardas.Text + "' and Pavarde= '" + txtDestytojoPavarde.Text + "'";
                SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
                Destytojas.DestytojoId = cmd.ExecuteScalar().ToString();
                con.Close();
        }

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
            catch (Exception ex)
            {
                MessageBox.Show("Klaida- negali viena grupe mokytis vienodu dalykų.");
            }
            con.Close();
            DestytojasDataGridView.DataSource = FillDatagrid();
        }
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
            }
            
        }

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
                
            }
        }
        private void DestytojasUpdate()
        {
            Destytojas.Vardas = txtDestytojoVardas.Text;
            Destytojas.Pavarde = txtDestytojoVardas.Text;
            Destytojas.DestytojoId = Dalykas.DestytojoId;
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
                MessageBox.Show("Klaida" + ex.Message);
            }
            con.Close();
            DestytojasDataGridView.DataSource = FillDatagrid();
        }
        private void btnAtnaujinti_Click(object sender, EventArgs e)
        {
            if (txtDestytojoPavarde.Text == "" || txtDestytojoVardas.Text == "" || ComboGrupe.Text == "" || Destytojas.DestytojoId == "" || ComboDalykas.Text=="" || Dalykas.DalykoId=="")
            {
                MessageBox.Show("Nepasirinktas įrašas.");
            }
            else
            {
               
            }

        }
    }
}
