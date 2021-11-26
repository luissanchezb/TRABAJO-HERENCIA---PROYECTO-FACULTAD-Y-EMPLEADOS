using System;
using System.Collections.Generic;
using System.Text;

namespace AplicaciondeFacultad
{
    //Propiedades o Caracteristicas de Profesores
    public class Profesores:Empleado
    {
        public string Departamento { get; set; }


        //Metodo de Cambio de Departamento
        public void Cambiodedepartamento()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t   Universidad Laica Eloy Alfaro de Manabi");
            Console.WriteLine("\t\t  Facultad de Ciencias Informaticas");
            Console.WriteLine("\n\t\t      Manta - Manabí - Ecuador\n");
            Console.WriteLine("\t\t\t\t\t  Fecha: " + DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("             Cambio Departamento de {0}                  ", Rol);
            Console.WriteLine();
            Console.WriteLine(Nombre + " " + Apellidos + "\nDepartamento actual: " + Departamento);
            Console.WriteLine("\nIngrese un nuevo departamento: ");
            Departamento = Console.ReadLine();
            Console.WriteLine("\nEl cambio ha sido realizado");
        }
    }
}
