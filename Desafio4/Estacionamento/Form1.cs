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
            atualizarTextBoxEntrada();
            atualizarTextBoxSaida();
            labeldata.Text = DateTime.Now.ToString();

        }
        public void atualizarTextBoxEntrada()
        {
            textBoxListaVeiculosEntrada.Clear();
            foreach (var item in listaVeiculosEntrada)
            {
                textBoxListaVeiculosEntrada.AppendText(item.PlacaVeiculo + " ; " 
                    + item.DataEntrada.ToString("dd/MM/yyyy") + " ; " 
                    + item.HoraEntrada.ToString("hh:mm:ss tt")
                    + Environment.NewLine);
            }
        }
        public void atualizarTextBoxSaida()
        {
            textBoxListaSaidaVeiculos.Clear();
            foreach (var item in listaVeiculosSaida)
            {
                textBoxListaSaidaVeiculos.AppendText(item.PlacaVeiculo + " ; " 
                    + item.DataEntrada.ToString("dd/MM/yyyy") + " ; " 
                    + item.HoraEntrada.ToString("hh:mm:ss tt") + " ; " 
                    + item.TempoPermanencia + " ; " 
                    + item.ValorCobrado 
                    + Environment.NewLine);
            }
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            textBoxTempoPermanencia.Text = "";
            textBoxValorPagar.Text = "";
            string placa = textBoxPlacaVeiculo.Text;
            string hora = textBoxHora.Text;

            if (string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("Nenhuma placa informada!");
                return;
            }
            if (string.IsNullOrEmpty(hora))
            {
                MessageBox.Show("Nenhuma horário informado!");
                return;
            }
            if (Veiculo.PlacaJaCadastrada(placa, listaVeiculosEntrada))
            {
                MessageBox.Show("Veiculo já cadastrado na garagem!");
                return;
            }
            var testeHora = DateTime.TryParse(hora, out var horaInformada);
            if (!testeHora)
            {
                horaInformada = DateTime.Now;
            }
            MessageBox.Show(horaInformada.ToString());
            listaVeiculosEntrada.Add(new Veiculo(placa, horaInformada));
            atualizarTextBoxEntrada();
            Persistencia.gravarArquivoVeiculosEntrada(listaVeiculosEntrada);
            textBoxPlacaVeiculo.Text = "";
            textBoxHora.Text = "";
            


        }

        private void buttonsaida_Click(object sender, EventArgs e)
        {
            textBoxTempoPermanencia.Text = "";
            textBoxValorPagar.Text = "";
            string placa = textBoxPlacaVeiculo.Text;
            string hora = textBoxHora.Text;
            if (string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("Nenhuma placa informada!");
                return;
            }
            if (string.IsNullOrEmpty(hora))
            {
                MessageBox.Show("Nenhuma horário informado!");
                return;
            }            
            var testeHora = DateTime.TryParse(hora, out var horaInformada);
            if (!testeHora)
            {
                horaInformada = DateTime.Now;
            }
            if (!Veiculo.PlacaJaCadastrada(placa, listaVeiculosEntrada))
            {
                MessageBox.Show("Veiculo não cadastrado na garagem!");
                return;
            }
            var veiculo = Veiculo.RetornaVeiculo(listaVeiculosEntrada, placa);
            var tempoPermanencia = horaInformada - veiculo.HoraEntrada;
            var valorPago = Veiculo.ValorPago(tempoPermanencia);
            Veiculo.PopulaListaSaidaVeiculos(placa, horaInformada, listaVeiculosSaida, listaVeiculosEntrada);
            atualizarTextBoxEntrada();
            atualizarTextBoxSaida();
            Persistencia.gravarArquivoVeiculosEntrada(listaVeiculosEntrada);
            Persistencia.gravarArquivoVeiculosSaida(listaVeiculosSaida);
            textBoxPlacaVeiculo.Text = "";
            textBoxHora.Text = "";            
            textBoxTempoPermanencia.Text = tempoPermanencia.TotalHours.ToString() + " horas";
            textBoxValorPagar.Text = valorPago.ToString();
        }
    }
}