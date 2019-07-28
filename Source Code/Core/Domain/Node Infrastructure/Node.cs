using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public abstract class Node: IEntity
    {
        public long Id { get; private set; }
        public long version { get; private set; }
        public string UUID { get; private set; }
        public virtual Transaction Transaction { get; private set; }
        public virtual AccessControlList AccessControlList { get; set; }
        public Audit Audit { get; private set; }
    }
}
