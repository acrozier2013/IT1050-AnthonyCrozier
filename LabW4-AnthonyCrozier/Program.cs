using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW4_AnthonyCrozier
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal dAmount1;
            decimal dAmount2;
            decimal dResult;



            Console.WriteLine("Enter the first number:");
            dAmount1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            dAmount2 = decimal.Parse(Console.ReadLine());
            dResult = dAmount1 + dAmount2;
            Console.WriteLine("{0:C} and {1:C} is {2:C}", dAmount1, dAmount2, dResult);

            int x;
            int y;
            int z;
            decimal dResult2;
            x = 2;
            y = 3;
            z = 4;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            dResult2 = (x + y) * (z + 10);
            Console.WriteLine("({0:C} + {1:C}) * ({2:C} + 10) = {3:C})", x, y, z, dResult);


        
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hellox");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello\\World!");




        }

    }
}
