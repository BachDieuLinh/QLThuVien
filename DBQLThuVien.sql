USE [master]
GO
/****** Object:  Database [QLThuVien]    Script Date: 12/4/2015 9:16:08 AM ******/
CREATE DATABASE [QLThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLThuVien', FILENAME = N'E:\Nam 4 ki 1\TT nhóm\QLThuVien\QLThuVien.mdf' , SIZE = 3328KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLThuVien_log', FILENAME = N'E:\Nam 4 ki 1\TT nhóm\QLThuVien\QLThuVien_log.LDF' , SIZE = 3520KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLThuVien] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLThuVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLThuVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QLThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QLThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLThuVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLThuVien', N'ON'
GO
USE [QLThuVien]
GO
/****** Object:  Table [dbo].[CHITIETMUON]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETMUON](
	[MaPhieu] [varchar](10) NOT NULL,
	[MaSach] [varchar](10) NOT NULL,
 CONSTRAINT [PK_CHITIETMUON] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[UserName] [char](30) NULL,
	[Pass] [char](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaDG] [varchar](10) NOT NULL,
	[TenDG] [nvarchar](50) NOT NULL,
	[NgheNghiep] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUMUONSACH]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUMUONSACH](
	[MaPhieu] [varchar](10) NOT NULL,
	[MaDG] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
	[NgayMuon] [datetime] NULL,
	[NgayTra] [datetime] NULL,
	[TinhTrang] [int] NULL,
 CONSTRAINT [PK_PHIEUMUONSACH] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [varchar](10) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[TheLoai] [nvarchar](50) NULL,
	[NoiDung] [nvarchar](50) NULL,
	[TacGia] [nvarchar](50) NULL,
	[NXB] [nvarchar](50) NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHITIETMUON] ([MaPhieu], [MaSach]) VALUES (N'PM002', N'MS004')
INSERT [dbo].[CHITIETMUON] ([MaPhieu], [MaSach]) VALUES (N'PM003', N'MS001')
INSERT [dbo].[CHITIETMUON] ([MaPhieu], [MaSach]) VALUES (N'PM004', N'MS005')
INSERT [dbo].[CHITIETMUON] ([MaPhieu], [MaSach]) VALUES (N'PM005', N'MS002')
INSERT [dbo].[DANGNHAP] ([UserName], [Pass]) VALUES (N'linheve@gmail.com             ', N'123456                        ')
INSERT [dbo].[DANGNHAP] ([UserName], [Pass]) VALUES (N'huyende@gmail.com             ', N'123456                        ')
INSERT [dbo].[DANGNHAP] ([UserName], [Pass]) VALUES (N'binnguyen@gmail.com           ', N'123456                        ')
INSERT [dbo].[DANGNHAP] ([UserName], [Pass]) VALUES (N'velasgooner@gmail.com         ', N'123456                        ')
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgheNghiep], [SDT], [DiaChi]) VALUES (N'DG001', N'Nguyễn Hoàng Hiếu', N'Sinh viên', N'0912345777', N'Thái Nguyên')
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgheNghiep], [SDT], [DiaChi]) VALUES (N'DG002', N'Đặng Đức Anh', N'Cảnh sát', N'0989777333', N'Sơn Tây')
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgheNghiep], [SDT], [DiaChi]) VALUES (N'DG003', N'Nguyễn Ngọc Hòa', N'Cảnh sát', N'0909222111', N'Phú Thọ')
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgheNghiep], [SDT], [DiaChi]) VALUES (N'DG004', N'Nguyễn Thị Huế', N'Bộ đội', N'0909345678', N'Thanh Hóa')
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgheNghiep], [SDT], [DiaChi]) VALUES (N'DG005', N'Lê Tiến Dũng', N'Bộ đội', N'0989777456', N'Thanh Hóa')
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgheNghiep], [SDT], [DiaChi]) VALUES (N'DG006', N'Lê Thành Trung ', N'Học viên', N'0977666333', N'Điện Biên')
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgheNghiep], [SDT], [DiaChi]) VALUES (N'DG007', N'Nguyễn Duy Quang', N'Cảnh sát', N'0978343421', N'Hà Nội')
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgheNghiep], [SDT], [DiaChi]) VALUES (N'DG008', N'Đoàn Tiến Đạt', N'Học viên', N'0922345888', N'Hải Phòng')
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgheNghiep], [SDT], [DiaChi]) VALUES (N'DG009', N'Phạm Qúy Danh', N'Cảnh sát', N'0977678900', N'Quảng Ninh')
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgheNghiep], [SDT], [DiaChi]) VALUES (N'DG010', N'Vũ Việt Đoàn', N'Học viên', N'0909123888', N'Ninh Bình')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV01', N'Nguyễn Hòa Nhật Quang', NULL, N'An Giang', N'0913211322')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV02', N'Bạch Thị Diệu Linh', NULL, N'Hòa Bình', N'0912345678')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV03', N'Trần Thị Huyền', NULL, N'Hà Tĩnh', N'0913456789')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV04', N'Trần Minh Nghiệp', NULL, N'Bắc Ninh', N'0995002003')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV05', N'Đoàn Quang Long', NULL, N'Hải Dương', N'0912345678')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV06', N'Phạm Văn Lượng', NULL, N'Ninh Bình', N'0989778889')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV07', N'Lê Viết Hoàng Anh', NULL, N'Nghệ An', N'0987654321')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV08', N'Võ Khương Lĩnh', NULL, N'Sài Gòn', N'0979345678')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV09', N'Trần Văn Anh Tuấn', NULL, N'Đà Nẵng', N'0989333222')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV10', N'Nguyễn Ngọc Hải', NULL, N'Quảng Trị', N'0945827771')
INSERT [dbo].[PHIEUMUONSACH] ([MaPhieu], [MaDG], [MaNV], [NgayMuon], [NgayTra], [TinhTrang]) VALUES (N'PM001', N'DG002', N'NV08', CAST(N'2015-11-22 00:00:00.000' AS DateTime), CAST(N'2015-12-09 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PHIEUMUONSACH] ([MaPhieu], [MaDG], [MaNV], [NgayMuon], [NgayTra], [TinhTrang]) VALUES (N'PM002', N'DG010', N'NV07', CAST(N'2015-11-15 00:00:00.000' AS DateTime), CAST(N'2016-04-01 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PHIEUMUONSACH] ([MaPhieu], [MaDG], [MaNV], [NgayMuon], [NgayTra], [TinhTrang]) VALUES (N'PM003', N'DG008', N'NV01', CAST(N'2015-10-10 00:00:00.000' AS DateTime), CAST(N'2015-12-24 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PHIEUMUONSACH] ([MaPhieu], [MaDG], [MaNV], [NgayMuon], [NgayTra], [TinhTrang]) VALUES (N'PM004', N'DG001', N'NV05', CAST(N'2015-10-29 00:00:00.000' AS DateTime), CAST(N'2015-12-20 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PHIEUMUONSACH] ([MaPhieu], [MaDG], [MaNV], [NgayMuon], [NgayTra], [TinhTrang]) VALUES (N'PM005', N'DG003', N'NV04', CAST(N'2015-10-30 00:00:00.000' AS DateTime), CAST(N'2016-01-18 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PHIEUMUONSACH] ([MaPhieu], [MaDG], [MaNV], [NgayMuon], [NgayTra], [TinhTrang]) VALUES (N'PM006', N'DG002', N'NV03', CAST(N'2015-12-03 00:01:27.000' AS DateTime), CAST(N'2015-12-24 00:01:13.000' AS DateTime), 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [NoiDung], [TacGia], [NXB]) VALUES (N'MS001', N'Lập trình C', N'tài liệu tự học', N'hay hay hay', N'ABC', N'Nhà xuất bản giáo dục')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [NoiDung], [TacGia], [NXB]) VALUES (N'MS002', N'Lập trình C#', N'Tài liệu tự học', N'không có gì', N'không biết', N'NXB Giáo dục')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [NoiDung], [TacGia], [NXB]) VALUES (N'MS003', N'Mật mã Davici', N'Truyện ', N'Rất rất hay', N'Dainly Brown', N'NXB nước ngoài')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [NoiDung], [TacGia], [NXB]) VALUES (N'MS004', N'Tôi thấy hoa vàng trên cỏ xanh', N'Truyện ngắn', N'đang hót đó', N'Nguyễn Nhật Ánh', N'NXB Hà Nội')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [NoiDung], [TacGia], [NXB]) VALUES (N'MS005', N'Rồi chúng ta  sẽ ổn thôi', N'tiểu thuyết', N'đáng xem', N'Gào', N'NXB Sài gòn')
ALTER TABLE [dbo].[CHITIETMUON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETMUON_PHIEUMUONSACH] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PHIEUMUONSACH] ([MaPhieu])
GO
ALTER TABLE [dbo].[CHITIETMUON] CHECK CONSTRAINT [FK_CHITIETMUON_PHIEUMUONSACH]
GO
ALTER TABLE [dbo].[CHITIETMUON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETMUON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETMUON] CHECK CONSTRAINT [FK_CHITIETMUON_SACH]
GO
ALTER TABLE [dbo].[PHIEUMUONSACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUONSACH_DOCGIA] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DOCGIA] ([MaDG])
GO
ALTER TABLE [dbo].[PHIEUMUONSACH] CHECK CONSTRAINT [FK_PHIEUMUONSACH_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUONSACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUONSACH_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUMUONSACH] CHECK CONSTRAINT [FK_PHIEUMUONSACH_NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[ADD_Sach]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[ADD_Sach]  @TenSach nvarchar(50), @TheLoai nvarchar(50), @NoiDung nvarchar(50),@TacGia nvarchar(50),@NXB nvarchar(50)
as
begin
	declare @MaSach varchar(10)
	declare @SoTT int
	declare contro CURSOR FORWARD_ONLY FOR SELECT @MaSach from SACH
	set @SoTT = 0
	open contro
	FETCH NEXT FROM contro into @MaSach
	while(@@FETCH_STATUS =0)
	BEGIN
		If(CAST(right(@MaSach,8) as int)-@SoTT) = 1
			begin
				set @SoTT = CAST(right(@MaSach,8) as int)
			end 
		else BREAK 
		FETCH NEXT FROM contro into @MaSach
	end
	declare @CDai int
	declare @i int
	set @MaSach = CAST((@soTT + 1) as varchar(8) )
	set @CDai = LEN(@MaSach)
	set @i = 1
	while ( @i<=8-@CDai)
	begin
		set @MaSach = '0'+@MaSach
		set @i = @i +1
	end
set @MaSach = 'MS' +@MaSach
insert into SACH values(@MaSach ,@TenSach, @TheLoai, @NoiDung,@TacGia,@NXB)
select @MaSach
close contro
DEALLOCATE contro

end 

GO
/****** Object:  StoredProcedure [dbo].[add1_Sach]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create proc [dbo].[add1_Sach]  @MaSach varchar(10),@TenSach nvarchar(50), @TheLoai nvarchar(50), @NoiDung nvarchar(50),@TacGia nvarchar(50),@NXB nvarchar(50)
as
begin
	insert into SACH values(@MaSach ,@TenSach, @TheLoai, @NoiDung,@TacGia,@NXB)
end

GO
/****** Object:  StoredProcedure [dbo].[Del_Sach]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[Del_Sach] @MaSach varchar(10)
as
begin 
	delete from SACH where MaSach = @MaSach
end

GO
/****** Object:  StoredProcedure [dbo].[Ins_CTM]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create proc [dbo].[Ins_CTM] @MaPhieu  varchar(10), @MaSach varchar(10)
as
begin
	insert into CHITIETMUON values(@MaPhieu,@MaSach)
end

GO
/****** Object:  StoredProcedure [dbo].[Ins_PM]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create proc [dbo].[Ins_PM] @MaPhieu  varchar(10), @MaDG varchar(10), @MaNV varchar(10), @NgayMuon datetime, @NgayTra datetime,@TinhTrang int
as
begin
	declare @TT int
	set @TT = 1;
	insert into PHIEUMUONSACH values(@MaPhieu,@MaDG,@MaNV,@NgayMuon,@NgayTra,@TinhTrang)
end

GO
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[login] @Username char(30), @Pass char(30)
as
begin
	select * from DANGNHAP where (Username = @Username and Pass = @Pass)
end


GO
/****** Object:  StoredProcedure [dbo].[Sea_MaSach]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sea_MaSach] @MaSach varchar(10)
as
begin
	select * from SACH where MaSach like '%'+@MaSach+'%'
end


GO
/****** Object:  StoredProcedure [dbo].[Sea_NoiDung]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sea_NoiDung] @NoiDung nvarchar(50)
as
begin
	select * from SACH where NoiDung like '%'+@NoiDung+'%'
end


GO
/****** Object:  StoredProcedure [dbo].[Sea_NXB]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sea_NXB] @NXB nvarchar(50)
as
begin
	select * from SACH where NXB like '%'+@NXB+'%'
end


GO
/****** Object:  StoredProcedure [dbo].[Sea_TacGia]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sea_TacGia] @TacGia nvarchar(50)
as
begin
	select * from SACH where TacGia like '%'+@TacGia+'%'
end


GO
/****** Object:  StoredProcedure [dbo].[Sea_TenSach]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sea_TenSach] @TenSach nvarchar(50)
as
begin
	select * from SACH where TenSach like '%'+@TenSach+'%'
end


GO
/****** Object:  StoredProcedure [dbo].[Sea_TheLoai]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sea_TheLoai] @TheLoai nvarchar(50)
as
begin
	select * from SACH where TheLoai like '%'+@TheLoai+'%'
end


GO
/****** Object:  StoredProcedure [dbo].[Sho_Sach]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create proc [dbo].[Sho_Sach]
as
begin
	select *from SACH
end

GO
/****** Object:  StoredProcedure [dbo].[Upd_Sach]    Script Date: 12/4/2015 9:16:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[Upd_Sach] @MaSach varchar(10),@TenSach nvarchar(50), @TheLoai nvarchar(50), @NoiDung nvarchar(50),@TacGia nvarchar(50),@NXB nvarchar(50)
as
begin
	update SACH
	set TenSach =  @TenSach, TheLoai  = @TheLoai, NoiDung = @NoiDung, TacGia = @TacGia ,NXB = @NXB
	where MaSach = @MaSach
end


GO
USE [master]
GO
ALTER DATABASE [QLThuVien] SET  READ_WRITE 
GO
