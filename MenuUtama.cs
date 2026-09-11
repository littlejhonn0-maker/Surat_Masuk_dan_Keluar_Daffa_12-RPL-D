using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surat_Masuk_dan_Keluar_Daffa_12_RPL_D
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {

        }
        void loadFormKePanel(Form formTujuan)
        {
            // Bersihkan form sebelumnya yang ada di panel konten
            pnlkonten.Controls.Clear();

            // Atur form agar bisa masuk ke panel tanpa border jendela
            formTujuan.TopLevel = false;
            formTujuan.FormBorderStyle = FormBorderStyle.None;
            formTujuan.Dock = DockStyle.Fill;

            // Masukkan form ke panel lalu tampilkan
            pnlkonten.Controls.Add(formTujuan);
            formTujuan.Show();
        }

        private void btnmainmenu_Click(object sender, EventArgs e)
        {
            loadFormKePanel(new MenuUtama());
        }

        private void btnsm_Click(object sender, EventArgs e)
        {
            loadFormKePanel(new SuratMasuk());
        }

        private void btnsk_Click(object sender, EventArgs e)
        {
            loadFormKePanel(new SuratKeluar());
        }

        private void btndis_Click(object sender, EventArgs e)
        {
            loadFormKePanel(new Disposisi());
        }

        private void btnbA_Click(object sender, EventArgs e)
        {
            loadFormKePanel(new BukuAgenda());
        }

        private void logoutPic_Click(object sender, EventArgs e)
        {

        }

        private void btndatauser_Click(object sender, EventArgs e)
        {
            loadFormKePanel(new DataUser());
        }
    }
}
