using Dapper;
using QLCV.Data.Helper;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Services
{
    public class BaseService<T> : IBaseService<T>
    {
        public string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:/Code/QLCV/QLCV.accdb;";
        public int ExcuteNonQuery(string query, DynamicParameters dynamicParameters)
        {
            try
            {
                return SqlHelper.conn.Execute(query, dynamicParameters);
            }
            catch (Exception ex)
            {

                return 0;
            }


        }
        public int GetMaxId(string tableName)
        {
            try
            { 
                 return SqlHelper.conn.ExecuteScalar<int>($"select Max(ID) as ID from {tableName}");
            }
            catch (Exception ex)
            {

                return 0;
            }


        }
        public int ExcuteNonQuery(string query)
        {
            try
            {
                return SqlHelper.conn.Execute(query);
            }
            catch (Exception ex)
            {

                return 0;
            }


        }
        public int ExcuteScalar(string query)
        {
            try
            {
                return (int)SqlHelper.conn.ExecuteScalar(query);
            }
            catch (Exception ex)
            {

                return 0;
            }


        }
        public int? Create(T entity)
        {
            try
            { 
                return SqlHelper.conn.Insert<T>(entity);
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public int Delete(int ID)
        {
           
            return SqlHelper.conn.Delete<T>(ID);
        }

        public IEnumerable<T> GetAll(string condition = "")
        {
            try
            {
                if(string.IsNullOrEmpty(condition))
               return  SqlHelper.conn.GetList<T>();
                return SqlHelper.conn.GetList<T>(condition);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        
        public T GetByID(int ID)
        {
            try
            {
                return SqlHelper.conn.Get<T>(ID);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public int Update(T entity)
        {
          return  SqlHelper.conn.Update<T>(entity);
        }
    }
}
