using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;

using DirectShowLib;


namespace Posyandu
{
    public partial class frmTakePhoto : Form
    {

        private int cameraIndex;
        private Capture capturer;
        private IntPtr m_ip = IntPtr.Zero;
        private Image originalImage;

        private bool _selecting;
        private Rectangle _selection = Rectangle.Empty;
        private Point _selStart;

        private frmDetailPasien pas;
        public frmTakePhoto(frmDetailPasien pas)
        {
            InitializeComponent();
            this.pas = pas;
        }

        private void listAvailableCameras()
        {
            List<KeyValuePair<int, string>> camerasData = new List<KeyValuePair<int, string>>();

            DsDevice[] systemCameras = DsDevice.GetDevicesOfCat(DirectShowLib.FilterCategory.VideoInputDevice);

            int i = 0;
            foreach (DirectShowLib.DsDevice camera in systemCameras)
            {
                camerasData.Add(new KeyValuePair<int, string>(i, camera.Name));
                i++;
            }

            //-> clear the combobox
            cameraList.DataSource = null;
            cameraList.Items.Clear();

            //-> bind the combobox
            cameraList.DataSource = new BindingSource(camerasData, null);
            cameraList.DisplayMember = "Value";
            cameraList.ValueMember = "Key";

            cameraIndex = 0;
        }

        private void frmTakePhoto_Load(object sender, EventArgs e)
        {
            listAvailableCameras();

        }

        private void cameraList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cameraIndex = cameraList.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capturer = new Capture(cameraIndex, 320, 240, 24, image);
            disableControl(true);
            button3.Visible = false;

            if (originalImage != null)
            {
                originalImage.Dispose();
                originalImage = null;
            }
        }

        private void disableControl(bool enable)
        {
            button1.Enabled = !enable;
            button2.Enabled = enable;
        }

        private Image Crop(Image image, Rectangle selection)
        {
            Bitmap bmp = image as Bitmap;

            // Check if it is a bitmap:
            if (bmp == null)
                throw new ArgumentException("No valid bitmap");

            // Crop the image:
            Bitmap cropBmp = bmp.Clone(selection, bmp.PixelFormat);

            // Release the resources:
            image.Dispose();
            return cropBmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            // Release any previous buffer
            if (m_ip != IntPtr.Zero)
            {
                Marshal.FreeCoTaskMem(m_ip);
                m_ip = IntPtr.Zero;
            }

            // capture image
            m_ip = capturer.Click();
            Bitmap b = new Bitmap(capturer.Width, capturer.Height, capturer.Stride, PixelFormat.Format24bppRgb, m_ip);

            // If the image is upsidedown
            b.RotateFlip(RotateFlipType.RotateNoneFlipY);
            capturer.Dispose();
            capturer = null;
            GC.Collect();

            image.Image = b;
            originalImage = (Image) image.Image.Clone();
            disableControl(false);
            button3.Visible = true;

            Cursor.Current = Cursors.Default;
        }

        private void frmTakePhoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (capturer != null)
            {
                capturer.Dispose();
                capturer = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Cropping credit to Günther M. FOIDL 
        //Profile: www.codeproject.com/script/Membership/View.aspx?mid=4137368
        //Article: www.codeproject.com/Articles/30725/Cropping-Images
        //Cropping improved by vanleeuwena
        //Profile: www.codeproject.com/script/Membership/View.aspx?mid=3350926

        private void image_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _selecting && capturer==null)
            {
                _selecting = false;
            }
        }

        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            // Starting point of the selection:
            if (e.Button == MouseButtons.Left && capturer == null)
            {
                _selecting = true;
                _selection = new Rectangle(new Point(e.X, e.Y), new Size());
                _selStart = new Point(e.X, e.Y);
            }
        }

        private void image_MouseMove(object sender, MouseEventArgs e)
        {
            if (capturer == null)
            {
                image.Cursor = Cursors.Cross;
                // Update the actual size of the selection:
                if (_selecting)
                {
                    if (e.X < _selection.X)
                    {
                        _selection.Width = _selStart.X - e.X;
                        _selection.X = e.X;
                    }
                    else
                    {
                        _selection.Width = e.X - _selection.X;
                    }

                   if (e.Y < _selection.Y)
                   {
                       _selection.Height = _selStart.Y - e.Y;
                       _selection.Y = e.Y;
                   }
                   else
                   {
                       _selection.Height = e.Y - _selection.Y;
                   }

                    // Redraw the picturebox:
                    image.Refresh();
                }
            }
            else
            {
                image.Cursor = Cursors.Default;
            }
        }

        private void image_Paint(object sender, PaintEventArgs e)
        {
            if (_selecting && capturer == null)
            {
                // Draw a rectangle displaying the current selection
                Pen pen = Pens.GreenYellow;
                e.Graphics.DrawRectangle(pen, _selection);
            }
        }

        private void simpanFoto(Image image)
        {
            Random rand = new Random();
            bool filebaru = true;
            string namafile = rand.Next().ToString() + ".jpg";

            //Cek direktori file
            if (!Directory.Exists(Application.StartupPath + "/foto/"))
                Directory.CreateDirectory(Application.StartupPath + "/foto/");
            

            //Cek namafile untuk menghindari duplikasi nama
            while (filebaru)
            {
                if (!File.Exists(Application.StartupPath + "/foto/" + namafile))
                {
                    filebaru = false;
                }
                else
                {
                    namafile = rand.Next().ToString() + ".jpg";
                }
            }

            if (!_selection.IsEmpty)
            {
                Image newImage = Crop(image, _selection);
                newImage.Save(Application.StartupPath + "/foto/" + namafile, ImageFormat.Jpeg);
                newImage.Dispose();
                newImage = null;
                GC.Collect();

                pas.setNamaFile(namafile);
                Close();
            }
            else
            {
                MessageBox.Show("Pilih area yang akan disimpan terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            simpanFoto(image.Image);
        }

    }
}
