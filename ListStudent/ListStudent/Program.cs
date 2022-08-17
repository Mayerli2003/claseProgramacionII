using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int codigo;
            string carrera;
            int longitud, indice=0, indiceEditar,opc,  menu=1;
           
            try
            {
                WriteLine("Ingrese el tamaño de la lista de estudientes (multiplo de 4): ");
                longitud = Convert.ToInt32(Console.ReadLine());
                string [] RegEstudiante= new string [longitud];

                while (menu != 0)
                {
                    WriteLine("1-Registrar nuevo estudiante");
                    WriteLine("2-Mostrar lista de estudiante");
                    WriteLine("3-Buscar un  estudiante");
                    WriteLine("4-Editar registro de estudiante");
                    WriteLine("5-Eliminar registro de estudiante");
                    WriteLine("6-Salir del programa");
                    opc= Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        //Insertar nuevos registros de estudiantes
                        case 1:
                            {
                                WriteLine("Ingrese el nombre: ");
                                nombre=ReadLine();
                                WriteLine("Ingrese el apellido: ");
                                apellido=ReadLine();
                                WriteLine("Ingrese el codigo de estuadiante: ");
                                codigo= Convert.ToInt32(Console.ReadLine());
                                WriteLine("Ingrese la carrera: ");
                                carrera=ReadLine();

                                if (indice < RegEstudiante.Length )
                                {
                                    RegEstudiante[indice] = nombre;
                                    RegEstudiante[indice+1] = apellido;
                                    RegEstudiante[indice+2] = Convert.ToString(codigo);
                                    RegEstudiante[indice+3] = carrera;
                                    indice += 4;


                                }
                                else
                                {
                                    WriteLine("Almacenamiento lleno!!");

                                }
                                break;
                            }
                            //Mostrar  todos los registros de estudiantes 
                        case 2:
                            {
                                for(int i=0; i < RegEstudiante.Length; i+=4)
                                {
                                    WriteLine(i+"- "+ RegEstudiante[i]+" " + RegEstudiante[i+1]+" "+ RegEstudiante[i+2]+" " + RegEstudiante[i+3]);
                                }
                                break;
                            }
                            
                        case 3:
                            //Buscar un regristo de estudiante por nombre
                            {
                                WriteLine("Ingrese el nombre del estudiante a buscar: ");
                                nombre = ReadLine();
                                if(indice!= 0 && indice < RegEstudiante.Length)
                                {
                                    for(int i=0; i <indice; i++)
                                    {
                                        if (RegEstudiante[i] == nombre)
                                        {
                                            WriteLine(i + "- " + RegEstudiante[i] + " " + RegEstudiante[i + 1] + " " + RegEstudiante[i + 2] + " " + RegEstudiante[i + 3]);

                                        }
                                        
                                    }

                                }
                                else
                                {
                                    WriteLine("El almacenamiento esta vacio!!");
                                }
                                break;
                            }
                            //Editar un registro de estudiante
                        case 4:
                            {
                                WriteLine("Ingrese el dato a modificar del estudiante");
                                nombre=ReadLine();
                                if(indice !=0 && indice < RegEstudiante.Length)
                                {
                                    for(int i=0; i < indice; i++)
                                    {
                                        if (RegEstudiante[i] == nombre)
                                        {
                                            WriteLine("ingrese la nueva informacion: ");
                                            nombre= ReadLine();
                                            RegEstudiante[i] = nombre;
                                        }
                                    }

                                }
                                else
                                {
                                    WriteLine("El almacenamiento esta vacio!!");

                                }

                                break;
                            }
                            //Eliminar registro de estudiante
                        case 5:
                            {
                                WriteLine("Ingrese el nombre del estudiante: ");
                                nombre= ReadLine();
                                if(indice !=0 && indice < RegEstudiante.Length)
                                {
                                    for (int i=0; i < indice; i++)
                                    {
                                        if(RegEstudiante[i] == nombre)
                                        {
                                            for (int j=i; j < indice; j++) 
                                            {
                                                RegEstudiante[j] = RegEstudiante[j + 4 ];
                                                 
                                            }
                                            indice -=4;
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
                                menu= 0;
                                break;
                            }
                        default:
                            WriteLine("La opcion elejida no es valida");
                            break;
                    }
                }

            }
            catch(Exception e)
            {
                WriteLine("Ocurrio un error en la ejecucion del programa "+ e.Message );

            }

            



        }
    }
}
