using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menus_y_subrutinas
{
    class MENUPRI
    {
        static void Main(string[] args)
        {

            int OPCION;
            MENUPRI MP = new MENUPRI();
            ENTRADAS E = new ENTRADAS();
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            do
            {

            VUELVE:

                try
                {


                    Console.Clear();
                    Console.WriteLine("OPERACIONES ARITMETICAS CON ARREGLOS");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("MENU PRINCIPAL");

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("ENTRADA DE DATOS A LOS ARREGLOS");
                    Console.WriteLine();

                    Console.WriteLine("2-SALIDAS");
                    Console.WriteLine();
                    Console.Write("ESCRIBA EL NUMERO DE LA OPCION QUE DESEA: ");


                    OPCION = int.Parse(Console.ReadLine());


                }
                catch
                {


                    Console.WriteLine("DEBE DIGITAR UN VALOR NUMERICO");
                    goto VUELVE;


                }

                //switch se usa para buscar el una expresion a el contenido de una variable.

                switch (OPCION)
                {
                    case 1:
                        E.LLENAR();
                        break;

                    case 2:

                        Console.WriteLine();
                        Console.Write("SE ACABO. PULSE ENTER PARA TERMINAR");
                        Console.ReadKey();

                        return;
                        break;

                    default:

                        Console.WriteLine("ESCOJA UNA CATEGORIA VALIDA");
                        Console.Clear();

                        break;

                }

            } while (OPCION != 7);
            Console.Clear();

        }
    }


    public class ENTRADAS

    {

        //Declaramos una variable tipo entero para usar como contador

        int I;
        //Declaramos una variable tipo cadena que servira para llenar los arreglos A y B

        string TEXTO;

        CALCULOS C = new CALCULOS();

        public int[]A = new int[5];
         public int[]B = new int[5];

        //En este metodo le introducimos datos a los arreglos de entrada


        public void LLENAR()

        {
            Console.Clear();

            /*Especificamos la longitud de los arreglos A y B.
             usamos new para poder usarlo
             */

            Console.WriteLine("VECTOR A");
            Console.WriteLine();

            /*Iniciamos un bucle for bucle desde cero hasta la longitud del vector A
             que puede ser la de cualquiera de los vectores que es de 5
             */


            for (I = 0; I < A.Length; I++)
            {


            VUELVE1:
                try
                {//Para introducir los elementos del vector A

                    Console.Write("A");
                    Console.Write("(");
                    Console.Write(I);
                    Console.Write("(");


                    //Se introduce el valor como una cadena

                    TEXTO = Console.ReadLine();

                    /*Y se convierte a entero para almacenarlo en la posicion del arreglos cuya posicion esta indicada por el
                     numero que tiene el contador [I]
                     */

                    A[I] = int.Parse(TEXTO);
                    C.AC[I] = A[I];

                }

                catch
                {

                    Console.WriteLine("EMTRAD INVALIDA");

                    goto VUELVE1;


                }
            }
            Console.WriteLine();
            Console.WriteLine("VECTOR B");
            for (I = 0; I < B.Length; I++)
            {

            VUELVE2:

                try
                {
                    Console.Write("B");
                    Console.Write("(");
                    Console.Write(I);
                    Console.Write(")");




                    TEXTO = Console.ReadLine();

                    B[I] = int.Parse(TEXTO);
                    C.BC[I] = B[I];


                }

                catch
                {

                    Console.WriteLine("ENTRADA INVALIDA");

                    goto VUELVE2;

                }
            }
                
            



            MOSTRAR_A();
            MOSTRAR_B();
            SUBMENU();


        


        //En este metodo mostramos por pantalla los elementos del vector A

        }public void MOSTRAR_A(){
    
    
    
    

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("PRIMER VECTOR ");

        for(I=0; I<=4; I++)


        {
        Console.Write((A[I])+ "");

        }

    Console.WriteLine();
    Console.WriteLine();

        }

//En este metodo mostramos por pantalla los elemento del vector B

public void MOSTRAR_B()

{




Console.WriteLine();
        Console.WriteLine("SEGUNDO VECTOR ");

        for(I=0; I<=4; I++)


    {
        Console.Write((B[I])+ "");

}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("PULSE CUALQUIER TECLA PARA CONTINUAR");
Console.ReadKey();


}

//En este metodo mostramos por pantalla los elementos del vector C

private void SUBMENU()

{
int OPCION;

    do

    {
    VUELVE:

        try
        {
            Console.Clear();
            Console.WriteLine("MENU OPERACIONES ARITMETICAS CON ARREGLOS");

            Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("1-SUMA");
Console.WriteLine(); 
Console.WriteLine("2-RESTA"); 
Console.WriteLine();
Console.WriteLine("3-MULTIPLICACION");
Console.WriteLine();
Console.WriteLine("4-DIVISION");
Console.WriteLine();
Console.WriteLine("5-POTENCIA");
Console.WriteLine();
Console.WriteLine("6-VOLVER AL MENU PRINCIPAL");
Console.WriteLine();
Console.Write("ESCRIBA EL NUMERO DE LA OPERACION DESEADA:");


            OPCION = int.Parse(Console.ReadLine());

        }

        catch

        {

            Console.WriteLine("DEBE DIGITAR UN VALOR NUMERICO");

            goto VUELVE;

        }
        switch(OPCION)

        {
            case 1:
                C.SUMAR();

                break;
                
            
            case 2:
                C.RESTAR();

                break;
        case 3:

            C.MULTIPLICAR();

                break;




            case 4:

                C.DIVIDIR();

                break;

            case 5:
 C.ELEVAR();
                break;

            case 6:
                Console.WriteLine();
                Console.Write("PULSE ENTER PARA VOLVER AL MENU PRINCIPAL");
                Console.ReadKey();
                return;
                break;
            default:

                Console.WriteLine("ESCOJA UNA CATEGORIA VALIDA");

                Console.Clear();
                break;
        }
    }while (OPCION !=7);
    Console.Clear();

}
    }

    /*En este metodo usamos un buble for para efectuar la suma de los vectores A Y B y el resultado coloca en el vector C.
    El contador [I] sirve de subindice e indica la posicion de los elementos empezando desde 0 hasta 4
     
    En este metodo mostramos por pantalla los elementos del vector A
     
     */


    public class CALCULOS
    
    {
        public int[] AC = new int [5];
        public int[] BC = new int [5];

        public double[] R = new double[5];

        int I;
        public void SUMAR()

    {
        for(I=0; I<=4;I++)


    {

        R[I]= AC[I] + BC[I];

    }

    MOSTRAR_R();

}




//En este metodo mostramos por pantallas los elementos del vector C

public void RESTAR()

{
for(I=0; I<=4; I++)
{

  R[I]= AC[I] - BC[I];
}

    MOSTRAR_R();
}
        public void MULTIPLICAR()

        {


for(I=0; I<=4; I++)

{
 R[I]= AC[I] * BC[I];
}

MOSTRAR_R();

        }
        public void DIVIDIR()
        {


            for(I=0; I<=4; I++)
            
            {

 R[I]= AC[I] / BC[I];

            }

            MOSTRAR_R();
        }
        public void ELEVAR()
    {


for(I=0; I<=4; I++)

{

    R[I]=Math.Pow(AC[I], BC[I]);

}

            MOSTRAR_R();

        }public void MOSTRAR_R(){


        Console.WriteLine();

        Console.WriteLine("RESULTADO: ");



        for(I=0; I<=4; I++)

    {
        Console.WriteLine((R[I]+ ""));


    }


    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.ReadKey();


}

   }
    }


            





























































         


