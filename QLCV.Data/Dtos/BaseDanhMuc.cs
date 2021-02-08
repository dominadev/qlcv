using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Dtos
{
    public class BaseDanhMuc: IDanhMuc
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Tên")]
        public string Ten { get; set; }
    }
}
