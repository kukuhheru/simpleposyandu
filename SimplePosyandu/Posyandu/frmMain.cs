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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmPasien fPasien = new frmPasien();
            fPasien.MdiParent = this;
            fPasien.Show();
        }

        private void dataPasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPasien fPasien = frmPasien.getInstance();
            fPasien.MdiParent = this;
            fPasien.Show();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            frmPasien fPasien = frmPasien.checkInstance();
            if (fPasien != null)
            {
                fPasien.Size = new Size(this.Width - 25, this.Height - 75);
            }
        }
    }
}
