using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aumento_de_sueldo
{
    class AUMENTOSUELDO {
       
        //DECLARAR VARIABLE
        double SUELDO, AUMENTO, NUEVOSUELDO;
        int TIEMPO;
        string ENTRADA;

            
    
        static void Main(string[] args)
        {

            AUMENTOSUELDO A = new AUMENTOSUELDO();
            A.CALCULOS();

            }
        private void ENTRADAS()
        {

        VUELVE1:
        try
    {
        Console.WriteLine();
        Console.Write("SUELDO: ");
        ENTRADA = Console.ReadLine();
        SUELDO = double.Parse(ENTRADA);

    }
    catch
{
 Console.Write("SUELDO INVALIDO: ");
    Console.WriteLine();
    Console.ReadKey();
     Console.Clear();
   
    goto VUELVE1;

}

    VUELVE2:
    try
{
         Console.WriteLine();
         Console.Write("AÑOS EN LA EMPRESA: ");
        ENTRADA = Console.ReadLine();
        TIEMPO = int.Parse(ENTRADA);


}
    catch
{


    Console.Write("INTRODUSCA EL TIEMPO. INTENTELO DE NUEVO: ");
    Console.WriteLine();
    Console.ReadKey();
        Console.Clear();
    
    goto VUELVE2;



}
}

private void CALCULOS()


{

ENTRADAS();

    if(TIEMPO >= 5)
    {
        
        AUMENTO = SUELDO * 0.5;
    
    }
    else
    {
    
     AUMENTO = SUELDO * 0.3;
    
    }

    NUEVOSUELDO = SUELDO + AUMENTO;
    SALIDAS();

}
    private void SALIDAS()

    
    {



         Console.Clear();
        Console.WriteLine();
          
        
        Console.WriteLine();
          Console.WriteLine("TIEMPO: " + TIEMPO);

          Console.WriteLine();
          Console.WriteLine("AUMENTO: " + AUMENTO);
          Console.WriteLine();

          Console.WriteLine("NUEVO SUELDO: " + NUEVOSUELDO);
        Console.ReadKey();
}









    
    
        }
}

