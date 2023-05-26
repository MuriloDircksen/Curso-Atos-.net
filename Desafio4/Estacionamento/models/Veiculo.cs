using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Estacionamento.models
{
   public class Veiculo
    {
        public string PlacaVeiculo { get;}
        public DateTime DataEntrada { get;}
        public DateTime HoraEntrada { get;}
        public double TempoPermanencia { get;}
        public double ValorCobrado { get; }

       

        public Veiculo(string placaVeiculo, DateTime horaEntrada)
        {
            PlacaVeiculo = placaVeiculo;
            DataEntrada = dataEntrada();
            HoraEntrada = horaEntrada;
        }
       
        public Veiculo(string placaVeiculo, DateTime dataEntrada, DateTime horaEntrada)
        {
            PlacaVeiculo = placaVeiculo;
            DataEntrada = dataEntrada;
            HoraEntrada = horaEntrada;
        }
        public Veiculo(string placaVeiculo, DateTime dataEntrada, DateTime horaEntrada, double permanecia, double valorCobrado) :
            this(placaVeiculo, dataEntrada, horaEntrada)
        {
            TempoPermanencia = permanecia;
            ValorCobrado = valorCobrado;
        }

        private DateTime dataEntrada()
        {
            return DateTime.Now.Date;
        }

        public static bool PlacaJaCadastrada(String placaJaCadastrada, List<Veiculo> listaVeiculosEntrada)
        {
            foreach(var veiculo in listaVeiculosEntrada)
            {
                if(veiculo.PlacaVeiculo ==  placaJaCadastrada) return true;
            }
            return false;
        }
        public static Veiculo RetornaVeiculo(List<Veiculo> listaVeiculo, string placa)
        {
            foreach(var item in listaVeiculo)
            {
                if(item.PlacaVeiculo == placa)
                {
                    return item;
                }
            }
            return null;
        }
        public static void PopulaListaSaidaVeiculos(String placa, DateTime horaDeSaida, List<Veiculo> listaVeiculosSaida, List<Veiculo> listaVeiculosEntrada)
        {
            var veiculo = RetornaVeiculo(listaVeiculosEntrada, placa);
            
            var tempoPermanencia =   horaDeSaida - veiculo.HoraEntrada;

            double valorPago = ValorPago(tempoPermanencia);
            
            listaVeiculosSaida.Add(new Veiculo(veiculo.PlacaVeiculo, veiculo.DataEntrada, veiculo.HoraEntrada, Math.Round(tempoPermanencia.TotalMinutes), valorPago));
            listaVeiculosEntrada.Remove(veiculo);
            
        }

        public static double ValorPago(TimeSpan tempoPermanencia)
        {
            return 5.0 * Math.Ceiling(tempoPermanencia.TotalHours);
        }
    }
}
