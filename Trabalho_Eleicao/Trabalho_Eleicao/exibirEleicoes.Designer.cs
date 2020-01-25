namespace Trabalho_Eleicao
{
    partial class exibirEleicoes
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
            this.dgvEleicoes = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEleicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iniciarEleicao = new System.Windows.Forms.DataGridViewButtonColumn();
            this.continuar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.finalizar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleicoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEleicoes
            // 
            this.dgvEleicoes.AllowUserToAddRows = false;
            this.dgvEleicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEleicoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.dataCadastro,
            this.DataEleicao,
            this.Pais,
            this.Editar,
            this.iniciarEleicao,
            this.continuar,
            this.finalizar});
            this.dgvEleicoes.Location = new System.Drawing.Point(1, 2);
            this.dgvEleicoes.Name = "dgvEleicoes";
            this.dgvEleicoes.Size = new System.Drawing.Size(847, 451);
            this.dgvEleicoes.TabIndex = 1;
            this.dgvEleicoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEleicoes_CellContentClick_1);
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            // 
            // dataCadastro
            // 
            this.dataCadastro.HeaderText = "Data de Cadastro";
            this.dataCadastro.Name = "dataCadastro";
            // 
            // DataEleicao
            // 
            this.DataEleicao.HeaderText = "Data da Eleição";
            this.DataEleicao.Name = "DataEleicao";
            // 
            // Pais
            // 
            this.Pais.HeaderText = "País";
            this.Pais.Name = "Pais";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "";
            this.Editar.ToolTipText = "Editar";
            // 
            // iniciarEleicao
            // 
            this.iniciarEleicao.HeaderText = "Iniciar Eleição";
            this.iniciarEleicao.Name = "iniciarEleicao";
            this.iniciarEleicao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iniciarEleicao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // continuar
            // 
            this.continuar.HeaderText = "Continuar Eleição";
            this.continuar.Name = "continuar";
            // 
            // finalizar
            // 
            this.finalizar.HeaderText = "Finalizar Eleição";
            this.finalizar.Name = "finalizar";
            // 
            // exibirEleicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 454);
            this.Controls.Add(this.dgvEleicoes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "exibirEleicoes";
            this.Text = "Lista de Eleições";
            this.Load += new System.EventHandler(this.exibirEleicoes_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleicoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEleicoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEleicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn iniciarEleicao;
        private System.Windows.Forms.DataGridViewButtonColumn continuar;
        private System.Windows.Forms.DataGridViewButtonColumn finalizar;
    }
}