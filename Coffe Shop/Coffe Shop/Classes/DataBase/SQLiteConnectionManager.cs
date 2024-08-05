using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shop.Classes.DataBase
{
    public class SQLiteConnectionManager
    {
        private readonly SqlConnection _connection;
        private string _connectionString;
        public SqlConnection GetConnection => _connection;

        public SQLiteConnectionManager()
        {
            _connectionString = @$"Data Source=(localdb)\Local;Initial Catalog=CoffeeShop;Integrated Security=True";
            _connection = new SqlConnection(_connectionString);
        }

        public async Task OpenConnectionAsync()
        {
            if (_connection.State != System.Data.ConnectionState.Open) 
            {
                await _connection.OpenAsync();
            }
        }

        public async Task CloseConnectionAsync()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                await _connection.CloseAsync();
            }
        }
    }
}
