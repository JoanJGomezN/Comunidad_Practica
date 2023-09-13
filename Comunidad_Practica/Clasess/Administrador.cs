using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad_Practica.Clasess
{
    public class Administrador : Docente
    {
        public String CarreraACargo { get; set; }
        public override void Guardar()
        {
            Console.WriteLine("Guardando Docente Administrador...");
        }

        public override void Modificar()
        {
            Console.WriteLine("Modificando Docente Administrador...");
        }
        public override void Borrar()
        {
            Console.WriteLine("Borrando Docente Administrador...");
        }
    }

}
