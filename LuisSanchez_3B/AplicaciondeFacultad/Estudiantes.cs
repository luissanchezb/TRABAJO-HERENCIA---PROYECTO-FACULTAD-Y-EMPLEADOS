using System;
using System.Collections.Generic;
using System.Text;

namespace AplicaciondeFacultad
{
    public class Estudiantes:Persona
    {
        //Propiedades o Caracteristicas de Estudiantes
        public string Cursomatriculado { get; set; }
        public override void Informaciondetallada()
        {
            Console.WriteLine("Cursos Matriculados: " + Cursomatriculado);
        }

        //Metodo de polimorfismo abstracto  de Cambiar Estado Civil
        public override void Cambiarestadocivil()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t  Universidad Laica Eloy Alfaro de Manabi");
            Console.WriteLine("\t\t  Facultad de Ciencias Informaticas");
            Console.WriteLine("\n\t\t      Manta - Manabí - Ecuador\n");
            Console.WriteLine("\t\t\t\t\t  Fecha: " + DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("              Cambio Estado Civil de {0}                  ", Rol);
            Console.WriteLine();
            Console.WriteLine(Nombre + " " + Apellidos + "\nEstado civil actual: " + EstadoCivil);
            Console.WriteLine("\nIngrese nuevo estado civil: ");
            EstadoCivil = Console.ReadLine();
            Console.WriteLine("\nEl cambio ha sido realizado");
        }

        //Metodo de Matriculacion a Nuevo Curso
        public void Matriculaciondeuevocurso()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t   Universidad Laica Eloy Alfaro de Manabi");
            Console.WriteLine("\t\t  Facultad de Ciencias Informaticas");
            Console.WriteLine("\n\t\t      Manta - Manabí - Ecuador\n");
            Console.WriteLine("\t\t\t\t\t  Fecha: " + DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("                     Matricula Nuevo Curso                        ");
            Console.WriteLine();
            Console.WriteLine(Nombre + " " + Apellidos + "\nCurso actual: " + Cursomatriculado);
            Console.WriteLine("\nIngrese un nuevo curso: ");
            Cursomatriculado = Console.ReadLine();
            Console.WriteLine("\nEl estudiantes ha sido matriculado");
        }

    }
}
