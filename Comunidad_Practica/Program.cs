using Comunidad_Practica.Clasess;
using System;


namespace Comunidad_Practica
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Empleado emp1 = new Empleado();

                emp1.Nombres = "Joan Jesus";
                emp1.Apellidos = "Gomez Nuñez";
                emp1.Telefono = "809-767-6809";
                emp1.Correo = "joansito@gmail.com";
                emp1.Codigo = "1";
                Console.WriteLine("Nombres: " + emp1.Nombres);
                Console.WriteLine("Apellidos: " + emp1.Apellidos);
                Console.WriteLine("Telefono: " + emp1.Telefono);
                Console.WriteLine("Correo: " + emp1.Correo);
                Console.WriteLine("Codigo: " + emp1.Codigo);
                emp1.Guardar();

                Administrador admin1 = new Administrador();
                admin1.CarreraACargo = "Desarrollo de Software";
                Console.WriteLine("Carrera a cargo:" + admin1.CarreraACargo);
                admin1.Guardar();

                Maestro maestro1 = new Maestro();
                maestro1.Nombres = "Francis";
                maestro1.Apellidos = "Ramirez";
                maestro1.Materia = "Programacion 2";
                maestro1.Horario = "Sabados 9-1";
                Console.WriteLine("Nombres: " + maestro1.Nombres);
                Console.WriteLine("Apellidos: " + maestro1.Apellidos);
                Console.WriteLine("Materia: " + maestro1.Materia);
                Console.WriteLine("Horario: " + maestro1.Horario);
                maestro1.Guardar();
                maestro1.Borrar();
            }
        }

    }

