using System;
using System.Collections.Generic;

namespace Euler1
{
    class Program
    {
        static long figure = 600851475143;
        static void Main(string[] args)
        {
            // 600 851 475 143

            dilnyk(775147); // перевіряються всі числа до кореня числа 600851475143 
            foreach (long a in dilnyky)
                Console.WriteLine(a);


        }
        static List<long> dilnyky = new List<long>();
        static List<long> dilnyk(long number)
        {
           for(int i = 3; i < number; i ++)
            {
                if (figure % i == 0)
                    if (IsSimple(i))
                        dilnyky.Add(i);



            }



            return dilnyky;
        }

        static bool IsSimple(int number)
        {
            if (number < 1)
                return false;
            if (number == 1)
                return true;
            if (number >= 2)
            {
                for (int i = 2; i < number / 2; i++)
                {
                    if (number % i == 0)
                        return false;
                }
            }
            return true;
        }
    }
}
