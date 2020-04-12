using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine_Exercise
{
    public class WorkFlowEngine
    {
        public void Run(WorkFlow workflow)
        {
            foreach (var activity in workflow.GetActivities())
                activity.Execute();
        }
    }
}
