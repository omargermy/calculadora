using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora_6B.Libreria;

namespace Calculadora_6B.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos MisMetodos = new Metodos();
            //Console.WriteLine(MisMetodos.Saludar());
            //Console.ReadKey();
            Console.WriteLine("Introduzca El Primer Valor");
            float Valor1;
            Valor1 = float.Parse(Console.ReadLine()); //Lectura de datos tipo float
            //Valor1 = MisMetodos.Sumar(Valor1,0);
            //MisMetodos.Sumar(Valor1, 0);
            //Valor1 = Console.ReadLine();
            //Console.WriteLine("El Valor 1 Es: " + Valor1);
            //Console.ReadKey();
            Console.WriteLine("Introduzca El Segundo Valor");
            float Valor2;
            Valor2 = float.Parse(Console.ReadLine()); //Lectura de datos tipo float
            //Valor1 = MisMetodos.Sumar(0, Valor2);
            //MisMetodos.Sumar(0, Valor2);
            //Valor2 = Console.ReadLine();
            //Console.WriteLine("El Valor 2 Es: " + Valor2);
            //MisMetodos.Sumar(Valor1, Valor2);
            //Console.WriteLine("Resultado" + MisMetodos.Sumar());
            Console.WriteLine("\nResultados: ");
            Console.WriteLine("\nSuma: " + MisMetodos.Sumar(Valor1, Valor2));
            Console.WriteLine("Resta: " + MisMetodos.Restar(Valor1, Valor2));
            Console.WriteLine("Multiplicacion: " + MisMetodos.Multiplicar(Valor1, Valor2));
            Console.WriteLine("Division: " + MisMetodos.Dividir(Valor1, Valor2));
            Console.ReadKey();
        }
    }
}
