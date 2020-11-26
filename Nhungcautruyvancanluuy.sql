select p.MaPhieuNhap, ISNULL(c.TongTien,0) as TongTien ,NgayNhap from  PhieuNhap p right join  ChiTietPhieuNhap c 
on  p.MaPhieuNhap=c.MaPhieuNhap;
insert into PhieuNhap(MaPhieuNhap,NgayNhap) values ('PN009','26/11/2020');
set dateformat dmy;
select CONVERT(varchar,NgayNhap,101) from PhieuNhap;