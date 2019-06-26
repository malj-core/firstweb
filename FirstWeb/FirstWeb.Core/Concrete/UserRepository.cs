using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using FirstWeb.Core.Abstract;
using FirstWeb.Core.Entities;

namespace FirstWeb.Core.Concrete
{
    public class UserRepository
    {
        private readonly IDBConnection _dBConnection;

        public UserRepository(IDBConnection connection)
        {
            _dBConnection = connection;
        }

        public IEnumerable<UserInfo> FindAll()
        {
            using (var conn = _dBConnection.GetConnection())
            {
                try
                {
                    conn.Open();


                    return conn.Query<UserInfo>(
                        "SELECT [LocalID],[UserID],[OpenID],[WinCase],[TotalCase] FROM [UserInfo]");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
