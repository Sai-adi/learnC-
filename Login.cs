using System;

class checkScore()
{
    static void Main()
    {
        Console.Write("Enter Your Score");
        string score = Console.ReadLine();
        int newScore = int.Parse(score);

        if (newScore < 100 && newScore > 90)
            Console.WriteLine("A Grade");

        else if (newScore < 90 && newScore > 80)
            Console.WriteLine("B Grade");

        else if (newScore < 80 && newScore > 70)
            Console.WriteLine("C Grade");
        else if (newScore < 70 && newScore > 60)
            Console.WriteLine("D Grade");
        else if (newScore < 60)
            Console.WriteLine("F Grade");
    }
}