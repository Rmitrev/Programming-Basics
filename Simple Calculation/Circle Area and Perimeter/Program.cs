using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double circle = double.Parse(Console.ReadLine());
            double circleArea = (Math.PI * circle) * circle;
            double circlePerimeter = (2 * Math.PI) * circle;
            Console.WriteLine("Area = {0}", circleArea);
            Console.WriteLine("Perimeter = {0}", circlePerimeter);
        }
    }
}
