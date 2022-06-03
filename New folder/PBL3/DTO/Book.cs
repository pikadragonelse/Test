using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PBL3.DTO
{
    public class Book
    {
        public Book()
        {
            this.Phongs = new HashSet<Phong>();
        }
        [Key][Required][StringLength(10)]
        public string IdBook { get; set; }
        [Required][StringLength(10)]
        public string IdHoaDon { get; set; }
        [Required][StringLength(10)]
        public string IdKhachHang { get; set; }
        [Required][StringLength(10)]
        public string IdNhanVien { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime NgayCheckIn { get; set; }
        public DateTime NgayCheckOut { get; set; }
        public DateTime NgayCheckInThucTe { get; set; }
        public DateTime NgayCheckOutThucTe { get; set; }

        public virtual HoaDon HoaDon { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
