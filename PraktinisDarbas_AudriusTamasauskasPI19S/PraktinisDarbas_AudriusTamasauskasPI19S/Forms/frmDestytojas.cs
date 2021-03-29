using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    public partial class frmDestytojas : Form
    {
        clsDestytojas Destytojas = new clsDestytojas();
        clsHelper Helper = new clsHelper();

        public frmDestytojas(string Dst_vardas, string Dst_Pavarde, string Dst_Id)
        {
            InitializeComponent();
            Text = Dst_vardas + " " + Dst_Pavarde;
            Destytojas.Vardas = Dst_vardas;
            Destytojas.Pavarde = Dst_Pavarde;
            Destytojas.DestytojoId = Dst_Id;
           
        }

        private void btn_Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIn frmLogIn = new frmLogIn();
            frmLogIn.Show();
        }
    }
}
