using Common.Base.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class EventCenter
    {
        [ThreadStatic]
        public static Dictionary<Event,IHandler<Event>> Handlers;        

        public static void Register<T>(IHandler<T> Handler) where T: Event
        {
            // Create New Instance of Handlers 
            Handlers = Handlers ?? new Dictionary<Event, IHandler<Event>>();

            var Instance = Activator.CreateInstance<T>();
            Handlers[Instance] = Handler as IHandler<Event>;
        }

        public static void Raise<T>(T Event) where T: Event
        {
            var Instance = Activator.CreateInstance<T>();
            if (Handlers.ContainsKey(Instance))
            {
                Handlers[Instance].Action.Invoke(Event);
            }
        }
    }
}
