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

namespace PBOTenantMoney
{
    public partial class CreateAcc : Form
    {
        koneksi konn = new koneksi();
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            if (tbPASSWORD.Text == tbCONFIRMPASSWORD.Text)
            {
                SqlConnection sqlconn = konn.getconn();
                try
                {
                    sqlconn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Login(Username,Password) values('" + tbUSERNAME.Text + "','" + tbPASSWORD.Text + "')", sqlconn);
                    cmd.ExecuteNonQuery();
                    sqlconn.Close();
                    MessageBox.Show("Berhasil");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password Tidak Sesuai");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masuk login = new Masuk();
            login.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
