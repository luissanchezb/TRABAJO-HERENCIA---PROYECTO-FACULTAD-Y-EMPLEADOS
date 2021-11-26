using System;
using System.Collections.Generic;
using System.Text;

namespace ModelodeEmpresaEmpleado
{
    public class Temporal:Empleado
    {
        private DateTime FechaDeIngreso;
        private DateTime FechaDeSalida;
        private int sueldo = 100;

        public Temporal(DateTime FechaDeIngreso, DateTime FechaDeSalida, string nombres, string apellidos, int edad, string departamento) : base(nombres, apellidos, edad, departamento)
        {
            this.FechaDeIngreso = FechaDeIngreso;
            this.FechaDeSalida = FechaDeSalida;
        }

        public DateTime getFechaDeIngreso()
        {
            return FechaDeIngreso;
        }

        public void setFechaDeIngreso(DateTime FechaDeIngreso)
        {
            this.FechaDeIngreso = FechaDeIngreso;
        }
        public DateTime getFechaDeSalida()
        {
            return FechaDeSalida;
        }

        public void setFechaDeSalida(DateTime FechaDeSalida)
        {
            this.FechaDeSalida = FechaDeSalida;
        }

        //Metodos

        public float CalcularSueldo()
        {
            TimeSpan diferenciaDeFechas = FechaDeSalida - FechaDeIngreso;
            int dias = diferenciaDeFechas.Days;
            int meses = dias / 30;
            float totalSueldo = meses * sueldo;
            return totalSueldo;
        }
    }
}
