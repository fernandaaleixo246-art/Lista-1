using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diagonal, area;
            Console.WriteLine("Digite o valor da diagonal do quadrado");
            diagonal=double.Parse(Console.ReadLine());

            area = (diagonal * diagonal) / 2;

            Console.WriteLine("area = " + area) ;




        }
    }
}
