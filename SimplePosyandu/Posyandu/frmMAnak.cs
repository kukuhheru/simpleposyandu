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
    public partial class frmMAnak : Form
    {
        public frmMAnak(String id_pasien)
        {
            InitializeComponent();
            txtIDPasien.Text = id_pasien;
        }

        private void frmMAnak_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anakTableAdapter.Insert(txtIDPasien.Text, txtNama.Text, txtJenisKelamin.Text,
                txtJenisKelahiran.Text, Convert.ToInt32(txtKelahiranKe.Text),
                Convert.ToDouble(txtBeratLahir.Text), Convert.ToInt32(txtPanjangBadan.Text),
                txtTempatLahir.Text, txtAlamatTempatLahir.Text,
                txtTanggalLahir.Value);

            frmDetailPasien detail = frmDetailPasien.checkInstance();
            if (detail != null)
            {
                detail.refreshList(txtIDPasien.Text);
                detail.BringToFront();
                Close();
            }
        }
    }
}
