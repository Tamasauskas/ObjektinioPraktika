using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PraktinisDarbas_AudriusTamasauskasPI19S
{
    public partial class frmLogIn : Form
    {
        SqlConnection con = new SqlConnection();
        //for testing
        public int Id { get; set; } 
        Helper Helper = new Helper();

        public frmLogIn()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=.Praktinis darbas DB.db; Version=3;";
            btnLogIn.FlatStyle = FlatStyle.Standard;
            

        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtLonInName.Text.Equals("Prisijungimo vardas"))
            {
                txtLonInName.Text = "";
                txtLonInName.ForeColor = Color.Black;
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtLonInName.Text.Equals(""))
            {
                txtLonInName.Text = "Prisijungimo vardas";
                txtLonInName.ForeColor = Color.LightGray;
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Slaptažodis"))
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Slaptažodis";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            btnLogIn.FlatStyle = FlatStyle.Flat;
            con.Open();
            Helper.Query = "Select Count(*) From tbl_Admin where LogIn='" + txtLonInName.Text + "' and Password = '" + txtPassword.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Helper.Query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Helper.Query = "Select Id from tbl_Admin where LogIn='" + txtLonInName.Text + "' and Password = '" + txtPassword.Text + "'";
                SqlCommand cmd = new SqlCommand(Helper.Query, con);
                this.Hide();
                frmAdminStudentas frmAdmin = new frmAdminStudentas();
                frmAdmin.Show();
                //Id = (int)cmd.ExecuteScalar();
                //MessageBox.Show(Convert.ToString(Id));
                //con.Close();
            }
            else
                MessageBox.Show("Patikrinkite prisijungimo vardą ir/arba slaptažodį");
            txtPassword.Text = "Slaptažodis";
            txtPassword.ForeColor = Color.LightGray;
            con.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
