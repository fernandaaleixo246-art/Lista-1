using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média
{
    internal class Program
    {
        static void Main(string[] args)
        {double n1, n2, media;

            Console.WriteLine("Digite a primeira nota:");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());

            media = (n2 + n1) / 2;

            Console.WriteLine("Média = " + media);

        }
    }
}
