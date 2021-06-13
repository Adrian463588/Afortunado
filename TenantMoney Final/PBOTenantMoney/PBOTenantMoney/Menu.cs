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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnsender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            InputKendaraan inputkendaraan = new InputKendaraan();
            OpenChildForm(inputkendaraan, sender);
        }

        private void btnDaftarKendaraan_Click(object sender, EventArgs e)
        {
            DaftarKendaraan daftarkendaraan = new DaftarKendaraan();
            OpenChildForm(daftarkendaraan, sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masuk login = new Masuk();
            login.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSewa_Click(object sender, EventArgs e)
        {
            Sewa rent = new Sewa();
            OpenChildForm(rent, sender);
        }
    }
}
