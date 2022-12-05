﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Cosis.Models.Entities
{
    public partial class Master
    {
        public string MaSoThue { get; set; }
        public string MaSoThue2 { get; set; }
        public string MaCoSo { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string MaLh { get; set; }
        public string MaPhieu { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public DateTime? NgayDuTinh { get; set; }
        public string TenNguoiTraLoi { get; set; }
        public string SdtnguoiTraLoi { get; set; }

        public virtual ThongTinCaThe MaCoSoNavigation { get; set; }
        public virtual LoaiHinhKinhte MaLhNavigation { get; set; }
        public virtual ThongTinDoanhNghiep MaSoThueNavigation { get; set; }
    }
}
