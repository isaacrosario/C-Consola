using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision
{
    class comision
    {
        static void Main(string[] args)
        {
            //DECLARA VARIABLE
            string  VENDEDOR, TEXTO;
            double SUELDO, VENTA, TG, COMISION = 0;
            //LLENAR  LAS VARIABLES DE ENTRADA: SUELDO Y VENTA
            Console.Write("Escriba el nombre del vendedor: ");
            VENDEDOR = Console.ReadLine(); // SIRVE PARA QUE ME PERMITA ESCRIBIR EN LA CONSOLA
            VUELVE:

 try
 {

     Console.Write("Digite el sueldo: ");
     TEXTO = Console.ReadLine();
     SUELDO = Convert.ToDouble(TEXTO);
 }
 catch
 {
     Console.Write("Intente de nuevo: ");
     Console.ReadKey();
     Console.Clear();
     goto VUELVE;
 }

 VUELVE2:

 try
 {
     Console.Write("Digite la venta: ");
     TEXTO = Console.ReadLine();
     VENTA = Convert.ToDouble(TEXTO);
     //DECISION
 }

 catch
 {
     Console.Write("Intente de nuevo: ");
     Console.ReadKey();
     Console.Clear();
     goto VUELVE2;
 }
           
            if (VENTA >= 100000)
            {
                
                COMISION = VENTA * 0.10000000;
                //TG = SUELDO = COMISION;
            }
           
            TG = SUELDO + COMISION;
            Console.WriteLine("COMISION: " + COMISION);
            Console.WriteLine("TOTAL GANADO: " + TG);
            Console.ReadKey();




            

        }
    }
}
