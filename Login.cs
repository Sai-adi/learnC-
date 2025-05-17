// using System;


// // class checkScore

// {
//     static void Main()
//     {
//         int count = 1;
//         int oddCount = 0;
//         int evenCount = 0;
//         while (count <= 10)
//         {
//             Console.WriteLine($"Enter the number {count}");
//             string numbers = Console.ReadLine();
//             int newNumbers = int.Parse(numbers);

//             if (newNumbers % 2 == 0)
//             {
//                 evenCount++;
//             }
//             else
//             {
//                 oddCount++;
//             }
//             count++;
//         }

//         Console.WriteLine("...");
//         Console.WriteLine("All Numbers Entered");
//         Console.WriteLine($"Totaleven numbers : {evenCount}");
//         Console.WriteLine($"Totaleven numbers :{oddCount}");

//     }

// }

using System;

class largeNumber
{
    static void Main()
    {
        int count = 1;
        int max = int.MinValue;
        while (count <= 5)
        {
            Console.WriteLine($"Enter Number {count}");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number > max)
            {
                max = number;
            }

            count++;
        }

        Console.WriteLine($"The largest number is {max}");
    }
}