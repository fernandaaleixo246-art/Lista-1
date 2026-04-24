using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quilometros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double milhas, km;

            Console.WriteLine("Digite o valor em milhas marítimas");
            milhas = Convert.ToDouble(Console.ReadLine());

         

           
             km = milhas * 1852;

            Console.WriteLine("Valor em quilometros:" + km);



        }
    }
}
