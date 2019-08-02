namespace Domain
{
    public class AccessControlListMember
    {
        public AccessControlList AccessControlList { get; set; }
        public AccessControlListEntry AccessControlListEntry { get; set;}
        public int Position { get; set; }
    }
}