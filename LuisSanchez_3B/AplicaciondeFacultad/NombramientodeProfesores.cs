using System;
using System.Collections.Generic;
using System.Text;

namespace AplicaciondeFacultad
{
   public  class NombramientodeProfesores:Profesores
    {

        //Propiedades o Carcetristicas de Nombramiento de Profesores
        public int HorasExtras { get; set; }
        public double PrecioHoras { get; set; }
        public double SueldoBase { get; set; }

        public double sueldoTotal;

        //Metodo de polimorfismo abstracto de Informacion Detallada
        public override void Informaciondetallada()
        {
            Console.WriteLine("Año de Incorporacion: " + AAdeincorporacion + "\t\t\tDesapacho #" + Numerodedespacho);
            sueldoTotal = SueldoBase + (PrecioHoras * HorasExtras);
            Console.WriteLine("Sueldo: $ " + sueldoTotal + "\t\t\t\t\tDepartamento: " + Departamento);
        }

    }
}
