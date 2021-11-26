using System;
using System.Collections.Generic;
using System.Text;

namespace ModelodeEmpresaEmpleado
{
    public class PorHoras:Empleado
    {
        static private float PrecioDeHora = 3f;
        private int HorasTrabajadas;

        public PorHoras(int horasTrabajadas, string nombres, string apellidos, int edad, string departamento) : base(nombres, apellidos, edad, departamento)
        {
            this.HorasTrabajadas = horasTrabajadas;
        }

        public int getHorasTrabajadas()
        {
            return HorasTrabajadas;
        }

        public void setHorasTrabajadas(int horasTrabajadas)
        {
            this.HorasTrabajadas = horasTrabajadas;
        }
        //Metodo

        public float Calcularsueldo()
        {
            float sueldo = PrecioDeHora * HorasTrabajadas;
            return sueldo;
        }
    }
}
