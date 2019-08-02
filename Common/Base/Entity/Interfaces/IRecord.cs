using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Base.Entity
{
    public interface IRecord:IEntity
    {
        string Creator { get; }
        DateTime Created { get; }
    }
}
