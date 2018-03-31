using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HORASEXTRAS
    {
        //DECLARAMOS LA VARAIBLE
        double SUELDO, PHN = 160, CHE, PHE, MHE, TG;
        string ENTRADA;
        static void Main(string[] args)
        {
            HORASEXTRAS HE = new HORASEXTRAS();
            HE.CALCULAR();

        }
        private void ENTRADAS()
        {
        VUELVE1:
            try
            {
                Console.Write("SUELDO: ");
                ENTRADA = Console.ReadLine();
                SUELDO = double.Parse(ENTRADA);

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

                Console.Write("CANTIDAD DE HORAS EXTRAS: ");
                ENTRADA = Console.ReadLine();
                CHE = double.Parse(ENTRADA);


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

            PHE = (SUELDO / 191);

            if (CHE != 0)
            {

                PHE = PHN * 1.5;

            }


            MHE = CHE * PHE;
            TG = SUELDO + MHE;

            SALIDAS();

        }
        private void SALIDAS()
        {


            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("PRECIO HORAS NORMALES: " + PHN);
            Console.WriteLine();
            Console.WriteLine("SUELDO: " + SUELDO);
            Console.WriteLine();
            Console.WriteLine("CANTIDAD DE HORAS EXTRAS: " + CHE);
            Console.WriteLine();
            Console.WriteLine("PRECIO DE HORAS EXTRAS: " + PHE);
            Console.WriteLine();
            Console.WriteLine("MONTO HORAS EXTRAS: " + MHE);
            Console.WriteLine();
            Console.WriteLine("TOTAL GANADO: " + TG);
            Console.ReadKey();







        }
    }

}