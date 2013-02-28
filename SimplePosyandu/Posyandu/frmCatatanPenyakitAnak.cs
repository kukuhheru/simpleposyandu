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
    public partial class frmCatatanPenyakitAnak : Form
    {
        private int id;
        public frmCatatanPenyakitAnak(int id, String nama)
        {
            InitializeComponent();
            this.id = id;
            txtNama.Text = nama;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCatatanPenyakitAnak_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            catatanPenyakitAnakTableAdapter.Insert(id, txtTanggal.Value,
                txtPenyakit.Text, txtTindakan.Text, txtKeterangan.Text);

            frmDetailAnak fDetailAnak = frmDetailAnak.checkInstance();
            if (fDetailAnak != null)
            {
                fDetailAnak.refreshPenyakitList(id);
            }
            Close();
        }
    }
}
