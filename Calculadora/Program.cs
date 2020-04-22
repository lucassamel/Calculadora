using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para operação de SOMA, 2 para SUBTRAÇÃO, 3 para MULTIPLICAÇÃO e 4 para DIVISÃO");

            Console.Write("Selecione uma opção:");
            int opcao = Int32.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Opção 1 selecionada");
                    Soma();
                    break;
                case 2:
                    Console.WriteLine("Opção 2 selecionada");
                    Subtracao();
                    break;
                case 3:
                    Console.WriteLine("Opção 3 selecionada");
                    Multiplicacao();
                    break;
                case 4:
                    Console.WriteLine("Opção 4 selecionada");
                    Divisao();
                    break;
                default:
                    Console.WriteLine("Opção selecionada inválida");
                    break;
            }

           

        }

        private static void Divisao()
        {
            Console.WriteLine("Operação de divisão selecionada");

            Console.Write("Insira o primeiro numero: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.Write("Insira o segundo numero: ");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: " + (x / y));
        }

        private static void Multiplicacao()
        {
            Console.WriteLine("Operação de multiplicação selecionada");

            Console.Write("Insira o primeiro numero: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.Write("Insira o segundo numero: ");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: " + (x * y));
        }

        private static void Subtracao()
        {
            Console.WriteLine("Operação de subtração selecionada");

            Console.Write("Insira o primeiro numero: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.Write("Insira o segundo numero: ");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: " + (x - y));
        }

        private static void Soma()
        {
            Console.WriteLine("Operação de adição selecionada");

            Console.Write("Insira o primeiro numero: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.Write("Insira o segundo numero: ");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: " + (x + y));
        }

        
    }
}
