using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad_Practica.Clasess
{

    public abstract class MiembroComunidad

    {
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }


        public virtual void Guardar()
        {
            Console.WriteLine("Guardando");
        }

        public virtual void Modificar()
        {
            Console.WriteLine("Modificando");
        }
        public virtual void Borrar()
        {
            Console.WriteLine("Borrando...");
        }

    }

}
