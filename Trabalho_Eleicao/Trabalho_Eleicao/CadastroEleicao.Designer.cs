namespace Trabalho_Eleicao
{
    partial class CadastroEleicao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbPais = new System.Windows.Forms.Label();
            this.txtDataEleicao = new System.Windows.Forms.MaskedTextBox();
            this.lbDataEleicao = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbCadastroDeEleicao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCandidatos);
            this.groupBox1.Location = new System.Drawing.Point(38, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 219);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Candidatos:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.AllowUserToAddRows = false;
            this.dgvCandidatos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.dgvCandidatos.Location = new System.Drawing.Point(6, 25);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.Size = new System.Drawing.Size(761, 188);
            this.dgvCandidatos.TabIndex = 0;
            this.dgvCandidatos.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "  ";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Nome";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Partido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Número";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1- Brasil",
            "2- Argentina",
            "3- Paraguai",
            "4- Uruguai"});
            this.comboBox1.Location = new System.Drawing.Point(585, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 28);
            this.comboBox1.TabIndex = 28;
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(536, 135);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(43, 20);
            this.lbPais.TabIndex = 27;
            this.lbPais.Text = "País:";
            // 
            // txtDataEleicao
            // 
            this.txtDataEleicao.Location = new System.Drawing.Point(423, 132);
            this.txtDataEleicao.Mask = "00/00/0000";
            this.txtDataEleicao.Name = "txtDataEleicao";
            this.txtDataEleicao.Size = new System.Drawing.Size(96, 26);
            this.txtDataEleicao.TabIndex = 26;
            // 
            // lbDataEleicao
            // 
            this.lbDataEleicao.AutoSize = true;
            this.lbDataEleicao.Location = new System.Drawing.Point(291, 135);
            this.lbDataEleicao.Name = "lbDataEleicao";
            this.lbDataEleicao.Size = new System.Drawing.Size(126, 20);
            this.lbDataEleicao.TabIndex = 25;
            this.lbDataEleicao.Text = "Data da Eleição:";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(179, 132);
            this.txtDataCadastro.Mask = "00/00/0000";
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.RejectInputOnFirstFailure = true;
            this.txtDataCadastro.Size = new System.Drawing.Size(96, 26);
            this.txtDataCadastro.TabIndex = 24;
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.Location = new System.Drawing.Point(34, 135);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(139, 20);
            this.lbDataCadastro.TabIndex = 23;
            this.lbDataCadastro.Text = "Data de Cadastro:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(372, 79);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(439, 26);
            this.txtTitulo.TabIndex = 22;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(237, 82);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(129, 20);
            this.lbTitulo.TabIndex = 21;
            this.lbTitulo.Text = "Título da Eleição:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(103, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(120, 26);
            this.txtCodigo.TabIndex = 20;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(34, 82);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(63, 20);
            this.lbCodigo.TabIndex = 19;
            this.lbCodigo.Text = "Código:";
            // 
            // lbCadastroDeEleicao
            // 
            this.lbCadastroDeEleicao.AutoSize = true;
            this.lbCadastroDeEleicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroDeEleicao.Location = new System.Drawing.Point(290, 21);
            this.lbCadastroDeEleicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadastroDeEleicao.Name = "lbCadastroDeEleicao";
            this.lbCadastroDeEleicao.Size = new System.Drawing.Size(250, 29);
            this.lbCadastroDeEleicao.TabIndex = 18;
            this.lbCadastroDeEleicao.Text = "Cadastro de Eleição";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(773, 61);
            this.button1.TabIndex = 30;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CadastroEleicao
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.txtDataEleicao);
            this.Controls.Add(this.lbDataEleicao);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.lbDataCadastro);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbCadastroDeEleicao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadastroEleicao";
            this.Text = "Cadastro de Eleição";
            this.Load += new System.EventHandler(this.CadastroEleicao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCandidatos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.MaskedTextBox txtDataEleicao;
        private System.Windows.Forms.Label lbDataEleicao;
        private System.Windows.Forms.MaskedTextBox txtDataCadastro;
        private System.Windows.Forms.Label lbDataCadastro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbCadastroDeEleicao;
        private System.Windows.Forms.Button button1;
    }
}