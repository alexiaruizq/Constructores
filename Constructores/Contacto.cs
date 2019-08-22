using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        //Los constructores siempre llevan el nombre de la clase
        public Contacto()
        {
            Nombre = "No name";
            Celular = "No Cellphone";
            Telefono = "Unaviable";
            Correo = "Not found";
            Direccion = "Unknown";

        }

        //Contructor de parametros 
        public Contacto(string nombre, string correo)
        {
            //Variable parametro
            Nombre = nombre;
            Correo = correo;
            Celular = "No cellphone";
            Direccion = "Unkown";
            Telefono = "Unaviable";

        }
        //no se puede hacer otro constructor que tenga dos strings porque ya esta arriba, tienen que ser mas
        public Contacto(string nombre, string correo, string celular, string direccion, string telefono);
        
}
}

