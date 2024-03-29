CREATE DATABASE QLNHASACH
GO
USE QLNHASACH
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/06/2018 9:00:24 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON;
set dateformat dmy;
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 11/06/2018 9:00:24 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [nvarchar](50) NOT NULL,
	[MaSach] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[TongTien] [int] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/06/2018 9:00:24 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NULL,
	[TenKH] [nvarchar](50) NULL,
	[Ngaylap] [date] NULL,
	[TongTien] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/06/2018 9:00:24 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKh] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AI NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[NoDau] [nvarchar](50) NULL DEFAULT ((1)),
	[PhatSinh] [nvarchar](50) NULL DEFAULT ((1)),
	[TongNo] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/06/2018 9:00:24 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Email] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuBan]    Script Date: 11/06/2018 9:00:24 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuBan](
	[MaPhieuBan] [nvarchar](50) NOT NULL,
	[MaSach] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_PhieuBan] PRIMARY KEY CLUSTERED 
(
	[MaPhieuBan] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/06/2018 9:00:24 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [nvarchar](50) NOT NULL,
	[TongTien] [int] NOT NULL DEFAULT ((0)),
	[NgayNhap] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuThu]    Script Date: 11/06/2018 9:00:24 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThu](
	[MaPhieuThu] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[NgayThu] [date] NOT NULL,
	[SoTienThu] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuyDinh]    Script Date: 11/06/2018 9:00:24 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinh](
	[MaQuyDinh] [nvarchar](50) NOT NULL,
	[NhapToiThieu] [nvarchar](50) NOT NULL,
	[TonNhapToiThieu] [nvarchar](50) NOT NULL,
	[KHNoToiThieu] [int] NOT NULL,
	[TonBanToiThieu] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQuyDinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sach]    Script Date: 11/06/2018 9:00:24 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [nvarchar](50) NOT NULL,
	[TenSach] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AI NOT NULL,
	[TheLoai] [nvarchar](50) NOT NULL,
	[TacGia] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AI NOT NULL,
	[DonGia] [int] NOT NULL,
	[TonDau] [nvarchar](50) NULL DEFAULT ((0)),
	[TongNhap] [nvarchar](50) NULL DEFAULT ((0)),
	[TongBan] [nvarchar](50) NULL DEFAULT ((0)),
	[PhatSinh] [nvarchar](50) NULL DEFAULT ((0)),
	[TonCuoi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Account] ([UserName], [PassWord]) VALUES (N'admin', N'admin')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [TongTien]) VALUES (N'PN004', N'S001', 200, 10000, 2000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [TongTien]) VALUES (N'PN004', N'S005', 200, 16000, 3200000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [TongTien]) VALUES (N'PN004', N'S006', 150, 20000, 3000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [TongTien]) VALUES (N'PN005', N'S002', 200, 15000, 3000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [TongTien]) VALUES (N'PN005', N'S006', 300, 15000, 4500000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSach], [SoLuong], [DonGia], [TongTien]) VALUES (N'PN007', N'S004', 250, 25000, 6250000)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [TenKH], [Ngaylap], [TongTien]) VALUES (N'HD001', N'KH006', N'Đông Nhi', '10/08/2019', 4500000)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [TenKH], [Ngaylap], [TongTien]) VALUES (N'HD005', N'KH004', N'Nguyễn Bảo Trâm','07/06/2019', 110000)
INSERT [dbo].[KhachHang] ([MaKh], [HoTen], [SDT], [DiaChi], [Email], [NoDau], [PhatSinh], [TongNo]) VALUES (N'KH001', N'Nguyễn Ngọc Phương Thảo', N'1653053522', N'TP.HCM', N'phuongthao@gmail.com', N'179000', N'100000', N'79000')
INSERT [dbo].[KhachHang] ([MaKh], [HoTen], [SDT], [DiaChi], [Email], [NoDau], [PhatSinh], [TongNo]) VALUES (N'KH002', N'Huỳnh Ngọc Tiên', N'1253053555', N'Tiền Giang', N'ngoctien@gmail.com', N'85000', N'0', N'85000')
INSERT [dbo].[KhachHang] ([MaKh], [HoTen], [SDT], [DiaChi], [Email], [NoDau], [PhatSinh], [TongNo]) VALUES (N'KH004', N'Nguyễn Bảo Trâm', N'1693053555', N'Thái Bình', N'baotram@gmail.com', N'535000', N'20000', N'515000')
INSERT [dbo].[KhachHang] ([MaKh], [HoTen], [SDT], [DiaChi], [Email], [NoDau], [PhatSinh], [TongNo]) VALUES (N'KH006', N'Đông Nhi', N'997567894', N'TP.HCM', N'dongnhi@gmail.com', N'230000', N'150000', N'80000')
INSERT [dbo].[KhachHang] ([MaKh], [HoTen], [SDT], [DiaChi], [Email], [NoDau], [PhatSinh], [TongNo]) VALUES (N'KH007', N'Huỳnh Trọng Nghĩa', N'1153053555', N'TP.HCM', N'trongnghia@gmail.com', N'410000', N'190000', N'220000')
INSERT [dbo].[NhanVien] ([Email], [HoTen], [DiaChi], [SDT], [PassWord]) VALUES (N'maitrang@gmail.com', N'Võ Mai Trang', N'Bến Tre', N'1253053555', N'222')
INSERT [dbo].[NhanVien] ([Email], [HoTen], [DiaChi], [SDT], [PassWord]) VALUES (N'phuchau@gmail.com', N'Đỗ Phúc Hậu ', N'TP.HCM', N'1777788679', N'444')
INSERT [dbo].[NhanVien] ([Email], [HoTen], [DiaChi], [SDT], [PassWord]) VALUES (N'phuongdung@gmail.com', N'Bùi Phương Dung', N'TP.HCM', N'1653053555', N'111')
INSERT [dbo].[NhanVien] ([Email], [HoTen], [DiaChi], [SDT], [PassWord]) VALUES (N'phuongnguyen@gmail.com', N'Trần Phương Nguyên', N'Tiền Giang', N'1225655668', N'333')
INSERT [dbo].[PhieuBan] ([MaPhieuBan], [MaSach], [SoLuong]) VALUES (N'HD001', N'S006', 150)
INSERT [dbo].[PhieuBan] ([MaPhieuBan], [MaSach], [SoLuong]) VALUES (N'HD005', N'S004', 5)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [TongTien], [NgayNhap]) VALUES (N'PN004', 8200000,'02/06/2018')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [TongTien], [NgayNhap]) VALUES (N'PN005', 7500000,'04/06/2018')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [TongTien], [NgayNhap]) VALUES (N'PN007', 6250000,'05/06/2018')
INSERT [dbo].[PhieuThu] ([MaPhieuThu], [MaKH], [NgayThu], [SoTienThu]) VALUES (N'PT001', N'KH004', '06/08/2018', 20000)
INSERT [dbo].[PhieuThu] ([MaPhieuThu], [MaKH], [NgayThu], [SoTienThu]) VALUES (N'PT002', N'KH007', '06/08/2018', 600000)
INSERT [dbo].[PhieuThu] ([MaPhieuThu], [MaKH], [NgayThu], [SoTienThu]) VALUES (N'PT003', N'KH002', '06/08/2018', 50000)
INSERT [dbo].[PhieuThu] ([MaPhieuThu], [MaKH], [NgayThu], [SoTienThu]) VALUES (N'PT004', N'KH001', '10/06/2018', 100000)
INSERT [dbo].[PhieuThu] ([MaPhieuThu], [MaKH], [NgayThu], [SoTienThu]) VALUES (N'PT005', N'KH006', '10/08/2018', 150000)
INSERT [dbo].[QuyDinh] ([MaQuyDinh], [NhapToiThieu], [TonNhapToiThieu], [KHNoToiThieu], [TonBanToiThieu]) VALUES (N'1', N'150', N'300', 300000, N'20')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia], [TonDau], [TongNhap], [TongBan], [PhatSinh], [TonCuoi]) VALUES (N'S001', N'Hậu duệ mặt trời', N'Tình cảm', N'Song Joong Ki', 25000, N'0', N'200', N'0', N'200', 200)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia], [TonDau], [TongNhap], [TongBan], [PhatSinh], [TonCuoi]) VALUES (N'S002', N'Lập trình cơ bản', N'Tin học', N'Trần Hữu Quốc Thư', 15000, N'0', N'200', N'0', N'200', 200)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia], [TonDau], [TongNhap], [TongBan], [PhatSinh], [TonCuoi]) VALUES (N'S003', N'Ngôi nhà bí ẩn', N'Kinh Dị', N'Lưu Văn Tuyết', 13000, N'0', N'0', N'0', N'0', 0)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia], [TonDau], [TongNhap], [TongBan], [PhatSinh], [TonCuoi]) VALUES (N'S004', N'Hoa Du Ký', N'Tình cảm', N'Hoa Vô Tuyết', 22000, N'0', N'250', N'5', N'245', 245)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia], [TonDau], [TongNhap], [TongBan], [PhatSinh], [TonCuoi]) VALUES (N'S005', N'Running Man', N'Hài hước', N'Yoo Jae Suk', 30000, N'0', N'200', N'0', N'200', 200)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [TacGia], [DonGia], [TonDau], [TongNhap], [TongBan], [PhatSinh], [TonCuoi]) VALUES (N'S006', N'Tin học cơ bản', N'Tin học', N'Lê Thị Đào', 30000, N'0', N'450', N'150', N'300', 300)
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_Sach]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKh])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[PhieuBan]  WITH NOCHECK ADD  CONSTRAINT [FK_PhieuBan_HoaDon] FOREIGN KEY([MaPhieuBan])
REFERENCES [dbo].[HoaDon] ([MaHD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuBan] CHECK CONSTRAINT [FK_PhieuBan_HoaDon]
GO
ALTER TABLE [dbo].[PhieuBan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuBan_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuBan] CHECK CONSTRAINT [FK_PhieuBan_Sach]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThu_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKh])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [FK_PhieuThu_KhachHang]
GO

	select * from QuyDinh;
		select * from Nhanvien;
		select * from sach;