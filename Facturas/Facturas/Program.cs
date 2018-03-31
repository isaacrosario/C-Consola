using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    class Facturacion
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
            string ARTICULO, TEXTO;
            double CANTIDAD, PRECIO, SUBTOTAL, ITBIS, TOTAL;
            //LLENAR VARIABLES DE ENTRADA
            Console.Write("Digite el articulo");
            ARTICULO = Console.ReadLine();

            Console.Write("Digite el precio");
            TEXTO = Console.ReadLine();
            CANTIDAD = Convert.ToDouble(TEXTO);

            Console.Write("Digite el cantidad: ");
            TEXTO = Console.ReadLine();
            PRECIO = Convert.ToDouble(TEXTO);
            //FIN DEL LLENADO
            //CALCULAR SUBTOTAL, ITBIS, Y TOTAL
            SUBTOTAL = CANTIDAD * PRECIO;
            ITBIS = SUBTOTAL * 0.18;
            TOTAL = SUBTOTAL + ITBIS;
            //MOSTRAR RESULTADOS
            Console.WriteLine("SUBTOTAL: " + SUBTOTAL);
            Console.WriteLine("ITBIS: " + ITBIS);
            Console.WriteLine("TOTAL: " + TOTAL);

            Console.ReadKey();
        }
    }
}