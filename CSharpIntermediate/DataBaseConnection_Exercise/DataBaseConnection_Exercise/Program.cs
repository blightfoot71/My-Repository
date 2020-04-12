using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeout = TimeSpan.FromSeconds(10);
            
            var sql = new SqlConnection("xyz123", timeout);
            var oracle = new OracleConnection("abc789");

            //sql.OpenConnection();
            //sql.CloseConnection();

            //Console.WriteLine();

            //oracle.OpenConnection();
            //oracle.CloseConnection();

            var sqlCommand = new DbCommand(sql);
            sqlCommand.Execute();

            Console.WriteLine();

            var oracleCommand = new DbCommand(oracle);
            oracleCommand.Execute();
        }
    }
}
