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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            btnGalaga = new System.Windows.Forms.Button();
            btnFirma = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnGalaga
            // 
            btnGalaga.BackgroundImage = Properties.Resources.descarga__1_;
            btnGalaga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGalaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGalaga.Location = new System.Drawing.Point(444, 72);
            btnGalaga.Name = "btnGalaga";
            btnGalaga.Size = new System.Drawing.Size(323, 151);
            btnGalaga.TabIndex = 1;
            btnGalaga.UseVisualStyleBackColor = true;
            btnGalaga.Click += btnGalaga_Click;
            // 
            // btnFirma
            // 
            btnFirma.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnFirma.BackgroundImage");
            btnFirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnFirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFirma.Location = new System.Drawing.Point(43, 72);
            btnFirma.Name = "btnFirma";
            btnFirma.Size = new System.Drawing.Size(317, 151);
            btnFirma.TabIndex = 2;
            btnFirma.Text = "Firma";
            btnFirma.UseVisualStyleBackColor = true;
            btnFirma.Click += btnFirma_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(517, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(170, 27);
            label1.TabIndex = 3;
            label1.Text = "JUGAR GALAGA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(96, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(204, 27);
            label2.TabIndex = 4;
            label2.Text = "GRABAR TU FIRMA";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(808, 281);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFirma);
            Controls.Add(btnGalaga);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmInicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnGalaga;
        private System.Windows.Forms.Button btnFirma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}