using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace IoCExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer().
                RegisterType<IPrint, PrintOddNumbers>();
            var print = container.Resolve<IPrint>();
            print.PrintNumbers();
            Console.ReadLine();

        }
    }
}
