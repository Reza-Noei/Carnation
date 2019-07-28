namespace Domain
{
    public class AccessControlListEntry: IEntity
    {
        public long Id { get; set; }
        public long Version { get; set; }
        public Permission Permission { get; set; }
        public Authority Authority { get; set; }
        public bool Allowed { get; set; }
    }
}