using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Base.Entity
{
    public interface ITrackable
    {
        long Version { get; set; }
    }
}
