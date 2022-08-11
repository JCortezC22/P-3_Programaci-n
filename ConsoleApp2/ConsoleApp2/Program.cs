using System;
using static System.Console;
namespace ListaDeAlumnos_Arreglo_
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int codigo;
            string carrera;
            int longitud, indice = 0, indiceEdit, opc, menu = 1;
            try
            {

                Console.WriteLine("Ingrese el tamaño de la lista de estudiantes (Multiplo de 4)");
                longitud = Convert.ToInt32(ReadLine());
                string[] RegEstudiante = new string[longitud]; //Define el tamaño

                while (menu != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" 1-Registrar nuevo estudiante " +
                        "\n 2-Mostrar lista de estudiantes " +
                        "\n 3-Buscar un estudiante " +
                        "\n 4-Editar registro de estudiante" +
                        "\n 5-Eliminar registro de estudiante" +
                        "\n 6-Salir del programa");

                    opc = Convert.ToInt32(ReadLine());
                    Console.ResetColor();

                    switch (opc)
                    {
                        // Insertar nuevo registro de estudiante
                        case 1:
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Ingrese el nombre \n");
                                Console.ResetColor();
                                nombre = ReadLine();


                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Ingrese el apellido \n");
                                Console.ResetColor();
                                apellido = ReadLine();

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Ingrese el codigo del estudiante por favor \n");
                                Console.ResetColor();
                                codigo = Convert.ToInt32(ReadLine());

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Ingrese la carrera del estudio \n");
                                Console.ResetColor();
                                carrera = ReadLine();

                                if (indice < RegEstudiante.Length)
                                {
                                    RegEstudiante[indice] = nombre;
                                    RegEstudiante[indice + 1] = apellido;
                                    RegEstudiante[indice + 2] = Convert.ToString(codigo);
                                    RegEstudiante[indice + 3] = carrera;
                                    indice += 4;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Almacenamiento lleno!!!!! D:");
                                    Console.ResetColor();

                                }

                                break;
                            }

                        //Mostrar todos los registros de estudiantes 
                        case 2:
                            {
                                for (int i = 0; i < indice; i += 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(i + " " + RegEstudiante[i] + " "
                                        + RegEstudiante[i + 1] + " " + RegEstudiante[i + 2] +
                                        " " + RegEstudiante[i + 3]);
                                    Console.ResetColor();
                                }
                                break;
                            }

                        //buscar un registro de estudiante por nombre 
                        case 3:
                            {
                                Console.WriteLine("Ingrese el nombre al estudiante buscar: ");
                                nombre = ReadLine();
                                if (indice != 0 && indice < RegEstudiante.Length)
                                {
                                    for (int i = 0; i < indice; i++)
                                    {
                                        if (RegEstudiante[i] == nombre)
                                        {
                                            Console.WriteLine(i + "-" + RegEstudiante[i] + "-" + RegEstudiante[i + 1] + "-" + RegEstudiante[i + 2] + "-" + RegEstudiante[i + 3]);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("El almacenamiento esta vacio");
                                    Console.ResetColor();
                                }
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Ingrese el dato a modificar del estudiante");
                                nombre = ReadLine();
                                if (indice != 0 && indice < RegEstudiante.Length)
                                {
                                    for (int i = 0; i < indice; i++)
                                    {
                                        if (RegEstudiante[i] == nombre)
                                        {
                                            Console.WriteLine("Ingrese la nueva informaciom");
                                            nombre = ReadLine();
                                            RegEstudiante[i] = nombre;

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("El almacenamiento esta vacio");
                                }
                                break;
                            }
                        case 5:
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Ingrese el nombre de los estudiantes: ");
                                Console.ResetColor();
                                nombre = ReadLine();

                                if (indice != 0 && indice < RegEstudiante.Length)
                                {
                                    for (int i = 0; i < indice; i++)
                                    {
                                        if (RegEstudiante[i] == nombre)
                                        {
                                            for (int j = i; j < indice; j++)
                                            {
                                                RegEstudiante[i] = RegEstudiante[i + 4];
                                            }

                                            indice -= 4;
                                        }
                                    }
                                }
                                else
                                {

                                }
                                break;
                            }
                        case 6:
                            {
                                menu = 0;
                                break;
                            }
                        default:
                            Console.WriteLine("La opción eligida no es valida");
                            break;

                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un error en la ejecucion del programa" + e.Message);
            }

        }
    }
}
