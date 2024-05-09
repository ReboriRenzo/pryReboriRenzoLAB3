
namespace pryReboriRenzoLAB3
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblPuntaje = new System.Windows.Forms.Label();
            temporizadorDisparo = new System.Windows.Forms.Timer(components);
            lblPuntos = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblPuntaje
            // 
            lblPuntaje.AutoSize = true;
            lblPuntaje.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPuntaje.ForeColor = System.Drawing.Color.Red;
            lblPuntaje.Location = new System.Drawing.Point(744, 9);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new System.Drawing.Size(65, 17);
            lblPuntaje.TabIndex = 0;
            lblPuntaje.Text = "PUNTOS";
            // 
            // temporizadorDisparo
            // 
            temporizadorDisparo.Enabled = true;
            temporizadorDisparo.Tick += timer1_Tick;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Location = new System.Drawing.Point(815, 11);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new System.Drawing.Size(38, 15);
            lblPuntos.TabIndex = 1;
            lblPuntos.Text = "label1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(864, 538);
            Controls.Add(lblPuntos);
            Controls.Add(lblPuntaje);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmMain";
            Text = "Form1";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Timer temporizadorDisparo;
        private System.Windows.Forms.Label lblPuntos;
    }
}

