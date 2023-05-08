namespace tccCsharp
{
    partial class frmPersonalizacao
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
            this.btnSelecaoCorP = new System.Windows.Forms.Button();
            this.cldPersonalizacao = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnSelecaoCorP
            // 
            this.btnSelecaoCorP.Location = new System.Drawing.Point(21, 24);
            this.btnSelecaoCorP.Name = "btnSelecaoCorP";
            this.btnSelecaoCorP.Size = new System.Drawing.Size(136, 23);
            this.btnSelecaoCorP.TabIndex = 0;
            this.btnSelecaoCorP.Text = "Selecione a cor desejada";
            this.btnSelecaoCorP.UseVisualStyleBackColor = true;
            this.btnSelecaoCorP.Click += new System.EventHandler(this.btnSelecaoCorP_Click);
            // 
            // frmPersonalizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelecaoCorP);
            this.Name = "frmPersonalizacao";
            this.Text = "frmPersonalizacao";
            this.Load += new System.EventHandler(this.frmPersonalizacao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecaoCorP;
        private System.Windows.Forms.ColorDialog cldPersonalizacao;
    }
}