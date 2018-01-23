using CalcConsole;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Double result = double.NaN;
            Calc calc = new Calc();
            var oper = "";
            var data = new List<string>();

            var operations = calc.GetOperationNames();

            if (args.Length > 0)
            {
                oper = args[0];
                data.AddRange(new[] { args[1], args[2] });
            }
            else
            {
                Console.WriteLine("Выберите операцию:");
                foreach (var item in operations)
                {
                    Console.WriteLine(item);
                }

                oper = Console.ReadLine();

                Console.WriteLine("Введите данные в одну строку, разделяя числа пробелом");
                data = Console.ReadLine().Split(' ').ToList();
            }
            
            result = calc.Exec(oper, data.ToArray());

            Console.WriteLine($"{oper}({string.Join(", ", data)}) = {result}");

            Console.ReadKey();
        }
    }
}
