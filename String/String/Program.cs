using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string [] args)
        {
            
            string ejemplo = "Hola bienvenidos a programando en C#"; 
            int tam = ejemplo.Length;
            string subcad = "venidos";
            if(ejemplo.Contains(subcad))
                Console.WriteLine("{0} se encuentra en la frase: {1}", subcad,ejemplo);
            Console.WriteLine("bien se encuentra en la posicion {0}",ejemplo.IndexOf("bien"));
 
           Console.WriteLine("do se encuentra por ultima vez en la posicion {0}", ejemplo.LastIndexOf("do"));
           Console.WriteLine("Mayuscula: {0}",ejemplo.ToUpper());
           Console.WriteLine("Minuscula: {0}",ejemplo.ToLower());
           Console.WriteLine("Hemos insertado amigo en la frase: {0}", ejemplo.Insert(5, "amigos "));
           Console.WriteLine("Hemos removido inico en la frase: {0}",ejemplo.Remove(0,5));
           Console.WriteLine("Hemos remplazado \"hola\" por \"que tal\": {0}", ejemplo.Replace("Hola", "Que tal"));
           

            //NOTA: los \ son para mostrar entre "" esas frases
            Console.ReadKey();
        
        
        }
    }
}