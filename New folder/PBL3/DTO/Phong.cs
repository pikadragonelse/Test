using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Phong
    {
        public Phong()
        {
            this.VatDungPhongs = new HashSet<VatDungPhong>();
            this.Book = new HashSet<Book>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        public string IdPhong { get; set; }
        [StringLength(10)]
        [Required]
        public string IdLoaiPhong { get; set; }
        [Required]
        public bool TrangThai { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }
        public virtual ICollection<VatDungPhong> VatDungPhongs { get; set; }
        public virtual ICollection<Book> Book { get; set; }
    }
}
