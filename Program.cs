using System;
using System.Globalization;
namespace Moedas
{
    class Program
    {
        static void Main(string [] args)
        {
            Floor();

        }

        static void Cultura(){
            decimal valor = 10.25m;
            Console.WriteLine(valor.ToString("C", // O "C" coloca em formato de R$
                CultureInfo.CreateSpecificCulture("pt-BR"))); // O pt-Br coloca no formato do páis
        }
        static void Round(){
            Console.Clear();
           decimal valor = 10536.25m;
           Console.WriteLine(Math.Round(valor)); // O round faz a média do valor
        }

        static void Ceiling(){
            Console.Clear();
           decimal valor = 10536.25m;
           Console.WriteLine(Math.Ceiling(valor)); // O Ceiling arredonda o valor para cima
        }

        static void Floor(){
            Console.Clear();
           decimal valor = 10536.25m;
           Console.WriteLine(Math.Floor(valor)); // O Floor arredonda o valor para baixo
           
        }
    }
}
