USE [posyandu]
GO
/****** Object:  Table [dbo].[Pasien]    Script Date: 02/28/2013 11:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pasien](
	[id] [nvarchar](10) NOT NULL,
	[nama_ibu] [nvarchar](50) NULL,
	[tempat_lahir_ibu] [nvarchar](50) NULL,
	[tanggal_lahir_ibu] [date] NULL,
	[agama_ibu] [nvarchar](25) NULL,
	[pendidikan_ibu] [nvarchar](50) NULL,
	[golongan_darah_ibu] [nvarchar](10) NULL,
	[pekerjaan_ibu] [nvarchar](50) NULL,
	[nama_suami] [nvarchar](50) NULL,
	[tempat_lahir_suami] [nvarchar](50) NULL,
	[tanggal_lahir_suami] [date] NULL,
	[agama_suami] [nvarchar](25) NULL,
	[pendidikan_suami] [nvarchar](50) NULL,
	[pekerjaan_suami] [nvarchar](50) NULL,
	[alamat] [nvarchar](150) NULL,
	[kecamatan] [nvarchar](50) NULL,
	[kabupaten] [nvarchar](50) NULL,
	[telepon] [nvarchar](50) NULL,
	[no_ktp_ibu] [nvarchar](50) NULL,
	[no_ktp_suami] [nvarchar](50) NULL,
	[foto] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pasien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Pasien] ([id], [nama_ibu], [tempat_lahir_ibu], [tanggal_lahir_ibu], [agama_ibu], [pendidikan_ibu], [golongan_darah_ibu], [pekerjaan_ibu], [nama_suami], [tempat_lahir_suami], [tanggal_lahir_suami], [agama_suami], [pendidikan_suami], [pekerjaan_suami], [alamat], [kecamatan], [kabupaten], [telepon], [no_ktp_ibu], [no_ktp_suami], [foto]) VALUES (N'I0001', N'Ari Hastuti2', N'Lawang', CAST(0x63000B00 AS Date), N'Islam', N'SMA', N'B', N'IRT', N'Imam Maliki', N'Wajak', CAST(0xF1080B00 AS Date), N'Islam', N'SMA', N'Swasta', N'Sumbermlaten', N'Lawang', N'Malang', N'888888', N'81892912', N'457887627392', N'')
INSERT [dbo].[Pasien] ([id], [nama_ibu], [tempat_lahir_ibu], [tanggal_lahir_ibu], [agama_ibu], [pendidikan_ibu], [golongan_darah_ibu], [pekerjaan_ibu], [nama_suami], [tempat_lahir_suami], [tanggal_lahir_suami], [agama_suami], [pendidikan_suami], [pekerjaan_suami], [alamat], [kecamatan], [kabupaten], [telepon], [no_ktp_ibu], [no_ktp_suami], [foto]) VALUES (N'I002', N'Petrik Hala', N'26 Februari 2013', CAST(0xCC360B00 AS Date), N'Kristen', N'SMA', N'A', N'IRT', N'Hobla Hala', N'Lawang', CAST(0xCC360B00 AS Date), N'Budha', N'S1', N'Swasta', N'Jl blablabla', N'Sumbersari', N'Malang', N'9999999', N'Probolinggo', N'88219323', N'609175358.jpg')
/****** Object:  Table [dbo].[Neonatus]    Script Date: 02/28/2013 11:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Neonatus](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_anak] [int] NULL,
	[tanggal] [date] NULL,
	[berat] [float] NULL,
	[tinggi] [int] NULL,
	[suhu] [int] NULL,
	[penyakit] [nvarchar](50) NULL,
	[frekuensi_nafas] [int] NULL,
	[frekuensi_denyut_jantung] [int] NULL,
	[diare] [nvarchar](50) NULL,
	[ikterus] [nvarchar](50) NULL,
	[berat_badan_rendah] [nvarchar](50) NULL,
	[status_vitamin_k] [nvarchar](50) NULL,
	[status_imunisasi] [nvarchar](50) NULL,
	[keluhan] [nvarchar](50) NULL,
	[keluhan_lain] [nvarchar](50) NULL,
	[pemeriksa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Neonatus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Neonatus] ON
INSERT [dbo].[Neonatus] ([id], [id_anak], [tanggal], [berat], [tinggi], [suhu], [penyakit], [frekuensi_nafas], [frekuensi_denyut_jantung], [diare], [ikterus], [berat_badan_rendah], [status_vitamin_k], [status_imunisasi], [keluhan], [keluhan_lain], [pemeriksa]) VALUES (1, 2, CAST(0xCD360B00 AS Date), 3.5, 30, 25, N'Biru', 32, 35, N'Negatif', N'Positif', N'Negatif', N'Sudah', N'Sudah', N'Tidak ada', N'Tidak ada', N'Adrian Mutu')
SET IDENTITY_INSERT [dbo].[Neonatus] OFF
/****** Object:  Table [dbo].[KMS]    Script Date: 02/28/2013 11:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KMS](
	[id_anak] [int] NOT NULL,
	[berat] [text] NULL,
	[bulan] [text] NULL,
 CONSTRAINT [PK_KMS] PRIMARY KEY CLUSTERED 
(
	[id_anak] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[KMS] ([id_anak], [berat], [bulan]) VALUES (1, N'3,5;0;0;0;0;0;0;0;0;0;0;0;0', N'Maret;Januari;Januari;Januari;Januari;Januari;Januari;Januari;Januari;Januari;Januari;Januari;Januari')
INSERT [dbo].[KMS] ([id_anak], [berat], [bulan]) VALUES (2, N'3,5;3,7;4,2;5,5;0;0;0;0;0;0;0;0;0', N'Maret;April;Mei;Juni;Januari;Januari;Januari;Januari;Januari;Januari;Januari;Januari;Januari')
/****** Object:  Table [dbo].[Kelahiran]    Script Date: 02/28/2013 11:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kelahiran](
	[id_kelahiran] [nvarchar](10) NULL,
	[id_anak] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kehamilan]    Script Date: 02/28/2013 11:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kehamilan](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[haid_terakhir] [date] NULL,
	[taksiran_persalinan] [date] NULL,
	[lingkar_lengan_atas] [int] NULL,
	[tinggi_badan] [int] NULL,
	[kontrasepsi_sebelum_kehamilan] [nvarchar](50) NULL,
	[jarak_kehamilan_terakhir] [int] NULL,
	[status] [tinyint] NULL,
 CONSTRAINT [PK_Kehamilan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 untuk lahir, 0 untuk belum lahir' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kehamilan', @level2type=N'COLUMN',@level2name=N'status'
GO
/****** Object:  Table [dbo].[CatatanPenyakitAnak]    Script Date: 02/28/2013 11:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatatanPenyakitAnak](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_anak] [int] NULL,
	[tanggal] [date] NULL,
	[penyakit] [nvarchar](50) NULL,
	[tindakan] [nvarchar](50) NULL,
	[keterangan] [nvarchar](50) NULL,
 CONSTRAINT [PK_CatatanPenyakitAnak] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CatatanPenyakitAnak] ON
INSERT [dbo].[CatatanPenyakitAnak] ([id], [id_anak], [tanggal], [penyakit], [tindakan], [keterangan]) VALUES (1, 1, CAST(0xCD360B00 AS Date), N'Panas', N'Pemberian Paracetamol', N'Posyandu Sumbermlaten')
INSERT [dbo].[CatatanPenyakitAnak] ([id], [id_anak], [tanggal], [penyakit], [tindakan], [keterangan]) VALUES (2, 1, CAST(0xC6360B00 AS Date), N'Diare', N'Rujuk ke RSSA Malang', N'Posyandu Sumbermlaten')
SET IDENTITY_INSERT [dbo].[CatatanPenyakitAnak] OFF
/****** Object:  Table [dbo].[CatatanKesehatanNifas]    Script Date: 02/28/2013 11:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatatanKesehatanNifas](
	[id_pasien] [nvarchar](10) NULL,
	[tanggal] [date] NULL,
	[keluhan] [nvarchar](100) NULL,
	[tekanan_darah] [nvarchar](10) NULL,
	[nadi] [int] NULL,
	[nafas] [int] NULL,
	[suhu] [int] NULL,
	[kontraksi_rahim] [nvarchar](50) NULL,
	[perdarahan] [nvarchar](50) NULL,
	[lokhia] [nvarchar](50) NULL,
	[air_besar] [nchar](1) NULL,
	[air_kecil] [nchar](1) NULL,
	[asi] [nvarchar](50) NULL,
	[tindakan] [nvarchar](100) NULL,
	[nasihat] [nvarchar](100) NULL,
	[keterangan] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CatatanKesehatan]    Script Date: 02/28/2013 11:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatatanKesehatan](
	[id_pasien] [nvarchar](10) NULL,
	[tanggal] [date] NULL,
	[keluhan] [nvarchar](100) NULL,
	[tekanan_darah] [nvarchar](10) NULL,
	[berat] [int] NULL,
	[umur_kehamilan] [int] NULL,
	[tinggi] [int] NULL,
	[letak_janin] [nvarchar](50) NULL,
	[denyut_jantung] [int] NULL,
	[hasil_pemeriksaan_lab] [nvarchar](100) NULL,
	[tindakan] [nvarchar](100) NULL,
	[nasihat] [nvarchar](100) NULL,
	[keterangan] [nvarchar](100) NULL,
	[kapan_harus_kembali] [date] NULL,
	[kaki_bengkak] [nchar](1) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Anak]    Script Date: 02/28/2013 11:10:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Anak](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_orang_tua] [nvarchar](50) NULL,
	[nama] [nvarchar](50) NULL,
	[jenis_kelamin] [nvarchar](10) NULL,
	[jenis_kelahiran] [nvarchar](25) NULL,
	[kelahiran_ke] [int] NULL,
	[berat_lahir] [float] NULL,
	[panjang_badan] [int] NULL,
	[tempat_lahir] [nvarchar](50) NULL,
	[alamat_tempat_lahir] [nvarchar](50) NULL,
	[tanggal_lahir] [date] NULL,
 CONSTRAINT [PK_Anak] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Anak] ON
INSERT [dbo].[Anak] ([id], [id_orang_tua], [nama], [jenis_kelamin], [jenis_kelahiran], [kelahiran_ke], [berat_lahir], [panjang_badan], [tempat_lahir], [alamat_tempat_lahir], [tanggal_lahir]) VALUES (1, N'I002', N'Andini', N'Laki-Laki', N'Tunggal', 2, 3500, 25, N'Rumah Bidan', N'SUmbermlaten', CAST(0xCD360B00 AS Date))
INSERT [dbo].[Anak] ([id], [id_orang_tua], [nama], [jenis_kelamin], [jenis_kelahiran], [kelahiran_ke], [berat_lahir], [panjang_badan], [tempat_lahir], [alamat_tempat_lahir], [tanggal_lahir]) VALUES (2, N'I002', N'Andong', N'Perempuan', N'Kembar 2', 3, 3500, 30, N'Rumah Bersalin', N'Sumbermlaten', CAST(0xCD360B00 AS Date))
SET IDENTITY_INSERT [dbo].[Anak] OFF
