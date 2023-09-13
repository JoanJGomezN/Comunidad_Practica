using System;


namespace Comunidad_Practica.Clasess
{
    public class Maestro : Docente
    {
        public string Materia { get; set; }
        public string Horario { get; set; }

        public override void Guardar()
        {
            Console.WriteLine("Guardando Maestro...");
        }

        public override void Modificar()
        {
            Console.WriteLine("Modificando Maestro...");
        }
        public override void Borrar()
        {
            Console.WriteLine("Borrando Maestro...");
        }
    }

}
