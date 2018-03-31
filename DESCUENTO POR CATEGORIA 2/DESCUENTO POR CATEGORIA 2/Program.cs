using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DESCUENTO_POR_CATEGORIA_2
{
    class DESCUENTOS
    {
       string TEXTO;
           int CATEGORIA;
           double CANTIDAD, PRECIO, SUBTOTAL, DESCUENTO, ITBIS, TOTAL;
        
        
        
        
        static void Main(string[] args)
        {


            DESCUENTOS DS = new DESCUENTOS();
            DS.DECISION();




        }
        private void ENTRADAS()
        {


             
        try
    {
        Console.WriteLine();
        Console.Write("CANTIDAD: ");
        TEXTO = Console.ReadLine();
        CANTIDAD = double.Parse(TEXTO);

    }
    catch
{
 Console.Write("ENTRADA INVALIDA. INTENTELO DE NUEVO ");
    
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine();
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


            Console.Write("ENTRADA INVALIDA. INTENTELO DE NUEVO ");
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
                Console.Write("ESCOJA UNA DE LAS CATEGORIAS PARA EL DESCUENTO: ");
                TEXTO = Console.ReadLine();
                CATEGORIA = int.Parse(TEXTO);
                Console.WriteLine();



            }
            catch
            {



                Console.Write("ENTRADA INVALIDA. INTENTELO DE NUEVO ");
                Console.WriteLine();
                Console.ReadKey();
                DECISION();

            }
            
            if (CATEGORIA ==0)
            
            {
            
            ENTRADAS();
            
            
            
            }

            else
           
            if (CATEGORIA == 1)

            {
                DESCUENTO = SUBTOTAL * 0.2;

            CALCULOS();

        }
    
        else
    
    if (CATEGORIA == 2)
    
    {

       DESCUENTO = SUBTOTAL * 0.15;


     CALCULOS();




}





else
    
    if (CATEGORIA == 3)
    {


       DESCUENTO = SUBTOTAL * 0.10;


     CALCULOS();




}




else
    
    if (CATEGORIA == 4)
    {


       DESCUENTO = SUBTOTAL * 0.05;


     CALCULOS();




}

else

        if (CATEGORIA == 5)
        {

            return;


        }
        else
        {




            Console.WriteLine("ESCOJA UNA CATEGORIA VALIDA");
            Console.ReadLine();
            Console.Clear();
            DECISION();

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
Console.WriteLine();


}private void RESULTADOS(){

Console.WriteLine();
Console.WriteLine("CANTIDAD: " + CANTIDAD);

Console.WriteLine();
Console.WriteLine("PRECIO U: " + PRECIO);

Console.WriteLine();
Console.WriteLine("SUBTOTAL: " + SUBTOTAL);

Console.WriteLine();
Console.WriteLine("DESCUENTO: " + DESCUENTO);

Console.WriteLine();
Console.WriteLine("ITBIS: " + ITBIS);

Console.WriteLine();
Console.WriteLine("TOTAL: " + TOTAL);

Console.ReadLine();
Console.Clear();

DECISION();

}
}
}