namespace Trabalho_Eleicao
{
    partial class resultadoEleicoes
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lbA = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.lbIntervalDates = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.dgvEleicoes = new System.Windows.Forms.DataGridView();
            this.verResultado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbObs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleicoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(535, 53);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(252, 52);
            this.btnFiltrar.TabIndex = 17;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(343, 73);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(18, 20);
            this.lbA.TabIndex = 16;
            this.lbA.Text = "à";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(377, 69);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(131, 26);
            this.dtpFim.TabIndex = 15;
            // 
            // lbIntervalDates
            // 
            this.lbIntervalDates.AutoSize = true;
            this.lbIntervalDates.Location = new System.Drawing.Point(31, 69);
            this.lbIntervalDates.Name = "lbIntervalDates";
            this.lbIntervalDates.Size = new System.Drawing.Size(159, 20);
            this.lbIntervalDates.TabIndex = 14;
            this.lbIntervalDates.Text = "Intervalo entre datas:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(196, 68);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(131, 26);
            this.dtpInicio.TabIndex = 13;
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(30, 18);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(74, 29);
            this.lbFiltro.TabIndex = 10;
            this.lbFiltro.Text = "Filtro:";
            // 
            // dgvEleicoes
            // 
            this.dgvEleicoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEleicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEleicoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verResultado});
            this.dgvEleicoes.Location = new System.Drawing.Point(35, 172);
            this.dgvEleicoes.Name = "dgvEleicoes";
            this.dgvEleicoes.Size = new System.Drawing.Size(786, 346);
            this.dgvEleicoes.TabIndex = 18;
            this.dgvEleicoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEleicoes_CellContentClick);
            this.dgvEleicoes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvEleicoes_DataBindingComplete);
            // 
            // verResultado
            // 
            this.verResultado.HeaderText = "Ver Resultado";
            this.verResultado.Name = "verResultado";
            this.verResultado.Text = "Ver Resultado";
            this.verResultado.UseColumnTextForButtonValue = true;
            // 
            // lbObs
            // 
            this.lbObs.AutoSize = true;
            this.lbObs.Location = new System.Drawing.Point(35, 130);
            this.lbObs.Name = "lbObs";
            this.lbObs.Size = new System.Drawing.Size(470, 20);
            this.lbObs.TabIndex = 19;
            this.lbObs.Text = "Observação: Todas as eleições listadas aqui já foram encerradas.";
            // 
            // resultadoEleicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 541);
            this.Controls.Add(this.lbObs);
            this.Controls.Add(this.dgvEleicoes);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.lbIntervalDates);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lbFiltro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "resultadoEleicoes";
            this.Text = "Consulta de Resultados";
            this.Load += new System.EventHandler(this.ResultadoEleicoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleicoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label lbIntervalDates;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.DataGridView dgvEleicoes;
        private System.Windows.Forms.DataGridViewButtonColumn verResultado;
        private System.Windows.Forms.Label lbObs;
    }
}