using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parciales_y_calificaciones
{
    class PARCIALES
    {
        static void Main(string[] args)
        {




        
            int I, NOTA, PP, SP, TP, EF;
            string TEXTO;
            for (I = 1; I <= 5; I++)
            {
               
           
            VUELVE:
               
            try
                {
                    Console.WriteLine();
                    Console.Write("DIGITE LA NOTA DEL PRIMER PARCIAL: ");
                    TEXTO = Console.ReadLine();
                    PP = int.Parse(TEXTO);

                }

                catch
                {
                    Console.WriteLine("LA ENTRADA NO ES VALIDA. INTENTE DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    goto VUELVE;

                }
                if (PP > 20)
                {
                    Console.WriteLine("EL VALOR DE TODO LOS PARCIAL NO DEBE SER MAYOR A 20. PULSE UNA TECLA E INTENTE DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    goto VUELVE;
                }


            VUELVE1:
                try
                {
                    Console.WriteLine();
                    Console.Write("DIGITE LA NOTA DEL SEGUNDO PARCIAL: ");
                    TEXTO = Console.ReadLine();
                    SP = int.Parse(TEXTO);

                }

                catch
                {
                    Console.WriteLine("LA ENTRADA NO ES VALIDA. INTENTE DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    goto VUELVE1;

                }
                if (SP > 20)
                {
                    Console.WriteLine("EL VALOR DE TODOS LOS PARCIAL NO DEBE SER MAYOR A 20. PULSE UNA TECLA E INTENTE DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    goto VUELVE1;
                }

            VUELVE2:
                try
                {
                    Console.WriteLine();
                    Console.Write("DIGITE EL TOTAL DE PRACTICAS: ");
                    TEXTO = Console.ReadLine();
                    TP = int.Parse(TEXTO);

                }

                catch
                {
                    Console.WriteLine("LA ENTRADA NO ES VALIDA. INTENTE DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    goto VUELVE2;

                }
                if (TP > 20)
                {
                    Console.WriteLine("EL VALOR DE TODOS LOS PARCIAL NO DEBE SER MAYOR A 20. PULSE UNA TECLA E INTENTE DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    goto VUELVE2;
                }



            VUELVE3:
                try
                {
                    Console.WriteLine();
                    Console.Write("DIGITE LA NOTA DEL EXAMEN FINAL: ");
                    TEXTO = Console.ReadLine();
                    EF = int.Parse(TEXTO);

                }

                catch
                {
                    Console.WriteLine("LA ENTRADA NO ES VALIDA. INTENTE DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    goto VUELVE2;

                }
                if (EF > 40)
                {
                    Console.WriteLine("EL VALOR DE TODOS LOS PARCIAL NO DEBE SER MAYOR A 20. PULSE UNA TECLA E INTENTE DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    goto VUELVE3;
                }

              

    
           
            NOTA = PP + SP + TP + EF;
            
         
           
        



            
            
            
            
            
            
            
            
          //LA OTRA PARTE
            
    
            
            
            
            
            
            
            VUELVE4:
                


                
                if (NOTA > 100)
                {

                    Console.WriteLine("EL VALOR DE LA NOTA NO DEBE SER MAYOR A 100. PULSE UNA TECLA E INTENTE DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();

                    goto VUELVE4;


                }

                if (NOTA >= 90 & NOTA <= 100)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("PRIMER PARCIAL: " + PP);

                    Console.WriteLine();
                    Console.WriteLine("SEGUNDO PARCIAL: " + SP);

                    Console.WriteLine();
                    Console.WriteLine("TOTAL DE PRACTICA: " + TP);

                    Console.WriteLine();
                    Console.WriteLine("EXAMEN FINAL: " + EF);

                    Console.WriteLine();
                    Console.WriteLine("NOTA: " + NOTA);
                    Console.WriteLine();
                    Console.WriteLine("CALIFICACION = A");

                }

                else
                {
                    if (NOTA >= 80 & NOTA <= 90)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("PRIMER PARCIAL: " + PP);

                        Console.WriteLine();
                        Console.WriteLine("SEGUNDO PARCIAL: " + SP);

                        Console.WriteLine();
                        Console.WriteLine("TOTAL DE PRACTICA: " + TP);

                        Console.WriteLine();
                        Console.WriteLine("EXAMEN FINAL: " + EF);

                        Console.WriteLine();
                        Console.WriteLine("NOTA: " + NOTA);
                        
                        Console.WriteLine();
                        Console.WriteLine("CALIFICACION = B");

                    }



                    else
                    {
                        if (NOTA >= 75 & NOTA <= 80)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("PRIMER PARCIAL: " + PP);

                            Console.WriteLine();
                            Console.WriteLine("SEGUNDO PARCIAL: " + SP);

                            Console.WriteLine();
                            Console.WriteLine("TOTAL DE PRACTICA: " + TP);

                            Console.WriteLine();
                            Console.WriteLine("EXAMEN FINAL: " + EF);

                            Console.WriteLine();
                            Console.WriteLine("NOTA: " + NOTA);
                            
                            Console.WriteLine();
                            Console.WriteLine("CALIFICACION = C");

                        }


                        else
                        {

                            if (NOTA >= 70 & NOTA <= 75)
                            {

                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("PRIMER PARCIAL: " + PP);

                                Console.WriteLine();
                                Console.WriteLine("SEGUNDO PARCIAL: " + SP);

                                Console.WriteLine();
                                Console.WriteLine("TOTAL DE PRACTICA: " + TP);

                                Console.WriteLine();
                                Console.WriteLine("EXAMEN FINAL: " + EF);

                                Console.WriteLine();
                                Console.WriteLine("NOTA: " + NOTA);


                                Console.WriteLine();
                                Console.WriteLine("CALIFICACION = D");

                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("PRIMER PARCIAL: " + PP);

                                Console.WriteLine();
                                Console.WriteLine("SEGUNDO PARCIAL: " + SP);

                                Console.WriteLine();
                                Console.WriteLine("TOTAL DE PRACTICA: " + TP);

                                Console.WriteLine();
                                Console.WriteLine("EXAMEN FINAL: " + EF);

                                Console.WriteLine();
                                Console.WriteLine("NOTA: " + NOTA);

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