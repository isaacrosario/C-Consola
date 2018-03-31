using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int I, NOTA;
            string ENTRADA;
            for (I = 1; I <= 5; I++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("DIGITE LA NOTA: ");

            VUELVE:
                try
                {
                    ENTRADA = Console.ReadLine();
                    NOTA = int.Parse(ENTRADA);

                }

                catch
                {
                    Console.WriteLine("LA ENTRADA NO ES VALIDA. INTENTE DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    goto VUELVE;


                }
                if (NOTA > 100)
                {

                    Console.WriteLine("EL VALOR DE LA NOTA NO DEBE SER MAYOR A 100. PULSE UNA TECLA E INTENTE DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();

                    goto VUELVE;


                }

                if (NOTA >= 90 & NOTA <= 100)
                {
                    Console.WriteLine();
                    Console.WriteLine("CALIFICACION = A");

                }

                else
                {
                    if (NOTA >= 80 & NOTA <= 90)
                    {
                        Console.WriteLine();
                        Console.WriteLine("CALIFICACION = B");

                    }



                    else
                    {
                        if (NOTA >= 75 & NOTA <= 80)
                        {
                            Console.WriteLine();
                            Console.WriteLine("CALIFICACION = C");

                        }


                        else
                        {

                            if (NOTA >= 70 & NOTA <= 75)
                            {


                                Console.WriteLine();
                                Console.WriteLine("CALIFICACION = D");

                            }

                            else
                            {


                                Console.WriteLine();
                                Console.WriteLine("CALIFICACION = F");

                                {

                                    Console.ReadKey();


                                }
                            }
                        }
                    }
                }
            }
        }
    }
}