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
            label1 = new Label();
            textBoxPlacaVeiculo = new TextBox();
            groupBox1 = new GroupBox();
            radioButtonEntrada = new RadioButton();
            radioButtonSaida = new RadioButton();
            Hora = new Label();
            textBoxHora = new TextBox();
            labelDataAtual = new Label();
            textBoxListaVeiculosEntrada = new TextBox();
            textBoxListaSaidaVeiculos = new TextBox();
            labelListaVeiculosEntrada = new Label();
            labelListaVeiculosSaida = new Label();
            buttonGravar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 15);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Digite Placa Veiculo";
            // 
            // textBoxPlacaVeiculo
            // 
            textBoxPlacaVeiculo.Location = new Point(214, 38);
            textBoxPlacaVeiculo.Name = "textBoxPlacaVeiculo";
            textBoxPlacaVeiculo.Size = new Size(125, 27);
            textBoxPlacaVeiculo.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonSaida);
            groupBox1.Controls.Add(radioButtonEntrada);
            groupBox1.Location = new Point(411, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButtonEntrada
            // 
            radioButtonEntrada.AutoSize = true;
            radioButtonEntrada.Location = new Point(33, 26);
            radioButtonEntrada.Name = "radioButtonEntrada";
            radioButtonEntrada.Size = new Size(81, 24);
            radioButtonEntrada.TabIndex = 0;
            radioButtonEntrada.TabStop = true;
            radioButtonEntrada.Text = "Entrada";
            radioButtonEntrada.UseVisualStyleBackColor = true;
            // 
            // radioButtonSaida
            // 
            radioButtonSaida.AutoSize = true;
            radioButtonSaida.Location = new Point(33, 80);
            radioButtonSaida.Name = "radioButtonSaida";
            radioButtonSaida.Size = new Size(67, 24);
            radioButtonSaida.TabIndex = 1;
            radioButtonSaida.TabStop = true;
            radioButtonSaida.Text = "Saida";
            radioButtonSaida.UseVisualStyleBackColor = true;
            // 
            // Hora
            // 
            Hora.AutoSize = true;
            Hora.Location = new Point(217, 77);
            Hora.Name = "Hora";
            Hora.Size = new Size(42, 20);
            Hora.TabIndex = 3;
            Hora.Text = "Hora";
            // 
            // textBoxHora
            // 
            textBoxHora.Location = new Point(213, 105);
            textBoxHora.Name = "textBoxHora";
            textBoxHora.Size = new Size(125, 27);
            textBoxHora.TabIndex = 4;
            // 
            // labelDataAtual
            // 
            labelDataAtual.AutoSize = true;
            labelDataAtual.Location = new Point(107, 425);
            labelDataAtual.Name = "labelDataAtual";
            labelDataAtual.Size = new Size(176, 20);
            labelDataAtual.TabIndex = 5;
            labelDataAtual.Text = "DateTime.Now.ToString()";
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
            textBoxListaSaidaVeiculos.Location = new Point(605, 213);
            textBoxListaSaidaVeiculos.Multiline = true;
            textBoxListaSaidaVeiculos.Name = "textBoxListaSaidaVeiculos";
            textBoxListaSaidaVeiculos.ReadOnly = true;
            textBoxListaSaidaVeiculos.ScrollBars = ScrollBars.Vertical;
            textBoxListaSaidaVeiculos.Size = new Size(395, 139);
            textBoxListaSaidaVeiculos.TabIndex = 7;
            // 
            // labelListaVeiculosEntrada
            // 
            labelListaVeiculosEntrada.AutoSize = true;
            labelListaVeiculosEntrada.Location = new Point(246, 183);
            labelListaVeiculosEntrada.Name = "labelListaVeiculosEntrada";
            labelListaVeiculosEntrada.Size = new Size(162, 20);
            labelListaVeiculosEntrada.TabIndex = 8;
            labelListaVeiculosEntrada.Text = "Lista Veiculos Garagem";
            // 
            // labelListaVeiculosSaida
            // 
            labelListaVeiculosSaida.AutoSize = true;
            labelListaVeiculosSaida.Location = new Point(750, 183);
            labelListaVeiculosSaida.Name = "labelListaVeiculosSaida";
            labelListaVeiculosSaida.Size = new Size(138, 20);
            labelListaVeiculosSaida.TabIndex = 9;
            labelListaVeiculosSaida.Text = "Lista Veiculos Saida";
            // 
            // buttonGravar
            // 
            buttonGravar.Location = new Point(700, 68);
            buttonGravar.Name = "buttonGravar";
            buttonGravar.Size = new Size(94, 29);
            buttonGravar.TabIndex = 10;
            buttonGravar.Text = "Gravar";
            buttonGravar.UseVisualStyleBackColor = true;
            buttonGravar.Click += buttonGravar_Click;
            // 
            // ControleGaragem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 503);
            Controls.Add(buttonGravar);
            Controls.Add(labelListaVeiculosSaida);
            Controls.Add(labelListaVeiculosEntrada);
            Controls.Add(textBoxListaSaidaVeiculos);
            Controls.Add(textBoxListaVeiculosEntrada);
            Controls.Add(labelDataAtual);
            Controls.Add(textBoxHora);
            Controls.Add(Hora);
            Controls.Add(groupBox1);
            Controls.Add(textBoxPlacaVeiculo);
            Controls.Add(label1);
            Name = "ControleGaragem";
            Text = "Placa veiculo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPlacaVeiculo;
        private GroupBox groupBox1;
        private RadioButton radioButtonSaida;
        private RadioButton radioButtonEntrada;
        private Label Hora;
        private TextBox textBoxHora;
        private Label labelDataAtual;
        private TextBox textBoxListaVeiculosEntrada;
        private TextBox textBoxListaSaidaVeiculos;
        private Label labelListaVeiculosEntrada;
        private Label labelListaVeiculosSaida;
        private Button buttonGravar;
    }
}