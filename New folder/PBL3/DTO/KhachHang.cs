﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class KhachHang
    {
        public KhachHang()
        {
            this.Book = new HashSet<Book>();
        }
        [Key][StringLength(10)][Required]
        public string IdKhachHang { get; set; }
        [Required]
        public string Ten { get; set; }
        [Required]
        public bool GioiTinh { get; set; }
        [Required]
        public string CMND { get; set; }
        [Required]
        public string SDT { get; set; }
        [Required]
        public string QuocTich { get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<Book> Book { get; set; }
    }
}
