using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto05_For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<=5; i++)
            {
                if (i == 3)
                {
                    break;
                }

                Console.WriteLine("{0}", i);
            }

            Console.ReadLine();
        }
    }
}
