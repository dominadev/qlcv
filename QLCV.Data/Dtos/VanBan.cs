using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Dtos
{
    public class VanBan
    {
        public int ID { get; set; }
        public string DiaChi { get; set; }
        public DateTime LichHoanThien { get; set; }
        public int IDMauVanBan { get; set; }
        public MauVanBan MauVanBan { get; set; }
    }
}
