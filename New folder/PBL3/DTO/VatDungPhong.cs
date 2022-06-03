using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class VatDungPhong
    {
        [Key]
        [StringLength(10)]
        [Required]
        public string IdVatDung { get; set; }
        [StringLength(10)]
        [Required]
        public string IdPhong { get; set; }
        [Required]
        public string SoLuongBanDau { get; set; }
        [Required]
        public string SoLuongHienTai { get; set; }
        [StringLength(10)]
        [Required]
        public string IdTrangThaiVatDung { get; set; }

        public virtual LoaiVatDung LoaiVatDung { get; set; }
        public virtual Phong Phong { get; set; }
        public virtual TrangThaiVatDung TrangThaiVatDung { get; set; }
    }
}
