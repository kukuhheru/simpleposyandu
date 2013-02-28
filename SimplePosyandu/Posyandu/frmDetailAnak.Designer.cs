namespace Posyandu
{
    partial class frmDetailAnak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEditData = new System.Windows.Forms.Button();
            this.txtTempatLahir = new System.Windows.Forms.ComboBox();
            this.txtJenisKelahiran = new System.Windows.Forms.ComboBox();
            this.txtJenisKelamin = new System.Windows.Forms.ComboBox();
            this.txtTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAlamatTempatLahir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPanjangBadan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBeratLahir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKelahiranKe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKMS = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInputPenyakit = new System.Windows.Forms.Button();
            this.btnInputNeonatus = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.daftarNeonatus = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.daftarPenyakit = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.anakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posyanduDataSet = new Posyandu.posyanduDataSet();
            this.anakTableAdapter = new Posyandu.posyanduDataSetTableAdapters.AnakTableAdapter();
            this.neonatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neonatusTableAdapter = new Posyandu.posyanduDataSetTableAdapters.NeonatusTableAdapter();
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.catatanPenyakitAnakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catatanPenyakitAnakTableAdapter = new Posyandu.posyanduDataSetTableAdapters.CatatanPenyakitAnakTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posyanduDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neonatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catatanPenyakitAnakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditData
            // 
            this.btnEditData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditData.Location = new System.Drawing.Point(792, 12);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(182, 29);
            this.btnEditData.TabIndex = 9;
            this.btnEditData.Text = "Edit Data";
            this.btnEditData.UseVisualStyleBackColor = true;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // txtTempatLahir
            // 
            this.txtTempatLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempatLahir.FormattingEnabled = true;
            this.txtTempatLahir.Items.AddRange(new object[] {
            "Rumah Bidan",
            "Polindes",
            "Rumah Bersalin",
            "Puskesmas",
            "Rumah Sakit"});
            this.txtTempatLahir.Location = new System.Drawing.Point(542, 93);
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(227, 24);
            this.txtTempatLahir.TabIndex = 7;
            this.txtTempatLahir.Text = "Rumah Bidan";
            // 
            // txtJenisKelahiran
            // 
            this.txtJenisKelahiran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJenisKelahiran.FormattingEnabled = true;
            this.txtJenisKelahiran.Items.AddRange(new object[] {
            "Tunggal",
            "Kembar 2",
            "Kembar 3"});
            this.txtJenisKelahiran.Location = new System.Drawing.Point(158, 121);
            this.txtJenisKelahiran.Name = "txtJenisKelahiran";
            this.txtJenisKelahiran.Size = new System.Drawing.Size(227, 24);
            this.txtJenisKelahiran.TabIndex = 3;
            this.txtJenisKelahiran.Text = "Tunggal";
            // 
            // txtJenisKelamin
            // 
            this.txtJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtJenisKelamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJenisKelamin.FormattingEnabled = true;
            this.txtJenisKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.txtJenisKelamin.Location = new System.Drawing.Point(158, 92);
            this.txtJenisKelamin.Name = "txtJenisKelamin";
            this.txtJenisKelamin.Size = new System.Drawing.Size(227, 24);
            this.txtJenisKelamin.TabIndex = 2;
            // 
            // txtTanggalLahir
            // 
            this.txtTanggalLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTanggalLahir.Location = new System.Drawing.Point(158, 66);
            this.txtTanggalLahir.Name = "txtTanggalLahir";
            this.txtTanggalLahir.Size = new System.Drawing.Size(227, 22);
            this.txtTanggalLahir.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Tanggal Lahir";
            // 
            // txtAlamatTempatLahir
            // 
            this.txtAlamatTempatLahir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamatTempatLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamatTempatLahir.Location = new System.Drawing.Point(542, 122);
            this.txtAlamatTempatLahir.Name = "txtAlamatTempatLahir";
            this.txtAlamatTempatLahir.Size = new System.Drawing.Size(227, 22);
            this.txtAlamatTempatLahir.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Alamat Tempat Lahir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tempat Lahir";
            // 
            // txtPanjangBadan
            // 
            this.txtPanjangBadan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPanjangBadan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanjangBadan.Location = new System.Drawing.Point(542, 66);
            this.txtPanjangBadan.Name = "txtPanjangBadan";
            this.txtPanjangBadan.Size = new System.Drawing.Size(227, 22);
            this.txtPanjangBadan.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Panjang Badan";
            // 
            // txtBeratLahir
            // 
            this.txtBeratLahir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBeratLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeratLahir.Location = new System.Drawing.Point(542, 38);
            this.txtBeratLahir.Name = "txtBeratLahir";
            this.txtBeratLahir.Size = new System.Drawing.Size(227, 22);
            this.txtBeratLahir.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Berat Lahir";
            // 
            // txtKelahiranKe
            // 
            this.txtKelahiranKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKelahiranKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelahiranKe.Location = new System.Drawing.Point(542, 10);
            this.txtKelahiranKe.Name = "txtKelahiranKe";
            this.txtKelahiranKe.Size = new System.Drawing.Size(227, 22);
            this.txtKelahiranKe.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Kelahiran Ke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Jenis Kelahiran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Jenis Kelamin";
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(158, 38);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(227, 22);
            this.txtNama.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nama";
            // 
            // btnKMS
            // 
            this.btnKMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKMS.Location = new System.Drawing.Point(792, 42);
            this.btnKMS.Name = "btnKMS";
            this.btnKMS.Size = new System.Drawing.Size(182, 29);
            this.btnKMS.TabIndex = 47;
            this.btnKMS.Text = "Kartu Menuju Sehat";
            this.btnKMS.UseVisualStyleBackColor = true;
            this.btnKMS.Click += new System.EventHandler(this.btnKMS_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(792, 77);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(182, 29);
            this.btnSimpan.TabIndex = 48;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Visible = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(792, 106);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(182, 29);
            this.btnBatal.TabIndex = 49;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Visible = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInputPenyakit);
            this.groupBox1.Controls.Add(this.btnInputNeonatus);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.daftarNeonatus);
            this.groupBox1.Controls.Add(this.daftarPenyakit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 348);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Catatan Kesehatan Anak ";
            // 
            // btnInputPenyakit
            // 
            this.btnInputPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputPenyakit.Location = new System.Drawing.Point(770, 170);
            this.btnInputPenyakit.Name = "btnInputPenyakit";
            this.btnInputPenyakit.Size = new System.Drawing.Size(182, 29);
            this.btnInputPenyakit.TabIndex = 51;
            this.btnInputPenyakit.Text = "Input Baru";
            this.btnInputPenyakit.UseVisualStyleBackColor = true;
            this.btnInputPenyakit.Click += new System.EventHandler(this.btnInputPenyakit_Click);
            // 
            // btnInputNeonatus
            // 
            this.btnInputNeonatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputNeonatus.Location = new System.Drawing.Point(770, 22);
            this.btnInputNeonatus.Name = "btnInputNeonatus";
            this.btnInputNeonatus.Size = new System.Drawing.Size(182, 29);
            this.btnInputNeonatus.TabIndex = 50;
            this.btnInputNeonatus.Text = "Input Baru";
            this.btnInputNeonatus.UseVisualStyleBackColor = true;
            this.btnInputNeonatus.Click += new System.EventHandler(this.btnInputNeonatus_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(322, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "CATATAN PENYAKIT DAN PERKEMBANGAN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "NEONATUS";
            // 
            // daftarNeonatus
            // 
            this.daftarNeonatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.daftarNeonatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daftarNeonatus.FullRowSelect = true;
            this.daftarNeonatus.GridLines = true;
            this.daftarNeonatus.Location = new System.Drawing.Point(9, 56);
            this.daftarNeonatus.MultiSelect = false;
            this.daftarNeonatus.Name = "daftarNeonatus";
            this.daftarNeonatus.Size = new System.Drawing.Size(943, 103);
            this.daftarNeonatus.TabIndex = 2;
            this.daftarNeonatus.UseCompatibleStateImageBehavior = false;
            this.daftarNeonatus.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tanggal";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Berat";
            this.columnHeader6.Width = 54;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tinggi";
            this.columnHeader7.Width = 59;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Suhu";
            this.columnHeader8.Width = 59;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Bayi Sakit Apa?";
            this.columnHeader9.Width = 107;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nafas";
            this.columnHeader10.Width = 46;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Denyut Jantung";
            this.columnHeader11.Width = 92;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Diare?";
            this.columnHeader12.Width = 91;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Ikterus";
            this.columnHeader13.Width = 79;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Berat rendah?";
            this.columnHeader14.Width = 81;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Status Vit.K";
            this.columnHeader15.Width = 68;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Status Imun.";
            this.columnHeader16.Width = 73;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Keluhan Lain";
            this.columnHeader17.Width = 97;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Keluhan Ibu";
            this.columnHeader18.Width = 80;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Pemeriksa";
            this.columnHeader19.Width = 73;
            // 
            // daftarPenyakit
            // 
            this.daftarPenyakit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.daftarPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daftarPenyakit.FullRowSelect = true;
            this.daftarPenyakit.GridLines = true;
            this.daftarPenyakit.Location = new System.Drawing.Point(9, 205);
            this.daftarPenyakit.MultiSelect = false;
            this.daftarPenyakit.Name = "daftarPenyakit";
            this.daftarPenyakit.Size = new System.Drawing.Size(943, 136);
            this.daftarPenyakit.TabIndex = 1;
            this.daftarPenyakit.UseCompatibleStateImageBehavior = false;
            this.daftarPenyakit.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tanggal";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Penyakit/Masalah";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tindakan/Rujukan/Umpan Balik";
            this.columnHeader3.Width = 221;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Keterangan";
            this.columnHeader4.Width = 145;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(158, 10);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(227, 22);
            this.txtID.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "ID";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "ID";
            // 
            // anakBindingSource
            // 
            this.anakBindingSource.DataMember = "Anak";
            this.anakBindingSource.DataSource = this.posyanduDataSet;
            // 
            // posyanduDataSet
            // 
            this.posyanduDataSet.DataSetName = "posyanduDataSet";
            this.posyanduDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anakTableAdapter
            // 
            this.anakTableAdapter.ClearBeforeFill = true;
            // 
            // neonatusBindingSource
            // 
            this.neonatusBindingSource.DataMember = "Neonatus";
            this.neonatusBindingSource.DataSource = this.posyanduDataSet;
            // 
            // neonatusTableAdapter
            // 
            this.neonatusTableAdapter.ClearBeforeFill = true;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Id";
            // 
            // catatanPenyakitAnakBindingSource
            // 
            this.catatanPenyakitAnakBindingSource.DataMember = "CatatanPenyakitAnak";
            this.catatanPenyakitAnakBindingSource.DataSource = this.posyanduDataSet;
            // 
            // catatanPenyakitAnakTableAdapter
            // 
            this.catatanPenyakitAnakTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetailAnak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 550);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnKMS);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.txtTempatLahir);
            this.Controls.Add(this.txtJenisKelahiran);
            this.Controls.Add(this.txtJenisKelamin);
            this.Controls.Add(this.txtTanggalLahir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAlamatTempatLahir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPanjangBadan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBeratLahir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKelahiranKe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailAnak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Detail Anak";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetailAnak_FormClosing);
            this.Load += new System.EventHandler(this.frmDetailAnak_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posyanduDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neonatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catatanPenyakitAnakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.ComboBox txtTempatLahir;
        private System.Windows.Forms.ComboBox txtJenisKelahiran;
        private System.Windows.Forms.ComboBox txtJenisKelamin;
        private System.Windows.Forms.DateTimePicker txtTanggalLahir;
        private System.Windows.Forms.BindingSource anakBindingSource;
        private posyanduDataSet posyanduDataSet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAlamatTempatLahir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPanjangBadan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBeratLahir;
        private System.Windows.Forms.Label label6;
        private posyanduDataSetTableAdapters.AnakTableAdapter anakTableAdapter;
        private System.Windows.Forms.TextBox txtKelahiranKe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKMS;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView daftarNeonatus;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ListView daftarPenyakit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnInputPenyakit;
        private System.Windows.Forms.Button btnInputNeonatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.BindingSource neonatusBindingSource;
        private posyanduDataSetTableAdapters.NeonatusTableAdapter neonatusTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.BindingSource catatanPenyakitAnakBindingSource;
        private posyanduDataSetTableAdapters.CatatanPenyakitAnakTableAdapter catatanPenyakitAnakTableAdapter;
    }
}