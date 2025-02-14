using System;

class Program
{
    static void Main()
    {
        int choice;

        while (true)
        {
            Console.WriteLine("select a task (press 0 for exit)\n1. exponentiation of a number\n2. operations with numbers");

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 2)
            {
                Console.WriteLine("incorrect input! Please choose 1 2 or 0");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter the number a");
                    int numberA = int.Parse(Console.ReadLine());

                    Console.WriteLine("enter the number n");
                    int numberN = int.Parse(Console.ReadLine());

                    if (numberN == 0)
                    {
                        Console.WriteLine("result: " + 1);
                        return;
                    }

                    double result = 1;
                    if (numberN > 0)
                    {
                        for (int i = 0; i < numberN; i++)
                        {
                            result *= numberA;
                        }
                    }

                    if (numberN < 0)
                    {
                        for (int i = 0; i < -numberN; i++)
                        {
                            result *= numberA;
                        }
                        result = 1 / result;
                    }

                    Console.WriteLine("result: " + result);
                    return;
                case 2:
                    Console.WriteLine("enter the number x");
                    int numberX = int.Parse(Console.ReadLine());
                    if (numberX > 99)
                    {
                        string xStr = numberX.ToString();
                        
                        char secondDigit = xStr[1];
                        string newX = xStr.Remove(1, 1);
                        
                        string nStr = newX + secondDigit;
                        int numbern = int.Parse(nStr);
                        
                        Console.WriteLine("result: " + numbern);
                    }
                    else
                    {
                        Console.WriteLine("the number must be > or = 100");
                    }
                    return;
                case 0:
                    return;
            }
        }
    }
}
