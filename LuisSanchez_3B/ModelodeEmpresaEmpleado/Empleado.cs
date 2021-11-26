using System;
using System.Collections.Generic;
using System.Text;

namespace ModelodeEmpresaEmpleado
{
    public class Empleado
    {
        private string Nombres;
        private string Apellidos;
        private int Edad;
        private string Departamento;


        public Empleado(string nombres, string apellidos, int edad, string departamento)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Departamento = departamento;
        }





        public string getnombre()
        {
            return Nombres;
        }
        public void setnombre(string nombre)
        {
            this.Nombres = nombre;
        }



        public string getapellido()
        {
            return Apellidos;
        }
        public void setapellido(string apellido)
        {
            this.Apellidos = apellido;
        }




        public int getedad()
        {
            return Edad;
        }
        public void setedad(int edad)
        {
            this.Edad = edad;
        }



        public string getdepartamento()
        {
            return Departamento;
        }
        public void setdepartamento(string departamento)
        {
            this.Departamento = departamento;
        }

    }
}
