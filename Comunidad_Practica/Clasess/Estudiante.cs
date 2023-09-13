using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad_Practica.Clasess
{
    public class Estudiante : MiembroComunidad
    {
        public String Matricula { get; set; }
        public String Carrera { get; set; }
        public override void Guardar()
        {
            Console.WriteLine("Guardando Docente...");
        }

        public override void Modificar()
        {
            Console.WriteLine("Modificando Docente...");
        }
        public override void Borrar()
        {
            Console.WriteLine("Borrando Docente...");
        }
    }

}
