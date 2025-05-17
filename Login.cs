using System;

class checkScore()
{
    static void Main()
    {
        int attempts = 1;
        while (attempts <= 3)
        {
            Console.WriteLine("Guess a Number from 1 to 10");
            string num = Console.ReadLine();
            int newNum = int.Parse(num);

            Random rnd = new Random();
            int secret = rnd.Next(1, 11);
            // int secret = 3;

            if (newNum == secret)
            {
                Console.WriteLine("Your Guess is Correct");

                Console.WriteLine($"The system guessed number is :{secret}");
                break;
            }
            else
            {
                Console.WriteLine("Wrong Guess");
                Console.WriteLine($"The system guessed number is :{secret}");
            }
            attempts++;
        }
        if (attempts > 3)
        {
            Console.WriteLine("Out of moves");
    }
    }
}