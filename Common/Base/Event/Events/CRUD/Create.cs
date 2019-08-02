using Common.Base.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Base.Event
{
    public abstract class Create : Event
    {
        public Create(IEntity entity)
        {

        }
    }
}
