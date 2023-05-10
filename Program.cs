using System.Linq.Expressions;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("SOMA");
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("O Resultado da soma é: " + (valor1 + valor2));
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("SUBTRAÇÂO");
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("O Resultado da subtração é: " + (valor1 - valor2));
            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("DIVISÃO");
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("O Resultado da divisão é: " + (valor1 / valor2));
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("MULTIPLICAÇÃO");
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("O Resultado da multiplicação é: " + (valor1 * valor2));
            Console.ReadKey();
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Escolha uma das Operações Matemáticas");
            Console.WriteLine("1 - Soma.");
            Console.WriteLine("2 - Subtração.");
            Console.WriteLine("3 - Divisão.");
            Console.WriteLine("4 - Multiplicação.");
            Console.WriteLine("5 - Sair.");
            Console.WriteLine("-----------------");
            Console.WriteLine("Selecione: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

    }

}