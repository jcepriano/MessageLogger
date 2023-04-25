using MessageLogger;
using System.Reflection.Metadata;

Console.WriteLine("Welcome to Message Logger!");
Console.WriteLine();
Console.WriteLine("Let's create a user profile for you.");
Console.Write("What is your name? ");
string Name = Console.ReadLine();
Console.Write("What is your username? (one word, no spaces!) ");
string UserName = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("To log out of your user profile, enter 'log out'. To quit the application, enter 'quit'");
Console.Write("Add a message: ");

var users = new List<User>();

//var messages = new List<Message>();

//var Messages = new List<Message>();
User user1 = new User(Name, UserName);

while (true)
{

    //if (users.Contains(UserName))
    //{

    //}

    string userInput = Console.ReadLine();
    Message newMessage = new Message(userInput);

    user1.Messages.Add(newMessage);
    //users.Add(user1);

    if (userInput.ToLower() == "quit")
    {
        break;
    }

    foreach (var message in user1.Messages)
    {
        Console.WriteLine();
        //Console.Write(user1.Name );
        Console.WriteLine(user1.Name + " " + message.CreatedAt.ToString("hh:mm tt") + ": " + message.Content);
    }

    //foreach(var log in logIn)
    //{
    //    Console.WriteLine(log.Name + log.UserName);
    //}

    Console.WriteLine();
    Console.Write("Add a message: ");
}

user1.Messages.RemoveAt(user1.Messages.Count - 1);
Console.WriteLine();
Console.WriteLine($"Thanks for using Message Logger! During this session, you logged {user1.Messages.Count()} messages.");