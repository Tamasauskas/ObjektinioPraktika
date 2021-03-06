using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    /// <summary>
    /// Forma skirta studentams, kad peržiūreti savo ivertinimus
    /// </summary>
    public partial class FrmStudentas : Form
    {
        #region
        SQLiteConnection con = new SQLiteConnection(ClsHelper.ConnectionString);
        ClsHelper Helper = new ClsHelper();
        ClsStudentas Studentas = new ClsStudentas();
        #endregion

        /// <summary>
        /// Formos uzsikrovimo veiksai
        /// </summary>
        public FrmStudentas(string std_vardas, string std_Pavarde, string std_Id)
        {
            InitializeComponent();
            Text = std_vardas + " " + std_Pavarde;
            Studentas.Vardas = std_vardas;
            Studentas.Pavarde = std_Pavarde;
            Studentas.StudentoId = std_Id;
            StudentoIvertinimaiDataGridView.DataSource = FillDatagrid();
        }
        /// <summary>
        /// Studento pazymiu lenteles uzpildymas
        /// </summary>
        /// <returns></returns>
        private DataTable FillDatagrid()
        {
            DataTable dt = new DataTable();
            Helper.Query = " Select " +
                           " tbl_Dalykas.GrupesId As Grupe, " +
                           " tbl_Destytojas.Vardas || ' ' || tbl_Destytojas.Pavarde As Destytojas," + 
                           " tbl_Dalykas.DalykoPavadinimasId As Dalykas, "+
                           " tbl_Studentas.Vardas || ' ' || tbl_Studentas.Pavarde As Studentas, " +
                           " tbl_StudentoIvertinimas.PazymysId As Ivertinimas"+
                           " From "+
                           " (((tbl_StudentoIvertinimas "+
                           " Inner Join tbl_Pazymys On tbl_StudentoIvertinimas.PazymysId = tbl_Pazymys.PazymysId) "+
                           " Inner Join tbl_Studentas On  tbl_StudentoIvertinimas.StudentoId = tbl_Studentas.StudentoId) "+
                           " Inner Join tbl_Dalykas On tbl_StudentoIvertinimas.DalykoId = tbl_Dalykas.DalykoId), "+
                           " tbl_Destytojas "+
                           " Where tbl_Destytojas.DestytojoId = tbl_Dalykas.DestytojoId And tbl_Studentas.StudentoId = '"+Studentas.StudentoId+"'; ";
            SQLiteCommand cmd = new SQLiteCommand(Helper.Query, con);
            try
            {
                con.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Klaida studento pažymių lentelės atvaizdavime. " + Ex.Message);
            }
            con.Close();
            return dt;

        }
        /// <summary>
        /// Mygtumas grizimui i pradzio forma
        /// </summary>
        private void btnAtsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.Show();
        }

 
    }
}
