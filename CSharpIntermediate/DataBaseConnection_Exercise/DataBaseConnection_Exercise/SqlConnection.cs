using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection_Exercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }

        public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Openning SQL Connection...");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing SQL Connection...");
        }
    }
}
