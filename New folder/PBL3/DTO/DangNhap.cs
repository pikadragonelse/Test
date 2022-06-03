using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class DangNhap
    {


        [Key][StringLength(10)][Required]

        public string IdNhanVien { get; set; }
        [ForeignKey("IdNhanVien")]

        [Required]
        public virtual NhanVien NhanVien { get; set; }
        public string MatKhau { get; set; }
        [Required]
        public bool TrangThai { get; set; }


    }
}
