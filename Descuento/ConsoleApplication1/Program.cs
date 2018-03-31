using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DESCUENTOPORCATEGORIA
    {
        string TEXTO;
        int CTG;
        double DESCUENTO, VENTA, SUBTOTAL, ITBIS, TOTAL;

      
        static void Main(string[] args)
       
        {
            //DECLARAR VARIABLES
            // DESCUENTOPORCATEGORIA = DCP
       
           DESCUENTOPORCATEGORIA DCP = new DESCUENTOPORCATEGORIA(); 
       DCP.CALCULAR();
        }
        

        private void ENTRADAS()
        
     {

            
            Console.Write("NOMBRE DEL CLIENTE: ");
            TEXTO = Console.ReadLine();
           
            
            VUELVE1:
            try
            {
                Console.Write("CATEGORIA: ");
                TEXTO = Console.ReadLine();
                CTG = int.Parse(TEXTO);
            }

            catch
            {

                Console.Write("INTENTELO DE NUEVO: ");
                Console.ReadKey();
                Console.Clear();
                goto VUELVE1;
            }
            VUELVE2:
            try
            {
                Console.Write("VENTA: ");
                TEXTO = Console.ReadLine();
                VENTA = double.Parse(TEXTO);

            }
            catch
            {

                Console.Write("INTENTE DE NUEVO: ");
                Console.ReadKey();
                Console.Clear();
                goto VUELVE2;

            }


        }private void CALCULAR(){


            ENTRADAS();

            if (CTG == 1)
            {

                /*PARA HACER DESCUENTO:
                
                Si el descuento que queremos calcular es del 40%, deberás dividir 40/100 = 0,4
                 
               
                Si el precio original es de 120€, la operación a realizar será 120 x 0,4 = 48€
                
                
                Si 48€ es el 40% de descuento de 120€, para encontrar el precio final debemos restar 
                
                la cantidad menor a la mayor: 120-48 = 72€
                
                
                 */

                DESCUENTO = VENTA * 0.20;
                ITBIS = 0.18;

                


                SUBTOTAL = VENTA - DESCUENTO;
                ITBIS = SUBTOTAL * 0.18;
                TOTAL = SUBTOTAL + ITBIS;
                //MOSTRAR RESULTADOS
            
                
           
                Console.WriteLine("CTG: " + CTG);
                Console.WriteLine("SUBTOTAL: " + SUBTOTAL);
                Console.WriteLine("DESCUENTO: " + DESCUENTO);
                Console.WriteLine("ITBIS: " + ITBIS);
                Console.WriteLine("TOTAL: " + TOTAL);
                
                Console.ReadKey();
            }

            else
        {

            DESCUENTO = 0;





            SUBTOTAL = VENTA - DESCUENTO;
            ITBIS = SUBTOTAL * 0.18;
            TOTAL = SUBTOTAL + ITBIS;
            //MOSTRAR RESULTADOS
           
               
                
                Console.WriteLine("CTG: " + CTG);
            Console.WriteLine("SUBTOTAL: " + SUBTOTAL);
            Console.WriteLine("DESCUENTO: " + DESCUENTO);
            Console.WriteLine("ITBIS: " + ITBIS);
            Console.WriteLine("TOTAL: " + TOTAL);
            
            Console.ReadKey();

        }
        }
    }
}
