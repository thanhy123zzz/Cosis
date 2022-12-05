using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Cosis.Models.Entities
{
    public partial class ThongTinCaThe
    {
        public ThongTinCaThe()
        {
            Master = new HashSet<Master>();
        }

        public string MaSoThue { get; set; }
        public string MaSoThue2 { get; set; }
        public string MaCoSo { get; set; }
        public string TenCoSo { get; set; }
        public string DiaChi { get; set; }
        public string SdtcoSo { get; set; }
        public string Email { get; set; }
        public string MaLh { get; set; }

        public virtual LoaiHinhKinhte MaLhNavigation { get; set; }
        public virtual ICollection<Master> Master { get; set; }
    }
}
