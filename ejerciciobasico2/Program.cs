using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciobasico2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double metros, pies;

            Console.WriteLine("Ingrese pies: ");
            pies =Convert.ToInt32(Console.ReadLine());

            metros = pies / 3.2808399;
            Console.WriteLine("Pies a metros: " + metros);
            Console.ReadKey();

        }
    }
}
