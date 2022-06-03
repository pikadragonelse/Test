using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class NhanVien
    {
        public NhanVien()
        {
            this.Books = new HashSet<Book>();
            this.LichSuDangNhaps = new HashSet<LichSuDangNhap>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        public string IdNhanVien { get; set; }
        public virtual DangNhap DangNhap { get; set; }
        [StringLength(10)]
        [Required]
        public string IdChucVu { get; set; }
        [Required]
        public string Ten { get; set; }
        [Required]
        public bool GioiTinh { get; set; }
        [Required]
        public DateTime NgaySinh { get; set; }
        [Required]
        public string CMND { get; set; }
        [Required]
        public string SDT { get; set; }
        [Required]
        public string DiaChi { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        public virtual ChucVu ChucVu { get; set; }

        public virtual ICollection<LichSuDangNhap> LichSuDangNhaps { get; set; }
    }
}
