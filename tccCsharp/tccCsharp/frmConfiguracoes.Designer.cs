namespace tccCsharp
{
    partial class frmConfiguracoes
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
            this.btnPersonalizacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonalizacao
            // 
            this.btnPersonalizacao.Location = new System.Drawing.Point(72, 59);
            this.btnPersonalizacao.Name = "btnPersonalizacao";
            this.btnPersonalizacao.Size = new System.Drawing.Size(75, 23);
            this.btnPersonalizacao.TabIndex = 0;
            this.btnPersonalizacao.Text = "Personalizar";
            this.btnPersonalizacao.UseVisualStyleBackColor = true;
            this.btnPersonalizacao.Click += new System.EventHandler(this.btnPersonalizacao_Click);
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPersonalizacao);
            this.Name = "frmConfiguracoes";
            this.Text = "frmConfiguracoes";
            this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonalizacao;
    }
}