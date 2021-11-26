using System;
using System.Collections.Generic;
using System.Text;

namespace ModelodeEmpresaEmpleado
{
    public class Fijo:Empleado
    {
        private int AñoDeEntrada;
        static private float sueldomensual = 425;
        private int mesesTrabajados;


        public Fijo(int AñoDeEntrada, string apellidos, string nombres, int edad, string departamento) : base(apellidos, nombres, edad, departamento)
        {
            this.AñoDeEntrada = AñoDeEntrada;
        }



        public int getAñoDeEntrada()
        {
            return AñoDeEntrada;
        }
        public void setañodeEntrada(int AñoDeEntrada)
        {
            this.AñoDeEntrada = AñoDeEntrada;
        }
        public int getmesesTrabajados()
        {
            return mesesTrabajados;
        }
        public void setmesesTrabajados(int mesesTrabajados)
        {
            this.mesesTrabajados = mesesTrabajados;
        }
        //metodo............

        public float Calcularsueldo()
        {
            float sueldo = mesesTrabajados * sueldomensual;
            return sueldo;
        }
    }
}
