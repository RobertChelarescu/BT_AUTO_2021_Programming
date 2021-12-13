using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Homework2
    {            static void Main(string[] args)
    {
        static bool checkPalindrome(string str)
        {


            int len = str.Length;


            for (int i = 0; i < len / 2; i++)
            {


                if (str[i] != str[len - i - 1])
                    return false;
            }
            return true;
        }

        string st = "2002";


        if (checkPalindrome(st) == true)
            Console.WriteLine("Yes is a palidrome number");
        else
            Console.WriteLine("No, is not a palidrome number");
        Console.WriteLine("****************************");
    }
}
} 
