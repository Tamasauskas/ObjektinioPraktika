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
    public partial class frmStudentas : Form
    {
        SQLiteConnection con = new SQLiteConnection();
        clsHelper Helper = new clsHelper();
        clsStudentas Studentas = new clsStudentas();
        

        public frmStudentas(string Std_vardas, string Std_Pavarde, string Std_Id)
        {
            InitializeComponent();
            con.ConnectionString = clsHelper.ConnectionString;
            Text = Std_vardas + " " + Std_Pavarde;
            Studentas.Vardas = Std_vardas;
            Studentas.Pavarde = Std_Pavarde;
            Studentas.StudentoId = Std_Id;
            StudentoIvertinimaiDataGridView.DataSource = FillDatagrid();
        }

        private DataTable FillDatagrid()
        {
            DataTable dt = new DataTable();
            Helper.Query = " Select " +
                           " tbl_Dalykas.GrupesId As Grupe, " +
                           " tbl_Destytojas.Vardas || ' ' || tbl_Destytojas.Pavarde As Destytojas," + 
                           " tbl_Dalykas.DalykoPavadinimasId, "+
                           " tbl_Studentas.Vardas || ' ' || tbl_Studentas.Pavarde As Studentas, " +
                           " tbl_StudentoIvertinimas.PazymysId "+
                           " From "+
                           " (((tbl_StudentoIvertinimas "+
                           " Inner Join tbl_Pazymys On tbl_StudentoIvertinimas.PazymysId = tbl_Pazymys.PazymysId) "+
                           " Inner Join tbl_Studentas On  tbl_StudentoIvertinimas.StudentasId = tbl_Studentas.StudentoId) "+
                           " Inner Join tbl_Dalykas On tbl_StudentoIvertinimas.DalykasId = tbl_Dalykas.DalykoId), "+
                           " tbl_Destytojas "+
                           " Where tbl_Destytojas.DestytojoId = tbl_Dalykas.DestytojoId And tbl_Studentas.StudentoId = '5'; ";
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

     
    }
}
