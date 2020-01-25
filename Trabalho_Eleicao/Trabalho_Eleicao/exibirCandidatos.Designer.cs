namespace Trabalho_Eleicao
{
    partial class exibirCandidatos
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
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar});
            this.dgvCandidatos.Location = new System.Drawing.Point(8, 12);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.ReadOnly = true;
            this.dgvCandidatos.Size = new System.Drawing.Size(845, 453);
            this.dgvCandidatos.TabIndex = 0;
            this.dgvCandidatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCandidatos_CellContentClick);
            this.dgvCandidatos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCandidatos_CellEndEdit);
            this.dgvCandidatos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvCandidatos_DataBindingComplete);
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Text = "Editar";
            this.editar.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Trabalho_Eleicao.Properties.Resources.edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // exibirCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 478);
            this.Controls.Add(this.dgvCandidatos);
            this.Name = "exibirCandidatos";
            this.Text = "Lista de Candidatos";
            this.Load += new System.EventHandler(this.ExibirCandidatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidatos;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
    }
}