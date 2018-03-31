using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CURSO
    {
        static void Main(string[] args)
        {
            /*operadores matematicos
             
             + suma var1+var2
             * - Resta var1-var2
             * Multiplicacion var1*var2
             * divicion / var1/var2
             * residuo % var1%var2
             * 
             * */
             //se ordenan asi: primero * / % + -
            
             
             
             
         
           
   
    //declaramos variable        
    int numero1;
    int numero2;
    int suma;
    Console.Write("Escriba el primer numero entero:"); //covertimos la cadena
    numero1 = Convert.ToInt32 (Console.ReadLine()); // lee la informacion
    Console.Write("Escriba el segundo numero entero:");
    numero2 = Convert.ToInt32(Console.ReadLine());
    suma = numero1 + numero2;
    Console.WriteLine("la suma es {0}", suma);
    Console.ReadKey();
        }
    }
}
