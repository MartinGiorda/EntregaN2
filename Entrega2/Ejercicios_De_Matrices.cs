/*
//1- Crear una matriz de 3x3. Solicitar al usuario que ingrese todos los elementos y luego mostrar la suma de cada fila.//

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int[,] val = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("ingresa los valores para la matris: ");
                    val[i , j]= int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("Matriz completa: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(val[i,j]);
                }
                Console.WriteLine();
            }
             
            for (int i = 0;i < 3; i++)
            {
                for (int j = 0;j < 3; j++)
                {
                    suma = suma + val[i, j];
                }
                Console.WriteLine($"Suma de la fila: {suma}");
            }
        }
    }
}
*/

/*
//2- Cargar una matriz de 3x3. Mostrar la fila con mayor suma.//


using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int max = 0;
            int[,] matris = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese los numeros que quiera para su matris: ");
                    matris[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matris[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma = suma + matris[i, j];
                    if (suma > max)
                    {
                        max = suma;
                    }
                }
                Console.WriteLine($"Suma de la fila: {suma}");
            }
            Console.WriteLine($"Maximo valor de la suma de las filas: {max}");
        }
    }
}
*/

/*
//3- Crear una matriz de 3x3. Reemplazar todos los elementos negativos por cero.//


using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int[,] matris = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese los numeros que quiera para su matris: ");
                    matris[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matris[i, j] < 0)
                    {
                        matris[i, j] = 0;
                    }
                    Console.WriteLine(matris[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
*/

