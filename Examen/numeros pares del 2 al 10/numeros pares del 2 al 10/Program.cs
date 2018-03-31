using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numeros_pares_del_2_al_10
{
    class Program
    {
        static void Main(string[] args)
        {

            /*HAGA UN DIAGRAMA DE FLUJO Y UN PROGRAMA QUE ACEPTE POR EL TECLADO SOLAMENTE LOS NUMEROS PARES DEL 2 AL 10 
             Y CALCULE EL ACUMULADO
             
             */
            int num;
            Console.WriteLine("      NUMEROS");
            Console.WriteLine();
            for (num = 2; num <= 10; num++)

                if (num % 2 == 0)
                {

                    Console.WriteLine("        " + num);


                    Console.ReadKey();






                }




        }
    }
}