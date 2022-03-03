using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em dólar($): ");
            decimal.TryParse(Console.ReadLine(), out decimal valorConvertido);
            decimal ValorCambioConvertido = valorConvertido * 5.22m;
            Console.WriteLine($"Valor em R$: {ValorCambioConvertido}");
            Console.ReadLine();
        }
    }
}
