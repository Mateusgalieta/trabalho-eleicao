namespace Trabalho_Eleicao
{
    partial class Documentacao
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
            this.lbDocumentação = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDocumentação
            // 
            this.lbDocumentação.AutoSize = true;
            this.lbDocumentação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocumentação.Location = new System.Drawing.Point(12, 45);
            this.lbDocumentação.Name = "lbDocumentação";
            this.lbDocumentação.Size = new System.Drawing.Size(57, 20);
            this.lbDocumentação.TabIndex = 1;
            this.lbDocumentação.Text = "label1";
            // 
            // Documentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 477);
            this.Controls.Add(this.lbDocumentação);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Documentacao";
            this.Text = "Documentacao do sistema";
            this.Load += new System.EventHandler(this.Documentacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDocumentação;
    }
}