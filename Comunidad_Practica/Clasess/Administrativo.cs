using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad_Practica.Clasess
{
    public class Administrativo : Empleado
    {
        public String Departamento { get; set; }
        public String Cargo { get; set; }

        public override void Guardar()
        {
            Console.WriteLine("Guardando Empleado Administrativo...");
        }

        public override void Modificar()
        {
            Console.WriteLine("Modificando Empleado Administrativo...");
        }
        public override void Borrar()
        {
            Console.WriteLine("Borrando Empleado Administrativo...");
        }
    }

}
