namespace Domain
{
    public class QName: IEntity
    {
        public long Id { get; private set; }
        public string LocaleName { get; set; }
    }
}