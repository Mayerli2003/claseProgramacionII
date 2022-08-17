using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayerliLaboratorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreLibro;
            string autor;
            string edicion;
            string pais;
            int Fecha;
            int longitud, indice = 0, opc, menu = 1;
            try
            {

                WriteLine("Ingrese la longitud de la lista de libros (multiplo de 5): ");
                longitud = Convert.ToInt32(Console.ReadLine());
                string[] RegLibros = new string[longitud];

                while (menu != 0)
                {
                    WriteLine("1-Registrar un libro");
                    WriteLine("2-Editar registro de libro");
                    WriteLine("3-Buscar registro e libro");
                    WriteLine("4-Mostrar libros registrados");
                    WriteLine("5-Eliminar registro de libro");
                    WriteLine("6-Salir del programa");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        //Insertar nuevos registros de libros 
                        case 1:
                            {
                                WriteLine("Ingrese el nombre del libro: ");
                                nombreLibro = ReadLine();
                                WriteLine("Ingrese el autor: ");
                                autor = ReadLine();
                                WriteLine("Ingrese la edicion: ");
                                edicion = ReadLine();
                                WriteLine("Ingrese el pais: ");
                                pais = ReadLine();
                                WriteLine("Ingrese el año e publicacion: ");
                                Fecha = Convert.ToInt32(Console.ReadLine());
                                

                                if (indice < RegLibros.Length)
                                {
                                    RegLibros[indice] = nombreLibro;
                                    RegLibros[indice + 1] = autor;
                                    RegLibros[indice + 2] = edicion;
                                    RegLibros[indice + 3] = pais;
                                    RegLibros[indice + 4] = Convert.ToString(Fecha);
                                    indice += 5;


                                }
                                else
                                {
                                    WriteLine("Almacenamiento lleno!!");

                                }
                                break;
                            }
                        //Editar un registro del libro
                        case 2:
                            {
                                WriteLine("Ingrese el nombre del libro  a modificar ");
                                nombreLibro = ReadLine();
                                if (indice != 0 && indice <= RegLibros.Length)
                                {
                                    for (int i = 0; i < indice; i++)
                                    {
                                        if (RegLibros[i] == nombreLibro)
                                        {
                                           


                                            WriteLine("Ingrese el nombre del libro: ");
                                            nombreLibro = ReadLine();
                                            RegLibros[i] = nombreLibro;
                                            WriteLine("Ingrese el autor: ");
                                            autor = ReadLine();
                                            RegLibros[i+1] = autor;
                                            WriteLine("Ingrese la edicion: ");
                                            edicion = ReadLine();
                                            RegLibros[i+2] = edicion;
                                            WriteLine("Ingrese el pais: ");
                                            pais = ReadLine();
                                            RegLibros[i+3] = pais;
                                            WriteLine("Ingrese el año e publicacion: ");
                                            Fecha = Convert.ToInt32(Console.ReadLine());
                                            RegLibros[i+4] = Convert.ToString(Fecha);
                                        }
                                    }

                                }
                                else
                                {
                                    WriteLine("El almacenamiento esta vacio!!");

                                }

                                break;
                            }
                        //Buscar un regristo de un libro por nombre
                        case 3:
                            
                            {
                                WriteLine("Ingrese el nombre del libro a buscar: ");
                                nombreLibro = ReadLine();
                                if (indice != 0 && indice < RegLibros.Length)
                                {
                                    for (int i = 0; i < indice; i++)
                                    {
                                        if (RegLibros[i] == nombreLibro)
                                        {
                                            WriteLine(i + "- " + RegLibros[i] + " " + RegLibros[i + 1] + " " + RegLibros[i + 2] + " " + RegLibros[i + 3] + " " + RegLibros[i + 4]);

                                        }

                                    }

                                }
                                else
                                {
                                    WriteLine("El almacenamiento esta vacio!!");
                                }
                                break;
                            }
                        //Mostrar libros registrados
                        case 4:
                            {
                                {
                                    for (int i = 0; i < RegLibros.Length; i += 5)
                                    {
                                        WriteLine(i + "- " + RegLibros[i] + " " + RegLibros[i + 1] + " " + RegLibros[i + 2] + " " + RegLibros[i + 3] + " " + RegLibros[i + 4]);
                                    }
                                    break;
                                }
                            }
                        //Eliminar registro de estudiante
                        case 5:
                            {
                                WriteLine("Ingrese el nombre del libro: ");
                                nombreLibro = ReadLine();
                                if (indice != 0 && indice < RegLibros.Length)
                                {
                                    for (int i = 0; i < indice; i++)
                                    {
                                        if (RegLibros[i] == nombreLibro)
                                        {
                                            for (int j = i; j < indice; j++)
                                            {
                                                RegLibros[j] = RegLibros[j + 5];

                                            }
                                            indice -= 5;
                                        }
                                    }

                                }
                                
                                break;
                            }
                        case 6:
                            {
                                menu = 0;
                                break;
                            }
                        default:
                            WriteLine("La opcion  no es valida");
                            break;
                    }

                }
            }
            catch (Exception e)
            {
                WriteLine("Ocurrio un error en la ejecucion del programa " + e.Message);
            }
        }
    }
}
