using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection_Exercise
{
    public abstract class DbConnection
    {
        private string _connectionString { get; set; }
        private TimeSpan _timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (connectionString == null || connectionString == "")
                throw new ArgumentException("Please pass a valid Connection String!");

            _connectionString = connectionString;
        }

        public DbConnection(string connectionString, TimeSpan timeout)
            : this(connectionString)
        {
            _timeout = timeout;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
