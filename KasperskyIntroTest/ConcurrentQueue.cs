using System;
using System.Collections.Generic;
using System.Threading;

namespace KasperskyIntroTest
{
    class ConcurrentQueue<T>
    {
        private Queue<T> queue;
        private bool closed;

        public ConcurrentQueue()
        {
            closed = false;
        }

        public void Push(T item)
        {
            lock (queue)
            {
                while (true)
                {
                    if (closed)
                    {
                        throw new InvalidOperationException("Queue is closed");
                    }
                    else
                    {
                        queue.Enqueue(item);
                        Monitor.Pulse(queue);
                        break;
                    }
                }
            }
        }

        public bool Pop(out T item)
        {
            lock (queue)
            {
                while (true)
                {
                    if (queue.Count > 0)
                    {
                        item = queue.Dequeue();
                        Monitor.Pulse(queue);
                        return true;
                    }
                    else if (closed)
                    {
                        item = default(T);
                        return false;
                    }
                    Monitor.Wait(queue);
                }
            }
        }

        public void Close()
        {
            lock (queue)
            {
                closed = true;
                Monitor.PulseAll(queue);
            }
        }
    }
}
