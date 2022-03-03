using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distância total percorrida em KM: ");
            decimal.TryParse(Console.ReadLine(), out decimal distanciaTotal);
            Console.WriteLine("Informe a quantidade de combustível gasta em Litros: ");
            decimal.TryParse(Console.ReadLine(), out decimal combustivelGasto);
            decimal media = combustivelGasto / distanciaTotal;
           
            Console.WriteLine($"A média do consumo foi de: {media}L/Km ");
            Console.ReadLine();
        }
    }
}
