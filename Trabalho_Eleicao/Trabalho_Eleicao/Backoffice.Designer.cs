namespace Trabalho_Eleicao
{
    partial class Backoffice
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eleiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarEleiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirEleiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCandidatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirCandidatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBemVindo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eleiçãoToolStripMenuItem,
            this.candidatosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.documentaçãoToolStripMenuItem,
            this.fecharProgramaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eleiçãoToolStripMenuItem
            // 
            this.eleiçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarEleiçãoToolStripMenuItem,
            this.exibirEleiçõesToolStripMenuItem,
            this.verResultadosToolStripMenuItem});
            this.eleiçãoToolStripMenuItem.Name = "eleiçãoToolStripMenuItem";
            this.eleiçãoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.eleiçãoToolStripMenuItem.Text = "Eleições";
            this.eleiçãoToolStripMenuItem.Click += new System.EventHandler(this.EleiçãoToolStripMenuItem_Click);
            // 
            // cadastrarEleiçãoToolStripMenuItem
            // 
            this.cadastrarEleiçãoToolStripMenuItem.Name = "cadastrarEleiçãoToolStripMenuItem";
            this.cadastrarEleiçãoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadastrarEleiçãoToolStripMenuItem.Text = "Cadastrar Eleição";
            this.cadastrarEleiçãoToolStripMenuItem.Click += new System.EventHandler(this.CadastrarEleiçãoToolStripMenuItem_Click);
            // 
            // exibirEleiçõesToolStripMenuItem
            // 
            this.exibirEleiçõesToolStripMenuItem.Name = "exibirEleiçõesToolStripMenuItem";
            this.exibirEleiçõesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exibirEleiçõesToolStripMenuItem.Text = "Exibir Eleições";
            this.exibirEleiçõesToolStripMenuItem.Click += new System.EventHandler(this.ExibirEleiçõesToolStripMenuItem_Click);
            // 
            // verResultadosToolStripMenuItem
            // 
            this.verResultadosToolStripMenuItem.Name = "verResultadosToolStripMenuItem";
            this.verResultadosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.verResultadosToolStripMenuItem.Text = "Ver Resultados";
            this.verResultadosToolStripMenuItem.Click += new System.EventHandler(this.VerResultadosToolStripMenuItem_Click);
            // 
            // candidatosToolStripMenuItem
            // 
            this.candidatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarCandidatoToolStripMenuItem,
            this.exibirCandidatosToolStripMenuItem});
            this.candidatosToolStripMenuItem.Name = "candidatosToolStripMenuItem";
            this.candidatosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.candidatosToolStripMenuItem.Text = "Candidatos";
            // 
            // cadastrarCandidatoToolStripMenuItem
            // 
            this.cadastrarCandidatoToolStripMenuItem.Name = "cadastrarCandidatoToolStripMenuItem";
            this.cadastrarCandidatoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cadastrarCandidatoToolStripMenuItem.Text = "Cadastrar Candidato";
            this.cadastrarCandidatoToolStripMenuItem.Click += new System.EventHandler(this.CadastrarCandidatoToolStripMenuItem_Click);
            // 
            // exibirCandidatosToolStripMenuItem
            // 
            this.exibirCandidatosToolStripMenuItem.Name = "exibirCandidatosToolStripMenuItem";
            this.exibirCandidatosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exibirCandidatosToolStripMenuItem.Text = "Exibir Candidatos";
            this.exibirCandidatosToolStripMenuItem.Click += new System.EventHandler(this.ExibirCandidatosToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // documentaçãoToolStripMenuItem
            // 
            this.documentaçãoToolStripMenuItem.Name = "documentaçãoToolStripMenuItem";
            this.documentaçãoToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.documentaçãoToolStripMenuItem.Text = "Documentação do Sistema";
            this.documentaçãoToolStripMenuItem.Click += new System.EventHandler(this.DocumentaçãoToolStripMenuItem_Click);
            // 
            // fecharProgramaToolStripMenuItem
            // 
            this.fecharProgramaToolStripMenuItem.Name = "fecharProgramaToolStripMenuItem";
            this.fecharProgramaToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.fecharProgramaToolStripMenuItem.Text = "Fechar Programa";
            this.fecharProgramaToolStripMenuItem.Click += new System.EventHandler(this.FecharProgramaToolStripMenuItem_Click);
            // 
            // labelBemVindo
            // 
            this.labelBemVindo.AutoSize = true;
            this.labelBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBemVindo.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelBemVindo.Location = new System.Drawing.Point(33, 197);
            this.labelBemVindo.Name = "labelBemVindo";
            this.labelBemVindo.Size = new System.Drawing.Size(775, 37);
            this.labelBemVindo.TabIndex = 1;
            this.labelBemVindo.Text = "Seja bem vindo ao sistema eleitoral do MercoSul!!";
            // 
            // Backoffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 497);
            this.Controls.Add(this.labelBemVindo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Backoffice";
            this.Text = "Gerenciar Eleições";
            this.Load += new System.EventHandler(this.Backoffice_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eleiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEleiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCandidatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirEleiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirCandidatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verResultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharProgramaToolStripMenuItem;
        private System.Windows.Forms.Label labelBemVindo;
    }
}