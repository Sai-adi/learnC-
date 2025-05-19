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

// using System;

// class sq()
// {
//     static int square(int number)
//     {
//         return number * number;
//     }
//     static void Main()
//     {
//         Console.WriteLine("Enter the number");
//         string num = Console.ReadLine();
//         int number = int.Parse(num);

//         int squaredNumber = square(number);
//         Console.WriteLine($"The squared number is {squaredNumber}");

//     }
// }

// using System;
// using System.Security.AccessControl;

// class sum {
//     static int Add(int a, int b)
//     {
//         return a + b;

//     }

//     static void Main()
//     {
//         Console.WriteLine("Enter Two Numbers with spaces");
//         string[] inputs = Console.ReadLine().Split(' ');
//         int a = int.Parse(inputs[0]);
//         int b = int.Parse(inputs[1]);

//         int final=Add(a, b);
//         Console.WriteLine($"The sum is {final}");
//     }
// }


// using System;
// using System.Reflection.Metadata;

// class Cal
// {
//     static int Add(int a, int b)
//     {
//         return a + b;
//     }
//     static int Sub(int a, int b)
//     {
//         return a - b;
//     }
//     static int Mul(int a, int b)
//     {
//         return a * b;
//     }
//     static int Div(int a, int b)
//     {
//         return a / b;
//     }

//     static void Main()
//     {
//         Console.WriteLine("Enter Two Numbers with spaces");
//         string[] input = Console.ReadLine().Split();
//         int a = int.Parse(input[0]);
//         int b = int.Parse(input[1]);

//         Console.WriteLine("Choose an Operation to do +,-,*,/");
//         string operation = Console.ReadLine();

//         if (operation == "+")
//         {
//             int Addition = Add(a, b);
//             Console.WriteLine($"The addition of two numbers is {Addition}");
//         }
//         else if (operation == "-")
//         {
//             int Substraction = Sub(a, b);
//             Console.WriteLine($"The substraction of two numbers is {Substraction}");
//         }
//         else if (operation == "*")
//         {
//             int Multiplication = Mul(a, b);
//             Console.WriteLine($"The substraction of two numbers is {Multiplication}");
//         }
//         else if (operation == "/")
//         {
//             if (b == 0)
//             {
//                 Console.WriteLine("Cannot divide by 0");
//             }
//             else
//             {
//                 int Division = Div(a, b);
//                 Console.WriteLine($"The Division of two numbers is {Division}");
//             }
//         }
//         else
//         {
//             Console.WriteLine($"The invalid operation");
//         }
//     }
// }


// using System.Security.AccessControl;

// class Grade
// {
//     static void Mark(int marks)
//     {
//         if (marks < 50)
//         {
//             Console.WriteLine("Fail");
//         }
//         else if (marks < 70)
//         {
//             Console.WriteLine("D grade");
//         }
//         else if (marks < 80)
//         {
//             Console.WriteLine("C grade");
//         }
//         else if (marks < 90)
//         {
//             Console.WriteLine("B grade");
//         }
//         else
//         {
//             Console.WriteLine("A grade");
//         }
//     }
//     static void Main()
//     {
//         Console.WriteLine("Enter the Students Marks");
//         string input = Console.ReadLine();
//         int marks = int.Parse(input);

//         if (marks < 0 || marks > 100)
//         {
//             Console.WriteLine("The marks should be below 100");
//         }
//         else
//         {
//             Mark(marks);
//         }
//     }
// }

// using System.ComponentModel.DataAnnotations;

// class Fun()
// {
//     static int Sum(int[] numbers)
//     {
//         int total = 0;
//         int index = 0;

//         while (index < numbers.Length)
//         {
//             total += numbers[index];
//             index++;
//         }
//         return total;
//     }
//     static void Main()
//     {
//         Console.WriteLine("Enter 10 Numbers");
//         string[] input = Console.ReadLine().Split();
//         int[] numbers = Array.ConvertAll(input, int.Parse);

//         int total = Sum(numbers);
//         Console.WriteLine($"The total is{total}");
//     }
// }

// using System;

// class Fun()
// {
//     static void Main()
//     {
//         for (int i = 0; i <= 5; i++)
//         {
//             Console.WriteLine("Iteration: " + i);
//         }
//         string[] fruits = { "Apple", "Banana", "Guava" };

//         foreach (string fruit in fruits)
//         {
//             Console.WriteLine(fruit);
//         }
//     }
// }


using System.Collections.Specialized;

class Hub {

    static double CalculateAverage(int[] marks)
    {
        Console.WriteLine("Students Marks");
        int sum = 0;

        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }
        for (int i = 0; i < marks.Length; i++)
        {
            sum += marks[i];
        }

        double average = (double)sum / marks.Length;
        return average;
    }
    static void Main()
    {
        Console.WriteLine("Enter The Student Marks: ");
        string input = Console.ReadLine();
        string[] marks = input.Split(' ');

        int[] intMarks = new int[marks.Length];
        for (int i=0; i < marks.Length; i++) {
            intMarks[i] = int.Parse(marks[i]);
        }

        double average = CalculateAverage(intMarks);
        Console.WriteLine("Average marks are "+ average);
    }
    
}