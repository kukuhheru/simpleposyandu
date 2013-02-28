namespace Posyandu
{
    partial class frmNeonatus
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBerat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTinggi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDenyut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNafas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBayiSakitApa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSuhu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStatusVitK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBeratBadanRendah = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIkterus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiare = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPemeriksa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKeluhanLain = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKeluhan = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStatusImun = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtTanggal = new System.Windows.Forms.DateTimePicker();
            this.posyanduDataSet = new Posyandu.posyanduDataSet();
            this.neonatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neonatusTableAdapter = new Posyandu.posyanduDataSetTableAdapters.NeonatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.posyanduDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neonatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(249, 12);
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = true;
            this.txtNama.Size = new System.Drawing.Size(227, 22);
            this.txtNama.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tanggal";
            // 
            // txtBerat
            // 
            this.txtBerat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBerat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBerat.Location = new System.Drawing.Point(249, 68);
            this.txtBerat.Name = "txtBerat";
            this.txtBerat.Size = new System.Drawing.Size(227, 22);
            this.txtBerat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Berat";
            // 
            // txtTinggi
            // 
            this.txtTinggi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTinggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinggi.Location = new System.Drawing.Point(249, 96);
            this.txtTinggi.Name = "txtTinggi";
            this.txtTinggi.Size = new System.Drawing.Size(227, 22);
            this.txtTinggi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tinggi";
            // 
            // txtDenyut
            // 
            this.txtDenyut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDenyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenyut.Location = new System.Drawing.Point(249, 208);
            this.txtDenyut.Name = "txtDenyut";
            this.txtDenyut.Size = new System.Drawing.Size(227, 22);
            this.txtDenyut.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Frekuensi Denyut Jantung (kali/menit)";
            // 
            // txtNafas
            // 
            this.txtNafas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNafas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNafas.Location = new System.Drawing.Point(249, 180);
            this.txtNafas.Name = "txtNafas";
            this.txtNafas.Size = new System.Drawing.Size(227, 22);
            this.txtNafas.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Frekuensi nafas (kali/menit)";
            // 
            // txtBayiSakitApa
            // 
            this.txtBayiSakitApa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBayiSakitApa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBayiSakitApa.Location = new System.Drawing.Point(249, 152);
            this.txtBayiSakitApa.Name = "txtBayiSakitApa";
            this.txtBayiSakitApa.Size = new System.Drawing.Size(227, 22);
            this.txtBayiSakitApa.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Bayi sakit apa?";
            // 
            // txtSuhu
            // 
            this.txtSuhu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuhu.Location = new System.Drawing.Point(249, 124);
            this.txtSuhu.Name = "txtSuhu";
            this.txtSuhu.Size = new System.Drawing.Size(227, 22);
            this.txtSuhu.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Suhu";
            // 
            // txtStatusVitK
            // 
            this.txtStatusVitK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatusVitK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusVitK.Location = new System.Drawing.Point(249, 349);
            this.txtStatusVitK.Name = "txtStatusVitK";
            this.txtStatusVitK.Size = new System.Drawing.Size(227, 22);
            this.txtStatusVitK.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Memeriksa status Pemberian Vit. K";
            // 
            // txtBeratBadanRendah
            // 
            this.txtBeratBadanRendah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBeratBadanRendah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeratBadanRendah.Location = new System.Drawing.Point(249, 305);
            this.txtBeratBadanRendah.Name = "txtBeratBadanRendah";
            this.txtBeratBadanRendah.Size = new System.Drawing.Size(227, 22);
            this.txtBeratBadanRendah.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 48);
            this.label10.TabIndex = 50;
            this.label10.Text = "Memeriksa Kemungkinan Berat \r\nBadan Rendah dan/atau Masalah\r\nPemberian ASI";
            // 
            // txtIkterus
            // 
            this.txtIkterus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIkterus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIkterus.Location = new System.Drawing.Point(249, 264);
            this.txtIkterus.Name = "txtIkterus";
            this.txtIkterus.Size = new System.Drawing.Size(227, 22);
            this.txtIkterus.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "Memeriksa Ikterus";
            // 
            // txtDiare
            // 
            this.txtDiare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiare.Location = new System.Drawing.Point(249, 236);
            this.txtDiare.Name = "txtDiare";
            this.txtDiare.Size = new System.Drawing.Size(227, 22);
            this.txtDiare.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Memeriksa adanya diare";
            // 
            // txtPemeriksa
            // 
            this.txtPemeriksa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPemeriksa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPemeriksa.Location = new System.Drawing.Point(249, 461);
            this.txtPemeriksa.Name = "txtPemeriksa";
            this.txtPemeriksa.Size = new System.Drawing.Size(227, 22);
            this.txtPemeriksa.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 463);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 16);
            this.label13.TabIndex = 60;
            this.label13.Text = "Nama Pemeriksa";
            // 
            // txtKeluhanLain
            // 
            this.txtKeluhanLain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeluhanLain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeluhanLain.Location = new System.Drawing.Point(249, 433);
            this.txtKeluhanLain.Name = "txtKeluhanLain";
            this.txtKeluhanLain.Size = new System.Drawing.Size(227, 22);
            this.txtKeluhanLain.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 435);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 16);
            this.label14.TabIndex = 58;
            this.label14.Text = "Memeriksa keluhan ibu";
            // 
            // txtKeluhan
            // 
            this.txtKeluhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeluhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeluhan.Location = new System.Drawing.Point(249, 405);
            this.txtKeluhan.Name = "txtKeluhan";
            this.txtKeluhan.Size = new System.Drawing.Size(227, 22);
            this.txtKeluhan.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 407);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 16);
            this.label15.TabIndex = 56;
            this.label15.Text = "Memeriksa keluhan lain";
            // 
            // txtStatusImun
            // 
            this.txtStatusImun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatusImun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusImun.Location = new System.Drawing.Point(249, 377);
            this.txtStatusImun.Name = "txtStatusImun";
            this.txtStatusImun.Size = new System.Drawing.Size(227, 22);
            this.txtStatusImun.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 379);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 16);
            this.label16.TabIndex = 54;
            this.label16.Text = "Memeriksa status imunisasi";
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(294, 518);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(182, 29);
            this.btnBatal.TabIndex = 62;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(294, 489);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(182, 29);
            this.btnSimpan.TabIndex = 61;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtTanggal
            // 
            this.txtTanggal.Location = new System.Drawing.Point(249, 41);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(227, 20);
            this.txtTanggal.TabIndex = 1;
            // 
            // posyanduDataSet
            // 
            this.posyanduDataSet.DataSetName = "posyanduDataSet";
            this.posyanduDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmNeonatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 554);
            this.Controls.Add(this.txtTanggal);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtPemeriksa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtKeluhanLain);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtKeluhan);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtStatusImun);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtStatusVitK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBeratBadanRendah);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIkterus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDiare);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDenyut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNafas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBayiSakitApa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSuhu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTinggi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBerat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNeonatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neonatus";
            this.Load += new System.EventHandler(this.frmNeonatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posyanduDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neonatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBerat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTinggi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDenyut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNafas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBayiSakitApa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSuhu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStatusVitK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBeratBadanRendah;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIkterus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiare;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPemeriksa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKeluhanLain;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKeluhan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStatusImun;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DateTimePicker txtTanggal;
        private posyanduDataSet posyanduDataSet;
        private System.Windows.Forms.BindingSource neonatusBindingSource;
        private posyanduDataSetTableAdapters.NeonatusTableAdapter neonatusTableAdapter;
    }
}