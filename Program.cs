using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("select a task (press 0 for exit)\n1. exponentiation of a number\n2. operations with numbers");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > 2)
            {
                Console.WriteLine("incorrect input! Please choose 1 2 or 0");
                continue;
            }

            if (choice == 0) return;

            switch (choice)
            {
                case 1:
                    Exponentiation();
                    break;
                case 2:
                    NumberOperations();
                    break;
            }
        }
    }

    static void Exponentiation()
    {
        Console.WriteLine("enter the number a");
        if (!int.TryParse(Console.ReadLine(), out int numberA))
        {
            Console.WriteLine("incorrect input!");
            return;
        }

        Console.WriteLine("enter the number n");
        if (!int.TryParse(Console.ReadLine(), out int numberN))
        {
            Console.WriteLine("incorrect input!");
            return;
        }

        double result = Math.Pow(numberA, numberN);
        Console.WriteLine("result: " + result);
    }

    static void NumberOperations()
    {
        Console.WriteLine("enter the number x (>= 100)");
        if (!int.TryParse(Console.ReadLine(), out int numberX) || numberX < 100)
        {
            Console.WriteLine("the number must be >= 100");
            return;
        }

        string xStr = numberX.ToString();
        char secondDigit = xStr[1];
        string newX = xStr.Remove(1, 1) + secondDigit;

        Console.WriteLine("result: " + newX);
    }
}

