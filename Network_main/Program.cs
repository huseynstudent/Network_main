using Network_main.Logger;
using Network_main.User;
using System.Net.Sockets;
using System.Net;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        bool letIn = false;
        bool exited = false;
        while (!letIn)
        {
            Console.WriteLine("Welcome to the Network App!\n1. Sign In\n2. Sign Up\n3. Exit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    letIn = Log.SignIn();
                    break;
                case "2":
                    Log.SignUp();
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
        ////
        var ip = IPAddress.Parse("127.0.0.1");
        var receiverport = 45679;
        var senderport = 45678;
        ////
        var server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        var remoteEP = new IPEndPoint(ip, receiverport);
        server.Bind(remoteEP);
        server.SendTo(Encoding.UTF8.GetBytes("client connected"), remoteEP);
        while (!exited)
        {
            var msg = Console.ReadLine() ?? string.Empty;
            if (msg == "" || msg.ToLower() == "exit")
                exited = true;
            var data = Encoding.UTF8.GetBytes(msg);
            server.SendTo(data, remoteEP);
        }
    }
}