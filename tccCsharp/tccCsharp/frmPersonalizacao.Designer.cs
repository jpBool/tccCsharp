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
            this.btnSelecaoDaltonismo = new System.Windows.Forms.Button();
            this.cldAcessibilidade = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnSelecaoDaltonismo
            // 
            this.btnSelecaoDaltonismo.Location = new System.Drawing.Point(21, 24);
            this.btnSelecaoDaltonismo.Name = "btnSelecaoDaltonismo";
            this.btnSelecaoDaltonismo.Size = new System.Drawing.Size(136, 23);
            this.btnSelecaoDaltonismo.TabIndex = 0;
            this.btnSelecaoDaltonismo.Text = "Selecione a cor desejada";
            this.btnSelecaoDaltonismo.UseVisualStyleBackColor = true;
            this.btnSelecaoDaltonismo.Click += new System.EventHandler(this.btnSelecaoCorP_Click);
            // 
            // frmPersonalizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelecaoDaltonismo);
            this.Name = "frmPersonalizacao";
            this.Text = "frmPersonalizacao";
            this.Load += new System.EventHandler(this.frmPersonalizacao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecaoDaltonismo;
        private System.Windows.Forms.ColorDialog cldAcessibilidade;
    }
}