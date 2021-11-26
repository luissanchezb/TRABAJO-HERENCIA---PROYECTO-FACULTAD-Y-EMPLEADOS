using System;
using System.Collections.Generic;
using System.Text;

namespace AplicaciondeFacultad
{
    public class PersonaldeServicio:Empleado
    {
        //Propiedades o Caracteristicas de Personal de Servicio
        public string Seccion { get; set; }

        public override void Informaciondetallada()
        {
            Console.WriteLine("Año de incorporacion: " + AAdeincorporacion + "\t\t\tDesapacho #" + Numerodedespacho);
            Console.WriteLine("Seccion: " + Seccion);
        }

        //Metodo de Traslado de Seccion
        public void trasladoSeccion()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t   Universidad Laica Eloy Alfaro de Manabi");
            Console.WriteLine("\t\t  Facultad de Ciencias Informaticas");
            Console.WriteLine("\n\t\t      Manta - Manabí - Ecuador\n");
            Console.WriteLine("\t\t\t\t\t  Fecha: " + DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("            Traslado Seccion a Personal de Servicio                ");
            Console.WriteLine();
            Console.WriteLine(Nombre + " " + Apellidos + "\nSeccion actual: " + Seccion);
            Console.WriteLine("\nIngrese una nueva seccion: ");
            Seccion = Console.ReadLine();
            Console.WriteLine("\nEl traslado ha sido realizado");
        }
    }
}
