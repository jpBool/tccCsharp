using System;

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
            this.cldPersonalizacao = new System.Windows.Forms.ColorDialog();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.btnAltTamFont = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonalizacao
            // 
            this.btnPersonalizacao.Location = new System.Drawing.Point(22, 56);
            this.btnPersonalizacao.Name = "btnPersonalizacao";
            this.btnPersonalizacao.Size = new System.Drawing.Size(102, 23);
            this.btnPersonalizacao.TabIndex = 0;
            this.btnPersonalizacao.Text = "Personalizar cores";
            this.btnPersonalizacao.UseVisualStyleBackColor = true;
            this.btnPersonalizacao.Click += new System.EventHandler(this.btnPersonalizacao_Click);
            this.btnPersonalizacao.MouseEnter += new System.EventHandler(this.btnPersonalizacao_MouseEnter);
            this.btnPersonalizacao.MouseLeave += new System.EventHandler(this.btnPersonalizacao_MouseLeave);
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.Location = new System.Drawing.Point(19, 21);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(75, 13);
            this.lblConfiguracoes.TabIndex = 1;
            this.lblConfiguracoes.Text = "Configurações";
            // 
            // btnAltTamFont
            // 
            this.btnAltTamFont.Location = new System.Drawing.Point(22, 102);
            this.btnAltTamFont.Name = "btnAltTamFont";
            this.btnAltTamFont.Size = new System.Drawing.Size(148, 23);
            this.btnAltTamFont.TabIndex = 2;
            this.btnAltTamFont.Text = "Alterar o tamanho da fonte";
            this.btnAltTamFont.UseVisualStyleBackColor = true;
            this.btnAltTamFont.Click += new System.EventHandler(this.btnAltTamFont_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(22, 144);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnAltTamFont);
            this.Controls.Add(this.lblConfiguracoes);
            this.Controls.Add(this.btnPersonalizacao);
            this.Name = "frmConfiguracoes";
            this.Text = "frmConfiguracoes";
            this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.Button btnPersonalizacao;
        private System.Windows.Forms.ColorDialog cldPersonalizacao;
        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.Button btnAltTamFont;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}