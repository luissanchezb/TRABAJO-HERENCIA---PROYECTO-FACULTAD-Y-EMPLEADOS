using System;

namespace ModelodeEmpresaEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {

            string datosEmpleado;


            Fijo empleadoFijo = new Fijo(2019, "Maria", "Sanchez", 25, "Recursos Humanos");

            datosEmpleado = "Nombre: " + empleadoFijo.getnombre() + "\nApellidos: " + empleadoFijo.getapellido() + "\nSueldo:" + empleadoFijo.Calcularsueldo();
            Console.WriteLine(datosEmpleado);
            Console.WriteLine();



            Temporal empleadoTemporal = new Temporal(new DateTime(2008, 5, 1, 8, 30, 52), new DateTime(2020, 4, 17, 7, 15, 03), "Carlos", "Reyes", 25, "Recursos Humanos");
            datosEmpleado = "Nombre: " + empleadoTemporal.getnombre() + "\nApellidos: " + empleadoTemporal.getapellido() + "\nSueldo:" + empleadoTemporal.CalcularSueldo();
            Console.WriteLine(datosEmpleado);


        }
    }
}
