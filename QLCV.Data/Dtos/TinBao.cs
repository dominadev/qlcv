using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Dtos
{
    public class TinBao
    {
        public int ID { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        public int IDLoaiTinBao { get; set; }
        public LoaiTinBao LoaiTinBao { get; set; }
        public  string TenNguoiCungCap { get; set; }
        public DateTime NgayXayRa { get; set; }
        public string NoiDung { get; set; }
        public int IDLoaiThongTin { get; set; }
        public LoaiThongTin LoaiThongTin { get; set; } 
        public int IDKetQuaXuLy { get; set; }
        public KetQuaXuLy KetQuaXuLy { get; set; }
    }
}
