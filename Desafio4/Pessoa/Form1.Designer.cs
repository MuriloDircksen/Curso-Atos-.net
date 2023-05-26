namespace Pessoa
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            textBoxListaAlunos = new TextBox();
            textBoxTotalAlunos = new TextBox();
            textBoxTotalPessoas = new TextBox();
            buttonComecar = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 37);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero Objetos Pessoas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 37);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero Objetos Alunos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 143);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 2;
            label3.Text = "Alunos e seus Cursos";
            // 
            // textBoxListaAlunos
            // 
            textBoxListaAlunos.Location = new Point(145, 189);
            textBoxListaAlunos.Multiline = true;
            textBoxListaAlunos.Name = "textBoxListaAlunos";
            textBoxListaAlunos.ReadOnly = true;
            textBoxListaAlunos.Size = new Size(410, 170);
            textBoxListaAlunos.TabIndex = 3;
            // 
            // textBoxTotalAlunos
            // 
            textBoxTotalAlunos.Location = new Point(472, 60);
            textBoxTotalAlunos.Name = "textBoxTotalAlunos";
            textBoxTotalAlunos.ReadOnly = true;
            textBoxTotalAlunos.Size = new Size(33, 27);
            textBoxTotalAlunos.TabIndex = 4;
            // 
            // textBoxTotalPessoas
            // 
            textBoxTotalPessoas.Location = new Point(197, 60);
            textBoxTotalPessoas.Name = "textBoxTotalPessoas";
            textBoxTotalPessoas.ReadOnly = true;
            textBoxTotalPessoas.Size = new Size(32, 27);
            textBoxTotalPessoas.TabIndex = 5;
            // 
            // buttonComecar
            // 
            buttonComecar.Location = new Point(306, 59);
            buttonComecar.Name = "buttonComecar";
            buttonComecar.Size = new Size(94, 29);
            buttonComecar.TabIndex = 6;
            buttonComecar.Text = "Start";
            buttonComecar.UseVisualStyleBackColor = true;
            buttonComecar.Click += buttonComecar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(634, 188);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(122, 171);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(663, 143);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 8;
            label4.Text = "Pessoas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(buttonComecar);
            Controls.Add(textBoxTotalPessoas);
            Controls.Add(textBoxTotalAlunos);
            Controls.Add(textBoxListaAlunos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxListaAlunos;
        private TextBox textBoxTotalAlunos;
        private TextBox textBoxTotalPessoas;
        private Button buttonComecar;
        private TextBox textBox1;
        private Label label4;
    }
}