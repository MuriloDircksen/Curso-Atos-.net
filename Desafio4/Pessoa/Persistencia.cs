using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    internal class Persistencia
    {
        public static void popularArquivoLista(List<Pessoa> listaPessoas, List<Aluno> listaAlunos)
        {
            try
            {
                StreamReader leitor = new StreamReader("lista.txt", Encoding.UTF8);
                 
                string linha;
                List<string> listaAuxiliar = new List<string>();
                do
                {
                    linha = leitor.ReadLine();
                    listaAuxiliar.Add(linha);
                } while (!leitor.EndOfStream);
                leitor.Close();
                for (int i = 0; i < listaAuxiliar.Count(); i++)
                {
                    char linhaAtual = 'Z';
                    char linhaPosterior = 'Z';
                    if (i < listaAuxiliar.Count()-1)
                    {
                        linhaAtual = listaAuxiliar[i].FirstOrDefault();
                        linhaPosterior = listaAuxiliar[i + 1].FirstOrDefault();
                    }
                    if (linhaAtual == 'Z' && linhaPosterior == 'Y')
                    {
                        string[] aluno = listaAuxiliar[i].Split('-');
                        string[] curso = listaAuxiliar[i + 1].Split('-');
                        listaAlunos.Add(new Aluno(aluno[1], aluno[2], aluno[3], aluno[4], aluno[5], curso[1], curso[2], curso[3]));
                    }
                    else if (linhaAtual == 'Z' && linhaPosterior == 'Z')
                    {
                        string[] aluno = listaAuxiliar[i].Split('-');
                        listaPessoas.Add(new Pessoa(aluno[1], aluno[2], aluno[3], aluno[4], aluno[5]));
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }
    }
}
