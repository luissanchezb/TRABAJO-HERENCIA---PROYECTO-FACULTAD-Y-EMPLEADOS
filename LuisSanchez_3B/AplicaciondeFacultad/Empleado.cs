using System;
using System.Collections.Generic;
using System.Text;

namespace AplicaciondeFacultad
{
    public class Empleado:Persona
    {
        //Propiedades o Caracteristicas de Empleado
        public int AAdeincorporacion { get; set; }
        public int Numerodedespacho { get; set; }

        //Metodo Informacion Detallada
        public override void Informaciondetallada()
        {
            Console.WriteLine("Año de incorporacion: " + AAdeincorporacion + "\t\t\tDespacho #" + Numerodedespacho);
        }


        //Metodo de polimorfismo abstracto  de Cambiar Estado Civil
        public override void Cambiarestadocivil()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t   Universidad Laica Eloy Alfaro de Manabi  ");
            Console.WriteLine("\t\t  Facultad de Ciencias Informaticas");
            Console.WriteLine("\n\t\t      Manta - Manabi - Ecuador\n");
            Console.WriteLine("\t\t\t\t\t  Fecha: " + DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("            Cambio Estado Civil de {0}                  ", Rol);
            Console.WriteLine();
            Console.WriteLine(Nombre + " " + Apellidos + "\nEstado civil actual: " + EstadoCivil);
            Console.WriteLine("\nIngrese un nuevo estado civil: ");
            EstadoCivil = Console.ReadLine();
            Console.WriteLine("\nEl cambio ha sido realizado");
        }

        //Metodo de Resignacion de Despacho
        public void Reasignaciondedespacho()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t   Universidad Laica Eloy Alfaro de Manabi");
            Console.WriteLine("\t\t  Facultad de Ciencias Informaticas");
            Console.WriteLine("\n\t\t      Manta - Manabí - Ecuador\n");
            Console.WriteLine("\t\t\t\t\t  Fecha: " + DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("          Reasignacion Despacho de {0}                  ", Rol);
            Console.WriteLine();
            Console.WriteLine(Nombre + " " + Apellidos + "\nDespacho actual: #" + Numerodedespacho);
            Console.WriteLine("\nIngrese nuevo numero de despacho: ");
            Numerodedespacho = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEl cambio ha sido realizado");
        }


    }
}
