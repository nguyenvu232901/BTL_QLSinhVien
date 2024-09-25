create database btl_hsk
on
(
	name = btl_hsk,
	filename = 'C:\SQL\BTL\btl_hsk.mdf'
)
 
create table tblKhoa (
	sMaKhoa Varchar(20) PRIMARY KEY NOT NULL,
	sTenKhoa NVarchar(30) NOT NULL,
	sSDT Varchar(10),
	sDiaChiKhoa NVarchar(30)
)

create table tblLop (
	sMaLop Varchar(20) primary key not null,
	sTenLop Nvarchar(30) not null,
	sMaKhoa Varchar(20),

)
ALTER TABLE tblLop
ADD CONSTRAINT FK_lop_makhoa FOREIGN KEY(sMaKhoa)
REFERENCES tblKhoa(sMaKhoa)

select * from tblKhoa
alter table tblKhoa add TruongKhoa Nvarchar(30)

create table tblSinhVien (
	sMaSV Varchar(20) primary key not null,
	sTenSV Nvarchar(40) not null,
	dNgaySinh date,
	sMaLop Varchar(20),
	sQueQuan Nvarchar(50),
	sGT NChar(30),

)


ALTER TABLE tblSinhVien
ADD CONSTRAINT FK_sv_malop FOREIGN KEY(sMaLop)
REFERENCES tblLop(sMaLop)

CREATE TABLE tblMonHoc (
	sMaMH Varchar(20) PRIMARY KEY NOT NULL,
	sTenMH NVarchar(20) NOT NULL,
	iSoTC int
	)

CREATE TABLE tblCTDiem (
	
	sMaSV Varchar(20) NOT NULL,
	sMaMH Varchar(20) NOT NULL,
	dNgayHoc date NOT null,
	fDiemCC Float,
	fDiemBK Float,
	fDiemHK Float,
	fDiemTK float DEFAULT 0,
	
)

ALTER TABLE tblCTDiem
ADD CONSTRAINT FK_diem_maSV FOREIGN KEY(sMaSV)
REFERENCES tblSinhVien(sMaSV);

ALTER TABLE tblCTDiem
ADD CONSTRAINT FK_diemCT_mamh FOREIGN KEY(sMaMH)
REFERENCES tblMonHoc(sMaMH);

CREATE TABLE username
(	
	sTenTK varchar(20) PRIMARY KEY,
	sMK varchar(20),
	sQuyen nvarchar(50)
)

drop table tblCTDiem
drop table tblKhoa
drop table tblLop
drop table tblMonHoc
drop table tblSinhVien

INSERT INTO username
VALUES ('dv' , '1234' , 'Admin'),
('gv' , '123' , 'Giảng viên'),
('sv' , '12' , 'Sinh viên')



-- Chèn dữ liệu vào bảng tblKhoa
INSERT INTO tblKhoa 
VALUES  ('HOU01', N'Công nghệ thông tin', '0243664934', N'96 Định Công'),
		('HOU02', N'Kinh tế', '0246288508', N'193 Vĩnh Hưng'),
		('HOU03', N'Tiếng Anh', '0243868589', N'301 Nguyễn Trãi'),
		('HOU04', N'Tài chính ngân hàng', '0987927006',N'422 Vĩnh Hưng'),
		('HOU05', N'Luật','0243635341',N'193 Vĩnh Hưng');

-- Chèn dữ liệu vào bảng tblLop
INSERT INTO tblLop
VALUES  ('KT12', N'19A3', 'HOU02'),
		('KT13', N'20A1', 'HOU02'),
		('TA01', N'18A2', 'HOU03'),
		('TA02', N'18A5', 'HOU03'),
		('CNTT21', N'21A2', 'HOU01'),
		('CNTT22', N'21A1', 'HOU01'),
		('L1', N'22A4', 'HOU05'),
		('L2', N'20A3', 'HOU05'),
		('TCNH1', N'14A6', 'HOU04'),
		('TCNH2', N'15A2', 'HOU04');

-- Chèn dữ liệu vào bảng tblSinhVien
INSERT INTO tblSinhVien(sMaSV,sTenSV,sGT,dNgaySinh,sMaLop,sQueQuan)
VALUES  ('21A100', N'Đinh Ngọc Anh', N'Nữ', '20031118', 'CNTT21', N'Ha Nội'),
		('21A107', N'Nguyễn Tất Đạt', N'Nam', '20030208', 'CNTT21', N'Ninh Bình'),
		('21A110', N'Vũ Quang Được', N'Nam', '20031219', 'KT12', N'Nam Định'),
		('21A113', N'Ông Văn Sinh', N'Nam', '20030116', 'CNTT22', N'Nam Định'),
		('21A114', N'Ngọ Văn Sơn', N'Nam','20030627', 'CNTT21', N'Phú Thọ'),
		('21A117', N'Bùi Anh Tuấn', N'Nam',  '20031002', 'TCNH1', N'Phú Thọ'),
		('21A120', N'Hoàng Thị Hồng Nhung', N'Nữ', '20030905', 'L2', N'Hà Nam'),
		('21A123', N'Nguyễn Văn Việt', N'Nam',  '20031013', 'L2', N'Hà Nam'),
		('21A125', N'Phạm Quang Thắng', N'Nam',  '20031019', 'TCNH1', N'Hưng Yên'),
		('21A130', N'Nguyễn Tuấn Vũ', N'Nam', '20030620', 'TA01', N'Hà Nam');


INSERT INTO tblMonHoc
VALUES  ('MH1', N'Cơ sở lập trình', 4),
		('MH2', N'Tiếng Anh 3', 3),
		('MH3', N'Pháp luật đại cương', 2),
		('MH4', N'Hệ quản trị CSDL', 4),
		('MH5', N'Xác suất thống kê', 3),
		('MH6', N'Điện tử số', 3),
		('MH7', N'Tư tưởng HCM', 2);
 
INSERT INTO tblCTDiem(sMaSV,sMaMH,dNgayHoc,fDiemCC,fDiemBK,fDiemHK)
VALUES 
		('21A100', 'MH1','10/10/2020', 10, 10, 9.8),
		('21A107', 'MH2' ,'10/10/2020', 10, 9, 8),
		('21A110', 'MH5','10/10/2020', 10,9, 8.7),
		('21A113', 'MH4','10/10/2020', 10,9, 9),
		('21A114', 'MH6','10/10/2020', 10, 9, 9.3),
		('21A123', 'MH1','10/10/2020', 10, 9, 8.5),
		('21A125', 'MH5' ,'10/10/2020', 10, 19, 9),
		('21A130', 'MH2','10/10/2020', 10, 9, 8.6);

select * from tblKhoa
select * from tblLop
select * from tblMonHoc
select * from tblCTDiem



create view timtenSV
as
select tblSinhVien.sMaSV,sTenSV, sGT, dNgaySinh, count(sTenSV) as[soluong]
from tblSinhVien 
group by tblSinhVien.sMaSV,sGT, dNgaySinh
select * from timtenSV

create or alter proc timkiemtheoten
	@hoten Nvarchar(40)
as
select * from tblSinhVien where sTenSV like @hoten
exec timkiemtheoten N'%Nguyễn%'


create view bangtuoi
as
select tblSinhVien.sMaSV, sTenSV, dNgaySinh, tblSinhVien.sMaLop, tblSinhVien.sGT,
DATEDIFF(yyyy, dNgaySinh, getdate()) [Tuoi]
	from tblSinhVien

	select * from bangtuoi

create or alter proc SLSV_theoTuoi
@tuoi int
as
begin
	select Tuoi, count(@tuoi) [SLSV] from bangtuoi
	where Tuoi = @tuoi
	group by Tuoi
	
end

exec SLSV_theoTuoi 20

create or alter proc ChiTietDiemSV
@masv varchar(20)
as
select tblCTDiem.sMaMH, sTenMH, iSoTC, dNgayHoc, fDiemTK = fDiemCC*0.1 + fDiemBK*0.2 + fDiemHK*0.7
from tblSinhVien, tblCTDiem, tblMonHoc
where tblSinhVien.sMaSV = tblCTDiem.sMaSV and tblCTDiem.sMaSV = @masv
and tblCTDiem.sMaMH = tblMonHoc.sMaMH

exec ChiTietDiemSV '21A100'


select * from tblCTDiem
select * from tblLop
select * from tblKhoa
select tblSinhVien.sMaSV, sTenSV,tblMonHoc.sMaMH, sTenMH, iSoTC from tblMonHoc, tblCTDiem, tblSinhVien where tblCTDiem.sMaMH=tblMonHoc.sMaMH and tblCTDiem.sMaMH=tblSinhVien.sMaSV
create or alter view v_SV
as
select sTenLop [Tên lớp], tblSinhVien.sMaSV [Mã SV], sTenSV [Tên SV], dNgaySinh [Ngày sinh], sGT [Giới tính]
from tblSinhVien, tblLop
where tblSinhVien.sMaLop = tblLop.sMaLop

create view HDhocphi
as
select tblCTDiem.sMaSV, sTenSV, tblCTDiem.sMaMH, sTenMH, iSoTC from tblCTDiem, tblMonHoc, tblSinhVien
where tblSinhVien.sMaSV=tblCTDiem.sMaSV and tblCTDiem.sMaMH=tblMonHoc.sMaMH

create or alter proc sp_DSSVtheolop
@tenlop nvarchar(50)
as
select SV.sMaSV, sTenSV, SV.sMaLop,dNgaySinh, sQueQuan, sGT from tblLop inner join tblSinhVien SV on tblLop.sMaLop = SV.sMaLop 
where sTenLop = @tenlop
exec sp_DSSVtheolop '21A2'

CREATE  or alter  PROCEDURE [dbo].[sp_bangDiemTheoMon]
    @sMonHoc NVARCHAR(50)
AS
BEGIN
    SELECT tblSinhVien.sMaSV, sTenSV, dNgayHoc, fDiemCC, fDiemGK, fDiemCK, (fDiemCC * 0.1 + fDiemGK * 0.2 + fDiemCK * 0.7) AS [DiemTK]
    FROM tblSinhVien
        INNER JOIN tblCTDiem ON tblSinhVien.sMaSV = tblCTDiem.sMaSV
        INNER JOIN tblMonHoc ON tblCTDiem.sMaMH = tblMonHoc.sMaMH
    WHERE sTenMH = @sMonHoc
END
GO

CREATE  or alter  PROCEDURE [dbo].[sp_locbangdiem]
    @fDiemA INT,
    @fDiemB INT
AS
BEGIN
    SELECT tblSinhVien.sMaSV, sTenSV, dNgayHoc, fDiemCC, fDiemGK, fDiemCK, (fDiemCC * 0.1 + fDiemGK * 0.2 + fDiemCK * 0.7) AS [DiemTK]
    FROM tblSinhVien
        INNER JOIN tblCTDiem ON tblSinhVien.sMaSV = tblCTDiem.sMaSV

    WHERE (fDiemCC * 0.1 + fDiemGK * 0.2 + fDiemCK * 0.7) BETWEEN @fDiemA AND @fDiemB 
END
GO

create or alter view vvDiem
as
select sMaSV as [Mã SV], sMaMH[Mã Môn], dNgayHoc[Ngày học], fDiemCC[Điểm chuyên cần],
fDiemGK[Điểm giữa kì], fDiemCK[Điểm cuối kì], (fDiemCC * 0.1 + fDiemGK * 0.2 + fDiemCK * 0.7)[Điểm Tổng kết]
from tblCtDiem
select * from tblCTDiem

create or alter proc pcKetQuaHocTap
@sMaSV nvarchar(30)
as
begin
			select tblMonHoc.sTenMH, iSoTC,dNgayHoc, fDiemCC, fDiemGK, fDiemCK, (fDiemCC * 0.1 + fDiemGK * 0.2 + fDiemCK * 0.7)[fDiemTK] 
			from tblMonHoc
			inner join tblCTDiem on tblMonHoc.sMaMH = tblCTDiem.sMaMH
			where @sMaSV = tblCTDiem.sMaSV	
end

pcKetQuaHocTap '21A100'
end

CREATE or alter proc pcThongTinKQHT
@sMaSV nvarchar(30)
as
begin
	select sTenSV, dNgaySinh, sGT, sTenLop, sTenKhoa  from tblSinhVien
	inner join tblLop on tblSinhVien.sMaLop = tblLop.sMaLop
	inner join tblKhoa on tblLop.sMaKhoa = tblKhoa.sMaKhoa
	where sMaSV = @sMaSV
end
pcThongTinKQHT '21A100'

CREATE OR ALTER PROC pcDangKi
@sTenTK nvarchar(30),
@sMK nvarchar(20)
as
begin 
	insert into username
	values(@sTenTK , @sMK , N'Sinh Viên')
end

CREATE OR ALTER PROC pcDangNhap
@sTenTK nvarchar(30),
@sMK nvarchar(30)
as
begin
	select *from username where sTenTK = @sTenTK
	COLLate SQL_Latin1_General_CP1_CS_AS
	and sMK = @sMK
	COLLate SQL_Latin1_General_CP1_CS_AS
end

create proc pcDSSVLop
@sTenLop Nvarchar(30)
as
