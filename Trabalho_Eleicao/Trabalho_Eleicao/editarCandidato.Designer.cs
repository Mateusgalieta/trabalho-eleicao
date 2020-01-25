namespace Trabalho_Eleicao
{
    partial class editarCandidato
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
            this.txtNomePartido = new System.Windows.Forms.TextBox();
            this.lbNomePartido = new System.Windows.Forms.Label();
            this.txtNumeroPartido = new System.Windows.Forms.TextBox();
            this.lbNumeroPartido = new System.Windows.Forms.Label();
            this.txtImagem = new System.Windows.Forms.TextBox();
            this.pbFotoCandidato = new System.Windows.Forms.PictureBox();
            this.btnImagem = new System.Windows.Forms.Button();
            this.btnEditarCandidato = new System.Windows.Forms.Button();
            this.lbFoto = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.txtNomeAbreviado = new System.Windows.Forms.TextBox();
            this.lbNomeAbreviado = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lbNomeCandidato = new System.Windows.Forms.Label();
            this.lbEditarCandidato = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomePartido
            // 
            this.txtNomePartido.Location = new System.Drawing.Point(524, 181);
            this.txtNomePartido.Name = "txtNomePartido";
            this.txtNomePartido.Size = new System.Drawing.Size(345, 26);
            this.txtNomePartido.TabIndex = 35;
            // 
            // lbNomePartido
            // 
            this.lbNomePartido.AutoSize = true;
            this.lbNomePartido.Location = new System.Drawing.Point(520, 158);
            this.lbNomePartido.Name = "lbNomePartido";
            this.lbNomePartido.Size = new System.Drawing.Size(131, 20);
            this.lbNomePartido.TabIndex = 34;
            this.lbNomePartido.Text = "Nome do Partido:";
            // 
            // txtNumeroPartido
            // 
            this.txtNumeroPartido.Location = new System.Drawing.Point(334, 181);
            this.txtNumeroPartido.Name = "txtNumeroPartido";
            this.txtNumeroPartido.Size = new System.Drawing.Size(141, 26);
            this.txtNumeroPartido.TabIndex = 33;
            // 
            // lbNumeroPartido
            // 
            this.lbNumeroPartido.AutoSize = true;
            this.lbNumeroPartido.Location = new System.Drawing.Point(330, 158);
            this.lbNumeroPartido.Name = "lbNumeroPartido";
            this.lbNumeroPartido.Size = new System.Drawing.Size(145, 20);
            this.lbNumeroPartido.TabIndex = 32;
            this.lbNumeroPartido.Text = "Numero do Partido:";
            // 
            // txtImagem
            // 
            this.txtImagem.Location = new System.Drawing.Point(181, 270);
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.Size = new System.Drawing.Size(206, 26);
            this.txtImagem.TabIndex = 31;
            // 
            // pbFotoCandidato
            // 
            this.pbFotoCandidato.Location = new System.Drawing.Point(90, 259);
            this.pbFotoCandidato.Name = "pbFotoCandidato";
            this.pbFotoCandidato.Size = new System.Drawing.Size(73, 50);
            this.pbFotoCandidato.TabIndex = 30;
            this.pbFotoCandidato.TabStop = false;
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(198, 313);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(144, 47);
            this.btnImagem.TabIndex = 29;
            this.btnImagem.Text = "Inserir Imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.BtnImagem_Click);
            // 
            // btnEditarCandidato
            // 
            this.btnEditarCandidato.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEditarCandidato.Location = new System.Drawing.Point(373, 414);
            this.btnEditarCandidato.Name = "btnEditarCandidato";
            this.btnEditarCandidato.Size = new System.Drawing.Size(451, 43);
            this.btnEditarCandidato.TabIndex = 28;
            this.btnEditarCandidato.Text = "Editar";
            this.btnEditarCandidato.UseVisualStyleBackColor = false;
            this.btnEditarCandidato.Click += new System.EventHandler(this.BtnEditarCandidato_Click);
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(36, 270);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(46, 20);
            this.lbFoto.TabIndex = 27;
            this.lbFoto.Text = "Foto:";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(715, 114);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(109, 26);
            this.txtDataNascimento.TabIndex = 26;
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(711, 91);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(158, 20);
            this.lbDataNascimento.TabIndex = 25;
            this.lbDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtNomeAbreviado
            // 
            this.txtNomeAbreviado.Location = new System.Drawing.Point(37, 181);
            this.txtNomeAbreviado.Name = "txtNomeAbreviado";
            this.txtNomeAbreviado.Size = new System.Drawing.Size(239, 26);
            this.txtNomeAbreviado.TabIndex = 24;
            // 
            // lbNomeAbreviado
            // 
            this.lbNomeAbreviado.AutoSize = true;
            this.lbNomeAbreviado.Location = new System.Drawing.Point(33, 158);
            this.lbNomeAbreviado.Name = "lbNomeAbreviado";
            this.lbNomeAbreviado.Size = new System.Drawing.Size(130, 20);
            this.lbNomeAbreviado.TabIndex = 23;
            this.lbNomeAbreviado.Text = "Nome Abreviado:";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(37, 114);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(642, 26);
            this.txtNomeCompleto.TabIndex = 22;
            // 
            // lbNomeCandidato
            // 
            this.lbNomeCandidato.AutoSize = true;
            this.lbNomeCandidato.Location = new System.Drawing.Point(33, 91);
            this.lbNomeCandidato.Name = "lbNomeCandidato";
            this.lbNomeCandidato.Size = new System.Drawing.Size(127, 20);
            this.lbNomeCandidato.TabIndex = 21;
            this.lbNomeCandidato.Text = "Nome Completo:";
            // 
            // lbEditarCandidato
            // 
            this.lbEditarCandidato.AutoSize = true;
            this.lbEditarCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarCandidato.Location = new System.Drawing.Point(368, 26);
            this.lbEditarCandidato.Name = "lbEditarCandidato";
            this.lbEditarCandidato.Size = new System.Drawing.Size(208, 29);
            this.lbEditarCandidato.TabIndex = 20;
            this.lbEditarCandidato.Text = "Editar Candidato";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // editarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 484);
            this.Controls.Add(this.txtNomePartido);
            this.Controls.Add(this.lbNomePartido);
            this.Controls.Add(this.txtNumeroPartido);
            this.Controls.Add(this.lbNumeroPartido);
            this.Controls.Add(this.txtImagem);
            this.Controls.Add(this.pbFotoCandidato);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.btnEditarCandidato);
            this.Controls.Add(this.lbFoto);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.lbDataNascimento);
            this.Controls.Add(this.txtNomeAbreviado);
            this.Controls.Add(this.lbNomeAbreviado);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lbNomeCandidato);
            this.Controls.Add(this.lbEditarCandidato);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "editarCandidato";
            this.Text = "editarCandidato";
            this.Load += new System.EventHandler(this.EditarCandidato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCandidato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomePartido;
        private System.Windows.Forms.Label lbNomePartido;
        private System.Windows.Forms.TextBox txtNumeroPartido;
        private System.Windows.Forms.Label lbNumeroPartido;
        private System.Windows.Forms.TextBox txtImagem;
        private System.Windows.Forms.PictureBox pbFotoCandidato;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.Button btnEditarCandidato;
        private System.Windows.Forms.Label lbFoto;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.TextBox txtNomeAbreviado;
        private System.Windows.Forms.Label lbNomeAbreviado;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lbNomeCandidato;
        private System.Windows.Forms.Label lbEditarCandidato;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}