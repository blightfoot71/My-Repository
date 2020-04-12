using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Stack_Exercise
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Don't pass null pointers!");

            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("The stack is empty!");

            var lastIndex = _list.Count - 1;
            var value = _list[lastIndex];
            _list.RemoveAt(lastIndex);

            return value;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
