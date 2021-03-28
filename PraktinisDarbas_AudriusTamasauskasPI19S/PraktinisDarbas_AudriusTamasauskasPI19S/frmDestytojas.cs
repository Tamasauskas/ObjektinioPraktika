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
        public frmDestytojas(string Dst_vardas, string Dst_Pavarde, string Dst_Id)
        {
            InitializeComponent();
            Text = Dst_vardas + " " + Dst_Pavarde;
        }

        private void btn_Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIn frmLogIn = new frmLogIn();
            frmLogIn.Show();
        }
    }
}
