using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using operaciones;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el primer valor");
            double numero1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese el primer valor");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double suma = operacion.Sumar(numero1, numero2);
            double resta = operacion.Restar(numero1, numero2);
            double multiplicar = operacion.Multiplicar(numero1, numero2);
            double division = operacion.Dividir(numero1, numero2);

            Console.WriteLine("Resultado suma " + suma);
            Console.WriteLine("Resultado resta " + resta);
            Console.WriteLine("Resultado multiplicacion " + multiplicar);
            Console.WriteLine("Resultado division " + division);

            Console.ReadKey();
        }
    }
}
