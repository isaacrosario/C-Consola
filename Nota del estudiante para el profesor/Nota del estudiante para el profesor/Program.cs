using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nota_del_estudiante_para_el_profesor
{
    class Program
    {
        static void Main(string[] args)
        {

            string TEXTO;
            double NOTA = 0;

            Console.WriteLine();
            Console.Write("ESCRIBA EL NOMBRE DEL ESTUDIANTE: ");
            Console.ReadLine();

            VUELVE:
            try
            {
                Console.WriteLine();
                Console.Write("ESCRIBA LA NOTA DEL ESTUDIANTE: ");
                TEXTO = Console.ReadLine();
                NOTA = double.Parse(TEXTO);
            }

            catch
            {

                Console.Write("ENTRADA INVALIDAD INTETELO DE NUEVO");
                Console.ReadKey();
                Console.Clear();
                goto VUELVE;
            }

            if (NOTA >= 70)
            {
                Console.WriteLine();
                Console.Write("ESTUDIANTE APROBADO");
                Console.ReadKey();
                

            
            }


            else

            {

                Console.WriteLine();
            Console.Write("ESTUDIANTE REPROBADO"); }
            Console.ReadKey();
            




        }
    }
}
