using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Database
{
    class DatabaseConnection
    {
        private string _connectionString = "server=localhost;user id=root;password=root;database=edulink";

        public MySqlConnection GetDbConnection()
        {
           return new MySqlConnection(_connectionString);
        }
    }
}
