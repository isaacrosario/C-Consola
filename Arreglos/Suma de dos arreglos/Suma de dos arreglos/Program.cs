using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Suma_de_dos_arreglos
{
    class VECTORES
    {
       //declaramos una variable tipo entero para usarla como

        int I;

        //declaramos los arreglos A y B  sin especificar la longitud que sera entrada


        int[] A;
        int[] B;
        
        //Declaramos el arreglo C sin especificar la longitud que sera salida
        int[] C;
        
        //declaramos una variable tipo cadena que servira para llenar los arreglos de entradas A y B

        string TEXTO;

        //En este metodo le introducimos datos a los arreglos de entradas
        public void ENTRADAS()
        {
            /*especificamos la longitud de los arreglos A y B. y usamos new para poder usarlo*/

            A = new int[5];
            B = new int[5];

            Console.Write("PROGRAMA QUE SUMA DOS ARREGLOS");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("PRIMER ARREGLO");

            Console.WriteLine();
            Console.WriteLine();
            
            /*Iniciamos un bucle for desde cero hasta la longitud del vector
             que puede ser la de cualquiera de los vectores que es de 5
             
             */


            for (I = 0; I < A.Length; I++)
            {

            VUELVE1:
                try
                {
                    /*par introducir los elementos del vector A*/

                    
                    
                    Console.Write("VECTOR A");
                    Console.Write("(");
                    Console.Write(I);
                    Console.Write("(");



                    /*se introduce el valor como una cadena*/
                    TEXTO = Console.ReadLine();
                    /* y se convierte a entero para almacenarlo en la posicion del arreglos cuya posicion del arreglo esta indicada
                    por el numeros que tiene el contador [I]
                    */

                    A[I] = int.Parse(TEXTO);

                }

                catch
                {





                    Console.WriteLine("ENTRADA INVALIDA");
                    Console.ReadKey();
                    Console.Clear();
                    goto VUELVE1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("VECTOR B");

            for (I = 0; I <= 4; I++)
            {
            VUELVE2:
                try
                {
                    Console.Write("B");
                    Console.Write("(");
                    Console.Write(I);
                    Console.Write("(");
                    //se introduce el valor como una cadena

                    TEXTO = Console.ReadLine();

                    B[I] = int.Parse(TEXTO);

                }

                catch
                {
                    Console.WriteLine("ENTRADA INVALIDA");
                    Console.Clear();
                    goto VUELVE2;

                }
            }
        }



        /* En este metodo usamos un bucle for para efectuar la suma de los vectores A y B  el resultado se coloca en el vector C.
         El contador [I] sirve de subindice e indica la posicion de los elementos empezando desde 0 hasta 4*/

        private void SUMAR()
        
        {
            C=new    int[5];

            for(I = 0; I <= 4; I++)

                C[I] = A[I] + B[I];
                 
        }
    

    //en este metodo mostramos por pantalla los elementos del vector A

    private void MOSTRAR_A()
        {
            Console.WriteLine();
    Console.WriteLine("PRIMER VECTOR");
    
 

    for ( I = 0; I <= 4; I++)

{
       Console.WriteLine((A[I])+ " ");
}
    Console.WriteLine();
    Console.WriteLine();
}


//en este metodo mostramos por pantalla los elementos del vector B

private void MOSTRAR_B()
{

    Console.WriteLine();
    Console.WriteLine("SEGUNDO VECTOR: ");
for ( I = 0; I <= 4; I++)


{

    Console.WriteLine((B[I])+ " ");

}


    Console.WriteLine();
    Console.WriteLine();
        
}
        
//En este metodo mostramos por pantalla los elementos del vector C

private void MOSTRAR_C()
{

    Console.WriteLine();
    Console.WriteLine("RESULTADO: ");
    for (I = 0; I <= 4; I++)

    {



Console.WriteLine((C[I]) + " ");
        
}

    Console.WriteLine();
    Console.WriteLine();
}

//este es el metodo principal


        
        static void Main(string[] args)
        {
//Creamos una instancia de la clase de VECTORES

VECTORES SV = new VECTORES ();

//invocamos los metodos

SV.ENTRADAS ();
SV.SUMAR();
SV.MOSTRAR_A();
SV.MOSTRAR_B();
SV.MOSTRAR_C();

Console.ReadLine();




        }
    }
}