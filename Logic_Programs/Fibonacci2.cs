using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Programs
{
    public class Fibonacci2
    {
        int no1, no2, no3, count;

        public Fibonacci2()
        {
            no1 = no3 = 0;
            no2 = 1;
        }

        public void FibonacciSeries2()
        {
            Console.WriteLine("Fibonacci with Recursion");
            Console.WriteLine("Till what count you want?");
            count = Convert.ToInt32(Console.ReadLine());
            Console.Write(no1 + " " + no2);
            Countseries(count - 2);

        }

        public void Countseries(int count)
        {
            if (count > 0)
            {
                no3 = no1 + no2;
                Console.Write(" " + no3);
                no1 = no2;
                no2 = no3;
                Countseries(count - 1);
            }
        }
    }
}
