using System;
using System.Collections.Generic;
using System.Text;

namespace AplicaciondeFacultad
{
    class ContratodeProfesores:Profesores
    {


        //Propiedades o Carcetristicas de Profesores
        public string email { get; set; }
        public string NumeroTelefonico { get; set; }

        //Propiedades o Carcetristicas para Sueldo
        public int HorasTrabajadas { get; set; }
        public double PrecioHora { get; set; }
        public double Sueldototal;

        //Metodo de polimorfismo abstracto de Informacion Detallada
        public override void Informaciondetallada()
        {
            Console.WriteLine("Año de incorporacion: " + AAdeincorporacion + "\t\t\tDesapacho #" + Numerodedespacho);
            Sueldototal = HorasTrabajadas * PrecioHora;
            Console.WriteLine("Sueldo: $ " + Sueldototal + "\t\t\t\t\tDepartamento: " + Departamento);
        }

    }
}
