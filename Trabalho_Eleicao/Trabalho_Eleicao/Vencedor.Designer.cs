namespace Trabalho_Eleicao
{
    partial class Vencedor
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
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lbVencedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esse foi o Vencedor da eleição:";
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(245, 82);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(150, 113);
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // lbVencedor
            // 
            this.lbVencedor.AutoSize = true;
            this.lbVencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVencedor.Location = new System.Drawing.Point(240, 214);
            this.lbVencedor.Name = "lbVencedor";
            this.lbVencedor.Size = new System.Drawing.Size(20, 29);
            this.lbVencedor.TabIndex = 2;
            this.lbVencedor.Text = " ";
            // 
            // Vencedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 424);
            this.Controls.Add(this.lbVencedor);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vencedor";
            this.Text = "Vencedor";
            this.Load += new System.EventHandler(this.Vencedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lbVencedor;
    }
}