namespace Posyandu
{
    partial class frmDetailPasien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPekerjaanSuami = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPendidikanSuami = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtKecamatan = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtKabupaten = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.posyanduDataSet = new Posyandu.posyanduDataSet();
            this.btnEditData = new System.Windows.Forms.Button();
            this.pasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupSuami = new System.Windows.Forms.GroupBox();
            this.txtAgamaSuami = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTanggalLahirSuami = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKTPSuami = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTempatLahirSuami = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNamaSuami = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGolonganDarahIbu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPendidikanIbu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupIbu = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPekerjaanIbu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAgamaIbu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTanggalLahirIbu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKTPIbu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTempatLahirIbu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaIbu = new System.Windows.Forms.TextBox();
            this.txtIDPasien = new System.Windows.Forms.TextBox();
            this.pasienTableAdapter = new Posyandu.posyanduDataSetTableAdapters.PasienTableAdapter();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.PictureBox();
            this.btnCariFoto = new System.Windows.Forms.Button();
            this.btnAmbilFoto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.daftarAnak = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.anakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anakTableAdapter = new Posyandu.posyanduDataSetTableAdapters.AnakTableAdapter();
            this.btnRiwayatKesehatan = new System.Windows.Forms.Button();
            this.txtFoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.posyanduDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).BeginInit();
            this.groupSuami.SuspendLayout();
            this.groupIbu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Pasien";
            // 
            // txtPekerjaanSuami
            // 
            this.txtPekerjaanSuami.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPekerjaanSuami.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPekerjaanSuami.Location = new System.Drawing.Point(122, 193);
            this.txtPekerjaanSuami.Name = "txtPekerjaanSuami";
            this.txtPekerjaanSuami.Size = new System.Drawing.Size(202, 22);
            this.txtPekerjaanSuami.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 16);
            this.label18.TabIndex = 12;
            this.label18.Text = "Telepon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Pekerjaan";
            // 
            // txtPendidikanSuami
            // 
            this.txtPendidikanSuami.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPendidikanSuami.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendidikanSuami.Location = new System.Drawing.Point(122, 162);
            this.txtPendidikanSuami.Name = "txtPendidikanSuami";
            this.txtPendidikanSuami.Size = new System.Drawing.Size(202, 22);
            this.txtPendidikanSuami.TabIndex = 14;
            // 
            // txtTelepon
            // 
            this.txtTelepon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelepon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelepon.Location = new System.Drawing.Point(118, 105);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(187, 22);
            this.txtTelepon.TabIndex = 19;
            // 
            // txtKecamatan
            // 
            this.txtKecamatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKecamatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKecamatan.Location = new System.Drawing.Point(118, 49);
            this.txtKecamatan.Name = "txtKecamatan";
            this.txtKecamatan.Size = new System.Drawing.Size(187, 22);
            this.txtKecamatan.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(5, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 16);
            this.label21.TabIndex = 6;
            this.label21.Text = "Kecamatan";
            // 
            // txtKabupaten
            // 
            this.txtKabupaten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKabupaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKabupaten.Location = new System.Drawing.Point(118, 77);
            this.txtKabupaten.Name = "txtKabupaten";
            this.txtKabupaten.Size = new System.Drawing.Size(187, 22);
            this.txtKabupaten.TabIndex = 18;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(5, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 16);
            this.label22.TabIndex = 4;
            this.label22.Text = "Kabupaten/Kota";
            // 
            // txtAlamat
            // 
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(118, 21);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(187, 22);
            this.txtAlamat.TabIndex = 16;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(5, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "Alamat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Pendidikan";
            // 
            // posyanduDataSet
            // 
            this.posyanduDataSet.DataSetName = "posyanduDataSet";
            this.posyanduDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEditData
            // 
            this.btnEditData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditData.Location = new System.Drawing.Point(524, 12);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(162, 27);
            this.btnEditData.TabIndex = 12;
            this.btnEditData.Text = "Edit Data";
            this.btnEditData.UseVisualStyleBackColor = true;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // pasienBindingSource
            // 
            this.pasienBindingSource.DataMember = "Pasien";
            this.pasienBindingSource.DataSource = this.posyanduDataSet;
            // 
            // groupSuami
            // 
            this.groupSuami.Controls.Add(this.txtPekerjaanSuami);
            this.groupSuami.Controls.Add(this.label10);
            this.groupSuami.Controls.Add(this.txtPendidikanSuami);
            this.groupSuami.Controls.Add(this.label12);
            this.groupSuami.Controls.Add(this.txtAgamaSuami);
            this.groupSuami.Controls.Add(this.label13);
            this.groupSuami.Controls.Add(this.txtTanggalLahirSuami);
            this.groupSuami.Controls.Add(this.label14);
            this.groupSuami.Controls.Add(this.txtKTPSuami);
            this.groupSuami.Controls.Add(this.label15);
            this.groupSuami.Controls.Add(this.txtTempatLahirSuami);
            this.groupSuami.Controls.Add(this.label16);
            this.groupSuami.Controls.Add(this.txtNamaSuami);
            this.groupSuami.Controls.Add(this.label17);
            this.groupSuami.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSuami.Location = new System.Drawing.Point(352, 220);
            this.groupSuami.Name = "groupSuami";
            this.groupSuami.Size = new System.Drawing.Size(334, 227);
            this.groupSuami.TabIndex = 10;
            this.groupSuami.TabStop = false;
            this.groupSuami.Text = " Data Suami ";
            // 
            // txtAgamaSuami
            // 
            this.txtAgamaSuami.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAgamaSuami.FormattingEnabled = true;
            this.txtAgamaSuami.Items.AddRange(new object[] {
            "Islam",
            "Kristen",
            "Katolik",
            "Hindu",
            "Budha"});
            this.txtAgamaSuami.Location = new System.Drawing.Point(122, 132);
            this.txtAgamaSuami.Name = "txtAgamaSuami";
            this.txtAgamaSuami.Size = new System.Drawing.Size(202, 24);
            this.txtAgamaSuami.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Agama";
            // 
            // txtTanggalLahirSuami
            // 
            this.txtTanggalLahirSuami.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTanggalLahirSuami.Location = new System.Drawing.Point(122, 103);
            this.txtTanggalLahirSuami.Name = "txtTanggalLahirSuami";
            this.txtTanggalLahirSuami.Size = new System.Drawing.Size(202, 22);
            this.txtTanggalLahirSuami.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tanggal Lahir";
            // 
            // txtKTPSuami
            // 
            this.txtKTPSuami.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKTPSuami.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKTPSuami.Location = new System.Drawing.Point(122, 49);
            this.txtKTPSuami.Name = "txtKTPSuami";
            this.txtKTPSuami.Size = new System.Drawing.Size(202, 22);
            this.txtKTPSuami.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "No. KTP";
            // 
            // txtTempatLahirSuami
            // 
            this.txtTempatLahirSuami.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTempatLahirSuami.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempatLahirSuami.Location = new System.Drawing.Point(122, 77);
            this.txtTempatLahirSuami.Name = "txtTempatLahirSuami";
            this.txtTempatLahirSuami.Size = new System.Drawing.Size(202, 22);
            this.txtTempatLahirSuami.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Tempat Lahir";
            // 
            // txtNamaSuami
            // 
            this.txtNamaSuami.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaSuami.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaSuami.Location = new System.Drawing.Point(122, 21);
            this.txtNamaSuami.Name = "txtNamaSuami";
            this.txtNamaSuami.Size = new System.Drawing.Size(202, 22);
            this.txtNamaSuami.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(9, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "Nama";
            // 
            // txtGolonganDarahIbu
            // 
            this.txtGolonganDarahIbu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGolonganDarahIbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGolonganDarahIbu.Location = new System.Drawing.Point(122, 190);
            this.txtGolonganDarahIbu.Name = "txtGolonganDarahIbu";
            this.txtGolonganDarahIbu.Size = new System.Drawing.Size(56, 22);
            this.txtGolonganDarahIbu.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Golongan Darah";
            // 
            // txtPendidikanIbu
            // 
            this.txtPendidikanIbu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPendidikanIbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendidikanIbu.Location = new System.Drawing.Point(122, 162);
            this.txtPendidikanIbu.Name = "txtPendidikanIbu";
            this.txtPendidikanIbu.Size = new System.Drawing.Size(202, 22);
            this.txtPendidikanIbu.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pendidikan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // groupIbu
            // 
            this.groupIbu.Controls.Add(this.groupBox1);
            this.groupIbu.Controls.Add(this.txtPekerjaanIbu);
            this.groupIbu.Controls.Add(this.label9);
            this.groupIbu.Controls.Add(this.txtGolonganDarahIbu);
            this.groupIbu.Controls.Add(this.label8);
            this.groupIbu.Controls.Add(this.txtPendidikanIbu);
            this.groupIbu.Controls.Add(this.label7);
            this.groupIbu.Controls.Add(this.txtAgamaIbu);
            this.groupIbu.Controls.Add(this.label6);
            this.groupIbu.Controls.Add(this.txtTanggalLahirIbu);
            this.groupIbu.Controls.Add(this.label5);
            this.groupIbu.Controls.Add(this.txtKTPIbu);
            this.groupIbu.Controls.Add(this.label4);
            this.groupIbu.Controls.Add(this.txtTempatLahirIbu);
            this.groupIbu.Controls.Add(this.label3);
            this.groupIbu.Controls.Add(this.txtNamaIbu);
            this.groupIbu.Controls.Add(this.label2);
            this.groupIbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupIbu.Location = new System.Drawing.Point(10, 40);
            this.groupIbu.Name = "groupIbu";
            this.groupIbu.Size = new System.Drawing.Size(334, 407);
            this.groupIbu.TabIndex = 9;
            this.groupIbu.TabStop = false;
            this.groupIbu.Text = " Data Ibu ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelepon);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtKecamatan);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtKabupaten);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtAlamat);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Location = new System.Drawing.Point(12, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 144);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tempat Tinggal";
            // 
            // txtPekerjaanIbu
            // 
            this.txtPekerjaanIbu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPekerjaanIbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPekerjaanIbu.Location = new System.Drawing.Point(122, 218);
            this.txtPekerjaanIbu.Name = "txtPekerjaanIbu";
            this.txtPekerjaanIbu.Size = new System.Drawing.Size(202, 22);
            this.txtPekerjaanIbu.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pekerjaan";
            // 
            // txtAgamaIbu
            // 
            this.txtAgamaIbu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAgamaIbu.FormattingEnabled = true;
            this.txtAgamaIbu.Items.AddRange(new object[] {
            "Islam",
            "Kristen",
            "Katolik",
            "Hindu",
            "Budha"});
            this.txtAgamaIbu.Location = new System.Drawing.Point(122, 132);
            this.txtAgamaIbu.Name = "txtAgamaIbu";
            this.txtAgamaIbu.Size = new System.Drawing.Size(202, 24);
            this.txtAgamaIbu.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Agama";
            // 
            // txtTanggalLahirIbu
            // 
            this.txtTanggalLahirIbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTanggalLahirIbu.Location = new System.Drawing.Point(122, 103);
            this.txtTanggalLahirIbu.Name = "txtTanggalLahirIbu";
            this.txtTanggalLahirIbu.Size = new System.Drawing.Size(202, 22);
            this.txtTanggalLahirIbu.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tanggal Lahir";
            // 
            // txtKTPIbu
            // 
            this.txtKTPIbu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKTPIbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKTPIbu.Location = new System.Drawing.Point(122, 49);
            this.txtKTPIbu.Name = "txtKTPIbu";
            this.txtKTPIbu.Size = new System.Drawing.Size(202, 22);
            this.txtKTPIbu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "No. KTP";
            // 
            // txtTempatLahirIbu
            // 
            this.txtTempatLahirIbu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTempatLahirIbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempatLahirIbu.Location = new System.Drawing.Point(122, 77);
            this.txtTempatLahirIbu.Name = "txtTempatLahirIbu";
            this.txtTempatLahirIbu.Size = new System.Drawing.Size(202, 22);
            this.txtTempatLahirIbu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tempat Lahir";
            // 
            // txtNamaIbu
            // 
            this.txtNamaIbu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaIbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaIbu.Location = new System.Drawing.Point(122, 21);
            this.txtNamaIbu.Name = "txtNamaIbu";
            this.txtNamaIbu.Size = new System.Drawing.Size(202, 22);
            this.txtNamaIbu.TabIndex = 1;
            // 
            // txtIDPasien
            // 
            this.txtIDPasien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPasien.Location = new System.Drawing.Point(117, 12);
            this.txtIDPasien.Name = "txtIDPasien";
            this.txtIDPasien.ReadOnly = true;
            this.txtIDPasien.Size = new System.Drawing.Size(227, 22);
            this.txtIDPasien.TabIndex = 7;
            // 
            // pasienTableAdapter
            // 
            this.pasienTableAdapter.ClearBeforeFill = true;
            // 
            // btnTutup
            // 
            this.btnTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(489, 605);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(196, 27);
            this.btnTutup.TabIndex = 16;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(524, 91);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(162, 27);
            this.btnSimpan.TabIndex = 17;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Visible = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(524, 121);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(162, 27);
            this.btnBatal.TabIndex = 18;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Visible = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // foto
            // 
            this.foto.BackColor = System.Drawing.Color.Gray;
            this.foto.Location = new System.Drawing.Point(352, 13);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(155, 178);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 19;
            this.foto.TabStop = false;
            // 
            // btnCariFoto
            // 
            this.btnCariFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariFoto.Location = new System.Drawing.Point(524, 187);
            this.btnCariFoto.Name = "btnCariFoto";
            this.btnCariFoto.Size = new System.Drawing.Size(162, 27);
            this.btnCariFoto.TabIndex = 21;
            this.btnCariFoto.Text = "Cari Foto";
            this.btnCariFoto.UseVisualStyleBackColor = true;
            this.btnCariFoto.Visible = false;
            // 
            // btnAmbilFoto
            // 
            this.btnAmbilFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmbilFoto.Location = new System.Drawing.Point(525, 154);
            this.btnAmbilFoto.Name = "btnAmbilFoto";
            this.btnAmbilFoto.Size = new System.Drawing.Size(161, 27);
            this.btnAmbilFoto.TabIndex = 20;
            this.btnAmbilFoto.Text = "Ambil Foto";
            this.btnAmbilFoto.UseVisualStyleBackColor = true;
            this.btnAmbilFoto.Visible = false;
            this.btnAmbilFoto.Click += new System.EventHandler(this.btnAmbilFoto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.daftarAnak);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 146);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Anak ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(515, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Anak Baru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // daftarAnak
            // 
            this.daftarAnak.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.daftarAnak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daftarAnak.FullRowSelect = true;
            this.daftarAnak.GridLines = true;
            this.daftarAnak.Location = new System.Drawing.Point(7, 21);
            this.daftarAnak.MultiSelect = false;
            this.daftarAnak.Name = "daftarAnak";
            this.daftarAnak.Size = new System.Drawing.Size(660, 84);
            this.daftarAnak.TabIndex = 0;
            this.daftarAnak.UseCompatibleStateImageBehavior = false;
            this.daftarAnak.View = System.Windows.Forms.View.Details;
            this.daftarAnak.DoubleClick += new System.EventHandler(this.daftarAnak_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nama";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Jenis Kelamin";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tanggal Lahir";
            this.columnHeader4.Width = 145;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tempat Lahir";
            this.columnHeader5.Width = 132;
            // 
            // anakBindingSource
            // 
            this.anakBindingSource.DataMember = "Anak";
            this.anakBindingSource.DataSource = this.posyanduDataSet;
            // 
            // anakTableAdapter
            // 
            this.anakTableAdapter.ClearBeforeFill = true;
            // 
            // btnRiwayatKesehatan
            // 
            this.btnRiwayatKesehatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayatKesehatan.Location = new System.Drawing.Point(525, 45);
            this.btnRiwayatKesehatan.Name = "btnRiwayatKesehatan";
            this.btnRiwayatKesehatan.Size = new System.Drawing.Size(162, 27);
            this.btnRiwayatKesehatan.TabIndex = 23;
            this.btnRiwayatKesehatan.Text = "Riwayat Kesehatan";
            this.btnRiwayatKesehatan.UseVisualStyleBackColor = true;
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(352, 194);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(155, 20);
            this.txtFoto.TabIndex = 24;
            this.txtFoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmDetailPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 636);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.btnRiwayatKesehatan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCariFoto);
            this.Controls.Add(this.btnAmbilFoto);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupSuami);
            this.Controls.Add(this.groupIbu);
            this.Controls.Add(this.txtIDPasien);
            this.Controls.Add(this.btnEditData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailPasien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Detail Pasien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetailPasien_FormClosing);
            this.Load += new System.EventHandler(this.frmDetailPasien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posyanduDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).EndInit();
            this.groupSuami.ResumeLayout(false);
            this.groupSuami.PerformLayout();
            this.groupIbu.ResumeLayout(false);
            this.groupIbu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPekerjaanSuami;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPendidikanSuami;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.TextBox txtKecamatan;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtKabupaten;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label12;
        private posyanduDataSet posyanduDataSet;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.BindingSource pasienBindingSource;
        private System.Windows.Forms.GroupBox groupSuami;
        private System.Windows.Forms.ComboBox txtAgamaSuami;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker txtTanggalLahirSuami;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKTPSuami;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTempatLahirSuami;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNamaSuami;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGolonganDarahIbu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPendidikanIbu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupIbu;
        private System.Windows.Forms.TextBox txtPekerjaanIbu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtAgamaIbu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtTanggalLahirIbu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKTPIbu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTempatLahirIbu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaIbu;
        private System.Windows.Forms.TextBox txtIDPasien;
        private posyanduDataSetTableAdapters.PasienTableAdapter pasienTableAdapter;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Button btnCariFoto;
        private System.Windows.Forms.Button btnAmbilFoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView daftarAnak;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.BindingSource anakBindingSource;
        private posyanduDataSetTableAdapters.AnakTableAdapter anakTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRiwayatKesehatan;
        private System.Windows.Forms.Label txtFoto;
    }
}