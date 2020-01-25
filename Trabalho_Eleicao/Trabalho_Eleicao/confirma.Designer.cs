namespace Trabalho_Eleicao
{
    partial class confirma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbConfirma = new System.Windows.Forms.PictureBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbPartido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Partido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pressione S para confirmar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pressione N para cancelar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pbConfirma
            // 
            this.pbConfirma.Location = new System.Drawing.Point(449, 12);
            this.pbConfirma.Name = "pbConfirma";
            this.pbConfirma.Size = new System.Drawing.Size(154, 177);
            this.pbConfirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConfirma.TabIndex = 6;
            this.pbConfirma.TabStop = false;
            this.pbConfirma.Click += new System.EventHandler(this.pbConfirma_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(108, 25);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(60, 24);
            this.lbNome.TabIndex = 7;
            this.lbNome.Text = "label5";
            // 
            // lbPartido
            // 
            this.lbPartido.AutoSize = true;
            this.lbPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPartido.Location = new System.Drawing.Point(108, 80);
            this.lbPartido.Name = "lbPartido";
            this.lbPartido.Size = new System.Drawing.Size(60, 24);
            this.lbPartido.TabIndex = 8;
            this.lbPartido.Text = "label5";
            // 
            // confirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 286);
            this.ControlBox = false;
            this.Controls.Add(this.lbPartido);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.pbConfirma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "confirma";
            this.Text = "confirma";
            this.Load += new System.EventHandler(this.confirma_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirma_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbConfirma;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbPartido;
    }
}