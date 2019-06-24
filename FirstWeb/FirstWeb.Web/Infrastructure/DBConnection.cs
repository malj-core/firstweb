using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using FirstWeb.Core.Abstract;

namespace FirstWeb.Web.Infrastructure
{
    public class DBConnection: IDBConnection
    {
        private DBConnection() { }

        private readonly string _conStr = ConfigurationManager.AppSettings["ConStr"];

        public static DBConnection Instance => new DBConnection();

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_conStr);
        }
    }
}