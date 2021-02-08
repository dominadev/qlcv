using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Dtos
{
    public class CongVanDen
    {
        public int ID { get; set; }
        public DateTime NgayNhan { get; set; }
        public DateTime NgayBanHanh { get; set; }
        public int IDNoiGui { get; set; }
        public CoQuan NoiGui { get; set; }
        public string TrichYeuNoiDung { get; set; }
        public int IDNguoiKyBanHanh { get; set; }
        public CanBo NguoiKyBanHanh { get; set; }
        public int IDLoaiVanBan { get; set; }
        public LoaiVanBan LoaiVanBan { get; set; }
        public DateTime ThoiHanXuLy { get; set; }
        public int IDNguoiDuocGiao { get; set; }
        public CanBo NguoiDuocGiao { get; set; }
    }
}
