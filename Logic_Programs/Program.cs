namespace Logic_Programs
{
    internal class Program
    {
        public static int GetValue()
        {
            Console.Write("\nEnter the Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        static void Main(string[] args)
        {
            /*Fibonacci f1 = new Fibonacci();
            f1.FibonacciSeries();*/

             /*Fibonacci2 f2 = new Fibonacci2();
             f2.FibonacciSeries2();
            */

            
            ArmstrongNumber a1 = new ArmstrongNumber();
            a1.CheckArmstromg(GetValue());


        }
    }
}
