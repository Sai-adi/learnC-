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

// using System;

// class largeNumber
// {
//     static void Main()
//     {
//         int count = 1;
//         int max = int.MinValue;
//         while (count <= 5)
//         {
//             Console.WriteLine($"Enter Number {count}");
//             string input = Console.ReadLine();
//             int number = int.Parse(input);

//             if (number > max)
//             {
//                 max = number;
//             }

//             count++;
//         }

//         Console.WriteLine($"The largest number is {max}");
//     }
// }

// using System;

// class intro
// {
//     static void GreetingUser(string name)
//     {
//         Console.WriteLine($"The name is {name}");
//     }
//     static void SayHello()
//     {
//         Console.WriteLine("Hey Guys ");
//     }
//     static int add(int a, int b)
//     {
//         return a + b;
//     }
//     static void Main()
//     {
//         int result = add(5, 7);
//         Console.WriteLine($"Sum is:{result}");
//         SayHello();
//         GreetingUser("Adithya");
//     }
// }

using System;

class sq()
{
    static int square(int number)
    {
        return number * number;
    }
    static void Main()
    {
        Console.WriteLine("Enter the number");
        string num = Console.ReadLine();
        int number = int.Parse(num);

        int squaredNumber = square(number);
        Console.WriteLine($"The squared number is {squaredNumber}");

    }
}