namespace Domain
{
    public class Permission: IEntity
    {
        public long Id { get; set; }
        public long Version { get; set; }
        public string Name { get; set; }
        public QName TypeQName { get; set; }
    }
}