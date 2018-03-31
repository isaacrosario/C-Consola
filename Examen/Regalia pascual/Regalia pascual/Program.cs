using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Regalia_pascual
{
    class DOBLESUELDO
    {
       string TEXTO;
       double SUELDO, MESES, REGALIA, NUEVOSUELDO;
        
        static void Main(string[] args)
        {

  
     
            DOBLESUELDO DS = new DOBLESUELDO();
            DS.CALCULAR();

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
                Console.Write("SUELDO INVALIDO. INTENTELO DE NUEVO: ");
                Console.WriteLine();
                
                Console.ReadKey();
                Console.Clear();
                goto VUELVE1;

            }

        VUELVE2:
            try
            {
                Console.WriteLine();
                Console.Write("CANTIDAD DE MESES DEL EMPLEADO: ");
                TEXTO = Console.ReadLine();
                MESES = double.Parse(TEXTO);


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

        private void CALCULAR()
        {

            ENTRADAS();

            REGALIA = (SUELDO / 12) * MESES;
            NUEVOSUELDO = SUELDO + REGALIA;
           
            SALIDAS();

        }
        private void SALIDAS()
        {


            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("SUELDO: " + SUELDO);
            Console.WriteLine();
            Console.WriteLine("CANTIDAD DE MESES: " + MESES);
            Console.WriteLine();
            Console.WriteLine("REGALIA: " + REGALIA);
            Console.WriteLine();
            Console.WriteLine("NUEVO SUELDO: " + NUEVOSUELDO);
            Console.WriteLine();
           
            Console.ReadKey();







        }
    }

}