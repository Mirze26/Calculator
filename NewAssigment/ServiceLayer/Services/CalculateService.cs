using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CalculateService : ICalculateService
    {
        public double Calculate(double m, double b, string operation)
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = m + b;
                    return result;

                case "-":
                    result = m - b;
                    return result;


                case "*":
                    result = m * b;
                    return result;


                    case "/":
                    result = m / b;
                    return result;

                    if (m==0)
                    {
                        Console.WriteLine("sifira bolunmur");
                    }
                    return result;
                    
            }
                    return default;
        }        
    }
}
