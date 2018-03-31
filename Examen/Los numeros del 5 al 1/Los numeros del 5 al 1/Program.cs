using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Los_numeros_del_5_al_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("      NUMEROS");
            Console.WriteLine("");
            for (num = 5; num >= 1; num--)
            {

                Console.WriteLine("        " + num);

            }
                Console.ReadKey();
            }
        }
    }
