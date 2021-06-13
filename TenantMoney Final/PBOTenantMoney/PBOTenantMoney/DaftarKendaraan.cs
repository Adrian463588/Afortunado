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
    public partial class DaftarKendaraan : Form
    {
        koneksi konn = new koneksi();
        public void Clear()
        {
            tbMerekShow.Text = "";
            tbPlatNomorShow.Text = "";
            tbHargaShow.Text = "";
        }
        public DaftarKendaraan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                tbMerekShow.Text = row.Cells[1].Value.ToString();
                tbPlatNomorShow.Text = row.Cells[2].Value.ToString();
                tbHargaShow.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void DaftarKendaraan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pBOTenantMoneyDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.pBOTenantMoneyDataSet.Vehicle);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = konn.getconn();
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Vehicle where Merek = '" + tbMerekShow.Text + "' ", sqlconn);
            cmd.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("Data Berhasil DiHapus");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (tbMerekShow.Text == "" || tbPlatNomorShow.Text == "" || tbHargaShow.Text == "")
            {
                MessageBox.Show("Data Belum Lengkap");
            }
            else
            {
                SqlConnection sqlconn = konn.getconn();
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Vehicle SET Merek=@merek, PlatNomor=@platnomor, Harga=@harga where Merek=@key",sqlconn);
                cmd.Parameters.AddWithValue("@merek", tbMerekShow.Text);
                cmd.Parameters.AddWithValue("@platnomor", tbPlatNomorShow.Text);
                cmd.Parameters.AddWithValue("@harga", Convert.ToInt32(tbHargaShow.Text));
                cmd.Parameters.AddWithValue("@key", tbMerekShow.Text);
                cmd.ExecuteNonQuery();
                sqlconn.Close();
                Clear();
                MessageBox.Show("Data Berhasil diUpdate");
            }
        }
    }
}
