using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_from_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int cicleNumbers = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*',cicleNumbers));

            for (int i = 1; i <= cicleNumbers-2; i++)
            {
                Console.Write("*");
                Console.Write(new string(' ',cicleNumbers-2));
                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*',cicleNumbers));
        }
    }
}
