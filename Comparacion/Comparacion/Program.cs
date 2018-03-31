using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             X == Y
             * X != Y
             * X < Y
               X > Y
             * X <= Y
             * X >= Y
             
             
             
             
             
             
             
             */


            int numero1;
            int numero2;
            Console.Write("Escriba el primer entero: ");
           numero1 = Convert.ToInt32 (Console.ReadLine());
           Console.Write("Escriba el segundo entero: ");
           numero2 = Convert.ToInt32(Console.ReadLine());
            //comparamos los dos valores
           if (numero1 == numero2)
               Console.Write("{0}=={1}", numero1, numero2);

           if (numero1 != numero2)
               Console.Write("{0}!={1}", numero1, numero2);
          
            if (numero1 < numero2)
               Console.Write("{0}< {1}", numero1, numero2);
           
            if (numero1 > numero2)
                Console.Write("{0}>{1}", numero1, numero2);
            if (numero1 <= numero2)
                Console.Write("{0}<={1}", numero1, numero2);
            if (numero1 >= numero2)
                Console.Write("{0}>={1}", numero1, numero2);
            Console.ReadKey();
        }
    }
}
