using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DESCUENTO_POR_CATEGORIA
{
    class DESCUENTOS
    {
        int CATEGORIA;
        string TEXTO;
        double CANTIDAD, PRECIO, SUBTOTAL, DESCUENTO, ITBIS, TOTAL;
        
        
        static void Main(string[] args)
        {

            DESCUENTOS DS = new DESCUENTOS();
            DS.DECISION();



        }
    private void ENTRADAS(){

        try
        {

            Console.Write("CANTIDAD: ");
            TEXTO = Console.ReadLine();
            CANTIDAD = double.Parse(TEXTO);

        }

        catch
        {

            Console.Write("ENTRADA NO VALIDA");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();


            ENTRADAS();

        }
        
        VUELVE:

        try
        {

            Console.WriteLine();
            Console.Write("PRECIO: ");
            TEXTO = Console.ReadLine();
            PRECIO = double.Parse(TEXTO);
            Console.WriteLine();

        }

        catch
        {

            Console.Write("ENTRADA NO VALIDA");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            goto VUELVE;

        
        }

        SUBTOTAL = CANTIDAD * PRECIO;

        DECISION();

    }private void DECISION(){


        MENU();

        try
        {


            Console.WriteLine();
            Console.Write("ESCOJA UNA CATEGORIA: ");
            TEXTO = Console.ReadLine();
            CATEGORIA = int.Parse(TEXTO);
            Console.WriteLine();


        }

        catch
        {



            Console.Write("ENTRADA NO VALIDA");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();


            DECISION();

        }

        switch (CATEGORIA)
        {

            case 0:
                ENTRADAS();

                break;

            case 1:
                DESCUENTO = SUBTOTAL * 0.2;

                CALCULOS();
                break;


            case 2:
                DESCUENTO = SUBTOTAL * 0.15;

                CALCULOS();
                break;




            case 3:
                DESCUENTO = SUBTOTAL * 0.10;

                CALCULOS();
                break;



            case 4:
                DESCUENTO = SUBTOTAL * 0.05;

                CALCULOS();
                break;



            case 5:


                return;

            default:
                Console.WriteLine("ESCOJA UNA CATEGORIA VALIDAD");
                Console.ReadKey();
                Console.Clear();

                DECISION();
                break;

        }
    
    }
        private void CALCULOS()
    {


        ITBIS = (SUBTOTAL - DESCUENTO) * 0.18;
        TOTAL = (SUBTOTAL + ITBIS) - DESCUENTO;

        RESULTADOS();


        }private void MENU(){


            Console.Clear();
            Console.WriteLine("TABLA DE DESCUENTO");
            
            Console.WriteLine();
            Console.WriteLine("0. ENTRADA DE DATOS");
            
            Console.WriteLine();
            Console.WriteLine("1. 20%");

            Console.WriteLine();
            Console.WriteLine("2. 15%");

            Console.WriteLine();
            Console.WriteLine("3. 10%");

            Console.WriteLine();
            Console.WriteLine("4. 5%");
            
            Console.WriteLine();
            Console.WriteLine("5. SALIR");




        }private void RESULTADOS(){



            Console.WriteLine();
            Console.WriteLine("CANTIDAD:" + CANTIDAD);

            Console.WriteLine();
            Console.WriteLine("PRECIO U:" + PRECIO);


            Console.WriteLine();
            Console.WriteLine("SUBTOTAL:" + SUBTOTAL);

            Console.WriteLine();
            Console.WriteLine("DESCUENTO:" + DESCUENTO);

            Console.WriteLine();
            Console.WriteLine("ITBIS:" + ITBIS);

            Console.WriteLine();
            Console.WriteLine("TOTAL:" + TOTAL);
            Console.ReadLine();
            Console.Clear();

            DECISION();
        }
    }
}
