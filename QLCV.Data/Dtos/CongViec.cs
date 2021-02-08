using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Dtos
{
    public class CongViec
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string ThoiHanXuLy { get; set; }
        public int IDKetQuaXuLy { get; set; }
        public KetQuaXuLy KetQuaXuLy { get; set; }

    }
}
