using Common.Base.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Base.Event
{
    public abstract class Delete : Event
    {
        public Delete(IEntity entity)
        {

        }
    }
}
