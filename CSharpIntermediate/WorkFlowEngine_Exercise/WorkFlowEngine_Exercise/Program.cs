using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkFlow();

            workflow.AddActivityToList(new UploadVideoToCloudStorage());
            workflow.AddActivityToList(new CallWebService());
            workflow.AddActivityToList(new SendEmail());
            workflow.AddActivityToList(new ChangeDatabaseStatusToProcessing());

            var workflowengine = new WorkFlowEngine();
            workflowengine.Run(workflow);

            Console.WriteLine();
        }
    }
}
