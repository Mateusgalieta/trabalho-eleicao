namespace Trabalho_Eleicao
{
    partial class resultadosEleicoes
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
            this.lbEleicoes = new System.Windows.Forms.ListBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lbIntervalDates = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.lbA = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEleicoes
            // 
            this.lbEleicoes.FormattingEnabled = true;
            this.lbEleicoes.ItemHeight = 20;
            this.lbEleicoes.Location = new System.Drawing.Point(21, 210);
            this.lbEleicoes.Name = "lbEleicoes";
            this.lbEleicoes.Size = new System.Drawing.Size(799, 264);
            this.lbEleicoes.TabIndex = 0;
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(29, 22);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(74, 29);
            this.lbFiltro.TabIndex = 1;
            this.lbFiltro.Text = "Filtro:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(30, 82);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(60, 20);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Cadastrada",
            "Em Andamento",
            "Encerrada",
            "Cancelada"});
            this.cbStatus.Location = new System.Drawing.Point(96, 79);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(215, 28);
            this.cbStatus.TabIndex = 3;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(494, 81);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(131, 26);
            this.dtpInicio.TabIndex = 4;
            // 
            // lbIntervalDates
            // 
            this.lbIntervalDates.AutoSize = true;
            this.lbIntervalDates.Location = new System.Drawing.Point(329, 82);
            this.lbIntervalDates.Name = "lbIntervalDates";
            this.lbIntervalDates.Size = new System.Drawing.Size(159, 20);
            this.lbIntervalDates.TabIndex = 5;
            this.lbIntervalDates.Text = "Intervalo entre datas:";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(675, 82);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(131, 26);
            this.dtpFim.TabIndex = 6;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(641, 86);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(18, 20);
            this.lbA.TabIndex = 7;
            this.lbA.Text = "à";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(462, 138);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(344, 52);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // resultadosEleicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 504);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.lbIntervalDates);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.lbEleicoes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "resultadosEleicoes";
            this.Text = "Resultados das Eleições";
            this.Load += new System.EventHandler(this.ResultadosEeicoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEleicoes;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lbIntervalDates;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Button btnFiltrar;
    }
}