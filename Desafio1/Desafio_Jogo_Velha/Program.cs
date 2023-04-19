using System;
using System.Runtime.CompilerServices;

namespace Desafio_Jogo_Velha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool controle = true;
            do { 
                
                String[,] jogo = new string[4, 4];
                String jogador = " X ";
                
                
                Console.WriteLine("Bem vindo ao Jogo Da velha da Atos!");
                Console.WriteLine("Escolha posições numa matriz 3X3 para colocar X ou O");
                Console.WriteLine("Digite uma opção válida:\n1 - Novo Jogo P X P\n2 - Novo Jogo P X C modo fácil\n" +
                    "3 - Novo Jogo P X C modo fácil\n4 - sair");
                char opcao = char.Parse(Console.ReadLine());
                switch(opcao){

                    case '1':
                        Console.Clear();
                        IniciaTabuleiro(jogo);
                        ApresentaTabuleiro(jogo);
                        bool controleVitoria = true;
                        do
                        {

                            Console.WriteLine($"Diga qual posição da matriz deseja preencher com {jogador}");
                            int linha = int.Parse(Console.ReadLine());
                            int coluna = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (linha > 0 && linha <= 3)
                            {
                                if (coluna > 0 && coluna <= 3)
                                {

                                    if (VerificaEspacoVazio(jogo, linha, coluna))
                                    {
                                        Jogar(jogo, jogador, linha, coluna);
                                        controleVitoria = !VerificaVitoria(jogo, jogador);
                                        jogador = TrocaJogador(jogador);
                                    }
                                    else ApresentaTabuleiro(jogo);

                                }
                                else
                                {
                                    Console.WriteLine("Posição inexistente");
                                    ApresentaTabuleiro(jogo);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Posição inexistente");
                                ApresentaTabuleiro(jogo);
                            }
                            
                        } while (controleVitoria);
                        break;
                    case '2':
                        Console.Clear();
                        IniciaTabuleiro(jogo);
                        ApresentaTabuleiro(jogo);
                        controleVitoria = true;
                        do
                        {
                            if (jogador == " X ") {
                                Console.WriteLine($"Diga qual posição da matriz deseja preencher com {jogador}");
                                int linha = int.Parse(Console.ReadLine());
                                int coluna = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (linha > 0 && linha <= 3)
                                {
                                    if (coluna > 0 && coluna <= 3)
                                    {

                                        if (VerificaEspacoVazio(jogo, linha, coluna))
                                        {
                                            Jogar(jogo, jogador, linha, coluna);
                                            controleVitoria = !VerificaVitoria(jogo, jogador);
                                            jogador = TrocaJogador(jogador);
                                        }
                                        else ApresentaTabuleiro(jogo);

                                    }
                                    else
                                    {
                                        Console.WriteLine("Posição inexistente");
                                        ApresentaTabuleiro(jogo);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Posição inexistente");
                                    ApresentaTabuleiro(jogo);
                                }
                            }
                            else
                            {
                                ComputadorModoFacil(jogo, jogador);
                                controleVitoria = !VerificaVitoria(jogo, jogador);
                                jogador = TrocaJogador(jogador);
                            }
                        } while (controleVitoria);
                        break;
                    case '4':
                        controle = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }

                
            }while (controle);

        }

        static void IniciaTabuleiro(String[,] jogo)
        {
            jogo[0, 0] = " ";
            for (int i = 1; i <= 3; i++)
            {
                jogo[i, 0] = "" + i;
                for (int j = 1; j <= 3; j++)
                {
                    jogo[i, j] = " - ";
                    jogo[0, j] = $" {j} ";
                }
            }
        }
        static void ApresentaTabuleiro(String[,] jogo)
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
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
            for (int i = 1; i <= 3; i++)
            {
                pontos = 0;
                for (int c = 1; c <= 3; c++)
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
            for (int c = 1; c <= 3; c++)
            {
                pontos = 0;
                for (int i = 1; i <= 3; i++)
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
            for (int d = 1; d <= 3; d++)
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
            int l = 1;
            for (int c = 3; c >= 1; c--)
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
                for (int c = 1; c <= 3; c++)
                {

                    for (int i = 1; i <= 3; i++)
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
                    return true;
                    

                }
                else
                {
                    return vitoria;
                }
            }

        }
        static String TrocaJogador(String jogador)
        {
            return  (jogador == " X ") ? " O " : " X ";
        }
        static bool VerificaEspacoVazio (String[,] jogo, int linha, int coluna) 
        {
            return jogo[linha, coluna] == " - " ? true : false;
        }     
        
        static void Jogar(String[,] jogo, String jogador, int linha, int coluna)
        {
            if (VerificaEspacoVazio(jogo, linha, coluna))
            {
                
                jogo[linha,coluna] = jogador;
                 
                ApresentaTabuleiro(jogo);
                if (VerificaVitoria(jogo, jogador))
                {
                    TrocaJogador(jogador);
                    Console.WriteLine($"Jogador {jogador} venceu!\n\n");
                     
                }                

            }
            else
            {
                Console.WriteLine("Espaço já definido!");
                ApresentaTabuleiro(jogo);
            }
        }

        static void ComputadorModoFacil(String[,] jogo, String jogador) {
            int linha, coluna;

            do
            {
                var numeroAleatoria = new Random();
                linha = numeroAleatoria.Next(1, 4);
                coluna = numeroAleatoria.Next(1, 4);
            } while (!VerificaEspacoVazio(jogo, linha, coluna));
            Jogar(jogo, jogador, linha, coluna);
        }
        

        
           
    }
}