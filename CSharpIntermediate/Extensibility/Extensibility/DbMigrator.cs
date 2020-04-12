using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)   // Dependency Injection  We are injecting this interface
        {                                   // We are specifying the dependencies for the DbMigrator class
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migrating started at " + DateTime.Now);

            // Details of migrating the database

            _logger.LogInfo("Migrating finished at " + DateTime.Now);
        }
    }
}
