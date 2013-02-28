namespace Posyandu
{
    partial class frmMAnak
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
            this.txtIDPasien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKelahiranKe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBeratLahir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPanjangBadan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlamatTempatLahir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.txtJenisKelamin = new System.Windows.Forms.ComboBox();
            this.txtJenisKelahiran = new System.Windows.Forms.ComboBox();
            this.txtTempatLahir = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.posyanduDataSet = new Posyandu.posyanduDataSet();
            this.anakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anakTableAdapter = new Posyandu.posyanduDataSetTableAdapters.AnakTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.posyanduDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDPasien
            // 
            this.txtIDPasien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPasien.Location = new System.Drawing.Point(157, 262);
            this.txtIDPasien.Name = "txtIDPasien";
            this.txtIDPasien.ReadOnly = true;
            this.txtIDPasien.Size = new System.Drawing.Size(227, 22);
            this.txtIDPasien.TabIndex = 2;
            this.txtIDPasien.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anak Dari";
            this.label1.Visible = false;
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(157, 12);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(227, 22);
            this.txtNama.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jenis Kelahiran";
            // 
            // txtKelahiranKe
            // 
            this.txtKelahiranKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKelahiranKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelahiranKe.Location = new System.Drawing.Point(157, 122);
            this.txtKelahiranKe.Name = "txtKelahiranKe";
            this.txtKelahiranKe.Size = new System.Drawing.Size(227, 22);
            this.txtKelahiranKe.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kelahiran Ke";
            // 
            // txtBeratLahir
            // 
            this.txtBeratLahir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBeratLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeratLahir.Location = new System.Drawing.Point(157, 150);
            this.txtBeratLahir.Name = "txtBeratLahir";
            this.txtBeratLahir.Size = new System.Drawing.Size(227, 22);
            this.txtBeratLahir.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Berat Lahir";
            // 
            // txtPanjangBadan
            // 
            this.txtPanjangBadan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPanjangBadan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanjangBadan.Location = new System.Drawing.Point(157, 178);
            this.txtPanjangBadan.Name = "txtPanjangBadan";
            this.txtPanjangBadan.Size = new System.Drawing.Size(227, 22);
            this.txtPanjangBadan.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Panjang Badan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tempat Lahir";
            // 
            // txtAlamatTempatLahir
            // 
            this.txtAlamatTempatLahir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamatTempatLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamatTempatLahir.Location = new System.Drawing.Point(157, 234);
            this.txtAlamatTempatLahir.Name = "txtAlamatTempatLahir";
            this.txtAlamatTempatLahir.Size = new System.Drawing.Size(227, 22);
            this.txtAlamatTempatLahir.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Alamat Tempat Lahir";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tanggal Lahir";
            // 
            // txtTanggalLahir
            // 
            this.txtTanggalLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTanggalLahir.Location = new System.Drawing.Point(157, 40);
            this.txtTanggalLahir.Name = "txtTanggalLahir";
            this.txtTanggalLahir.Size = new System.Drawing.Size(227, 22);
            this.txtTanggalLahir.TabIndex = 1;
            // 
            // txtJenisKelamin
            // 
            this.txtJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtJenisKelamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJenisKelamin.FormattingEnabled = true;
            this.txtJenisKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.txtJenisKelamin.Location = new System.Drawing.Point(157, 67);
            this.txtJenisKelamin.Name = "txtJenisKelamin";
            this.txtJenisKelamin.Size = new System.Drawing.Size(227, 24);
            this.txtJenisKelamin.TabIndex = 2;
            // 
            // txtJenisKelahiran
            // 
            this.txtJenisKelahiran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJenisKelahiran.FormattingEnabled = true;
            this.txtJenisKelahiran.Items.AddRange(new object[] {
            "Tunggal",
            "Kembar 2",
            "Kembar 3"});
            this.txtJenisKelahiran.Location = new System.Drawing.Point(157, 96);
            this.txtJenisKelahiran.Name = "txtJenisKelahiran";
            this.txtJenisKelahiran.Size = new System.Drawing.Size(227, 24);
            this.txtJenisKelahiran.TabIndex = 3;
            this.txtJenisKelahiran.Text = "Tunggal";
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
            this.txtTempatLahir.Location = new System.Drawing.Point(157, 205);
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(227, 24);
            this.txtTempatLahir.TabIndex = 7;
            this.txtTempatLahir.Text = "Rumah Bidan";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(296, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(296, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // posyanduDataSet
            // 
            this.posyanduDataSet.DataSetName = "posyanduDataSet";
            this.posyanduDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmMAnak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.txtIDPasien);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMAnak";
            this.Text = "Anak Baru";
            this.Load += new System.EventHandler(this.frmMAnak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posyanduDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDPasien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKelahiranKe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBeratLahir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPanjangBadan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAlamatTempatLahir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtTanggalLahir;
        private System.Windows.Forms.ComboBox txtJenisKelamin;
        private System.Windows.Forms.ComboBox txtJenisKelahiran;
        private System.Windows.Forms.ComboBox txtTempatLahir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private posyanduDataSet posyanduDataSet;
        private System.Windows.Forms.BindingSource anakBindingSource;
        private posyanduDataSetTableAdapters.AnakTableAdapter anakTableAdapter;
    }
}