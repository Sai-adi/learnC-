using System;

class Login
{
    static void Main()
    {


        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter Password: ");
        string password = Console.ReadLine();

        if (username == "asdfghjkl" && password == "asdfghjkl")
        {
            Console.WriteLine("Correct credentials");
        }
        else {
            Console.WriteLine("Wrong Credentials");
        }
    }
}