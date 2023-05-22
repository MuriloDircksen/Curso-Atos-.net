using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Estacionamento.models
{
    internal class Veiculo
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
        //seuLabel.Text = DateTime.Now.ToString();
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

        public bool PlacaJaCadastrada(String placaJaCadastrada, List<Veiculo> listaVeiculosEntrada)
        {
            foreach(var veiculo in listaVeiculosEntrada)
            {
                if(veiculo.PlacaVeiculo ==  placaJaCadastrada) return true;
            }
            return false;
        }
        public void PopulaListaEntrada(Veiculo veiculo, List<Veiculo> listaVeiculosEntrada)
        {
            listaVeiculosEntrada.Add(veiculo);
        }
        public void RemoveVeiculoListaEntrada(Veiculo veiculo, List<Veiculo> listaVeiculosEntrada)
        {
            listaVeiculosEntrada.Remove(veiculo);
        }

        public void PopulaListaSaidaVeiculos(Veiculo veiculo, DateTime horaDeSaida, List<Veiculo> listaVeiculosSaida)
        {
            //tempo permanencia
            var tempoPermanencia = veiculo.HoraEntrada - horaDeSaida;
            //valor pago
            double valorPago = ValorPago(tempoPermanencia);
            //popula lista saida
            listaVeiculosSaida.Add(new Veiculo(veiculo.PlacaVeiculo, veiculo.DataEntrada, veiculo.HoraEntrada, tempoPermanencia.TotalMinutes, valorPago));
        }

        public double ValorPago(TimeSpan tempoPermanencia)
        {
            return 5 * Math.Ceiling(tempoPermanencia.TotalHours);
        }
    }
}
