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
    public partial class FrmGrupesDalykai : Form
    {
        SQLiteConnection con = new SQLiteConnection();
        ClsHelper Helper = new ClsHelper();
        ClsDalykoPavadinimas DalykoPavadinimas = new ClsDalykoPavadinimas();
        ClsGrupe Grupe = new ClsGrupe();
        

        public FrmGrupesDalykai()
        {
            InitializeComponent();
            con.ConnectionString = ClsHelper.ConnectionString;
            GrupeDataGridView.DataSource = FillGrupeDatagrid();
            DalykasDataGridView.DataSource = FillDalykasDatagrid();
        }

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

        private void btnStudentas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminStudentas frmAdminStudentas = new FrmAdminStudentas();
            frmAdminStudentas.Show();
        }

        private void btnDestytojas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminDestytojas frmAdminDestytojas = new FrmAdminDestytojas();
            frmAdminDestytojas.Show();
        }

        private void btn_Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.Show();
        }

        private void GrupeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GrupeDataGridView.Rows[e.RowIndex];
                txtGrupe.Text = row.Cells["Grupe"].Value.ToString();
            }
        }

        private void DalykasGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DalykasDataGridView.Rows[e.RowIndex];
                txtDalykas.Text = row.Cells["Dalykas"].Value.ToString();
            }
        }

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

        private void BtwDalykasPrideti_Click(object sender, EventArgs e)
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
                SalingiGrupe();
            }
            else
            {
                con.Close();
                MessageBox.Show("Grupei yra priskirti dalykai");

            }
        }

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

        private void SalingiGrupe()
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

        private void btnGrupePasalinti_Click(object sender, EventArgs e)
        {
            PatikrintiArNeraStudentuGrupeje();
            GrupeDataGridView.DataSource = FillGrupeDatagrid();
        }

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

        private void btnDalykasPašalinti_Click(object sender, EventArgs e)
        {
            PatikrintiArDalykoMokosi();
            DalykasDataGridView.DataSource = FillDalykasDatagrid();
        }

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

        private void frmGrupesDalykai_Load(object sender, EventArgs e)
        {
            this.Text = "Admininstratorius";
        }

        private void btnPazimiai_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPazimiai frmPazimiai = new FrmPazimiai();
            frmPazimiai.Show();
        }
    }
}
