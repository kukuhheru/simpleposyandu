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
    public partial class frmKMS : Form
    {
        private Image kmsOriginal;
        private int id;
        public static frmKMS instance;

        public frmKMS(int id)
        {
            InitializeComponent();
            kmsOriginal = (Image) KMS.Image.Clone();
            fillData(id);
            this.id = id;
            instance = this;
            lockControl(true);
        }

        public static frmKMS getInstance(int id)
        {
            if (instance == null)
                return new frmKMS(id);
            else
            {
                instance.fillData(id);
                return instance;
            }
        }

        public static frmKMS checkInstance()
        {
            return instance;
        }

        public int getIndexBulan(String teks)
        {
            switch (teks)
            {
                case "Februari": return 1;
                case "Maret": return 2;
                case "April": return 3;
                case "Mei": return 4;
                case "Juni": return 5;
                case "Juli": return 6;
                case "Agustus": return 7;
                case "September": return 8;
                case "Oktober": return 9;
                case "November": return 10;
                case "Desember": return 11;
                default: return 0;
            }
        }

        public String getNamaBulan(int id)
        {
            switch (id)
            {
                case 1:return "Februari"; 
                case 2:return "Maret"; 
                case 3:return "April"; 
                case 4:return "Mei"; 
                case 5:return "Juni"; 
                case 6:return "Juli"; 
                case 7:return "Agustus"; 
                case 8:return "September"; 
                case 9:return "Oktober"; 
                case 10:return "November"; 
                case 11:return "Desember"; 
                default: return "Januari";
            }
        }

        public void fillData(int id)
        {
            int check = (int) kMSTableAdapter.CekAnak(id);
            if (check <= 0)
            {
                IDataReader reader = anakTableAdapter.GetDataById(id).CreateDataReader();
                if (reader.Read())
                {
                    Double berat = reader.GetDouble(6)/1000;
                    String bulan = getNamaBulan(reader.GetDateTime(10).Month);
                    kMSTableAdapter.InsertKMS(id, berat.ToString() + ";0;0;0;0;0;0;0;0;0;0;0;0",
                        bulan + ";Januari;Januari;Januari;Januari;Januari;Januari;Januari;Januari;Januari;Januari;Januari;Januari");
                }
            }

            txtNama.Text = anakTableAdapter.GetNama(id);
            IDataReader readerAnak = kMSTableAdapter.GetDataById(id).CreateDataReader();
            if (readerAnak.Read())
            {
                String[] berat = readerAnak.GetString(1).Split(';');
                txtB0.Text = berat[0];
                txtB1.Text = berat[1];
                txtB2.Text = berat[2];
                txtB3.Text = berat[3];
                txtB4.Text = berat[4];
                txtB5.Text = berat[5];
                txtB6.Text = berat[6];
                txtB7.Text = berat[7];
                txtB8.Text = berat[8];
                txtB9.Text = berat[9];
                txtB10.Text = berat[10];
                txtB11.Text = berat[11];
                txtB12.Text = berat[12];

                String[] bulan = readerAnak.GetString(2).Split(';');
                b0.SelectedIndex = getIndexBulan(bulan[0]);
                b1.SelectedIndex = getIndexBulan(bulan[1]);
                b2.SelectedIndex = getIndexBulan(bulan[2]);
                b3.SelectedIndex = getIndexBulan(bulan[3]);
                b4.SelectedIndex = getIndexBulan(bulan[4]);
                b5.SelectedIndex = getIndexBulan(bulan[5]);
                b6.SelectedIndex = getIndexBulan(bulan[6]);
                b7.SelectedIndex = getIndexBulan(bulan[7]);
                b8.SelectedIndex = getIndexBulan(bulan[8]);
                b9.SelectedIndex = getIndexBulan(bulan[9]);
                b10.SelectedIndex = getIndexBulan(bulan[10]);
                b11.SelectedIndex = getIndexBulan(bulan[11]);
                b12.SelectedIndex = getIndexBulan(bulan[12]);
            }

            drawKMS();
        }

        private void lockControl(bool enable)
        {
            txtB0.ReadOnly = enable;
            txtB1.ReadOnly = enable;
            txtB2.ReadOnly = enable;
            txtB3.ReadOnly = enable;
            txtB4.ReadOnly = enable;
            txtB5.ReadOnly = enable;
            txtB6.ReadOnly = enable;
            txtB7.ReadOnly = enable;
            txtB8.ReadOnly = enable;
            txtB9.ReadOnly = enable;
            txtB10.ReadOnly = enable;
            txtB11.ReadOnly = enable;
            txtB12.ReadOnly = enable;

            b0.Enabled = !enable;
            b1.Enabled = !enable;
            b2.Enabled = !enable;
            b3.Enabled = !enable;
            b4.Enabled = !enable;
            b5.Enabled = !enable;
            b6.Enabled = !enable;
            b7.Enabled = !enable;
            b8.Enabled = !enable;
            b9.Enabled = !enable;
            b10.Enabled = !enable;
            b11.Enabled = !enable;
            b12.Enabled = !enable;
        }

        private void disableButton(bool enable)
        {
            btnSimpan.Visible = enable;
            btnBatal.Visible = enable;

            btnEdit.Enabled = !enable;
        }

        public void drawKMS()
        {
            KMS.Image = (Image)kmsOriginal.Clone();
            SolidBrush brush = new SolidBrush(Color.Red);
            Pen line = new Pen(Color.Blue,2);
            Pen lineB = new Pen(Color.White,4);
            Graphics g = Graphics.FromImage(KMS.Image);

            //Posisi 0 pertama: 48, 457
            //Perubahan x: 25
            //Perubahan y: 25

            int x = 50;

            //Draw PolyLine
            List<Point> points = new List<Point>();
            if (txtB0.Text != "0")
                points.Add(new Point(x, beratToInt(txtB0.Text) + 2));

            if (txtB1.Text != "0")
                points.Add(new Point(x + (1 * 25), beratToInt(txtB1.Text) + 2));

            if (txtB2.Text != "0")
                points.Add(new Point(x + (2 * 25), beratToInt(txtB2.Text) + 2));

            if (txtB3.Text != "0")
                points.Add(new Point(x + (3 * 25), beratToInt(txtB3.Text) + 2));

            if (txtB4.Text != "0")
                points.Add(new Point(x + (4 * 25), beratToInt(txtB4.Text) + 2));

            if (txtB5.Text != "0")
                points.Add(new Point(x + (5 * 25), beratToInt(txtB5.Text) + 2));

            if (txtB6.Text != "0")
                points.Add(new Point(x + (6 * 25), beratToInt(txtB6.Text) + 2));

            if (txtB7.Text != "0")
                points.Add(new Point(x + (7 * 25), beratToInt(txtB7.Text) + 2));

            if (txtB8.Text != "0")
                points.Add(new Point(x + (8 * 25), beratToInt(txtB8.Text) + 2));

            if (txtB9.Text != "0")
                points.Add(new Point(x + (9 * 25), beratToInt(txtB9.Text) + 2));

            if (txtB10.Text != "0")
                points.Add(new Point(x + (10 * 25), beratToInt(txtB10.Text) + 2));

            if (txtB11.Text != "0")
                points.Add(new Point(x + (11 * 25), beratToInt(txtB11.Text) + 2));

            if (txtB12.Text != "0")
                points.Add(new Point(x + (12 * 25), beratToInt(txtB12.Text) + 2));

            if (points.Count >= 2)
            {
                g.DrawLines(lineB, points.ToArray());
                g.DrawLines(line, points.ToArray());
            }

            //Draw Point
            x -= 2;
            if (txtB0.Text != "0")
                g.FillEllipse(brush, x, beratToInt(txtB0.Text), 6, 6);
            if (txtB1.Text != "0")
                g.FillEllipse(brush, x + (1 * 25), beratToInt(txtB1.Text), 6, 6);
            if (txtB2.Text != "0")
                g.FillEllipse(brush, x + (2 * 25), beratToInt(txtB2.Text), 6, 6);
            if (txtB3.Text != "0")
                g.FillEllipse(brush, x + (3 * 25), beratToInt(txtB3.Text), 6, 6);
            if (txtB4.Text != "0")
                g.FillEllipse(brush, x + (4 * 25), beratToInt(txtB4.Text), 6, 6);
            if (txtB5.Text != "0")
                g.FillEllipse(brush, x + (5 * 25), beratToInt(txtB5.Text), 6, 6);
            if (txtB6.Text != "0")
                g.FillEllipse(brush, x + (6 * 25), beratToInt(txtB6.Text), 6, 6);
            if (txtB7.Text != "0")
                g.FillEllipse(brush, x + (7 * 25), beratToInt(txtB7.Text), 6, 6);
            if (txtB8.Text != "0")
                g.FillEllipse(brush, x + (8 * 25), beratToInt(txtB8.Text), 6, 6);
            if (txtB9.Text != "0")
                g.FillEllipse(brush, x + (9 * 25), beratToInt(txtB9.Text), 6, 6);
            if (txtB10.Text != "0")
                g.FillEllipse(brush, x + (10 * 25), beratToInt(txtB10.Text), 6, 6);
            if (txtB11.Text != "0")
                g.FillEllipse(brush, x + (11 * 25), beratToInt(txtB11.Text), 6, 6);
            if (txtB12.Text != "0")
                g.FillEllipse(brush, x + (12 * 25), beratToInt(txtB12.Text), 6, 6);
        }

        public int beratToInt(String berat)
        {
            int berat0 = 457;
            int decrement = Convert.ToInt32( Convert.ToDouble(berat) * 25);
            return (berat0 - decrement);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lockControl(true);
            disableButton(false);

            String berat = txtB0.Text + ";" +
                           txtB1.Text + ";" +
                           txtB2.Text + ";" +
                           txtB3.Text + ";" +
                           txtB4.Text + ";" +
                           txtB5.Text + ";" +
                           txtB6.Text + ";" +
                           txtB7.Text + ";" +
                           txtB8.Text + ";" +
                           txtB9.Text + ";" +
                           txtB10.Text + ";" +
                           txtB11.Text + ";" +
                           txtB12.Text;

            String bulan = b0.Text + ";" +
                           b1.Text + ";" +
                           b2.Text + ";" +
                           b3.Text + ";" +
                           b4.Text + ";" +
                           b5.Text + ";" +
                           b6.Text + ";" +
                           b7.Text + ";" +
                           b8.Text + ";" +
                           b9.Text + ";" +
                           b10.Text + ";" +
                           b11.Text + ";" +
                           b12.Text;

            kMSTableAdapter.UpdateKMS(berat, bulan, id);
            drawKMS();
        }

        private void frmKMS_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lockControl(false);
            disableButton(true);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            lockControl(true);
            disableButton(false);
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
