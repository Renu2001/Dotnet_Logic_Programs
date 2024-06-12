using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Programs
{
    internal class ArmstrongNumber
    {
        int sum, no, temp;

        public void CheckArmstromg(int num)
        {
            temp = num;
            while( num > 0 )
            {
                no = num % 10;
                num = num / 10;
                sum = sum + (no * no * no);
            }
            if (temp == sum)
                Console.WriteLine("Given Number is Armstrong");
            else
                Console.WriteLine("Given Number is not Armstrong");
        }
    }
}
