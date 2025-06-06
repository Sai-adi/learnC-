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


// using System.Collections.Specialized;
// using System.Globalization;

// class Hub {

//     static double CalculateAverage(int[] marks)
//     {
//         Console.WriteLine("Students Marks");
//         int sum = 0;

//         foreach (int mark in marks)
//         {
//             Console.WriteLine(mark);
//         }
//         for (int i = 0; i < marks.Length; i++)
//         {
//             sum += marks[i];
//         }

//         double average = (double)sum / marks.Length;
//         return average;
//     }
//     static void Main()
//     {
//         Console.WriteLine("Enter The Student Marks: ");
//         string input = Console.ReadLine();
//         string[] marks = input.Split(' ');

//         int[] intMarks = new int[marks.Length];
//         for (int i=0; i < marks.Length; i++) {
//             intMarks[i] = int.Parse(marks[i]);
//         }

//         double average = CalculateAverage(intMarks);
//         Console.WriteLine("Average marks are "+ average);
//     }

// }

// class Program
// {
//     static void Main()
//     {
//         arrays();
//     }

//     static void arrays()
//     {


//         int[] intArray1 = new int[5];

//         int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };

//         int[] intArray3 = { 1, 2, 3 };
//         //One dimentional Array
//         Console.WriteLine("intArray3");
//         foreach (int d in intArray3)
//             Console.WriteLine(d);
//         Console.WriteLine();

//         //Two Dimentional Array
//         int[,] _2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
//         for (int i = 0; i < 4; i++)
//             for (int j = 0; j < 2; j++)
//                 Console.WriteLine(_2D[i, j] + "");
//         Console.WriteLine();
//         Console.WriteLine(intArray3);

//     }
//     int[][] J_A = new int[2][];
//     //jagged array
//     J_A[0]=new int[5] {1,3,5,7,9};


// }

// using System.Security.Cryptography;

// namespace Operators
// {
//     class program()
//     {
//         static void Main(string[] args)
//         {
//             operators();
//         }

//         static void operators()
//         {
//             int a = 10;
//             int b = 20;

//             //Arithmetic operators
//             Console.WriteLine(a + b);
//             Console.WriteLine(a - b);
//             Console.WriteLine(a * b);
//             Console.WriteLine(a / b);
//             Console.WriteLine(a % b);

//             //Relational operators
//             Console.WriteLine(a > b);
//             Console.WriteLine(a < b);
//             Console.WriteLine(a <= b);
//             Console.WriteLine(a >= b);
//             Console.WriteLine(a != b);

//             //Assignment Operator
//             Console.WriteLine(a = b);
//             Console.WriteLine(a += 10);
//             Console.WriteLine(a -= 10);
//             Console.WriteLine(a++);
//             Console.WriteLine(a--);
//             Console.WriteLine(a = 19);
//             Console.WriteLine(b);
//             Console.WriteLine(a > b ? b : a);
//             Console.WriteLine(a < b ? a : b);
//             Console.WriteLine(a > b && b > a);
//             Console.WriteLine(a > b || b > a);

//         }


//     }
// }

using System;

class para
{
    static void Main(string[] args)
    {
        string a = "Welcome to Me";
        Console.WriteLine(a);

        string[] b = new string[3];
        b[0] = "dotnet";
        b[1] = "ASP";
        b[2] = "CORE";
        for (int i = 0; i < 3; i++)
            Console.WriteLine(b[i]);

        string abc = b[2] + b[1] + " Good to see";
        Console.WriteLine(abc);
        int t = 100;
        string f = String.Format("{0}{1}{2}", a,"with", t.ToString());
        Console.WriteLine(f);
    }
}