using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Balance_de_una_cuenta_bancaria
{
    class CUENTAS
    {

        int NUMERO, TRANSC;
        double DEPOSITO, TDEPOSITO, RETIRO, TRETIRO, BALANCE;


        static void Main(string[] args)
        {


            CUENTAS CTA = new CUENTAS();
            CTA.ENTRADAS();

        }
        private void ENTRADAS(){


            TRANSC = 1;
        


            do
            {
                VEN:

                try
                {
                    Console.Write("NUMERO DE TRANSACCIONES: ");
                    TRANSC = int.Parse(Console.ReadLine());


                }
                catch
                {
                    Console.WriteLine("DEBE DIGITAR EL NUMERO DE TRANSACCION, PULSE UNA CUALQUIER TECLA E INTENTELO DE NUEVO");

                    Console.ReadKey();
                    Console.Clear();
                    goto VEN;

                }


                if (TRANSC == 0)
               
                {
                    return;

            }


                VUELVE1:
            try
            {

        Console.WriteLine();
                Console.Write("NUMERO DE CUENTA: ");
                NUMERO = int.Parse(Console.ReadLine());
            }
                catch
            {
      
              Console.WriteLine("DEBE DIGITAR EL NUMERO DE LA CUENTA, PULSE UNA CUALQUIER TECLA E INTENTELO DE NUEVO");
                Console.ReadKey();
                    Console.Clear();
                Console.WriteLine();
                    Console.Write("NUEMERO DE TRANSACCION: ");
                    Console.Write(TRANSC);
               
 
                    goto VUELVE1;


                }
               VUELVE2:
            try
            {

                 Console.WriteLine();
                Console.Write("DEPOSITO: ");
                DEPOSITO = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
                catch
            {
      
                    Console.WriteLine("DEBE DIGITAR EL VALOR, PULSE UNA CUALQUIER TECLA E INTENTELO DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write("NUEMERO DE TRANSACCION: ");
                    Console.Write(TRANSC);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("NUEMERO DE CUENTA: ");
                    Console.Write(NUMERO);
                    Console.WriteLine();
                   
                    
                    goto VUELVE2;

                }
                      VUELVE3:
            try
            {

                 Console.WriteLine();
                Console.Write("RETIRO: ");
                RETIRO = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
                catch
            {
      
                    Console.WriteLine("DEBE DIGITAR EL VALOR, PULSE UNA CUALQUIER TECLA E INTENTELO DE NUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write("NUEMERO DE TRANSACCION: ");
                    Console.Write(TRANSC);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("NUEMERO DE CUENTA: ");
                    Console.Write(NUMERO);
                    Console.WriteLine();

                    Console.Write("DEPOSITO: ");
                    Console.Write(DEPOSITO);
                   Console.WriteLine();
                   
                    
                    goto VUELVE3;

                }
                
        CALCULOS();

            continue;

            //FIN DEL BUCLE DO WHILE
        }
    while (TRANSC != 0);
    
    }private void CALCULOS(){
        
        BALANCE =BALANCE +(DEPOSITO - RETIRO);
    TDEPOSITO = TDEPOSITO + RETIRO;
    TRETIRO = TRETIRO + RETIRO;
        Console.Clear();
    RESULTADOS();

}
private void RESULTADOS()
{       
        
        Console.WriteLine("CUENTA NO: ");
     Console.WriteLine(NUMERO);
     Console.WriteLine();
        
     Console.WriteLine("DEPOSITO ACUMULADOS: "); 
    Console.WriteLine(TDEPOSITO);
    Console.WriteLine();


     Console.WriteLine("RETIROS");
     Console.WriteLine(TRETIRO);
     Console.WriteLine();

     Console.WriteLine("BALANCE: ");
     Console.WriteLine(BALANCE);
     Console.ReadLine();

    }
    }
}