using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Base.Event
{
    public interface IHandler<T> where T: Event
    {
        Action<T> Action { get; set; }
    }
}
