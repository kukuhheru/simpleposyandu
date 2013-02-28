namespace Posyandu
{
    partial class frmCatatanPenyakitAnak
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
            this.txtTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTindakan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPenyakit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.posyanduDataSet = new Posyandu.posyanduDataSet();
            this.catatanPenyakitAnakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catatanPenyakitAnakTableAdapter = new Posyandu.posyanduDataSetTableAdapters.CatatanPenyakitAnakTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.posyanduDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catatanPenyakitAnakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTanggal
            // 
            this.txtTanggal.Location = new System.Drawing.Point(217, 41);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(257, 20);
            this.txtTanggal.TabIndex = 42;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeterangan.Location = new System.Drawing.Point(217, 141);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(257, 22);
            this.txtKeterangan.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 48);
            this.label8.TabIndex = 51;
            this.label8.Text = "Keterangan\r\n(Nama Pemeriksa, Tempat\r\nPelayanan, Paraf)";
            // 
            // txtTindakan
            // 
            this.txtTindakan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTindakan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTindakan.Location = new System.Drawing.Point(217, 96);
            this.txtTindakan.Name = "txtTindakan";
            this.txtTindakan.Size = new System.Drawing.Size(257, 22);
            this.txtTindakan.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tindakan/Rujukan/Umpan Balik";
            // 
            // txtPenyakit
            // 
            this.txtPenyakit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenyakit.Location = new System.Drawing.Point(217, 68);
            this.txtPenyakit.Name = "txtPenyakit";
            this.txtPenyakit.Size = new System.Drawing.Size(257, 22);
            this.txtPenyakit.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Penyakit / Masalah";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tanggal";
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(217, 12);
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = true;
            this.txtNama.Size = new System.Drawing.Size(257, 22);
            this.txtNama.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nama";
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(292, 222);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(182, 29);
            this.btnBatal.TabIndex = 64;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(292, 187);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(182, 29);
            this.btnSimpan.TabIndex = 63;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // posyanduDataSet
            // 
            this.posyanduDataSet.DataSetName = "posyanduDataSet";
            this.posyanduDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmCatatanPenyakitAnak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 263);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtTanggal);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTindakan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPenyakit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCatatanPenyakitAnak";
            this.Text = "Catatan Penyakit Anak";
            this.Load += new System.EventHandler(this.frmCatatanPenyakitAnak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posyanduDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catatanPenyakitAnakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtTanggal;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTindakan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPenyakit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private posyanduDataSet posyanduDataSet;
        private System.Windows.Forms.BindingSource catatanPenyakitAnakBindingSource;
        private posyanduDataSetTableAdapters.CatatanPenyakitAnakTableAdapter catatanPenyakitAnakTableAdapter;
    }
}