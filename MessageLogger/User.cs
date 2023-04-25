namespace MessageLogger
{
    public class User
    {
        public string Name;
        public string UserName;
        public List<Message> Messages;

        public User(string name, string userName)
        {
            Name = name;
            UserName = userName;
            Messages = new List<Message>();
        }
    }
}
