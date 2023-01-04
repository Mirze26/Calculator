using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAssigment.Controller
{
    public class CalculateController
    {
        public double Calculate()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please write digit");
            Console.ResetColor();
            double m = double.Parse(Console.ReadLine());



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the operation to be performed");
            Console.ResetColor();
            string operation = Console.ReadLine();



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please second write digit");
            Console.ResetColor();
            double b = double.Parse(Console.ReadLine());



            ICalculateService calculateService = new CalculateService();
            var result = calculateService.Calculate(m,b,operation);


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{result}");
            Console.ResetColor();

            return result;
          

        }


    }
}
