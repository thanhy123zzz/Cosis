namespace WebApplication3.Models
{
    public partial class Phieu
    {
        private virtual Master Master { get; set; }
        private virtual ICollection<DanhSachNhanToAnhHuong> DanhSachNhanToAnhHuong { get; set; }
        private virtual NhanToThu9 NhanToThu9 { get; set; }
        private virtual Detail Detail { get; set; }
    }
}
