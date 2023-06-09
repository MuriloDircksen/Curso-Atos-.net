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
            if (listaVeiculosEntrada.Count() > 0)
            {
                atualizarTextBoxEntrada();
            }
            if (listaVeiculosSaida.Count() > 0)
            {
                atualizarTextBoxSaida();
            }

            labeldata.Text = DateTime.Now.ToString();

        }
        public void atualizarTextBoxEntrada()
        {
            textBoxListaVeiculosEntrada.Clear();
            foreach (var item in listaVeiculosEntrada)
            {
                textBoxListaVeiculosEntrada.AppendText(item.PlacaVeiculo.ToUpper() + " ; "
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
                textBoxListaSaidaVeiculos.AppendText(item.PlacaVeiculo.ToUpper() + " ; "
                    + item.DataEntrada.ToString("dd/MM/yyyy") + " ; "
                    + item.HoraEntrada.ToString("hh:mm:ss tt") + " ; "
                    + item.TempoPermanencia + " min ; "
                    + item.ValorCobrado.ToString("C2")
                    + Environment.NewLine);
            }
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            textBoxTempoPermanencia.Text = "";
            textBoxValorPagar.Text = "";
            string placa = textBoxPlacaVeiculo.Text.ToUpper();
            string hora = textBoxHora.Text;

            if (string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("Nenhuma placa informada!");
                return;
            }
            if (string.IsNullOrEmpty(hora))
            {
                MessageBox.Show("Nenhuma hor�rio informado!");
                return;
            }
            if (Veiculo.PlacaJaCadastrada(placa, listaVeiculosEntrada))
            {
                MessageBox.Show("Veiculo j� cadastrado na garagem!");
                return;
            }
            var testeHora = DateTime.TryParse(hora, out var horaInformada);
            if (!testeHora)
            {
                horaInformada = DateTime.Now;
            }

            if (horaInformada.Hour >= 20 || horaInformada.Hour <= 07)
            {
                MessageBox.Show("Fora de expediente!");
                textBoxPlacaVeiculo.Text = "";
                textBoxHora.Text = "";
                return;
            }

            if (!Garagem.TemVaga(listaVeiculosEntrada))
            {
                MessageBox.Show("Garagem Lotada");
                textBoxPlacaVeiculo.Text = "";
                textBoxHora.Text = "";
                return;
            }
            listaVeiculosEntrada.Add(new Veiculo(placa, horaInformada));
            MessageBox.Show("Veiculo cadastrado com Sucesso!");
            atualizarTextBoxEntrada();
            Persistencia.gravarArquivoVeiculosEntrada(listaVeiculosEntrada);
            textBoxPlacaVeiculo.Text = "";
            textBoxHora.Text = "";



        }

        private void buttonsaida_Click(object sender, EventArgs e)
        {
            textBoxTempoPermanencia.Text = "";
            textBoxValorPagar.Text = "";
            string placa = textBoxPlacaVeiculo.Text.ToUpper();
            string hora = textBoxHora.Text;
            if (string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("Nenhuma placa informada!");
                return;
            }
            if (string.IsNullOrEmpty(hora))
            {
                MessageBox.Show("Nenhuma hor�rio informado!");
                return;
            }
            var testeHora = DateTime.TryParse(hora, out var horaInformada);
            if (!testeHora)
            {
                horaInformada = DateTime.Now;
            }
            if (!Veiculo.PlacaJaCadastrada(placa, listaVeiculosEntrada))
            {
                MessageBox.Show("Veiculo n�o cadastrado na garagem!");
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
            textBoxValorPagar.Text = valorPago.ToString("C2");
        }

        private void ControleGaragem_Load(object sender, EventArgs e)
        {
            labeldata.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labeldata.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}