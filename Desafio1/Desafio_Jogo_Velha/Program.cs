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
                    "3 - Novo Jogo P X C modo dificil\n4 - sair");
                char opcao = char.Parse(Console.ReadLine()!);
                switch(opcao){

                    case '1':
                        Console.Clear();
                        IniciaTabuleiro(jogo);
                        ApresentaTabuleiro(jogo);
                        bool controleVitoria = true;
                        do
                        {
                            Console.WriteLine($"Diga qual posição da matriz deseja preencher com {jogador}");
                            int linha = int.Parse(Console.ReadLine()!);
                            int coluna = int.Parse(Console.ReadLine()!);
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
                                int linha = int.Parse(Console.ReadLine()!);
                                int coluna = int.Parse(Console.ReadLine()!);
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
                    case '3':
                        Console.Clear();
                        IniciaTabuleiro(jogo);
                        ApresentaTabuleiro(jogo);
                        controleVitoria = true;
                        bool primeiraJogada = true;
                        do
                        {                            
                            if (jogador == " X ")
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
                            }
                            else
                            {
                                if (primeiraJogada)
                                {                                   
                                    primeiraJogada = false;
                                    ComputadorModoFacil(jogo, jogador);
                                    jogador = TrocaJogador(jogador);
                                }
                                else
                                {                                   
                                    bool controleJogada = ComputadorOfensivo(jogo);
                                    Console.WriteLine("passei");
                                    controleVitoria = !VerificaVitoria(jogo, jogador);
                                    if (controleJogada)
                                    {
                                        jogador = TrocaJogador(jogador);
                                    }
                                }
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
        
        static bool Jogar(String[,] jogo, String jogador, int linha, int coluna)
        {
            if (VerificaEspacoVazio(jogo, linha, coluna))
            {
                
                jogo[linha,coluna] = jogador;
                 
                ApresentaTabuleiro(jogo);
                
                if (VerificaVitoria(jogo, jogador))
                {
                    TrocaJogador(jogador);
                    Console.WriteLine($"Jogador {jogador} venceu!\n\n");
                    return true;
                }
                return true;
            }
            else
            {
                Console.WriteLine("Espaço já definido!");
                ApresentaTabuleiro(jogo);
                return false;
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
        
        static bool ComputadorDefensivo(String[,] jogo)
        {
           
            for (int l = 1; l <= 3; l++)
            {
                if (jogo[l, 1] == " X " && jogo[l, 2] == " X " && VerificaEspacoVazio(jogo, l, 3)) { return Jogar(jogo, " O ", l, 3);  }

                if (jogo[l, 1] == " X " && jogo[l, 3] == " X " && VerificaEspacoVazio(jogo, l, 2)) { return Jogar(jogo, " O ", l, 2);  }

                if (jogo[l, 2] == " X " && jogo[l, 3] == " X " && VerificaEspacoVazio(jogo, l, 1)) { return Jogar(jogo, " O ", l, 1);  }
            }

            for (int c = 1; c <= 3; c++)
            {
                if (jogo[1, c] == " X " && jogo[2, c] == " X " && VerificaEspacoVazio(jogo, 3, c)) { return Jogar(jogo, " O ", 3, c);  }

                if (jogo[1, c] == " X " && jogo[3, c] == " X " && VerificaEspacoVazio(jogo, c, 2)) { return Jogar(jogo, " O ", 2, c);  }

                if (jogo[2, c] == " X " && jogo[3, c] == " X " && VerificaEspacoVazio(jogo, c, 1)) { return Jogar(jogo, " O ", 1, c); }
            }

            if (jogo[1, 1] == " X " && jogo[2, 2] == " X " && VerificaEspacoVazio(jogo, 3, 3)) { return Jogar(jogo, " O ", 3, 3);  }

            if (jogo[1, 1] == " X " && jogo[3, 3] == " X " && VerificaEspacoVazio(jogo, 2, 2)) { return Jogar(jogo, " O ", 2, 2);  }

            if (jogo[2, 2] == " X " && jogo[3, 3] == " X " && VerificaEspacoVazio(jogo, 1, 1)) { return Jogar(jogo, " O ", 1, 1);  }

            if (jogo[1, 3] == " X " && jogo[2, 2] == " X " && VerificaEspacoVazio(jogo, 3, 1)) { return Jogar(jogo, " O ", 3, 1);  }

            if (jogo[3, 1] == " X " && jogo[2, 2] == " X " && VerificaEspacoVazio(jogo, 1, 3)) { return Jogar(jogo, " O ", 1, 3);  }

            if (jogo[1, 3] == " X " && jogo[3, 1] == " X " && VerificaEspacoVazio(jogo, 2, 2)) { return Jogar(jogo, " O ", 2, 2);  }

            return false;
        }

        static bool ComputadorOfensivo(String[,] jogo)
        {
            bool controle = false;


            controle = ComputadorDefensivo(jogo);
            Console.WriteLine(controle);

            if (!controle)
            {
                for (int l = 1; l <= 3; l++)
                {
                    if (jogo[l, 1] == " O " && jogo[l, 2] == " O " && VerificaEspacoVazio(jogo, l, 3)) { return Jogar(jogo, " O ", l, 3);  }

                    if (jogo[l, 1] == " O " && jogo[l, 3] == " O " && VerificaEspacoVazio(jogo, l, 2)) { return Jogar(jogo, " O ", l, 2);  }

                    if (jogo[l, 2] == " O " && jogo[l, 3] == " O " && VerificaEspacoVazio(jogo, l, 1)) { return Jogar(jogo, " O ", l, 1); }
                    }

                for (int c = 1; c <= 3; c++)
                {
                    if (jogo[1, c] == " O " && jogo[2, c] == " O " && VerificaEspacoVazio(jogo, c, 3)) { return Jogar(jogo, " O ", 3, c); }

                    if (jogo[1, c] == " O " && jogo[3, c] == " O " && VerificaEspacoVazio(jogo, c, 2)) { return Jogar(jogo, " O ", 2, c); }

                    if (jogo[2, c] == " O " && jogo[3, c] == " O " && VerificaEspacoVazio(jogo, c, 1)) { return Jogar(jogo, " O ", 1, c); }
                    }

                if (jogo[1, 1] == " O " && jogo[2, 2] == " O " && VerificaEspacoVazio(jogo, 3, 3)) { return Jogar(jogo, " O ", 3, 3);  }
                if (jogo[1, 1] == " O " && jogo[3, 3] == " O " && VerificaEspacoVazio(jogo, 2, 2)) { return Jogar(jogo, " O ", 2, 2); }
                if (jogo[2, 2] == " O " && jogo[3, 3] == " O " && VerificaEspacoVazio(jogo, 1, 1)) { return Jogar(jogo, " O ", 1, 1);  }

                if (jogo[1, 3] == " O " && jogo[2, 2] == " O " && VerificaEspacoVazio(jogo, 3, 1)) { return Jogar(jogo, " O ", 3, 1);  }
                if (jogo[3, 1] == " O " && jogo[2, 2] == " O " && VerificaEspacoVazio(jogo, 1, 3)) { return Jogar(jogo, " O ", 1, 3);  }
                if (jogo[1, 3] == " O " && jogo[3, 1] == " O " && VerificaEspacoVazio(jogo, 2, 2)) { return Jogar(jogo, " O ", 2, 2); }

                for (int l = 0; l < 3; l++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (jogo[l, c] == " O ")
                        {
                            if (VerificaEspacoVazio(jogo, l + 1, c))
                            {
                                jogo[l + 1, c] = " O ";
                                return true;
                            }
                            if (VerificaEspacoVazio(jogo, l - 1, c))
                            {
                                jogo[l - 1, c] = " O ";
                                return true;
                            }
                            if (VerificaEspacoVazio(jogo, l, c + 1))
                            {
                                jogo[l, c + 1] = " O ";
                                return true;
                            }
                            if (VerificaEspacoVazio(jogo, l, c - 1))
                            {
                                jogo[l, c - 1] = " O ";
                                return true;
                            }

                        }

                    }
                }
            }
            return controle;
            
        }

    }
}