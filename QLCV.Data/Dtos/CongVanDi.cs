using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Dtos
{
    public class CongVanDi
    {
        public int ID { get; set; }
        public DateTime NgayBanHanh { get; set; }
        public string SoVanBan { get; set; }
        public string TrichYeuNoiDung { get; set; }
        public int IDNguoiKyBanHanh { get; set; }
        public CanBo NguoiKyBanHanh { get; set; }
        public int IDNoiNhan { get; set; }
        public CoQuan NoiNhan { get; set; }
        public int IDLoaiVanBan { get; set; }
        public LoaiVanBan LoaiVanBan { get; set; }
    }
}
