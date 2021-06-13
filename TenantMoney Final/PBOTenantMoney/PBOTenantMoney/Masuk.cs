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
    public partial class Masuk : Form
    {
        koneksi konn = new koneksi();
        public Masuk()
        {
            InitializeComponent();
        }

        private void Masuk_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = konn.getconn();
            using (sqlconn)
            {
                try
                {
                    sqlconn.Open();
                    SqlCommand cmd = new SqlCommand("select Count(*) From Login Where Username = @uname and Password=@pass", sqlconn);
                    cmd.Parameters.AddWithValue("@uname", tbusername.Text);
                    cmd.Parameters.AddWithValue("@pass", tbPassword.Text);
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        this.Hide();
                        Menu desktop = new Menu();
                        desktop.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password SALAH");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAcc create = new CreateAcc();
            create.Show();
        }
    }
}
