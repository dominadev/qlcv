using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Dtos
{
    public class KhenThuong_CanBo
    {
        public int ID { get; set; }
        public int IDKhenThuong { get; set; }
        public int IDCanBo { get; set; } 
        public string NgayThang { get; set; }
        public string CapKhenThuong { get; set; }
    

    }
    public class KhenThuong_CanBoView
    {
        public int ID { get; set; }
        public int IDKhenThuong { get; set; }
        public int IDCanBo { get; set; } 
        public string NgayThang { get; set; }
        public string CapKhenThuong { get; set; }
        public string TenKhenThuong { get; set; }


    }
}
