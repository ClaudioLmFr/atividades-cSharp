using System;
using System.Globalization;

namespace PrimeiroTexto {
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = '\u004D';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.534567;

            Console.WriteLine("Produtos: " + produto1 + " e " + produto2);
            Console.WriteLine("Computador, cujo o preço é R$" + preco1.ToString("F2"));
            Console.WriteLine("Mesa de escritório, cujo o preço é R$" + preco2.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Registro:" + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondando (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separadador decimal invariante culture:" + medida.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
