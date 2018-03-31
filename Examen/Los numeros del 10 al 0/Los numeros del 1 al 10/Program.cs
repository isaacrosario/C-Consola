using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Los_numeros_del_1_al_10
{
    class Program
    {
        static void Main(string[] args)
        {
      

            //haga un diagrama de flujo que visualice por pantalla los numeros desde 10 hasta el 0
            int num;
            Console.WriteLine(" NUMEROS PARES DEL 10 AL 0");
            Console.WriteLine("");
            for (num = 10; num >= 0; num--)

                if (num % 2 == 0)
            {

                Console.WriteLine("        "+num);
            }

            Console.ReadKey();
            }
    }
}
