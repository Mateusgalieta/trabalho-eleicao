namespace Trabalho_Eleicao
{
    partial class ConfirmaCodigo
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
            this.txtCodigoEleicao = new System.Windows.Forms.TextBox();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o código da eleição para continuar.";
            // 
            // txtCodigoEleicao
            // 
            this.txtCodigoEleicao.Location = new System.Drawing.Point(152, 141);
            this.txtCodigoEleicao.Name = "txtCodigoEleicao";
            this.txtCodigoEleicao.Size = new System.Drawing.Size(252, 26);
            this.txtCodigoEleicao.TabIndex = 1;
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.Location = new System.Drawing.Point(83, 218);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(383, 56);
            this.btnProsseguir.TabIndex = 2;
            this.btnProsseguir.Text = "Continuar";
            this.btnProsseguir.UseVisualStyleBackColor = true;
            this.btnProsseguir.Click += new System.EventHandler(this.BtnProsseguir_Click);
            // 
            // ConfirmaCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 375);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.txtCodigoEleicao);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConfirmaCodigo";
            this.Text = "Confirmar codigo da Eleição";
            this.Load += new System.EventHandler(this.ConfirmaCodigo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoEleicao;
        private System.Windows.Forms.Button btnProsseguir;
    }
}