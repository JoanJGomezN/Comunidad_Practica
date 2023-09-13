using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad_Practica.Clasess
{
    public class Empleado : MiembroComunidad
    {
        public String Codigo { get; set; }

        public override void Guardar()
        {
            Console.WriteLine("Guardando Empleado...");
        }

        public override void Modificar()
        {
            Console.WriteLine("Modificando Empleado...");
        }
        public override void Borrar()
        {
            Console.WriteLine("Borrando Empleado...");
        }
    }

}
