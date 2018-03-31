using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOSTRAR_EL_NUEMERO_MAYOR
{
    class Program
    {
        static void Main(string[] args)
        {


            string TEXTO;
            double A, B, C;

            VUELVE:
            try
            {
                Console.WriteLine();
                Console.Write("ESCRIBA EL PRIMER NUEMRO: ");
                TEXTO = Console.ReadLine();
                A = double.Parse(TEXTO);
            }

            catch
            {

                Console.Write("ENTRADA INVALIDA");
                Console.ReadKey();
                Console.Clear();
                goto VUELVE;


            }


        VUELVE1:
            try
            {
                Console.WriteLine();
                Console.Write("ESCRIBA EL SEGUNDO NUEMRO: ");
                TEXTO = Console.ReadLine();
                B = double.Parse(TEXTO);
            }

            catch
            {

                Console.Write("ENTRADA INVALIDA");
                Console.ReadKey();
                Console.Clear();
                goto VUELVE1;


            }



    VUELVE2:
        try
        {
            Console.WriteLine();
            Console.Write("ESCRIBA EL TERCER NUEMRO: ");
            TEXTO = Console.ReadLine();
            C = double.Parse(TEXTO);
        }

        catch
        {

            Console.Write("ENTRADA INVALIDA");
            Console.ReadKey();
            Console.Clear();
            goto VUELVE2;


        }


    if (A > B & A > C)
    {
        Console.WriteLine();
        Console.Write("EL NUMERO MAYOR ES: " + A);
    Console.ReadKey();
    }



    else
    {


        if (B > A & B > C)

        {
            Console.WriteLine();
            Console.Write("EL NUMERO MAYOR ES: " + B);
        Console.ReadKey();
        }


        else

        {


          
            {
               
                Console.WriteLine();
                Console.Write("EL NUMERO MAYOR ES: " + C);
            Console.ReadKey();

            }
        }



    
    }

        }
    }
}
