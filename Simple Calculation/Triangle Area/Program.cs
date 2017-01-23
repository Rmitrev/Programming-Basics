using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            float triangleWheight = float.Parse(Console.ReadLine());
            float triangleHeight = float.Parse(Console.ReadLine());
            float triangleArea = (triangleWheight * triangleHeight) / 2;
            Console.WriteLine("{0:f2}",triangleArea);
        }
    }
}
