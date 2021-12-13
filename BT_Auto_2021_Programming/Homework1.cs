using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Homework1
    {
        public static void Main(String[] args)

        {
            if (args.Length == 3)
            {
                float a = float.Parse(args[0]);
                float b = float.Parse(args[2]);
                string op = args[1];
            }
            {
                int a = 0; int b = 0;

                Console.WriteLine("Arithmetic calculator");
                Console.WriteLine("**********************\n");

                Console.WriteLine("Type a number, and then press Enter");
                a = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Type another number, and then press Enter");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");

                Console.Write("Your option? ");
                switch (Console.ReadLine())
                {

                    case "a":
                        Console.WriteLine($"Result is: {a} + {b} = " + (a + b));
                        break;
                    case "s":
                        Console.WriteLine($"Result is: {a} - {b} = " + (a - b));
                        break;
                    case "m":
                        Console.WriteLine($"Result is: {a} * {b} = " + (a * b));
                        break;
                    case "d":
                        Console.WriteLine($"Result is : {a} / {b} = " + (a / b));
                        break;
                    default:
                        Console.WriteLine("3 args are needed!");
                        break;
                }

            }
            Console.ReadKey();

            Console.WriteLine("Problem #2 Calculate the sum of the first 100 numbers higher than 0");
            int x, sum = 0;


            Console.WriteLine("\n\n");
            Console.WriteLine("Find the sum of first 100 natural numbers:\n");
            Console.WriteLine("******************************************");
            Console.WriteLine("\n\n");


            Console.WriteLine("The first 100 natural number are:\n");
            for (x = 1; x <= 100; x++)
            {
                sum = sum + x;
                Console.WriteLine("{0}", x);
                Console.WriteLine("\nThe Sum is : {0}\n", sum);
            }
        }
    }
}
