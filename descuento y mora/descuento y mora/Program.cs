using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace descuento_y_mora
{
    class descuento_y_mora
    {






        static void Main(string[] args)
        {
            //DES = DESCUENTO MR = MONTO REAL NAP = NETO A PAGAR 

            string ENTRADA;
            double MORA, DES, CUOTA, NAP;
            int FECHA;

            Console.WriteLine();
            Console.Write("INTRODUZCA EL NOMBRE DEL CIENTE: ");
            Console.ReadLine();

        VUELVE1:
            try
            {


                Console.WriteLine();
                Console.Write("CUOTA: ");
                ENTRADA = Console.ReadLine();
                CUOTA = double.Parse(ENTRADA);


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
              Console.Write("ESCRIBA DEL 1 AL 30 DEPENDIENDO EL DIA DEL PAGO : ");
                
              ENTRADA = Console.ReadLine();

              FECHA = int.Parse(ENTRADA);

            }

            catch
            {
                Console.WriteLine("ENTRADA INVALIDA INTENTE DE NUEVO");
                Console.ReadKey();
                Console.Clear();
                goto VUELVE2;
            }




        if (FECHA <= 30)
        {

            DES = CUOTA * 0.1;
               

            NAP = CUOTA - DES;

            Console.WriteLine("CUOTA: " + CUOTA);
            Console.WriteLine("DESCUENTO: " + DES+"%");
            Console.WriteLine("NETO A PAGAR: " + NAP);

            Console.ReadKey();
        }

           else
            {
                MORA = CUOTA * 0.05;


                NAP = CUOTA + MORA;
                //MOSTRAR RESULTADOS



                Console.WriteLine("CUOTA: " + CUOTA);
                Console.WriteLine("MORA: " + MORA);
                Console.WriteLine("NETO A PAGAR: " + NAP);
               
                 Console.ReadKey();


            }
        }
          
        }

                }
    

