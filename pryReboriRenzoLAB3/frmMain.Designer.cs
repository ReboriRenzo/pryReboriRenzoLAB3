
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
            temporizadorDisparo = new System.Windows.Forms.Timer(components);
            lblPuntaje = new System.Windows.Forms.Label();
            temporizadorRandom = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // temporizadorDisparo
            // 
            temporizadorDisparo.Enabled = true;
            temporizadorDisparo.Tick += timer1_Tick;
            // 
            // lblPuntaje
            // 
            lblPuntaje.AutoSize = true;
            lblPuntaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPuntaje.ForeColor = System.Drawing.Color.Red;
            lblPuntaje.Location = new System.Drawing.Point(943, 22);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new System.Drawing.Size(75, 21);
            lblPuntaje.TabIndex = 1;
            lblPuntaje.Text = "SCORE: 0";
            lblPuntaje.Click += lblPuntaje_Click;
            // 
            // temporizadorRandom
            // 
            temporizadorRandom.Tick += temporizadorRandom_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(1079, 642);
            Controls.Add(lblPuntaje);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmMain";
            Text = "Form1";
            Load += frmMain_Load;
            KeyDown += frmMain_KeyDown_1;
            KeyPress += frmMain_KeyPress_1;
            KeyUp += frmMain_KeyUp_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer temporizadorDisparo;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Timer temporizadorRandom;
    }
}

