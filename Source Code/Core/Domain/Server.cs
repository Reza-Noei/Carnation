namespace Domain
{
    public class Server : IEntity
    {
        public long Id { get; private set; }
        public string IpAddress { get; private set; }
    }
}