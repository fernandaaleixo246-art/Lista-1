using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, resultado;  


            Console.WriteLine("Digite o valor de x:");
            x = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite o valor de y:");
            y =  double.Parse(Console.ReadLine());

            resultado= Math.Pow(x, y);

            Console.WriteLine("Resultado> " + resultado);


        }
    }
}
