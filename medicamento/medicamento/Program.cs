using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicamento
{
    class Program
    {
        static void Main(string[] args)
        {

            MEDICAMENTOS bayaspirina = new MEDICAMENTOS();
            
            Console.WriteLine("Por favor ingrese el nombre del medicamento que desea");
            string nombremedicamento = Console.ReadLine();
            Console.ReadLine();
            bayaspirina.MOSTRARMENSAJE(nombremedicamento);



        }
    }
}
