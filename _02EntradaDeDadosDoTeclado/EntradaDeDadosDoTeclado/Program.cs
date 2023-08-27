using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args) { 

            string frase = Console.ReadLine();
            int quartos = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            int age = int.Parse(vet[1]);
            double alt = double.Parse(vet[2]);

            Console.WriteLine("Entre com seu nome completo:");
            Console.WriteLine(frase);
            Console.WriteLine("Quantos quartos tem na sua casa?");
            Console.WriteLine(quartos);
            Console.WriteLine("Entre com o preço de um produto:");
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Entre com seu último nome,idade e altura:");
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(alt.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
