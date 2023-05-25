namespace Estacionamento
{
    partial class ControleGaragem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBoxPlacaVeiculo = new TextBox();
            Hora = new Label();
            textBoxHora = new TextBox();
            textBoxListaVeiculosEntrada = new TextBox();
            textBoxListaSaidaVeiculos = new TextBox();
            labelListaVeiculosEntrada = new Label();
            labelListaVeiculosSaida = new Label();
            buttonEntrada = new Button();
            labeldata = new Label();
            buttonsaida = new Button();
            label2 = new Label();
            label3 = new Label();
            textBoxTempoPermanencia = new TextBox();
            textBoxValorPagar = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Digite Placa Veiculo";
            // 
            // textBoxPlacaVeiculo
            // 
            textBoxPlacaVeiculo.Location = new Point(168, 38);
            textBoxPlacaVeiculo.Name = "textBoxPlacaVeiculo";
            textBoxPlacaVeiculo.Size = new Size(125, 27);
            textBoxPlacaVeiculo.TabIndex = 1;
            // 
            // Hora
            // 
            Hora.AutoSize = true;
            Hora.Location = new Point(167, 81);
            Hora.Name = "Hora";
            Hora.Size = new Size(126, 20);
            Hora.TabIndex = 3;
            Hora.Text = "Hora (HH:MM:SS)";
            // 
            // textBoxHora
            // 
            textBoxHora.Location = new Point(168, 118);
            textBoxHora.Name = "textBoxHora";
            textBoxHora.Size = new Size(125, 27);
            textBoxHora.TabIndex = 4;
            // 
            // textBoxListaVeiculosEntrada
            // 
            textBoxListaVeiculosEntrada.Location = new Point(99, 213);
            textBoxListaVeiculosEntrada.Multiline = true;
            textBoxListaVeiculosEntrada.Name = "textBoxListaVeiculosEntrada";
            textBoxListaVeiculosEntrada.ReadOnly = true;
            textBoxListaVeiculosEntrada.ScrollBars = ScrollBars.Vertical;
            textBoxListaVeiculosEntrada.Size = new Size(410, 139);
            textBoxListaVeiculosEntrada.TabIndex = 6;
            // 
            // textBoxListaSaidaVeiculos
            // 
            textBoxListaSaidaVeiculos.Location = new Point(617, 213);
            textBoxListaSaidaVeiculos.Multiline = true;
            textBoxListaSaidaVeiculos.Name = "textBoxListaSaidaVeiculos";
            textBoxListaSaidaVeiculos.ReadOnly = true;
            textBoxListaSaidaVeiculos.ScrollBars = ScrollBars.Vertical;
            textBoxListaSaidaVeiculos.Size = new Size(406, 139);
            textBoxListaSaidaVeiculos.TabIndex = 7;
            // 
            // labelListaVeiculosEntrada
            // 
            labelListaVeiculosEntrada.AutoSize = true;
            labelListaVeiculosEntrada.Location = new Point(217, 183);
            labelListaVeiculosEntrada.Name = "labelListaVeiculosEntrada";
            labelListaVeiculosEntrada.Size = new Size(162, 20);
            labelListaVeiculosEntrada.TabIndex = 8;
            labelListaVeiculosEntrada.Text = "Lista Veiculos Garagem";
            // 
            // labelListaVeiculosSaida
            // 
            labelListaVeiculosSaida.AutoSize = true;
            labelListaVeiculosSaida.Location = new Point(771, 183);
            labelListaVeiculosSaida.Name = "labelListaVeiculosSaida";
            labelListaVeiculosSaida.Size = new Size(138, 20);
            labelListaVeiculosSaida.TabIndex = 9;
            labelListaVeiculosSaida.Text = "Lista Veiculos Saida";
            // 
            // buttonEntrada
            // 
            buttonEntrada.Location = new Point(396, 38);
            buttonEntrada.Name = "buttonEntrada";
            buttonEntrada.Size = new Size(94, 29);
            buttonEntrada.TabIndex = 10;
            buttonEntrada.Text = "Entrada";
            buttonEntrada.UseVisualStyleBackColor = true;
            buttonEntrada.Click += buttonGravar_Click;
            // 
            // labeldata
            // 
            labeldata.AutoSize = true;
            labeldata.Location = new Point(859, 9);
            labeldata.Name = "labeldata";
            labeldata.Size = new Size(63, 20);
            labeldata.TabIndex = 11;
            labeldata.Text = "13:52:14";
            // 
            // buttonsaida
            // 
            buttonsaida.Location = new Point(396, 109);
            buttonsaida.Name = "buttonsaida";
            buttonsaida.Size = new Size(94, 29);
            buttonsaida.TabIndex = 12;
            buttonsaida.Text = "Saida";
            buttonsaida.UseVisualStyleBackColor = true;
            buttonsaida.Click += buttonsaida_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(592, 47);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 13;
            label2.Text = "Tempo Permanencia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(592, 91);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 14;
            label3.Text = "Valor a Pagar";
            // 
            // textBoxTempoPermanencia
            // 
            textBoxTempoPermanencia.Location = new Point(756, 44);
            textBoxTempoPermanencia.Name = "textBoxTempoPermanencia";
            textBoxTempoPermanencia.ReadOnly = true;
            textBoxTempoPermanencia.Size = new Size(125, 27);
            textBoxTempoPermanencia.TabIndex = 15;
            // 
            // textBoxValorPagar
            // 
            textBoxValorPagar.Location = new Point(756, 84);
            textBoxValorPagar.Name = "textBoxValorPagar";
            textBoxValorPagar.ReadOnly = true;
            textBoxValorPagar.Size = new Size(125, 27);
            textBoxValorPagar.TabIndex = 16;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // ControleGaragem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 394);
            Controls.Add(textBoxValorPagar);
            Controls.Add(textBoxTempoPermanencia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonsaida);
            Controls.Add(labeldata);
            Controls.Add(buttonEntrada);
            Controls.Add(labelListaVeiculosSaida);
            Controls.Add(textBoxListaSaidaVeiculos);
            Controls.Add(labelListaVeiculosEntrada);
            Controls.Add(textBoxListaVeiculosEntrada);
            Controls.Add(textBoxHora);
            Controls.Add(Hora);
            Controls.Add(textBoxPlacaVeiculo);
            Controls.Add(label1);
            Name = "ControleGaragem";
            Text = "Garagem";
            Load += ControleGaragem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPlacaVeiculo;
        private Label Hora;
        private TextBox textBoxHora;
        private TextBox textBoxListaVeiculosEntrada;
        private TextBox textBoxListaSaidaVeiculos;
        private Label labelListaVeiculosEntrada;
        private Label labelListaVeiculosSaida;
        private Button buttonEntrada;
        private Label labeldata;
        private Button buttonsaida;
        private Label label2;
        private Label label3;
        private TextBox textBoxTempoPermanencia;
        private TextBox textBoxValorPagar;
        private System.Windows.Forms.Timer timer1;
    }
}