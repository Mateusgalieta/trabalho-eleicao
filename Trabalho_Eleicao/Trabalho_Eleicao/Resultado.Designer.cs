namespace Trabalho_Eleicao
{
    partial class Resultado
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
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.lbEleicao = new System.Windows.Forms.Label();
            this.lbVencedor = new System.Windows.Forms.Label();
            this.vlTitulo = new System.Windows.Forms.Label();
            this.vlVencedor = new System.Windows.Forms.Label();
            this.lbQtdVotos = new System.Windows.Forms.Label();
            this.vlTotalVotos = new System.Windows.Forms.Label();
            this.lbTotalBrancos = new System.Windows.Forms.Label();
            this.vlTotalBrancos = new System.Windows.Forms.Label();
            this.lbTotalNulos = new System.Windows.Forms.Label();
            this.vlTotalNulos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(53, 234);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(696, 257);
            this.dgvResultado.TabIndex = 3;
            this.dgvResultado.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvResultado_DataBindingComplete);
            // 
            // lbEleicao
            // 
            this.lbEleicao.AutoSize = true;
            this.lbEleicao.Location = new System.Drawing.Point(49, 20);
            this.lbEleicao.Name = "lbEleicao";
            this.lbEleicao.Size = new System.Drawing.Size(129, 20);
            this.lbEleicao.TabIndex = 2;
            this.lbEleicao.Text = "Título da Eleição:";
            // 
            // lbVencedor
            // 
            this.lbVencedor.AutoSize = true;
            this.lbVencedor.Location = new System.Drawing.Point(49, 56);
            this.lbVencedor.Name = "lbVencedor";
            this.lbVencedor.Size = new System.Drawing.Size(82, 20);
            this.lbVencedor.TabIndex = 4;
            this.lbVencedor.Text = "Vencedor:";
            // 
            // vlTitulo
            // 
            this.vlTitulo.AutoSize = true;
            this.vlTitulo.Location = new System.Drawing.Point(184, 20);
            this.vlTitulo.Name = "vlTitulo";
            this.vlTitulo.Size = new System.Drawing.Size(13, 20);
            this.vlTitulo.TabIndex = 5;
            this.vlTitulo.Text = " ";
            // 
            // vlVencedor
            // 
            this.vlVencedor.AutoSize = true;
            this.vlVencedor.Location = new System.Drawing.Point(147, 56);
            this.vlVencedor.Name = "vlVencedor";
            this.vlVencedor.Size = new System.Drawing.Size(13, 20);
            this.vlVencedor.TabIndex = 6;
            this.vlVencedor.Text = " ";
            // 
            // lbQtdVotos
            // 
            this.lbQtdVotos.AutoSize = true;
            this.lbQtdVotos.Location = new System.Drawing.Point(49, 93);
            this.lbQtdVotos.Name = "lbQtdVotos";
            this.lbQtdVotos.Size = new System.Drawing.Size(195, 20);
            this.lbQtdVotos.TabIndex = 7;
            this.lbQtdVotos.Text = "Quantidade total de votos:";
            // 
            // vlTotalVotos
            // 
            this.vlTotalVotos.AutoSize = true;
            this.vlTotalVotos.Location = new System.Drawing.Point(250, 93);
            this.vlTotalVotos.Name = "vlTotalVotos";
            this.vlTotalVotos.Size = new System.Drawing.Size(13, 20);
            this.vlTotalVotos.TabIndex = 8;
            this.vlTotalVotos.Text = " ";
            // 
            // lbTotalBrancos
            // 
            this.lbTotalBrancos.AutoSize = true;
            this.lbTotalBrancos.Location = new System.Drawing.Point(49, 131);
            this.lbTotalBrancos.Name = "lbTotalBrancos";
            this.lbTotalBrancos.Size = new System.Drawing.Size(173, 20);
            this.lbTotalBrancos.TabIndex = 9;
            this.lbTotalBrancos.Text = "Total de votos brancos:";
            // 
            // vlTotalBrancos
            // 
            this.vlTotalBrancos.AutoSize = true;
            this.vlTotalBrancos.Location = new System.Drawing.Point(228, 131);
            this.vlTotalBrancos.Name = "vlTotalBrancos";
            this.vlTotalBrancos.Size = new System.Drawing.Size(13, 20);
            this.vlTotalBrancos.TabIndex = 10;
            this.vlTotalBrancos.Text = " ";
            // 
            // lbTotalNulos
            // 
            this.lbTotalNulos.AutoSize = true;
            this.lbTotalNulos.Location = new System.Drawing.Point(49, 167);
            this.lbTotalNulos.Name = "lbTotalNulos";
            this.lbTotalNulos.Size = new System.Drawing.Size(154, 20);
            this.lbTotalNulos.TabIndex = 11;
            this.lbTotalNulos.Text = "Total de votos nulos:";
            // 
            // vlTotalNulos
            // 
            this.vlTotalNulos.AutoSize = true;
            this.vlTotalNulos.Location = new System.Drawing.Point(209, 167);
            this.vlTotalNulos.Name = "vlTotalNulos";
            this.vlTotalNulos.Size = new System.Drawing.Size(13, 20);
            this.vlTotalNulos.TabIndex = 12;
            this.vlTotalNulos.Text = " ";
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 514);
            this.Controls.Add(this.vlTotalNulos);
            this.Controls.Add(this.lbTotalNulos);
            this.Controls.Add(this.vlTotalBrancos);
            this.Controls.Add(this.lbTotalBrancos);
            this.Controls.Add(this.vlTotalVotos);
            this.Controls.Add(this.lbQtdVotos);
            this.Controls.Add(this.vlVencedor);
            this.Controls.Add(this.vlTitulo);
            this.Controls.Add(this.lbVencedor);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.lbEleicao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label lbEleicao;
        private System.Windows.Forms.Label lbVencedor;
        private System.Windows.Forms.Label vlTitulo;
        private System.Windows.Forms.Label vlVencedor;
        private System.Windows.Forms.Label lbQtdVotos;
        private System.Windows.Forms.Label vlTotalVotos;
        private System.Windows.Forms.Label lbTotalBrancos;
        private System.Windows.Forms.Label vlTotalBrancos;
        private System.Windows.Forms.Label lbTotalNulos;
        private System.Windows.Forms.Label vlTotalNulos;
    }
}