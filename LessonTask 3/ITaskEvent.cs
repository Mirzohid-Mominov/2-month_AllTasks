using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask_3
{
    public interface ITaskEvent
    {
        Guid Id { get; }
        string Name { get; }
        byte Priority { get; }
    }
}
