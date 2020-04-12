using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)  // I like what he did here to reduce duplication of code
        {
            using (var streamWriter = new StreamWriter(_path, true))    // Used for things not managed by the CLR
            {
                streamWriter.WriteLine(messageType + ": " + message);
                // streamWriter.Dispose();          // The using statement above automatically adds the dispose statement
            }
        }
    }
}
