using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            try
            {
                WriteLine("Ingrese cuatro numeros 4 ");
                
                int[] numeros = new int[4];
                int suma;

                WriteLine("Ingrese el numero 1: ");
                numeros[0] = int.Parse(Console.ReadLine()) ;

                WriteLine("Ingrese el numero 2: ");
                numeros[1] = int.Parse(Console.ReadLine());

                WriteLine("Ingrese el numero 3: ");
                numeros[2] = int.Parse(Console.ReadLine());

                WriteLine("Ingrese el numero 4: ");
                numeros[3] = int.Parse(Console.ReadLine());

                suma = numeros[0] + numeros[1] + numeros[2] + numeros[3];

                WriteLine("La media aritmetica de los numeros " + numeros[0] + " " + numeros[1] + " " + numeros[2] + " " + numeros[3]+ "es de");
            }
            catch (Exception e)
            {
                WriteLine("Ocurrio un error en la ejecucion del programa " + e.Message);

            }
        }
      
    }
}
