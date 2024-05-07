namespace pryReboriRenzoLAB3
{
    partial class frmInicio
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
            btnGalaga = new System.Windows.Forms.Button();
            btnFirma = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnGalaga
            // 
            btnGalaga.Location = new System.Drawing.Point(211, 73);
            btnGalaga.Name = "btnGalaga";
            btnGalaga.Size = new System.Drawing.Size(113, 44);
            btnGalaga.TabIndex = 1;
            btnGalaga.Text = "Galaga";
            btnGalaga.UseVisualStyleBackColor = true;
            btnGalaga.Click += btnGalaga_Click;
            // 
            // btnFirma
            // 
            btnFirma.Location = new System.Drawing.Point(27, 73);
            btnFirma.Name = "btnFirma";
            btnFirma.Size = new System.Drawing.Size(113, 44);
            btnFirma.TabIndex = 2;
            btnFirma.Text = "Firma";
            btnFirma.UseVisualStyleBackColor = true;
            btnFirma.Click += btnFirma_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Yu Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(334, 61);
            label1.TabIndex = 3;
            label1.Text = "BIENVENIDO";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.AppWorkspace;
            ClientSize = new System.Drawing.Size(353, 137);
            Controls.Add(label1);
            Controls.Add(btnFirma);
            Controls.Add(btnGalaga);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Name = "frmInicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnGalaga;
        private System.Windows.Forms.Button btnFirma;
        private System.Windows.Forms.Label label1;
    }
}