namespace Trabalho_Eleicao
{
    partial class Sobre
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
            this.lbSobre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSobre
            // 
            this.lbSobre.AutoSize = true;
            this.lbSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSobre.Location = new System.Drawing.Point(22, 48);
            this.lbSobre.Name = "lbSobre";
            this.lbSobre.Size = new System.Drawing.Size(57, 20);
            this.lbSobre.TabIndex = 0;
            this.lbSobre.Text = "label1";
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 454);
            this.Controls.Add(this.lbSobre);
            this.Name = "Sobre";
            this.Text = "Sobre o Sistema";
            this.Load += new System.EventHandler(this.Sobre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSobre;
    }
}