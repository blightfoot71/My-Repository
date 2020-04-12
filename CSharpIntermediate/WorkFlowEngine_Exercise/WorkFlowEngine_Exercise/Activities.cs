using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine_Exercise
{
    public class UploadVideoToCloudStorage : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Uploading Video to Cloud Storage...");
        }
    }
    public class CallWebService : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Calling Web Service...");
        }
    }
    public class SendEmail : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email...");
        }
    }
    public class ChangeDatabaseStatusToProcessing : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Changing video record in database to Processing...");
        }
    }
}
