using System;
using System.Collections.Generic;
using System.Text;

namespace AplicaciondeFacultad
{
   public abstract class Persona
    {
        //Propiedades o Caracteristicas de Persona
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Id { get; set; }
        public string EstadoCivil { get; set; }
        public string Rol { get; set; }



        public virtual void Mostrar()
        {
            Console.WriteLine("Nombre y Apellidos: {0} {1}", Nombre, Apellidos);
            Console.WriteLine("Estado Civil: " + EstadoCivil + "\t\t\t\tId: " + Id);
        }

        //Metodo de polimorfismo abstracto de Informacion Detallada
        public abstract void Informaciondetallada();

        //Metodo de polimorfismo abstracto  de Cambiar Estado Civil
        public abstract void Cambiarestadocivil();



    }
}
