/*
//1- Solicitar al usuario que ingrese 5 números enteros y guardarlos en una lista. Luego calcular y mostrar la suma total de los elementos.// 
 
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
            List<int> lista = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa 5 numeros para saber la suma de los mismos: ");
                int num = int.Parse(Console.ReadLine());
                suma = suma + num;
                lista.Add(suma);
            }

                Console.WriteLine($"La suma de los numeros ingresados es: {suma}");
        }
    }
}
*/

/*
//2- Pedir al usuario que ingrese 7 números y guardarlos en una lista. Luego pedir otro número y verificar si está en la lista. Mostrar un mensaje informando si se encontró o no.//


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
            List<int> lista = new List<int>();

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Ingresa los numeros que quieras: ");
                int num = int.Parse(Console.ReadLine());
                lista.Add(num);
            }
            int cont = 0;
            Console.WriteLine("Ingrese el numero que quiera saber si esta dentro de la lista: ");
            int val = int.Parse(Console.ReadLine());
            for (int i = 0;i < lista.Count;i++)
            {
                if (lista[i] == val)
                {
                    cont++;
                }
            }
            if (cont > 0)
            {
                Console.WriteLine($"El numero {val} esta en la lista");
            }
            else
            {
                Console.WriteLine($"El numero {val} NO esta en la lista");
            }
        }
    }
}
*/

/*
//3- Generar una lista con 10 números aleatorios entre 1 y 100. Luego pedir al usuario un valor límite y eliminar todos los elementos menores a ese valor. Mostrar la lista resultante.//


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
            int cont = 0;
            List <int> lista = new  List <int> ();
            
            while (cont < 10)
            {
                Console.WriteLine("ingrese 10 numeros entre 1 y 100: ");
                int num = int.Parse (Console.ReadLine());
                if (num >= 1 && num <= 100)
                {
                    cont++;
                    lista.Add (num);
                }
                else
                    Console.WriteLine("Ingrese numeros del 1 al 100");
            }

            Console.WriteLine("Ingrese un valor limite");
            int val = int.Parse (Console.ReadLine());
            Console.WriteLine("Los numeros dentro de ese rango son: ");

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] >= val)
                {
                    Console.WriteLine(lista[i]);
                }
            }
         
        }
    }
}
*/
