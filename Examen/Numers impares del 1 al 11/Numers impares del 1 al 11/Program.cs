using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numers_impares_del_1_al_11
{
    class Program
    {
        static void Main(string[] args)
        {

            /*HAGA UN DIAGRAMA DE FLUJO Y UN PROGRAMA QUE VISUALICE LOS NUMEROS IMPARES DESDE 1 HASTA EL 11 Y LOS ACUMULES */
            
            
            
           
            
            int num;
            Console.WriteLine("      NUMEROS");
            Console.WriteLine();
            for (num = 1; num <= 11; num++)

                if (num % 2 != 0)
                {

                    Console.WriteLine("        " + num);


                    Console.ReadKey();






                }




        }
    }
}