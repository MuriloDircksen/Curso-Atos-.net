using System.Runtime.CompilerServices;

namespace Desafio_Jogo_Velha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] jogo = new string[3, 3];
            String jogador = "X";
            IniciaTabuleiro(jogo);
            ApresentaTabuleiro(jogo);

        }

        static void IniciaTabuleiro(String[,] jogo)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    jogo[i, j] = " - ";
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

        static bool VerificaVitoria(String[,] jogo, String jogador)
        {
            int pontos = 0;
            bool vitoria = false;
            //linhas
            for (int i = 0; i < 3; i++)
            {
                pontos = 0;
                for (int c = 0; c < 3; c++)
                {
                    if (jogo[i,c] == jogador)
                    {
                        pontos++;
                    }
                }
                if (pontos >= 3)
                {
                    vitoria = true;
                    break;
                }
            }
            //colunas
            for (int c = 0; c < 3; c++)
            {
                pontos = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (jogo[i,c] == jogador)
                    {
                        pontos++;
                    }
                }
                if (pontos >= 3)
                {
                    vitoria = true;
                    break;
                }
            }
            //diagonais
            pontos = 0;
            for (int d = 0; d < 3; d++)
            {

                if (jogo[d,d] == jogador)
                {

                    pontos++;

                }
            }
            if (pontos >= 3)
            {
                vitoria = true;

            }
            pontos = 0;
            int l = 0;
            for (int c = 2; c >= 0; c--)
            {
                if (jogo[l,c] == jogador)
                {
                    pontos++;
                }
                l++;
            }
            if (pontos >= 3)
            {
                vitoria = true;

            }
            if (vitoria)
            {
                return vitoria;
            }
            else
            {
                int testa = 0;
                for (int c = 0; c < 3; c++)
                {

                    for (int i = 0; i < 3; i++)
                    {
                        if (jogo[i,c] != " - ")
                        {
                            testa++;
                        }
                    }
                }
                if (testa == 9)
                {
                   Console.WriteLine("Deu empate");
                    return false;

                }
                else
                {
                    return vitoria;
                }
            }

        }
    }
}