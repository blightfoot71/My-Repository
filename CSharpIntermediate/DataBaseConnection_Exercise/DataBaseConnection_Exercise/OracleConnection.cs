using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection_Exercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string ConnectionString) : base(ConnectionString)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Openning Oracle Connection...");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing Oracle Connection...");
        }
    }
}
