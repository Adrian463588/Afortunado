using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOTenantMoney
{
    public partial class InputKendaraan : Form
    {
        public void Clear()
        {
            tbMerek.Text = "";
            tbPlatNomor.Text = "";
            tbHarga.Text = "";
        }
        public InputKendaraan()
        {
            InitializeComponent();
        }

        private void InputKendaraan_Load(object sender, EventArgs e)
        {

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (tbMerek.Text == "" || tbPlatNomor.Text == "" || tbHarga.Text == "")
            {
                MessageBox.Show("Data Belum Lengkap");
            }
            else
            {
                Vehicle tambah = new Vehicle();
                tambah.Type = tbMerek.Text;
                tambah.ID = tbPlatNomor.Text;
                tambah.Price = Convert.ToInt32(tbHarga.Text);
                tambah.inputkendaraan(tambah.Type, tambah.ID, tambah.Price);
                Clear();
                MessageBox.Show("Data Berhasil diInput");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
