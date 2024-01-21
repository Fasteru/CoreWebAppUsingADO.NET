using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ConnectionFactory
{
    public class DBConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public DBConnectionFactory(string ConnectionString)
        {
            _connectionString = ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            var conn = new SqlConnection(_connectionString);
            return conn;
        }
    }
}
