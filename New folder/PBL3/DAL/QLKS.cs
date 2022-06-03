using PBL3.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace PBL3.DAL
{
    public class QLKS : DbContext
    {

        public QLKS()
            : base("name=QLKS")
        {
            Database.SetInitializer<QLKS>(new CreateDB());
        }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LichSuDangNhap> LichSuDangNhaps { get; set; }
        public virtual DbSet<LoaiDichVu> LoaiDichVus { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<LoaiVatDung> LoaiVatDungs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TrangThaiVatDung> TrangThaiVatDungs { get; set; }
        public virtual DbSet<VatDungPhong> VatDungPhongs { get; set; }
    }

}