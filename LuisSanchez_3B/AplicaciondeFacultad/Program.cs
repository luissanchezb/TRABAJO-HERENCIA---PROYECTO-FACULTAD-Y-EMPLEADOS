using System;
using System.Collections.Generic;

namespace AplicaciondeFacultad
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudiantes estudiantes = new Estudiantes();
            estudiantes.Rol = "Estudiante";
            estudiantes.Nombre = "Luis";
            estudiantes.Apellidos = "Sanchez Briones";
            estudiantes.Id = "1305234576";
            estudiantes.EstadoCivil = "Soltero";
            estudiantes.Cursomatriculado = "Lengua";

            ContratodeProfesores contratoprofesores = new ContratodeProfesores();
            contratoprofesores.Rol = "Profesor Contratado";
            contratoprofesores.Nombre = "Juan";
            contratoprofesores.Apellidos = "Segovia Reyes";
            contratoprofesores.Id = "1305241256";
            contratoprofesores.EstadoCivil = "Casado";
            contratoprofesores.AAdeincorporacion = 2015;
            contratoprofesores.Numerodedespacho = 1;
            contratoprofesores.Departamento = "Informatica";
            contratoprofesores.email = "juanseg@@live.uleam.edu.ec";
            contratoprofesores.NumeroTelefonico = "0965443131";
            contratoprofesores.PrecioHora = 2;
            contratoprofesores.HorasTrabajadas = 200;


            NombramientodeProfesores nombramientoprofesores = new NombramientodeProfesores();
            nombramientoprofesores.Rol = "Profesor por Nombramiento";
            nombramientoprofesores.Nombre = "Marianne";
            nombramientoprofesores.Apellidos = "Saavedra Palma";
            nombramientoprofesores.Id = "1312121268";
            nombramientoprofesores.EstadoCivil = "Casada";
            nombramientoprofesores.AAdeincorporacion = 2020;
            nombramientoprofesores.Numerodedespacho = 2;
            nombramientoprofesores.Departamento = "Ingenieria";
            nombramientoprofesores.PrecioHoras = 3;
            nombramientoprofesores.HorasExtras = 10;
            nombramientoprofesores.SueldoBase = 500;

            PersonaldeServicio personaldeservicio = new PersonaldeServicio();
            personaldeservicio.Rol = "Personal de Servicio";
            personaldeservicio.Nombre = "Leo";
            personaldeservicio.Apellidos = "Messi Cuchitinni";
            personaldeservicio.Id = "1315603368";
            personaldeservicio.EstadoCivil = "Soltero";
            personaldeservicio.AAdeincorporacion = 2018;
            personaldeservicio.Numerodedespacho = 3;
            personaldeservicio.Seccion = "Teatro";

            Profesores profesores = new Profesores();

            List<Persona> listadepersonas = new List<Persona>();
            listadepersonas.Add(estudiantes);
            listadepersonas.Add(contratoprofesores);
            listadepersonas.Add(nombramientoprofesores);
            listadepersonas.Add(personaldeservicio);
            //└ ┘
            int operacion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\tUniversidad Laica Eloy Alfaro de Manabi");
                Console.WriteLine("\t\t  Facultad de Ciencias Informaticas");
                Console.WriteLine("\n\t\t      Manta - Manabí - Ecuador\n");
                Console.WriteLine("\t\t\t\t\t   Fecha: " + DateTime.Now);
                Console.WriteLine();
                Console.WriteLine("                              Menu                                ");
                Console.WriteLine();
                Console.WriteLine(" 1) Cambio del estado civil de una persona                        ");
                Console.WriteLine(" 2) Reasignacion de despacho a un empleado                        ");
                Console.WriteLine(" 3) Matriculacion de un estudiante en un nuevo curso              ");
                Console.WriteLine(" 4) Cambio de departamento de un profesor                         ");
                Console.WriteLine(" 5) Traslado de seccioon de un empleado del personal de servicio  ");
                Console.WriteLine(" 6) Imprimir toda la informacion de cada tipo de individuo        ");
                Console.WriteLine(" 7) Salir                                                         ");
                Console.WriteLine();
                Console.WriteLine("Escoja una opcion: ");
                operacion = int.Parse(Console.ReadLine());
                switch (operacion)
                {
                    case 1:
                        {
                            //aqui desarrollar metodo para cambiar estado civil de una persona
                            Console.Clear();
                            Console.WriteLine("\t\t\t    Universidad Laica Eloy Alfaro de Manabi");
                            Console.WriteLine("\t\t  Facultad de Ciencias Informaticas");
                            Console.WriteLine("\n\t\t      Manta - Manabí - Ecuador\n");
                            Console.WriteLine("\t\t\t\t\t Fecha: " + DateTime.Now);
                            Console.WriteLine();
                            Console.WriteLine("                       Cambio Estado Civil                        ");
                            Console.WriteLine();
                            Console.WriteLine("Cambio de estado Civil a: ");
                            Console.WriteLine("1) Estudiante ");
                            Console.WriteLine("2) Profesores");
                            Console.WriteLine("3) Personal de Servicio");
                            Console.WriteLine("Escoja una opcion: ");
                            int opPersona = int.Parse(Console.ReadLine());
                            switch (opPersona)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        estudiantes.Cambiarestadocivil();
                                        Console.WriteLine();
                                        Console.WriteLine("Presione una tecla para continuar");
                                        Console.ReadKey();

                                    }
                                    break;
                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\t\t      Universidad Laica Eloy Alfaro de Manabi");
                                        Console.WriteLine("\t\t  Facultad de Ciencias Informaticas");
                                        Console.WriteLine("\n\t\t      Manta - Manabí - Ecuador\n");
                                        Console.WriteLine("\t\t\t\t\t  Fecha: " + DateTime.Now);
                                        Console.WriteLine();
                                        Console.WriteLine("                       Cambio Estado Civil                        ");
                                        Console.WriteLine();
                                        Console.WriteLine("1. Profesor por contrato ");
                                        Console.WriteLine("2. Profesor por nombramiento ");
                                        Console.WriteLine("Escoja una opcion: ");
                                        int opProfesor = int.Parse(Console.ReadLine());
                                        if (opProfesor == 1)
                                        {
                                            Console.Clear();
                                            contratoprofesores.Cambiarestadocivil();
                                            Console.WriteLine();
                                            Console.WriteLine("Presione una tecla para continuar");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            if (opProfesor == 2)
                                            {
                                                Console.Clear();
                                                nombramientoprofesores.Cambiarestadocivil();
                                                Console.WriteLine();
                                                Console.WriteLine("Presione una tecla para continuar");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nOpcion no valida");
                                                Console.WriteLine();
                                                Console.WriteLine("Presione una tecla para continuar");
                                                Console.ReadKey();
                                            }
                                        }

                                    }
                                    break;
                                case 3:
                                    {
                                        Console.Clear();
                                        personaldeservicio.Cambiarestadocivil();
                                        Console.WriteLine();
                                        Console.WriteLine("Presione una tecla para continuar");
                                        Console.ReadKey();
                                    }
                                    break;
                            }

                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t   Universidad Laica Eloy Alfaro de Manabi");
                            Console.WriteLine("\t\t  Facultad de Ciencias Informaticas");
                            Console.WriteLine("\n\t\t      Manta - Manabí - Ecuador\n");
                            Console.WriteLine("\t\t\t\t\t  Fecha: " + DateTime.Now);
                            Console.WriteLine();
                            Console.WriteLine("                    Reasignacion de Despacho                      ");
                            Console.WriteLine();
                            Console.WriteLine("1) Profesor ");
                            Console.WriteLine("2) Personal de servicio");
                            Console.WriteLine("Escoja una pcion: ");
                            int opEmpleado = int.Parse(Console.ReadLine());
                            if (opEmpleado == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("\t\t\t  Universidad Laica Eloy Alfaro de Manabi");
                                Console.WriteLine("\t\t  Facultad de Ciencias Informaticas");
                                Console.WriteLine("\n\t\t      Manta - Manabí - Ecuador\n");
                                Console.WriteLine("\t\t\t\t\t  Fecha: " + DateTime.Now);
                                Console.WriteLine();
                                Console.WriteLine("                   Reasignacion de Despacho                      ");
                                Console.WriteLine();
                                Console.WriteLine("1) Profesor por contrato ");
                                Console.WriteLine("2) Profesor por nombramiento ");
                                Console.WriteLine(" Escoja una opcion: ");
                                int opProfesor = int.Parse(Console.ReadLine());
                                if (opProfesor == 1)
                                {
                                    Console.Clear();
                                    contratoprofesores.Reasignaciondedespacho();
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una tecla para continuar");
                                    Console.ReadKey();

                                }
                                else
                                {
                                    if (opProfesor == 2)
                                    {
                                        Console.Clear();
                                        nombramientoprofesores.Reasignaciondedespacho();
                                        Console.WriteLine();
                                        Console.WriteLine("Presione una tecla para continuar");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nOpcion no valida");
                                        Console.WriteLine();
                                        Console.WriteLine("Presione una tecla para continuar");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            else
                            {
                                if (opEmpleado == 2)
                                {
                                    Console.Clear();
                                    personaldeservicio.Reasignaciondedespacho();
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una tecla para continuar");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Opcion no valida");
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una tecla para continuar");
                                    Console.ReadKey();
                                }
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            estudiantes.Matriculaciondeuevocurso();
                            Console.WriteLine();
                            Console.WriteLine("Presione una tecla para continuar");
                            Console.ReadKey();

                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t   Universidad Laica Eloy Alfaro de Manabi");
                            Console.WriteLine("\t\t  Facultad de Ciencias Informaticas");
                            Console.WriteLine("\n\t\t      Manta - Manabí - Ecuador\n");
                            Console.WriteLine("\t\t\t\t\t  Fecha: " + DateTime.Now);
                            Console.WriteLine();
                            Console.WriteLine("                     Cambio de Departamento                       ");
                            Console.WriteLine();
                            Console.WriteLine("1) Profesor por contrato ");
                            Console.WriteLine("2) Profesor por nombramiento ");
                            Console.WriteLine("Opcion: ");
                            int opProfesor = int.Parse(Console.ReadLine());
                            if (opProfesor == 1)
                            {
                                Console.Clear();
                                contratoprofesores.Cambiodedepartamento();
                                Console.WriteLine();
                                Console.WriteLine("Presione una tecla para continuar...");
                                Console.ReadKey();
                            }
                            else
                            {
                                if (opProfesor == 2)
                                {
                                    Console.Clear();
                                    nombramientoprofesores.Cambiodedepartamento();
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una tecla para continuar");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Opcion no valida");
                                    Console.WriteLine();
                                    Console.WriteLine("Presione una tecla para continuar");
                                    Console.ReadKey();
                                }
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            personaldeservicio.trasladoSeccion();
                            Console.WriteLine();
                            Console.WriteLine("Presione una tecla para continuar");
                            Console.ReadKey();

                        }
                        break;
                    case 6:
                        {
                            Console.Clear();
                            foreach (Persona persona in listadepersonas)
                            {
                                Console.WriteLine("" + persona.Rol + "");
                                persona.Mostrar();
                                persona.Informaciondetallada();
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (operacion != 7);



        }
    }
}
