using System;

namespace ExponentiationBySquaring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input base value: ");
            int Ivalue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            int evenresult=1;
            int oddResult = Ivalue;
            while(exponent!=0)
            {
                if ((exponent & 1) == 1)
                    evenresult *= oddResult;//Collect rest odd exponent
                else
                { }
                oddResult *= oddResult;
                exponent=exponent>>1;
            }

            Console.WriteLine($"output: {evenresult}");
        }
    }
}
