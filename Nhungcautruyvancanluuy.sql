select p.MaPhieuNhap, ISNULL(c.TongTien,0) as TongTien ,NgayNhap from  PhieuNhap p right join  ChiTietPhieuNhap c 
on  p.MaPhieuNhap=c.MaPhieuNhap;
insert into PhieuNhap(MaPhieuNhap,NgayNhap) values ('PN009','26/11/2020');
set dateformat dmy;
select CONVERT(varchar,NgayNhap,103) from PhieuNhap;
Select p.MaPhieuNhap as 'Mã Phiếu Nhập ',CONVERT(varchar,p.NgayNhap,103) as ngaynhap  ,IsNULL(Sum(c.TongTien),0) 
from PHIEUNHAP p  left join ChiTietPhieuNhap c 
on p.MaPhieuNhap=c.MaPhieuNhap 
group by p.MaPhieuNhap,p.NgayNhap
select * from chitietphieunhap;