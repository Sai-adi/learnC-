using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Your Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Your DOB Year: ");
        string ageInput = Console.ReadLine();
        int age = int.Parse(ageInput);

        int currentYear = DateTime.Now.Year;

        int newage = currentYear - age;

        Console.WriteLine($"Your Name is {name} and age is {newage}");
        if (newage > 18)
        {
            Console.WriteLine("You are adult");
        }
        else
        {
            Console.WriteLine("You are minor");
        }
    }
}
