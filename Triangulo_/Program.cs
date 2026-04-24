using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo, altura, area;

            Console.WriteLine("Digite a base;");
            baseTriangulo= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura:");
            altura = double.Parse(Console.ReadLine());

            area = (baseTriangulo * altura / 2);


            Console.WriteLine("Área =" + area); 





        }
    }
}
