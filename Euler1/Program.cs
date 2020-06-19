using System;

namespace Euler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int figure1 = 1;
            int figure2 = 2;
            int figure3 = figure1 + figure2;
            int sum = figure1 + figure2;

            while ((figure1+figure2) < 4000000)
            {
                figure3 = figure1 + figure2;
                figure1 = figure2;
                figure2 = figure3;
                Console.WriteLine(figure3+", ");
                if (figure3 % 2 == 0)
                    sum += figure3;

            }

            Console.WriteLine($"Sum = {sum}");
        }
    }
}
