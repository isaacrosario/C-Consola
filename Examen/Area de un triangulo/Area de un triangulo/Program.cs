using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Area_de_un_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            double B, H, AREA;
           
          VUELVE1:
            try
            {
                Console.WriteLine();
                Console.Write("INGRESA LA BASE: ");

                B = Convert.ToDouble(Console.ReadLine());


            }
            catch
            {
                Console.WriteLine();
                Console.Write("ENTRADA INVALIDA INTENTELO DE NUEVO");
                Console.ReadKey();
                Console.Clear();
                goto VUELVE1;
            }
                
                 VUELVE2:

            try
            {
                Console.WriteLine();
            Console.Write("INGRESA LA ALTURA: ");
           
            H = Convert.ToDouble(Console.ReadLine());           
            
            

            }
            catch
            {
                Console.WriteLine();
                Console.Write("ENTRADA INVALIDA INTENTELO DE NUEVO");
                Console.ReadKey();
                Console.Clear();
                goto VUELVE2;
            }

                AREA = B * H / 2;

                Console.WriteLine();
                Console.WriteLine("AREA: " + AREA);
                Console.ReadKey();
            
            }
        }
    }
