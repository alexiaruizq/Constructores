using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //para Constructor 1
            Contacto contacto1 = new Contacto();

            contacto.1 Nombre = "Alexia";
            contacto.1 Celular = "(644) 1323465";
            contacto.1 Correo = "alexiaruiz-@hotmail.com";
            //Fin del constructor

            Console.WriteLine("Contacto 1: ");
            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Celular:" + contacto1.Celular );
            Console.WriteLine("Correo: " + contacto1.Correo);

            //Para constructor 2
            Contacto contacto2 = new Contacto("Alexia", "alexiaruiz-@hotmail.com");
            //Fin del constructor 2

            Console.WriteLine("Contacto 2: ");
            Console.WriteLine("Nombre: " + contacto2.Nombre);
            Console.WriteLine("Celular:" + contacto2.Celular);
            Console.WriteLine("Correo: " + contacto2.Correo);

            Console.Read();
        }
    }
}
