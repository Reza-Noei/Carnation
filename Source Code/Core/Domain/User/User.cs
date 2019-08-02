using System.Dynamic;

namespace Domain
{
    public class User: Authority
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public User()
        {

        }
    }
}