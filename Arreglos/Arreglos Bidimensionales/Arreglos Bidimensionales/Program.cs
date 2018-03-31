using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arreglos_Bidimensionales
{
    
    
    class ARREGLOSBIDIM    
               {int I, J;

        int [,] A = new int [4,4];
         int [,] B = new int [4,4];
         int [,] C = new int [4,4];
         int [] D = new int [4];

        
        static void Main(string[] args)
        {
       
     ARREGLOSBIDIM AB = new ARREGLOSBIDIM ();
        
            
            AB.ENTRADAS();
            AB.VISUALARREGLOS();
            AB.MULTIPLICACION();
            AB.SALIDAMULTIPLICACION();
            AB.SALIDAACUMULADO();
        }

        private void ENTRADAS()

    {
        
        Console.WriteLine("PROGRAMA QUE MULTIPLICA DOS ARREGLOS BIDIMENCIONES Y ACUMULA EL RESULTADO");

            Console.WriteLine();
            Console.WriteLine("PRIMER ARREGLO");
            Console.WriteLine();


        
        for(I=0; I<=4; I++)

        {
            for (J = 0; J <= 4; J++)
            { }
      //  VUELVE:
        try
        {
        Console.WriteLine();
        Console.WriteLine("A(");
            Console.Write(I);
            Console.Write(",");
            Console.WriteLine(J);
            Console.Write(")");
           Console.Write(":");

            A[I,J]= int.Parse(Console.ReadLine());

       //    if (J==4)
      //      {J=0;}


        }catch{

    //    Console.Write("ENTRADA INVALIDA. VUELVA A INTERTARLO");
      // Console.ReadKey();
      // Console.Clear();
        //  goto VUELVE;
        }
        
    

            Console.WriteLine();
            Console.WriteLine("SEGUNDO ARREGLO");
            Console.WriteLine();

            for (I = 0; I<=4;I++)

            {
                
                for (J=0; J<=4;J++)
                {
          //    VUELVE1:

                    {
                        try
                        
                        {



                            Console.WriteLine();
                            Console.Write("B(");
                            Console.Write(I);
                            Console.Write(",");
                            Console.Write(J);
                            Console.Write(")");
                            Console.Write(":");
                            B[I,J] = int.Parse(Console.ReadLine());
                        }catch{


                   //     Console.WriteLine("ENTRADA INVALIDA. INTENTELO DE NUEVO");

//                            goto VUELVE1; 

                        }}}}}



        }private void MULTIPLICACION()
        
        
        {



               for (I=0; I<4;I++)

               {
                      for (J=0; J <=3; J++)

                      {

                          C[I,J] = A [I,J] * B[I,J]; 
                          D[I] = D [I] + C[I,J]; 




                      }}



        //SALIDA ARREGLOS
}private void VISUALARREGLOS(){

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("ARREGLO A");
        Console.WriteLine();

          for (I=0; I<4;I++)

    {


        for (J=0; J<=3;J++)



    {


        Console.Write(A[I,J]+ " ");

    }
    if(J>3)

{

    Console.WriteLine();

}
}    


 Console.WriteLine();
 Console.WriteLine("ARREGLO B");
 Console.WriteLine();

for (I=0; I<4;I++)


{
for (J=0; J<=3;J++)

{


 Console.Write(B[I,J]+ "");

}

if (J>3)

{

Console.WriteLine();

}
}

}private void SALIDAMULTIPLICACION(){


Console.WriteLine();
Console.WriteLine("VECTOR RESULTANTE");
Console.WriteLine();

for (I=0; I<4;I++)

{

for (J=0; J<=3;J++)

{

 Console.Write(C[I,J]+ "");

}
if(J>3)

{

Console.WriteLine();




}}


}private void SALIDAACUMULADO(){



Console.WriteLine();
Console.WriteLine("RESULTADO DEL ACUMULADO");
Console.WriteLine();

for (I=0; I<4;I++)

{
Console.Write(D[I]+ "");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("SE ACABO. PULSE ENTER PARA TERMINAR");
Console.ReadLine();


        
        }
    }
}
