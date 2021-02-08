using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.Data.Helper
{
    public static class SqlHelper
    {
        private static readonly string connectionString = ConfigurationManager.AppSettings["connectionString"];
        public static OleDbConnection conn => new OleDbConnection(connectionString);
    }
}
