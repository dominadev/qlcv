using QLCV.Data.Dtos;
using QLCV.Data.Helper;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Services
{
    public class CanBoService:BaseService<CanBo>
    {
        public List<KhenThuong_CanBoView> GetList(int IDCanBo)
        {
            using (var con = SqlHelper.conn)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"SELECT a.ID, a.IDCanBo, a.IDKhenThuong, a.NgayThang, a.CapKhenThuong, b.Ten FROM  (KhenThuong_CanBo a INNER JOIN  KhenThuong b ON a.IDKhenThuong = b.ID)WHERE  (a.IDCanBo = {IDCanBo})";
                    var reader = cmd.ExecuteReader();
                    List<KhenThuong_CanBoView> list = new List<KhenThuong_CanBoView>();
                  
                    while (reader.Read())
                    {
                        KhenThuong_CanBoView kt = new KhenThuong_CanBoView();
                        kt.ID = (int)reader["ID"];
                        kt.IDCanBo = (int)reader["IDCanBo"];
                        kt.IDKhenThuong = (int)reader["IDKhenThuong"];
                        kt.NgayThang = reader["NgayThang"].ToString();
                        kt.CapKhenThuong = reader["CapKhenThuong"].ToString();
                        kt.TenKhenThuong = reader["Ten"].ToString();
                        list.Add(kt);
                    }
                    return list;
                   
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    con.Close();
                }


            }
           
        }
    }
}
