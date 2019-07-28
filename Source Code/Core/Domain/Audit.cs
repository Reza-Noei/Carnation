using System;

namespace Domain
{
    public class Audit
    {
        public string Creator { get; set; }
        public DateTime Created { get; set; }
        public string Modifier { get; set; }
        public DateTime Accessed { get; set; }
    }
}