using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class LoaiVatDung
    {
        [Key]
        [StringLength(10)]
        [Required]
        public string IdVatDung { get; set; }
        [ForeignKey("IdVatDung")]
        [Required]
        public virtual VatDungPhong VatDungPhong { get; set; }
        public string TenVatDung { get; set; }
        [Required]
        public string DonGia { get; set; }

    }
}
