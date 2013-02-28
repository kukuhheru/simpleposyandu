using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Posyandu
{
    public partial class frmMPasien : Form
    {
        public frmMPasien()
        {
            InitializeComponent();
        }

        private void frmMPasien_Load(object sender, EventArgs e)
        {
            this.pasienTableAdapter.Fill(this.posyanduDataSet.Pasien);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pasienTableAdapter.PasienBaru(txtIDPasien.Text,
                txtNamaIbu.Text,
                txtTempatLahirIbu.Text,
                txtTanggalLahirIbu.Value.ToShortDateString(),
                txtAgamaIbu.Text,
                txtPendidikanIbu.Text,
                txtGolonganDarahIbu.Text,
                txtPekerjaanIbu.Text,
                txtNamaSuami.Text,
                txtTempatLahirSuami.Text,
                txtTanggalLahirSuami.Value.ToShortDateString(),
                txtAgamaSuami.Text,
                txtPendidikanSuami.Text,
                txtPekerjaanSuami.Text,
                txtAlamat.Text,
                txtKecamatan.Text,
                txtKabupaten.Text,
                txtTelepon.Text,
                txtKTPIbu.Text,
                txtKTPSuami.Text,"");
            
            frmPasien pasien = frmPasien.checkInstance();
            if (pasien != null)
            {
                pasien.refreshList();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
