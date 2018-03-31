using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision_segundo_ejercicio
{
    class COMISIONPORVENTA
    {
         //DECLARAR VARIABLE
        double VENTA, SUELDO, COMISION, TG;
       
        string ENTRADA;

            
    
        static void Main(string[] args)
        {

           COMISIONPORVENTA CV = new COMISIONPORVENTA();
            CV.CALCULOS();

            }
        private void ENTRADAS()
        {

        VUELVE1:
        try
    {
             Console.WriteLine();
        Console.Write("INTRODUZCA LA VENTA: ");
        ENTRADA = Console.ReadLine();
        VENTA = double.Parse(ENTRADA);

    }
    catch
{
 Console.Write("ENTRADA INVALIDA. INTENTELO DE NUEVO: ");
    Console.WriteLine();
    Console.Clear();
    Console.ReadKey();
    goto VUELVE1;

}

    VUELVE2:
    try
{
         Console.WriteLine();
         Console.Write("INTRODUZCA SUELDO: ");
        ENTRADA = Console.ReadLine();
        SUELDO = double.Parse(ENTRADA);


}
    catch
{


    Console.Write("ENTRADA INVALIDA. INTENTELO DE NUEVO: ");
    Console.WriteLine();
    Console.Clear();
    Console.ReadKey();
    goto VUELVE2;



}
}

private void CALCULOS()


{

ENTRADAS();

    if(VENTA >= 100000)
    {
        
       COMISION = VENTA * 0.10;
    
    }
    else
    {
    
     COMISION = VENTA * 0.05;
    
    }

    TG = SUELDO + COMISION;
    SALIDAS();

}
    private void SALIDAS()

    
    {



         Console.Clear();
        Console.WriteLine();
          
        
        Console.WriteLine();
          Console.WriteLine("SUELDO: " + SUELDO); 

          Console.WriteLine("VENTA: " + VENTA);
          Console.WriteLine();

          Console.WriteLine("COMISION: " + COMISION);
          Console.WriteLine("TG: " + TG);
        
        
        Console.ReadKey();
}









    
    
        }
}


