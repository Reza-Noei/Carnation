using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Base.Entity
{
    public interface IContent: IRecord
    {
        string Modifier { get; }
        DateTime Modfied { get; }
    }
}
