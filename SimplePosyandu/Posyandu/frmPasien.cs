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
    public partial class frmPasien : Form
    {
        public static frmPasien instance;

        public frmPasien()
        {
            InitializeComponent();
            instance = this;
        }

        public static frmPasien checkInstance()
        {
            return instance;
        }

        public static frmPasien getInstance()
        {
            if (instance == null)
                return new frmPasien();
            return instance;
        }

        private void frmPasien_Load(object sender, EventArgs e)
        {
            this.pasienTableAdapter.Fill(this.posyanduDataSet.Pasien);
            refreshList();

            this.Size = new Size(this.MdiParent.Width - 25, this.MdiParent.Height - 75);
        }

        public void refreshList()
        {
            daftarPasien.Items.Clear();

            IDataReader reader = pasienTableAdapter.GetData().CreateDataReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(8));
                item.SubItems.Add(reader.GetString(14));
                item.SubItems.Add(reader.GetString(17));

                daftarPasien.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMPasien pasienBaru = new frmMPasien();
            pasienBaru.ShowDialog();
        }

        private void cariData(String kriteria)
        {
            daftarPasien.Items.Clear();

            IDataReader reader = pasienTableAdapter.GetDaftarPasienByKriteria("%"+kriteria+"%").CreateDataReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(8));
                item.SubItems.Add(reader.GetString(14));
                item.SubItems.Add(reader.GetString(17));

                daftarPasien.Items.Add(item);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            cariData(txtCari.Text);
        }

        private void daftarPasien_DoubleClick(object sender, EventArgs e)
        {
            if (daftarPasien.SelectedItems.Count > 0)
            {
                String id = daftarPasien.SelectedItems[0].Text;
                frmDetailPasien detailPasien = frmDetailPasien.getInstance(id);
                detailPasien.MdiParent = this.MdiParent;
                detailPasien.Show();
                detailPasien.BringToFront();
            }
        }

        private void frmPasien_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
    }
}
