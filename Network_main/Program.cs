using Network_main.Logger;
using Network_main.User;
bool letIn = false;
bool exited= false;
while (!letIn)
{
    Console.WriteLine("Welcome to the Network App!\n1. Sign In\n2. Sign Up\n3. Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            letIn = Logger.SignIn();
            break;
        case "2":
            Logger.Log.SignUp();
            letIn = true;
            break;
        case "3":
            exited = true;
            break;
        default:
            Console.WriteLine("Invalid choice, please try again.");
            break;
    }
    if (exited) break;
}
while (!exited); 