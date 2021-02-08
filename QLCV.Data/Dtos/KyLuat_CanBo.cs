using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Dtos
{
    public class KyLuat_CanBo
    {
        public int ID { get; set; }
        public int IDKyLuat { get; set; }
        public KyLuat KyLuat { get; set; }
        public int IDCanBo { get; set; }
        public CanBo CanBo { get; set; }
        public DateTime NgayKyLuat { get; set; }
        public int IDCapKyLuat { get; set; }
        public CapKyLuat CapKyLuat { get; set; }
    }
}
