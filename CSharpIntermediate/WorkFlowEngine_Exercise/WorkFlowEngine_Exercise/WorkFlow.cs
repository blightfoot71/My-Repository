using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine_Exercise
{
    public class WorkFlow
    {
        private readonly IList<IActivities> _activites;

        public WorkFlow()
        {
            _activites = new List<IActivities>();
        }

        public void AddActivityToList(IActivities activity)
        {
            _activites.Add(activity);
        }

        public IEnumerable<IActivities> GetActivities()
        {
            return _activites;
        }
    }
}
