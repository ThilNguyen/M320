using System;
using System.Reflection.Metadata.Ecma335;

namespace Functions
{
    class MyMath
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calc_ggT(111, 123));
            Console.ReadKey();
        }


        static int Calc_ggT(int a, int b)
        {

            while (b != 0)
            {
                int z = a % b;
                a = b;
                b = z;
            }

            return a;
        }

        static int Calc_kgV(int a, int b)
        {
           Calc_ggT(a, b) * Calc_kgV(a, b) = a * b;

        }
        
    }
}