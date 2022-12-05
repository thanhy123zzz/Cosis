using System;
using System.Collections.Generic;
namespace Cosis.Models.Entities
{
    public partial class Phieu
    {
        public virtual Master Master { get; set; }
        public virtual ICollection<DanhSachNhanToAnhHuong> DanhSachNhanToAnhHuong { get; set; }
        public virtual NhanToThu9 NhanToThu9 { get; set; }
        public virtual Detail Detail { get; set; }
    }
}
