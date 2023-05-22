using Estacionamento.models;

namespace Estacionamento
{
    public partial class ControleGaragem : Form
    {
        List<Veiculo> listaVeiculosEntrada = new List<Veiculo>();
        List<Veiculo> listaVeiculosSaida = new List<Veiculo>();
        public ControleGaragem()
        {
            InitializeComponent();
            Persistencia.LerArquivoVeiculosEntrada(listaVeiculosEntrada);
            Persistencia.lerArquivoVeiculosSaida(listaVeiculosSaida);
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {

        }
        
    }
}