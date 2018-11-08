using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Circular_Linked_List_Queue
{
    public class Queue<T>
    {
        private LinkedList<T> queue;
        public int Count => queue.Count;

        public Queue()
        {
            queue = new LinkedList<T>();
        }

        public void Enqueue(T value)
        {
            queue.AddLast(value);
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new NullReferenceException("There are no items in the que");
            }

            var temp = queue.First.Value;
            queue.RemoveFirst();
            return temp;
        }

        public bool IsEmpty()
        {
            if (Count == 0)
            {
                return true;
            }
            return false;
        }

        public bool Contains(T value) => queue.Contains(value);
    }
}
