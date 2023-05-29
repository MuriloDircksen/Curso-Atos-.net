namespace Pessoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonComecar_Click(object sender, EventArgs e)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            List<Aluno> listaAlunos = new List<Aluno>();
            //List<string> listaAuxiliar = new List<string>();
            //Persistencia.popularArquivoLista(listaAuxiliar);
            //foreach (var item in listaAuxiliar)
            //{
            //    string[] letra = item.Split('-');
            //    textBoxListaAlunos.AppendText(letra[0]);
            //}
            Persistencia.popularArquivoLista(listaPessoas, listaAlunos);
            textBoxTotalAlunos.Text = listaAlunos.Count().ToString();
            textBoxTotalPessoas.Text = listaPessoas.Count().ToString();

            foreach (var aluno in listaAlunos)
            {
                textBoxListaAlunos.AppendText("Nome: " + aluno.Nome + ", Curso: " + aluno.NomeCurso + Environment.NewLine);
            }

            foreach (var pessoas in listaPessoas)
            {
                textBox1.AppendText(pessoas.Nome + Environment.NewLine);
            }

        }
    }
}