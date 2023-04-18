using System.Runtime.CompilerServices;

namespace Desafio_Jogo_Velha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] jogo = new string[3,3];
            IniciaTabuleiro(jogo);
            ApresentaTabuleiro(jogo);

        }

        static void IniciaTabuleiro(String[,] jogo)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    jogo[i, j] = "-";
                }
            }
        }
        static void ApresentaTabuleiro(String[,] jogo)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(jogo[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}