using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Isoseles_Escalenos_Equilatero
{
    class Program
    {
        static void Main(string[] args)

            //L = LADO
        {
            int L1, L2, L3;

        VUELVE1:
            try
            {



                Console.WriteLine();
                Console.Write("POR FAVOR INTRODUSCA EL LADO 1: ");



                L1 = int.Parse(System.Console.ReadLine());

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
                Console.Write("POR FAVOR INTRODUSCA EL LADO 2: ");



                L2 = int.Parse(System.Console.ReadLine());

                Console.WriteLine();

            }
            catch
            {

                Console.WriteLine();
                Console.Write("ENTRADA INVALIDA INTENTELO DE NUEVO");
                Console.ReadKey();
                Console.Clear();
                goto VUELVE2;
            }

            VUELVE3:
                try
                {

                    Console.Write("POR FAVOR INTRODUSCA EL LADO 3: ");
                    L3 = int.Parse(System.Console.ReadLine());
                    Console.WriteLine();

                }
                catch
                {

                    Console.WriteLine();
                    Console.Write("ENTRADA INVALIDA INTENTELO DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    goto VUELVE3;

                }

                Console.Write("LOS LADOS SON {0},{1} Y {2}", L1, L2, L3);

                if (L1 == L2 ^ L1 == L2 ^ L2 == L3)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("EL TRIANGULO ES EQUILATERO");//El triángulo es equilatero
                }
                else if ((L1 != L2) ^ (L1 != L3) ^ (L2 != L3))
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("EL TRIANGULO ES ESCALENO"); //El triángulo es escaleno
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("EL TRIANGULO ES ISOSELES"); //El triángulo es isósceles
                }
                Console.ReadLine();
            }
        }
    }
