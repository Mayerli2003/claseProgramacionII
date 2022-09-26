using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2
{
     class Program
    {
        static void Main(string[] args)
        
        {
            try
            {
                int[] numeros = new int[4];
                int suma;
                double media;
                
                WriteLine("Ingrese cuatro numeros 4 ");

                WriteLine("Ingrese el primer numero ");
                numeros[0] = Convert.ToInt32(Console.ReadLine());
                WriteLine("Ingrese el segundo  numero  ");
                numeros[1] = Convert.ToInt32(Console.ReadLine());
                WriteLine("Ingrese el tercero  numero  ");
                numeros[2] = Convert.ToInt32(Console.ReadLine());
                WriteLine("Ingrese el cuarto  numero  ");
                numeros[3] = Convert.ToInt32(Console.ReadLine());


                suma = (int)numeros[0] + numeros[1] + numeros[2] + numeros[3];
                media =(double) suma / 4;
                WriteLine("La media aritmetica de los numeros " + numeros[0] + ", " + numeros[1] + ", " + numeros[2] + ", " + numeros[3] + " es de  " + media);
                ReadKey();


            }

                
            catch (Exception e)
            {
                WriteLine("Ocurrio un error en la ejecucion del programa " + e.Message);

            }
        }
      
    }
}
