using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class CreateDB: DropCreateDatabaseAlways<QLKS>
    {
        protected override void Seed(QLKS context)
        {

            context.KhachHangs.Add(new KhachHang
            {
                IdKhachHang = "1001",
                Ten = "Long",
                GioiTinh = true,
                CMND = "101468157",
                SDT = "0862027357",
                QuocTich = "Việt Nam",
                GhiChu = ""
            });
            base.Seed(context);
        }
    }
}
