using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Services
{
    public interface IBaseService<T>
    {
        int? Create(T entity);
        int Update(T entity);
        int Delete(int ID);
        IEnumerable<T> GetAll(string conditon = "");
    }
}
