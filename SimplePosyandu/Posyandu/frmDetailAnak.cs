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
    public partial class frmDetailAnak : Form
    {
        private int id;
        public static frmDetailAnak instance;

        public frmDetailAnak(int id)
        {
            InitializeComponent();
            instance = this;
            this.id = id;
            readAnak(id);
            refreshNeonatusList(id);
            refreshPenyakitList(id);
            lockControl(true);
        }

        public static frmDetailAnak getInstance(int id)
        {
            if (instance == null)
                return new frmDetailAnak(id);
            else
            {
                instance.readAnak(id);
                return instance;
            }
        }

        public static frmDetailAnak checkInstance()
        {
            return instance;
        }

        private void disableButton(bool enable)
        {
            btnSimpan.Visible = enable;
            btnBatal.Visible = enable;

            btnEditData.Enabled = !enable;
            btnKMS.Enabled = !enable;
            btnInputNeonatus.Enabled = !enable;
            btnInputPenyakit.Enabled = !enable;
        }

        private void readAnak(int id)
        {
            IDataReader reader = anakTableAdapter.GetDataById(id).CreateDataReader();
            if (reader.Read())
            {
                txtID.Text = reader.GetInt32(0).ToString();
                txtNama.Text = reader.GetString(2);
                txtJenisKelamin.Text = reader.GetString(3);
                txtJenisKelahiran.Text = reader.GetString(4);
                txtKelahiranKe.Text = reader.GetInt32(5).ToString();
                txtBeratLahir.Text = reader.GetDouble(6).ToString();
                txtPanjangBadan.Text = reader.GetInt32(7).ToString();
                txtTempatLahir.Text = reader.GetString(8);
                txtAlamatTempatLahir.Text = reader.GetString(9);
                txtTanggalLahir.Value = reader.GetDateTime(10);
            }

            reader.Close();
        }

        private void lockControl(bool enable)
        {
            txtID.ReadOnly = enable;
            txtNama.ReadOnly = enable;
            txtJenisKelamin.Enabled = !enable;
            txtJenisKelahiran.Enabled = !enable;
            txtKelahiranKe.ReadOnly = enable;
            txtBeratLahir.ReadOnly = enable;
            txtPanjangBadan.ReadOnly = enable;
            txtTempatLahir.Enabled = !enable;
            txtAlamatTempatLahir.ReadOnly = enable;
            txtTanggalLahir.Enabled = !enable;

            txtID.BackColor = Color.White;
            txtNama.BackColor = Color.White;
            txtJenisKelamin.BackColor = Color.White;
            txtJenisKelahiran.BackColor = Color.White;
            txtKelahiranKe.BackColor = Color.White;
            txtBeratLahir.BackColor = Color.White;
            txtPanjangBadan.BackColor = Color.White;
            txtTempatLahir.BackColor = Color.White;
            txtAlamatTempatLahir.BackColor = Color.White;
            txtTanggalLahir.BackColor = Color.White;
        }

        public void refreshNeonatusList(int id)
        {
            IDataReader reader = neonatusTableAdapter.GetDataByIdAnak(id).CreateDataReader();
            daftarNeonatus.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetDateTime(2).ToShortDateString());
                item.SubItems.Add(reader.GetDouble(3).ToString());
                item.SubItems.Add(reader.GetInt32(4).ToString());
                item.SubItems.Add(reader.GetInt32(5).ToString());
                item.SubItems.Add(reader.GetString(6));
                item.SubItems.Add(reader.GetInt32(7).ToString());
                item.SubItems.Add(reader.GetInt32(8).ToString());
                item.SubItems.Add(reader.GetString(9));
                item.SubItems.Add(reader.GetString(10));
                item.SubItems.Add(reader.GetString(11));
                item.SubItems.Add(reader.GetString(12));
                item.SubItems.Add(reader.GetString(13));
                item.SubItems.Add(reader.GetString(14));
                item.SubItems.Add(reader.GetString(15));
                item.SubItems.Add(reader.GetString(16));
                item.SubItems.Add(reader.GetInt32(0).ToString());

                daftarNeonatus.Items.Add(item);
            }
        }

        public void refreshPenyakitList(int id)
        {
            IDataReader reader = catatanPenyakitAnakTableAdapter.GetDataByIdAnak(id).CreateDataReader();
            daftarPenyakit.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetInt32(0).ToString());
                item.SubItems.Add(reader.GetDateTime(2).ToShortDateString());
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetString(4));
                item.SubItems.Add(reader.GetString(5));

                daftarPenyakit.Items.Add(item);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            disableButton(false);
            lockControl(true);

            anakTableAdapter.UpdateAnak(txtNama.Text, txtJenisKelamin.Text, txtJenisKelahiran.Text,
                Convert.ToInt32(txtKelahiranKe.Text), Convert.ToDouble(txtBeratLahir.Text),
                Convert.ToInt32(txtPanjangBadan.Text), txtTempatLahir.Text,
                txtAlamatTempatLahir.Text, txtTanggalLahir.Value.ToShortDateString(),
                id);

            frmDetailPasien pasien = frmDetailPasien.checkInstance();
            if (pasien != null)
            {
                pasien.refreshList(pasien.current_id);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            disableButton(false);
            lockControl(true);
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            disableButton(true);
            lockControl(false);
        }

        private void frmDetailAnak_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btnKMS_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            frmKMS fKMS = frmKMS.getInstance(id);
            fKMS.MdiParent = this.MdiParent;
            fKMS.Show();
            fKMS.BringToFront();
        }

        private void btnInputNeonatus_Click(object sender, EventArgs e)
        {
            frmNeonatus fNeonatus = new frmNeonatus(id, txtNama.Text);
            fNeonatus.ShowDialog();
        }

        private void frmDetailAnak_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInputPenyakit_Click(object sender, EventArgs e)
        {
            frmCatatanPenyakitAnak fPenyakit = new frmCatatanPenyakitAnak(id, txtNama.Text);
            fPenyakit.ShowDialog();
        }
    }
}
