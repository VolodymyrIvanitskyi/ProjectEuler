using System;
using System.Collections.Generic;

namespace Euler1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            for(int i = 500; i < 1000; i++)
                for(int j = 500; j < 1000; j++)
                {
                    if(IsPolindrome(i*j))
                        Console.WriteLine(i*j);
                }


        }

        static bool IsPolindrome(int number)
        {
            if (number % 10 == number / 100000 && (number % 100)/10 == (number / 10000)%10 && (number % 1000) / 100 == (number / 1000) % 100)
                return true;
            return false;
        }
        
    }
}
