using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 3; count >= 0; count -= 1)


            {
                Console.WriteLine("The value of count is now " + count + " times.");
                Console.ReadKey();
                if (count == 2)
                {
                    return;
                }
            }
            Console.WriteLine("The loop is now finished.");
            Console.ReadKey();
        }
    }
}
