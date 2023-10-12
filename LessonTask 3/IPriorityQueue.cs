using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask_3
{
    public interface IPriorityQueue<TEvent> where TEvent : ITaskEvent
    {
        void Enqueue(TEvent eventItem);

        TEvent Dequeue();

        TEvent Peek();
    }
}
