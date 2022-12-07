﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Cosis.Models.Entities
{
    public partial class NhanToThu9
    {
        public string MaPhieu { get; set; }
        public string NoiDung { get; set; }

        public virtual Master MaPhieuNavigation { get; set; }
    }
}
