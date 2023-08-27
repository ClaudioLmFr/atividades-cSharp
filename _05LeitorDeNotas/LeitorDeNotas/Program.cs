using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, soma;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = nota1 + nota2;

            Console.WriteLine("NOTA FINAL  = " + soma.ToString("F1", CultureInfo.InvariantCulture));

            if  (soma < 60.0)
            {
                Console.WriteLine("REPROVADO");
            } else
            {
                Console.WriteLine("APROVADO");
            }

            Console.ReadLine();
        }
    }
}
