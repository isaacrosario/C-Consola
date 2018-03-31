using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AUMENTO_DEL_GOBIERNO
{
    class AUMENTOS
    {

        int TIEMPO;
        string TEXTO;
        double SUELDO, AUMENTO, NUEVOSUELDO;


        static void Main(string[] args)
        {




            AUMENTOS A = new AUMENTOS();
            A.CALCULOS();

        }
        private void ENTRADAS()
        {

        VUELVE1:
            try
            {
                Console.WriteLine();
                Console.Write("SUELDO: ");
                TEXTO = Console.ReadLine();
                SUELDO = double.Parse(TEXTO);

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
                TEXTO = Console.ReadLine();
                TIEMPO = int.Parse(TEXTO);


            }
            catch
            {


                Console.Write("ENTRADA INVALIDA. INTENTELO DE NUEVO: ");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
               
                goto VUELVE2;



            }
        }

        private void CALCULOS()
        {

            ENTRADAS();

            if (TIEMPO >= 10)
            {

                AUMENTO = SUELDO * 0.40;

            }
            if (TIEMPO >= 5 & TIEMPO < 10)
            {

                AUMENTO = SUELDO * 0.35;

            }

            if (TIEMPO >= 3 & TIEMPO < 5)

                AUMENTO = SUELDO * 0.30;

            if (TIEMPO < 3 )

            AUMENTO = SUELDO * 0.25;



            if (SUELDO < 10000 & TIEMPO >= 1)
             
    
    
            AUMENTO = SUELDO * 0.50;  
            
            NUEVOSUELDO = SUELDO + AUMENTO;
            SALIDAS();

        }
        private void SALIDAS()
        {



            Console.Clear();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("SUELDO: " + SUELDO);

           
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