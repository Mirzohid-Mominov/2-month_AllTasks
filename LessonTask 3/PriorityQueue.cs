using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask_3
{
    public class PriorityQueue<TEvent> : IEnumerable<TEvent>, IPriorityQueue<TEvent> where TEvent : ITaskEvent
    {
        private readonly List<TEvent> _events = new();

        public void Enqueue(TEvent eventItem)
        {
            _events.Add(eventItem);
        }

        public TEvent Dequeue()
        {
            List<TEvent> sortedEvents = new List<TEvent>();

            for(var i = 0; i < _events.Count; i++)
            {
                for(var j = 0; j < _events.Count; j++)
                {
                    if (_events[i].Priority > _events[j].Priority)
                    {
                        var sorted = _events[i];
                        _events[i] = _events[j];
                        _events[j] = sorted;
                    }
                }
            }
            var maxPriority = _events[_events.Count - 1];
            _events.Remove(maxPriority);
            return maxPriority;

        }

        public TEvent Peek()
        {
            List<TEvent> sortedEvents = new List<TEvent>();

            for (var i = 0; i < _events.Count; i++)
            {
                for (var j = 0; j < _events.Count; j++)
                {
                    if (_events[i].Priority > _events[j].Priority)
                    {
                        var sorted = _events[i];
                        _events[i] = _events[j];
                        _events[j] = sorted;
                    }
                }
            }
            return _events[_events.Count - 1];

        }

        public IEnumerator<TEvent> GetEnumerator()
        {
            return _events.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _events.GetEnumerator();
        }
    }
}
