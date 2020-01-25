namespace Trabalho_Eleicao
{
    partial class CadastroCandidato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbNomeCandidato = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtNomeAbreviado = new System.Windows.Forms.TextBox();
            this.lbNomeAbreviado = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lbFoto = new System.Windows.Forms.Label();
            this.btnCadastrarCandidato = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImagem = new System.Windows.Forms.Button();
            this.txtImagem = new System.Windows.Forms.TextBox();
            this.pbFotoCandidato = new System.Windows.Forms.PictureBox();
            this.lbNumeroPartido = new System.Windows.Forms.Label();
            this.txtNumeroPartido = new System.Windows.Forms.TextBox();
            this.txtNomePartido = new System.Windows.Forms.TextBox();
            this.lbNomePartido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Candidato";
            // 
            // lbNomeCandidato
            // 
            this.lbNomeCandidato.AutoSize = true;
            this.lbNomeCandidato.Location = new System.Drawing.Point(29, 70);
            this.lbNomeCandidato.Name = "lbNomeCandidato";
            this.lbNomeCandidato.Size = new System.Drawing.Size(127, 20);
            this.lbNomeCandidato.TabIndex = 1;
            this.lbNomeCandidato.Text = "Nome Completo:";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(33, 93);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(642, 26);
            this.txtNomeCompleto.TabIndex = 2;
            // 
            // txtNomeAbreviado
            // 
            this.txtNomeAbreviado.Location = new System.Drawing.Point(33, 160);
            this.txtNomeAbreviado.Name = "txtNomeAbreviado";
            this.txtNomeAbreviado.Size = new System.Drawing.Size(239, 26);
            this.txtNomeAbreviado.TabIndex = 4;
            // 
            // lbNomeAbreviado
            // 
            this.lbNomeAbreviado.AutoSize = true;
            this.lbNomeAbreviado.Location = new System.Drawing.Point(29, 137);
            this.lbNomeAbreviado.Name = "lbNomeAbreviado";
            this.lbNomeAbreviado.Size = new System.Drawing.Size(130, 20);
            this.lbNomeAbreviado.TabIndex = 3;
            this.lbNomeAbreviado.Text = "Nome Abreviado:";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(707, 70);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(158, 20);
            this.lbDataNascimento.TabIndex = 5;
            this.lbDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(711, 93);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(109, 26);
            this.txtDataNascimento.TabIndex = 6;
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(32, 249);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(46, 20);
            this.lbFoto.TabIndex = 7;
            this.lbFoto.Text = "Foto:";
            // 
            // btnCadastrarCandidato
            // 
            this.btnCadastrarCandidato.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCadastrarCandidato.Location = new System.Drawing.Point(369, 427);
            this.btnCadastrarCandidato.Name = "btnCadastrarCandidato";
            this.btnCadastrarCandidato.Size = new System.Drawing.Size(451, 43);
            this.btnCadastrarCandidato.TabIndex = 12;
            this.btnCadastrarCandidato.Text = "Cadastrar";
            this.btnCadastrarCandidato.UseVisualStyleBackColor = false;
            this.btnCadastrarCandidato.Click += new System.EventHandler(this.BtnCadastrarCandidato_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(194, 292);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(144, 47);
            this.btnImagem.TabIndex = 13;
            this.btnImagem.Text = "Inserir Imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.BtnImagem_Click);
            // 
            // txtImagem
            // 
            this.txtImagem.Location = new System.Drawing.Point(177, 249);
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.Size = new System.Drawing.Size(206, 26);
            this.txtImagem.TabIndex = 15;
            // 
            // pbFotoCandidato
            // 
            this.pbFotoCandidato.Location = new System.Drawing.Point(86, 238);
            this.pbFotoCandidato.Name = "pbFotoCandidato";
            this.pbFotoCandidato.Size = new System.Drawing.Size(73, 50);
            this.pbFotoCandidato.TabIndex = 14;
            this.pbFotoCandidato.TabStop = false;
            // 
            // lbNumeroPartido
            // 
            this.lbNumeroPartido.AutoSize = true;
            this.lbNumeroPartido.Location = new System.Drawing.Point(326, 137);
            this.lbNumeroPartido.Name = "lbNumeroPartido";
            this.lbNumeroPartido.Size = new System.Drawing.Size(145, 20);
            this.lbNumeroPartido.TabIndex = 16;
            this.lbNumeroPartido.Text = "Numero do Partido:";
            // 
            // txtNumeroPartido
            // 
            this.txtNumeroPartido.Location = new System.Drawing.Point(330, 160);
            this.txtNumeroPartido.Name = "txtNumeroPartido";
            this.txtNumeroPartido.Size = new System.Drawing.Size(141, 26);
            this.txtNumeroPartido.TabIndex = 17;
            // 
            // txtNomePartido
            // 
            this.txtNomePartido.Location = new System.Drawing.Point(520, 160);
            this.txtNomePartido.Name = "txtNomePartido";
            this.txtNomePartido.Size = new System.Drawing.Size(345, 26);
            this.txtNomePartido.TabIndex = 19;
            // 
            // lbNomePartido
            // 
            this.lbNomePartido.AutoSize = true;
            this.lbNomePartido.Location = new System.Drawing.Point(516, 137);
            this.lbNomePartido.Name = "lbNomePartido";
            this.lbNomePartido.Size = new System.Drawing.Size(131, 20);
            this.lbNomePartido.TabIndex = 18;
            this.lbNomePartido.Text = "Nome do Partido:";
            // 
            // CadastroCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(911, 499);
            this.Controls.Add(this.txtNomePartido);
            this.Controls.Add(this.lbNomePartido);
            this.Controls.Add(this.txtNumeroPartido);
            this.Controls.Add(this.lbNumeroPartido);
            this.Controls.Add(this.txtImagem);
            this.Controls.Add(this.pbFotoCandidato);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.btnCadastrarCandidato);
            this.Controls.Add(this.lbFoto);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.lbDataNascimento);
            this.Controls.Add(this.txtNomeAbreviado);
            this.Controls.Add(this.lbNomeAbreviado);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lbNomeCandidato);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadastroCandidato";
            this.Text = "Cadastro de Candidato";
            this.Load += new System.EventHandler(this.CadastroCandidato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCandidato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNomeCandidato;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.TextBox txtNomeAbreviado;
        private System.Windows.Forms.Label lbNomeAbreviado;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label lbFoto;
        private System.Windows.Forms.Button btnCadastrarCandidato;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.PictureBox pbFotoCandidato;
        private System.Windows.Forms.TextBox txtImagem;
        private System.Windows.Forms.Label lbNumeroPartido;
        private System.Windows.Forms.TextBox txtNumeroPartido;
        private System.Windows.Forms.TextBox txtNomePartido;
        private System.Windows.Forms.Label lbNomePartido;
    }
}