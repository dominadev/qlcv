using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Dtos
{
    public class ThanhVienGiaDinh
    {
        public int ID { get; set; }
        public string QuanHe { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string HoKhau { get; set; }
        public string CongViec { get; set; }
        public int IDCanBo { get; set; }
    }
}
