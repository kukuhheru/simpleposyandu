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
    public partial class frmNeonatus : Form
    {
        private int id;
        public frmNeonatus(int id, String nama)
        {
            InitializeComponent();
            this.id = id;
            txtNama.Text = nama;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            neonatusTableAdapter.Insert(id, txtTanggal.Value, Convert.ToDouble(txtBerat.Text),
                Convert.ToInt32(txtTinggi.Text), Convert.ToInt32(txtSuhu.Text), txtBayiSakitApa.Text,
                Convert.ToInt32(txtNafas.Text), Convert.ToInt32(txtDenyut.Text), txtDiare.Text,
                txtIkterus.Text, txtBeratBadanRendah.Text, txtStatusVitK.Text, txtStatusImun.Text,
                txtKeluhan.Text, txtKeluhanLain.Text, txtPemeriksa.Text);

            frmDetailAnak fDetailAnak = frmDetailAnak.checkInstance();
            if (fDetailAnak != null)
            {
                fDetailAnak.refreshNeonatusList(id);
            }
            Close();
        }

        private void frmNeonatus_Load(object sender, EventArgs e)
        {

        }
    }
}
