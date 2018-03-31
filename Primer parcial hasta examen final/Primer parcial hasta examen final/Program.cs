using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primer_parcial_hasta_examen_final
{
    class PARCIALES

    { 
            double PP, SP, TP, EF, NOTA;
            string TEXTO;
       
           
        static void Main(string[] args)
        {
            
           PARCIALES P = new PARCIALES();
            P.CALCULOS();
           
        } private void ENTRADAS(){

            VUELVE:
               
            try
                {
                    Console.WriteLine();
                    Console.Write("DIGITE LA NOTA DEL PRIMER PARCIAL: ");
                    TEXTO = Console.ReadLine();
                    PP = double.Parse(TEXTO);

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
                    SP = double.Parse(TEXTO);

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
                    TP = double.Parse(TEXTO);

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
                    EF = double.Parse(TEXTO);

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

              

        } private void CALCULOS(){

            ENTRADAS();
           
            NOTA = PP + SP + TP + EF;
            
         
           
        

             SALIDAS();


            }
        private void SALIDAS()
        {
            
            Console.Clear();
            Console.WriteLine("PRIMER PARCIAL: " + PP);
            
            Console.WriteLine();
            Console.WriteLine("SEGUNDO PARCIAL: " + SP);
           
            Console.WriteLine();
            Console.WriteLine("TOTAL DE PRACTICA: " + TP);

            Console.WriteLine();
            Console.WriteLine("EXAMEN FINAL: " + EF);

            Console.WriteLine();
            Console.WriteLine("NOTA: " + NOTA);
            Console.ReadKey();


        }
            }

            }
        
 