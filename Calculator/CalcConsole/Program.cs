using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var oper = "";
            double x;
            double y;
            
            var operations = new List<string>()
            {
                "sum", "sub", "div", "sqrt"
            };

            if (args.Length > 0)
            {
                oper = args[0];
                x = Convert.ToDouble(args[1]);
                y = Convert.ToDouble(args[2]);
            } else
            {
                Console.WriteLine("Выберите операцию:");
                foreach (var item in operations)
                {
                    Console.WriteLine(item);
                }

                oper = Console.ReadLine();

                Console.WriteLine("Введите данные в одну строку, разделяя числа пробелом");
                var data = Console.ReadLine().Split(' ').Select(d => Convert.ToDouble(d)).ToArray();
                x = data[0];
                y = data.Length > 1 ? data[1] : 0;
            }

            Double result = double.NaN;
            Calc calc = new Calc();

            switch (oper)
            {
                case "sum":
                    result = calc.Sum(x, y);
                    break;
                case "sub":
                    result = calc.Sub(x, y);
                    break;
                case "div":
                    result = calc.Div(x, y);
                    break;
                case "sqrt":
                    result = calc.Sqrt(x);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{oper}({x}, {y}) = {result}");

            Console.ReadKey();
        }
    }
}
