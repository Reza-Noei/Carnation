using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Base.Event
{
    public abstract class Event
    {
        public DateTime WriteIn { get; private set; }
        public Event()
        {
            WriteIn = DateTime.UtcNow;
        }
    }
}
