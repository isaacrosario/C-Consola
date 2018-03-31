using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodo_de_burbujas
{
    class ORDENAR
    {
        
        int []A = new int [4];
        int []B = new int [4];

        int PRIMERO, UBICACION, ULTIMO, I;

        
        
        static void Main(string[] args)
        {
      
        
           





        ORDENAR OR = new ORDENAR();
            OR.ENTRADAS();
            OR.ORDENA();
            OR.SALIDA();

    }
    private void ENTRADAS()
    {

        //DECLARACION DE LA VARIABLE
        //Y EL SUPERIOR DEL ARREGLO A LA VARIABLE ULTIMO

        ULTIMO = 4;

        //SE LE ASIGNA EL LIMITE INFERIOR A LA VARIABLE PRIMERO

        PRIMERO = 0;

        for (I=PRIMERO; I <= ULTIMO; I++)
        
        
        {

            try

            {
                
                Console.WriteLine();

                Console.WriteLine("A");

                Console.Write("(");

                Console.Write(I);

                Console.Write(":); ");

                A [I] =  int.Parse(Console.ReadLine());

            }
        
     catch
            {
     
     }

            Console.WriteLine();
        }
    
    
    }private void ORDENA(){

        //MIENTRAS EL CONTENIDO DE LA VARIABLE ULTIMO, QUE ES EL NUMERO DE LA ULTIMA POSICION DEL ARREGLO SEA QUE PERMANEZCA MAYOR QUE EL CONTENIDO DE LA VARIABLE PRIMERO QUE ES LA PRIMERA POSICION
        // O REPETIRAN TODAS LAS ACCIONES CONTENIDAS ENTRE WHILE Y WEND



        do 

        {
        
        // SE ASIGNA NUMEROS DE PRIMERA POSICION A LA VARIABLE 
         //UBICACION QUE SE INCREMENTA HASTA ALCANZAR COMO VALOR EL NUMERO DE LA ULTIMA 
         //POSICION DEL ARREGLO, ENTONCES EL BUCLE FOR QUE ULTIMO Y PRIMERO SERAN IGUALES

            UBICACION = PRIMERO;
        

            //SE INICIA UN BUCLE FOR O PARA CUYO NUMERO DE CICLOS O REPETICIONES SERA DESDE  PRIMERO O EL NUMERO DE LA PRIMERA
            //POSICION DEL ARREGLO HASTA LA ULTIMA POSICION (ULTIMO); MENOS 1.
            //MENOS 1 PARA QUE LA VARIABLE I QUE SIRVE DE CONTADOR DEL CICLO
            //FOR NUNCA QUEDE //FUERA DE RANGO


            for (I = PRIMERO; I < ULTIMO -1; I++)


            {


                //SI EL CONTENIDO DEL ELEMENTO ACTUAL ES MAYOR QUE EL CONTENIDO DEL SIGUENTE ELEMENTO

                if (A[I] > A[I + 1])

                
               
                {
                    //ENTONCES ASIGNA EL VALOR O CONTENIDO DEL SIGUIENTE ELEMENTO AL // ARREGLO B(I); QUE LO USAREMOS TEMPORALMENTE
 
                    B[I] = A[I + 1];


                    //LUEGO COPIA EL CONTENIDO O VALOR DEL ELEMENTO ACTUAL DEL ARREGLO A AL SIGUIENTE ELEMENTO

                    A[I + 1] = A[I];

                    //A CONTINUACION MUEVE EL CONTENIDO DE B(I); AL ELEMENTO ACTUAL DEL //ARREGLO A



                   A[I]= B[I];
                    
                   //FINAL DEL BUCLE FOR

                }

                //SE LE ASIGNA EL VALOR DEL CONTADOR A LA VAIABLE UBICACION

                UBICACION = I;
                //FINALDEL BUCLE FOR


            }



            //SE LE ASIGNA EL VALOR DE LA VARIABLE UBICACION,QUE AL FINALIZAR EL BUCLE FOR TOMARA
            //COMO VALOR EL NUMERO DE LA ULTIMA POSICION DEL ARREGLO QUE SERA // LA MISMA POSICION Y VALOR DE LA VARIABLE PRIMERO
            //ASI LA CONDICION WHILE ULTIMO >PRIMERO YA NO SE MANTENDRA VERDADERA
            ULTIMO = UBICACION;

        }
        while (ULTIMO > PRIMERO);
    }private void SALIDA(){

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("VECTOR ORDENADO");
        Console.WriteLine();
        //SE MUESTRA POR PANTALLA EL VECTOR ORDENADO
        for(I = 0; I<4;I++)

        {
        Console.WriteLine(A[I]);}


Console.ReadKey();


                    





        }
    }
}
