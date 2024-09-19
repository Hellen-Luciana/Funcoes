using System;

namespace Funcoes
{
    internal class Program
    {
        public static void MostraMensagemNaTela()
        {
            Console.WriteLine("===MENSAGEM NA TELA===");
            Console.WriteLine("Olá pessoa");
            Console.WriteLine("\n");
        }
        public static void Tabuada(int numero)
        {
            Console.WriteLine("===TABUADA===");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero}x{i}={(numero * i)}");
            }
            Console.WriteLine("======================================");
        }
        public static int CalcularSoma()
        {
            Console.WriteLine("===SOMA===");
            int a = 1;
            int b = 2;
            int c = a + b;
            Console.Write($"{a} + {b} = ");
            return c;
        }
        
        static void Main(string[] args)//temos uma funçao Main 
        {
            Console.WriteLine(CalcularSoma());
            Console.WriteLine("\n");
            MostraMensagemNaTela();
            Tabuada(9);
            Tabuada(10);
            Tabuada(97);
            Console.ReadLine();
        }
    }
}
