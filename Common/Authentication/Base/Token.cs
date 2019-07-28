using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Authentication.Base
{
    public class Token
    {
        public string Content { get; set; }
        public TokenType Type { get; set; }
    }

    public enum TokenType
    {
        Bearer = 0
    }
}
