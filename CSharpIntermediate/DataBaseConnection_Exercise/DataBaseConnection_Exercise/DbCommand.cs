using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection_Exercise
{
    public class DbCommand
    {
        private DbConnection _dbconnection;

        public DbCommand(DbConnection dbConnection)
        {
            if (dbConnection == null)
                throw new ArgumentNullException("dbConnection can't be null!");

            _dbconnection = dbConnection;
        }

        public void Execute()
        {
            _dbconnection.OpenConnection();

            Console.WriteLine("Execute Database Command");

            _dbconnection.CloseConnection();

        }
    }
}
