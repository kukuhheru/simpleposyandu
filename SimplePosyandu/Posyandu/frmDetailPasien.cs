using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Posyandu
{
    public partial class frmDetailPasien : Form
    {
        private bool simpan = false;
        public static frmDetailPasien instance;
        public String current_id;

        public frmDetailPasien(String id)
        {
            InitializeComponent();
            lockControl(true);
            current_id = id;
            readPasien(id);
            instance = this;
        }

        public static frmDetailPasien checkInstance()
        {
            return instance;
        }

        public static frmDetailPasien getInstance(String id)
        {
            if (instance == null)
                return new frmDetailPasien(id);
            else
            {
                instance.disableButton(false);
                instance.lockControl(true);
                instance.readPasien(id);
                return instance;
            }
        }

        private void disableButton(bool enable)
        {
            btnSimpan.Visible = enable;
            btnBatal.Visible = enable;
            btnAmbilFoto.Visible = enable;
            btnCariFoto.Visible = enable;

            btnEditData.Enabled = !enable;
            btnRiwayatKesehatan.Enabled = !enable;
        }

        private void lockControl(bool enable)
        {
            txtNamaIbu.ReadOnly = enable;
            txtTempatLahirIbu.ReadOnly = enable;
            txtTanggalLahirIbu.Enabled = !enable;
            txtAgamaIbu.Enabled = !enable;
            txtPendidikanIbu.ReadOnly = enable;
            txtGolonganDarahIbu.ReadOnly = enable;
            txtPekerjaanIbu.ReadOnly = enable;
            txtNamaSuami.ReadOnly = enable;
            txtTempatLahirSuami.ReadOnly = enable;
            txtTanggalLahirSuami.Enabled = !enable;
            txtAgamaSuami.Enabled = !enable;
            txtPendidikanSuami.ReadOnly = enable;
            txtPekerjaanSuami.ReadOnly = enable;
            txtAlamat.ReadOnly = enable;
            txtKecamatan.ReadOnly = enable;
            txtKabupaten.ReadOnly = enable;
            txtTelepon.ReadOnly = enable;
            txtKTPIbu.ReadOnly = enable;
            txtKTPSuami.ReadOnly = enable;

            txtNamaIbu.BackColor = Color.White;
            txtTempatLahirIbu.BackColor = Color.White;
            txtTanggalLahirIbu.BackColor = Color.White;
            txtAgamaIbu.BackColor = Color.White;
            txtPendidikanIbu.BackColor = Color.White;
            txtGolonganDarahIbu.BackColor = Color.White;
            txtPekerjaanIbu.BackColor = Color.White;
            txtNamaSuami.BackColor = Color.White;
            txtTempatLahirSuami.BackColor = Color.White;
            txtTanggalLahirSuami.BackColor = Color.White;
            txtAgamaSuami.BackColor = Color.White;
            txtPendidikanSuami.BackColor = Color.White;
            txtPekerjaanSuami.BackColor = Color.White;
            txtAlamat.BackColor = Color.White;
            txtKecamatan.BackColor = Color.White;
            txtKabupaten.BackColor = Color.White;
            txtTelepon.BackColor = Color.White;
            txtKTPIbu.BackColor = Color.White;
            txtKTPSuami.BackColor = Color.White;
        }

        private int stringToIndex(String agama)
        {
            switch (agama)
            {
                case "Kristen": return 1;
                case "Katolik": return 2;
                case "Hindu": return 3;
                case "Budha": return 4;
                default: return 0;
            }
        }

        private void readPasien(String id)
        {
            IDataReader reader = pasienTableAdapter.GetDataPasienByID(id).CreateDataReader();
            if (reader.Read())
            {
                txtIDPasien.Text = reader.GetString(0);
                txtNamaIbu.Text = reader.GetString(1);
                txtTempatLahirIbu.Text = reader.GetString(2);
                txtTanggalLahirIbu.Value = reader.GetDateTime(3);
                txtAgamaIbu.SelectedIndex = stringToIndex(reader.GetString(4));
                txtPendidikanIbu.Text = reader.GetString(5);
                txtGolonganDarahIbu.Text = reader.GetString(6);
                txtPekerjaanIbu.Text = reader.GetString(7);
                txtNamaSuami.Text = reader.GetString(8);
                txtTempatLahirSuami.Text = reader.GetString(9);
                txtTanggalLahirSuami.Value = reader.GetDateTime(10);
                txtAgamaSuami.SelectedIndex = stringToIndex(reader.GetString(11));
                txtPendidikanSuami.Text = reader.GetString(12);
                txtPekerjaanSuami.Text = reader.GetString(13);
                txtAlamat.Text = reader.GetString(14);
                txtKecamatan.Text = reader.GetString(15);
                txtKabupaten.Text = reader.GetString(16);
                txtTelepon.Text = reader.GetString(17);
                txtKTPIbu.Text = reader.GetString(18);
                txtKTPSuami.Text = reader.GetString(19);
                txtFoto.Text = reader.GetString(20);

                if (File.Exists(Application.StartupPath + "//foto//" + txtFoto.Text))
                {
                    foto.Image = Image.FromFile(Application.StartupPath + "//foto//" + txtFoto.Text);
                }
                else
                {
                    foto.Image = null;
                }
            }

            reader.Close();
            refreshList(id);
        }

        public void refreshList(String id)
        {
            IDataReader reader = anakTableAdapter.GetDataByIdOrangTua(id).CreateDataReader();
            daftarAnak.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetInt32(0).ToString());
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetDateTime(10).ToShortDateString());
                item.SubItems.Add(reader.GetString(8));

                daftarAnak.Items.Add(item);
            }
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            disableButton(true);
            lockControl(false);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            disableButton(false);
            lockControl(true);
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            disableButton(false);
            lockControl(true);
            simpan = true;

            pasienTableAdapter.UpdateDataPasien(
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
                    txtKTPSuami.Text,
                    txtFoto.Text,
                    txtIDPasien.Text);
        }

        private void frmDetailPasien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (simpan)
            {
                frmPasien pasien = frmPasien.checkInstance();
                if (pasien != null)
                {
                    pasien.refreshList();
                }
            }
            instance = null;
            simpan = false;
        }

        private void frmDetailPasien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posyanduDataSet.Anak' table. You can move, or remove it, as needed.
            this.anakTableAdapter.Fill(this.posyanduDataSet.Anak);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMAnak fAnak = new frmMAnak(txtIDPasien.Text);
            fAnak.ShowDialog();
        }

        private void daftarAnak_DoubleClick(object sender, EventArgs e)
        {
            if (daftarAnak.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(daftarAnak.SelectedItems[0].Text);
                frmDetailAnak detailAnak = frmDetailAnak.getInstance(id);
                detailAnak.MdiParent = this.MdiParent;
                detailAnak.Show();
                detailAnak.BringToFront();
            }
        }

        public void setNamaFile(String nama)
        {
            txtFoto.Text = nama;
        }

        private void btnAmbilFoto_Click(object sender, EventArgs e)
        {
            frmTakePhoto fTake = new frmTakePhoto(this);
            fTake.ShowDialog();
        }
    }
}
