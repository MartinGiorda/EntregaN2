/*
//1- Cargar un array con 10 números aleatorios entre 1 y 100. Mostrar el mayor y el menor.//
 

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
           int max = 0;
           int min = 101;
           int cont = 0;
           int[] num = new int[10];

           Console.WriteLine("Ingrese 10 numeros entre el 1 y 100 para determinar el mayor y el menor: ");

           while (cont < 10)
           {
               Console.WriteLine("Ingrese un numero: ");
               int val = int.Parse(Console.ReadLine());
               if (val >= 1 && val <= 100)
               {
                   num[cont] = val;
                   cont = cont + 1;
                   if (val > max)
                   {
                       max = val;
                   }
                   else if (val < min)
                   {
                       min = val;
                   }
               }
               else
               {
                   Console.WriteLine("Ingresar números entre el 1 y 100");
               }
           }

           Console.WriteLine($"El numero mayor es: {max}");
           Console.WriteLine($"El numero menor es: {min}");
       }
   }
}
*/


/*
//2- Solicitar al usuario 8 nombres y almacenarlos en un array. Mostrar cuántos empiezan con la letra 'A'.//

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
            string[] arreglo = new string [8];

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("ingrese los nombres que quiera: ");
                arreglo[i] = (Console.ReadLine());

            }

            foreach (string n  in arreglo) 
            {
                char vocal = n[0];
                if (vocal == 'A')
                {
                        Console.WriteLine(n);
                }
            }
        }
    }
}
*/


/*
//3- Ingresar 10 números y mostrar cuántos son positivos, negativos y ceros.//

using System;
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
            int cont = 0;
            int[] array = new int[10];

            for (int i = 0;i < 10 ;i++)
            {
                Console.WriteLine("ingrese los numeros que se quieras: ");
                int num = int.Parse(Console.ReadLine());
                array[i] = num;
                
            }
            foreach (int n in array)
            {
                if (n > 0)
                {
                    Console.WriteLine($"Los numeros positivos son: {n}");
                }
                else if (n < 0)
                {
                    Console.WriteLine($"Los numeros negativos son: {n}");
                }
                else
                {
                    cont++;
                }
            }
            Console.WriteLine($"La cantidad de veces que sale el cero son: {cont}");
        }
    }
}
*/

/*
//4- Crear un array con los días de la semana y mostrar solo los días laborales.//

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
            string[] dias = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"};
                
                Console.WriteLine(dias[0]);
                Console.WriteLine(dias[1]);
                Console.WriteLine(dias[2]);
                Console.WriteLine(dias[3]);
                Console.WriteLine(dias[4]);
        }
    }
}
*/



