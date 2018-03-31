using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notas_de_un_estudiantes
{
    class NOTADEUNESTUDIANTE
    {
    
           string TEXTO;
            double NOTA1, NOTA2, NOTA3, NOTA4, NOTA, PROMEDIO;
        
    
        
        static void Main(string[] args)
        {
            

           
            NOTADEUNESTUDIANTE NDE = new NOTADEUNESTUDIANTE();
            NDE.CALCULOS();
            
        
            

        }private void ENTRADAS()
        {


            Console.WriteLine();
            Console.Write("ESCRIBA EL NOMBRE DEL ESTUDIANTE: ");
            Console.ReadLine();
            
            
            
            VUELVE1:
            try
            {
                Console.WriteLine();
                Console.Write("ESCRIBA LA  PRIMERA NOTA: ");
                TEXTO = Console.ReadLine();
                NOTA1 = double.Parse(TEXTO);

            }
            catch
            {
                Console.WriteLine("ENTRADA INVALIDA. INTENTE DE NUEVO");
                Console.ReadKey();
                Console.Clear();
                goto VUELVE1;

            }
                VUELVE2:
          
            
                
                
                try
            {
                Console.WriteLine();
                    Console.Write("ESCRIBA LA  SEGUNDA NOTA: ");
                TEXTO = Console.ReadLine();
                NOTA2 = double.Parse(TEXTO);

            }
            catch
            {
                Console.WriteLine("ENTRADA INVALIDA. INTENTE DE NUEVO");
                Console.ReadKey();
                Console.Clear();
                goto VUELVE2;

            }


                VUELVE3:
            try
            {
                Console.WriteLine();
                Console.Write("ESCRIBA LA  TERCERA NOTA: ");
                TEXTO = Console.ReadLine();
                NOTA3 = double.Parse(TEXTO);

            }
            catch
            {
                Console.WriteLine("ENTRADA INVALIDA. INTENTE DE NUEVO");
                Console.ReadKey();
                Console.Clear();
                goto VUELVE3;


            }
                VUELVE4:
                try
                {
                    Console.WriteLine();
                    Console.Write("ESCRIBA LA  CUARTA NOTA: ");
                    TEXTO = Console.ReadLine();
                    NOTA4 = double.Parse(TEXTO);

                }
                catch
                {
                    Console.WriteLine("ENTRADA INVALIDA. INTENTE DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    goto VUELVE4;
                }
                
                
                }private void CALCULOS(){
                
                    
                  
                  
                     ENTRADAS();

                     NOTA = NOTA1 + NOTA2 + NOTA3 + NOTA4;


                     PROMEDIO = NOTA / 4; 
                    
                    if (PROMEDIO > 70)
                     {
                         



                         Console.Clear();
                         Console.WriteLine();
                         Console.WriteLine("PRIMERA NOTA: " + NOTA1);
                         Console.WriteLine();
                         Console.WriteLine("SEGUNDA NOTA: " + NOTA2);
                         Console.WriteLine();
                         Console.WriteLine("TERCERA NOTA: " + NOTA3);
                         Console.WriteLine();
                         Console.WriteLine("CUARTA NOTA: " + NOTA4);
                         Console.WriteLine();
                         Console.WriteLine("PROMEDIO: " + PROMEDIO);
                         Console.WriteLine();
                         Console.Write("ESTUDIANTE PROMOVIDO");
                         Console.ReadKey();
                     }

                     else
                     
                   
                  


                         Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("PRIMERA NOTA: " + NOTA1);
                        Console.WriteLine();
                        Console.WriteLine("SEGUNDA NOTA: " + NOTA2);
                        Console.WriteLine();
                        Console.WriteLine("TERCERA NOTA: " + NOTA3);
                        Console.WriteLine();
                        Console.WriteLine("CUARTA NOTA: " + NOTA4);
                        Console.WriteLine();
                        Console.WriteLine("PROMEDIO: " + PROMEDIO);
                        Console.WriteLine();
                        Console.Write("ESTUDIANTE REPROBADO");
                         Console.ReadKey();

                        
                }
                
        }
    }

