using System.Collections.Generic;

namespace Domain
{
    public class AccessControlList: IEntity
    {
        public long Id { get; private set; }
        public string UUID { get; private set; }
        public bool Latest { get; set; }
        public long Version { get; set; }
        public bool Inherits { get; set; }
        public AccessControlList InheritsFrom { get; set; }
        public AccessControlListType Type { get; set; }

        public ICollection<AccessControlListMember> Members { get; set; }

        public AccessControlList()
        {
            Members = new HashSet<AccessControlListMember>();
        }
    }
}