using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("la raiz cuadrada de {0} es:{1}", i, Math.Sqrt(i));
            }
        }
        static int formula1(int f)
        {
            int x = (5 * (f - 32) / 9);
            return x;
        }
        static int formula2(int c)
        {
            int z = ((9 * c) / 5) + 32;
            return z;
        }
        static int resta(int a, int b)
        {
            int res = a - b;
            return res;
        }
        static int division(int a, int b)
        {
            int res = a / b;
            return res;
        }
        static int producto(int a, int b)
        {
            int res = a * b;
            return res;
        }
        static void primos()
        {
            int cont = 0; //un contador, el cual si es mayor a dos indica que el numero no es primo
            for (int i = 2; i <= 30; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont <= 2)
                { //si variable cont es mayor a dos, el numero es divisible en mas de dos numero osea no es primo
                    Console.WriteLine(i);
                }
                cont = 0;               //igualamos a cero para hacer otra evaluacion con otro numero
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos numeros");
                Console.WriteLine("[4] Division de dos numeros");
                Console.WriteLine("[5] Multiplicacion de dos numeros");
                Console.WriteLine("[6] Convertir °F a °C");
                Console.WriteLine("[7] Convertir °C a °F");
                Console.WriteLine("[8] Primeros numeros primos");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", x1, x2, resta(x1, x2));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int y1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int y2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", y1, y2, division(y1, y2));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int z = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El producto de {0} y {1} es {2}", y, z, producto(y, z));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Ingrese el dato a calcular:");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resutlado es {1}°C", c, formula1(c));
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el dato a calcular:");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resultado es  {1}°F", f, formula2(f));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Calculando...");
                        primos();
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }
    }
}