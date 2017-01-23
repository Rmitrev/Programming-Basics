using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            float celsius = float.Parse(Console.ReadLine());
            double farentheit = (celsius * 1.8) + 32;
            Console.WriteLine(farentheit);
        }
    }
}
