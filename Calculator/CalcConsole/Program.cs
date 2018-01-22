using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var oper = args[0];
            var x = Convert.ToInt64(args[1]);
            var y = Convert.ToInt64(args[2]);

            if (oper == "sum")
            {
                Console.WriteLine($"sum {x} {y} = {x + y}");
            }

            // calc.exe "sum" 1 2
            Console.ReadKey();
        }
    }
}
