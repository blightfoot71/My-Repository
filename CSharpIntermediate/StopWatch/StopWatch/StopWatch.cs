using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _start;
        private DateTime _stop;
        private bool _running;

        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch is already running!");

            _start = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            _stop = DateTime.Now;
            _running = false;

        }

        public TimeSpan Duration
        {
            get
            {
                return _stop - _start;
            }
        }
    }
}
