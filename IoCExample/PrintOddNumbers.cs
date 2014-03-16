using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCExample
{
    class PrintOddNumbers : IPrint
    {
        public void PrintNumbers()
        {
            Console.WriteLine("1, 3, 5, 7, 9...");
        }
    }
}
