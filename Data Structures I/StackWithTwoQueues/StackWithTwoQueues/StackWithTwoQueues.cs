using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithTwoQueues
{
    public class StackWithTwoQueues
    {
        private int count;
        private Queue<int> q1 = new Queue<int>();
        private Queue<int> q2 = new Queue<int>();

        //push
        public void Push(int value)
        {
            q1.Enqueue(value);
            count++;
        }

        //pop
        public int Pop()
        {
            var top = 0;
            if (IsEmpty())
                throw new ArgumentNullException();

            if (count == 1)
            {
                top = q1.Dequeue();
            }
            else
            {
                for (int i = 0; i < count - 1; i++)
                    q2.Enqueue(q1.Dequeue());

                top = q1.Dequeue();

                //for (int i = 0; i < count - 1; i++)
                //    q1.Enqueue(q2.Dequeue());
                var temp = q1;
                q1 = q2;
                q2 = temp;
            }
            count--;
            return top;
        }

        //peek

        //size

        //isEmpty
        public bool IsEmpty()
        {
            return count == 0;
        }

    }
}
