namespace Network_main.Logger;
using Network_main.User;
public class Log
{
    Context _context;
    public Log()
    {
        _context = new Context();
    }
    public bool SignIn()
    {
        List<User> Users = _context.Users.ToList();
        Console.WriteLine("Input username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Input password: ");
        string password = Console.ReadLine();
        if (username == "" || password == "")
        {
            Console.WriteLine("Username or password cannot be empty.");
            return false;
        }
        foreach (User u in Users)
        {
            if (u.Username == username && u.Password == password)
            {
                Console.WriteLine("User Signed in");
                return true;
            }
        }
        Console.WriteLine("User not found");
        return false;
    }

    public void SignUp()
    {
        Console.WriteLine("Input username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Input password: ");
        string password = Console.ReadLine();
        if (username == "" || password == "")
        {
            Console.WriteLine("Username or password cannot be empty.");
            return;
        }
        User user = new User(username, password);
        _context.Users.Add(user);
        _context.SaveChanges();
        Console.WriteLine($"User Signed up as:\n\tUsername: {username}, Password: {password}");

    }
}
