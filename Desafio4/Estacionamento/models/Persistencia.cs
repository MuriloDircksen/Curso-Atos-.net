using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.models
{
    internal class Persistencia
    {
        public static void LerArquivoVeiculosEntrada( List<Veiculo> listaVeiculosEntrada)
        {
            try
            {
                StreamReader leitor = new StreamReader("veiculosEntrada.dat", Encoding.UTF8);
                string[] vetorLinha;
                string linha;
                do
                {
                    linha = leitor.ReadLine();
                    vetorLinha = linha.Split(";");
                    listaVeiculosEntrada.Add(new Veiculo(vetorLinha[0], DateTime.Parse(vetorLinha[1]), DateTime.Parse(vetorLinha[2])));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                
            }
        }
        public static void lerArquivoVeiculosSaida(List<Veiculo> listaVeiculosSaida)
        {
            try
            {
                StreamReader leitor = new StreamReader("veiculosSaida.dat", Encoding.UTF8);
                string[] vetorLinha;
                string linha;
                do
                {
                    linha = leitor.ReadLine();
                    vetorLinha = linha.Split(";");
                    listaVeiculosSaida.Add(new Veiculo(vetorLinha[0], DateTime.Parse(vetorLinha[1]), DateTime.Parse(vetorLinha[2]), Double.Parse(vetorLinha[3]), Double.Parse(vetorLinha[4])));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                
            }
        }
        public static void gravarArquivoVeiculosEntrada(List<Veiculo> listaVeiculosEntrada)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculosEntrada.dat");

                foreach (var item in listaVeiculosEntrada)
                {
                    escritor.WriteLine(item.PlacaVeiculo + ";" + item.DataEntrada.ToString("dd/MM/yyyy") + ";" + item.HoraEntrada.ToString("hh:mm:ss tt"));
                    escritor.Flush();
                }
                escritor.Close();
            }
            catch (Exception)
            {
                
            }
        }
        public static void gravarArquivoVeiculosSaida(List<Veiculo> listaVeiculosSaida)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculosSaida.dat");

                foreach (var item in listaVeiculosSaida)
                {
                    escritor.WriteLine(item.PlacaVeiculo + ";" + item.DataEntrada.ToString("dd/MM/yyyy") + ";" + item.HoraEntrada.ToString("hh:mm:ss tt") + ";" + item.TempoPermanencia + ";" + item.ValorCobrado);
                    escritor.Flush();
                }
                escritor.Close();
            }
            catch (Exception)
            {
               
            }
        }
    }
}
