using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS203
{
    public class PriorityClass
    {
        private List<Tuple<int, int>> priorityQueue;

        public PriorityClass()
        {
            this.priorityQueue = new List<Tuple<int, int>>();
        }

        public int Count
        {
            get
            {
                return priorityQueue.Count;
            }
        }

        public void Enqueue(Tuple<int, int> item)
        {
            priorityQueue.Add(item);
            int i = priorityQueue.Count - 1;
            while (i > 0)
            {
                int j = (i - 1) / 2;
                if (priorityQueue[i].Item2 >= priorityQueue[j].Item2)
                {
                    break;
                }
                Tuple<int, int> temp = priorityQueue[i];
                priorityQueue[i] = priorityQueue[j];
                priorityQueue[j] = temp;
                i = j;
            }
        }

        public Tuple<int, int> Dequeue()
        {
            if (priorityQueue.Count == 0)
            {
                throw new InvalidOperationException("Priority queue is empty");
            }
            Tuple<int, int> result = priorityQueue[0];
            int last = priorityQueue.Count - 1;
            priorityQueue[0] = priorityQueue[last];
            priorityQueue.RemoveAt(last);
            last--;
            int i = 0;
            while (true)
            {
                int child1 = 2 * i + 1;
                int child2 = 2 * i + 2;
                if (child1 > last)
                {
                    break;
                }
                int j = child1;
                if (child2 <= last && priorityQueue[child2].Item2 < priorityQueue[child1].Item2)
                {
                    j = child2;
                }
                if (priorityQueue[j].Item2 >= priorityQueue[i].Item2)
                {
                    break;
                }
                Tuple<int, int> temp = priorityQueue[i];
                priorityQueue[i] = priorityQueue[j];
                priorityQueue[j] = temp;
                i = j;
            }
            return result;
        }

        public Tuple<int, int> Peek()














        {
            if (priorityQueue.Count == 0)
            {
                throw new InvalidOperationException("Priority queue is empty");
            }
            return priorityQueue[0];
        }
    }
}
