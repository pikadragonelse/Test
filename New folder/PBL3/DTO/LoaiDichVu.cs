﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class LoaiDichVu
    {
        public LoaiDichVu()
        {
            this.HoaDons = new HashSet<HoaDon>();
        }
        [Key][StringLength(10)][Required]

        public string IdDichVu { get; set; }
        [Required]
        public string TenDichVu { get; set; }
        [Required]
        public string DonGia { get; set; }
        [Required]
        public string GioMo { get; set; }
        [Required]
        public string GioDong { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
