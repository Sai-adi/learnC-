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

            int secret = 3;

            if (newNum == secret)
            {
                Console.WriteLine("Your Guess is Correct");
                break;
            }
            else
            {
                Console.WriteLine("Wrong Guess");
            }
            attempts++;
        }
        if(attempts>3){
        Console.WriteLine("Out of moves");
    }
    }
}