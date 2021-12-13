using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Homework3
    {
        public void Homework3(string[] args)
        {
            bool PrimeNr = true;
            Console.WriteLine("Prime Numbers : ");


            for (int i = 2; i <= 20000; i++)
            {
                for (int j = 2; j <= 20000; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        PrimeNr = false;
                        break;
                    }
                }
                if (PrimeNr)
                {
                    Console.Write("\t" + i);
                }
                PrimeNr = true;
            }
            Console.ReadKey();
        }
    }
}
    
