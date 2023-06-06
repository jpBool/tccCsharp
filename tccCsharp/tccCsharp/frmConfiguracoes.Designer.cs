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
            this.lblAcessibilidade = new System.Windows.Forms.Label();
            this.rgbPCores = new tccCsharp.RoundedGroupBox();
            this.lblDescC1 = new System.Windows.Forms.Label();
            this.lblDescC2 = new System.Windows.Forms.Label();
            this.lblCor1 = new System.Windows.Forms.Label();
            this.lblDescC3 = new System.Windows.Forms.Label();
            this.lblCor3 = new System.Windows.Forms.Label();
            this.lblDescC4 = new System.Windows.Forms.Label();
            this.lblCor2 = new System.Windows.Forms.Label();
            this.lblDescC5 = new System.Windows.Forms.Label();
            this.lblCorAviso = new System.Windows.Forms.Label();
            this.lblDescC6 = new System.Windows.Forms.Label();
            this.lblCor4 = new System.Windows.Forms.Label();
            this.lblDescC7 = new System.Windows.Forms.Label();
            this.lblCor6 = new System.Windows.Forms.Label();
            this.lblCor5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.rgbPCores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPersonalizacao
            // 
            this.btnPersonalizacao.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPersonalizacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalizacao.Location = new System.Drawing.Point(12, 220);
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
            this.lblConfiguracoes.Location = new System.Drawing.Point(12, 192);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(106, 13);
            this.lblConfiguracoes.TabIndex = 1;
            this.lblConfiguracoes.Text = "Configurações gerais";
            // 
            // btnAltTamFont
            // 
            this.btnAltTamFont.Location = new System.Drawing.Point(12, 58);
            this.btnAltTamFont.Name = "btnAltTamFont";
            this.btnAltTamFont.Size = new System.Drawing.Size(148, 23);
            this.btnAltTamFont.TabIndex = 2;
            this.btnAltTamFont.Text = "Alterar o tamanho da fonte";
            this.btnAltTamFont.UseVisualStyleBackColor = true;
            this.btnAltTamFont.Click += new System.EventHandler(this.btnAltTamFont_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 87);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // lblAcessibilidade
            // 
            this.lblAcessibilidade.AutoSize = true;
            this.lblAcessibilidade.Location = new System.Drawing.Point(12, 32);
            this.lblAcessibilidade.Name = "lblAcessibilidade";
            this.lblAcessibilidade.Size = new System.Drawing.Size(74, 13);
            this.lblAcessibilidade.TabIndex = 24;
            this.lblAcessibilidade.Text = "Acessibilidade";
            // 
            // rgbPCores
            // 
            this.rgbPCores.BackgroundColor = System.Drawing.Color.White;
            this.rgbPCores.BorderWidth = 1F;
            this.rgbPCores.Controls.Add(this.lblDescC1);
            this.rgbPCores.Controls.Add(this.lblDescC2);
            this.rgbPCores.Controls.Add(this.lblCor1);
            this.rgbPCores.Controls.Add(this.lblDescC3);
            this.rgbPCores.Controls.Add(this.lblCor3);
            this.rgbPCores.Controls.Add(this.lblDescC4);
            this.rgbPCores.Controls.Add(this.lblCor2);
            this.rgbPCores.Controls.Add(this.lblDescC5);
            this.rgbPCores.Controls.Add(this.lblCorAviso);
            this.rgbPCores.Controls.Add(this.lblDescC6);
            this.rgbPCores.Controls.Add(this.lblCor4);
            this.rgbPCores.Controls.Add(this.lblDescC7);
            this.rgbPCores.Controls.Add(this.lblCor6);
            this.rgbPCores.Controls.Add(this.lblCor5);
            this.rgbPCores.CornerRadius = 10;
            this.rgbPCores.Location = new System.Drawing.Point(357, 84);
            this.rgbPCores.Name = "rgbPCores";
            this.rgbPCores.Size = new System.Drawing.Size(322, 262);
            this.rgbPCores.TabIndex = 23;
            this.rgbPCores.TabStop = false;
            this.rgbPCores.Text = "Personalização de cores";
            this.rgbPCores.Visible = false;
            // 
            // lblDescC1
            // 
            this.lblDescC1.AutoSize = true;
            this.lblDescC1.Location = new System.Drawing.Point(43, 71);
            this.lblDescC1.Name = "lblDescC1";
            this.lblDescC1.Size = new System.Drawing.Size(153, 13);
            this.lblDescC1.TabIndex = 15;
            this.lblDescC1.Text = "(Parte superior do background)";
            // 
            // lblDescC2
            // 
            this.lblDescC2.AutoSize = true;
            this.lblDescC2.Location = new System.Drawing.Point(43, 96);
            this.lblDescC2.Name = "lblDescC2";
            this.lblDescC2.Size = new System.Drawing.Size(260, 13);
            this.lblDescC2.TabIndex = 22;
            this.lblDescC2.Text = "(cores internas dos cards e outros elementos internos)";
            // 
            // lblCor1
            // 
            this.lblCor1.AutoSize = true;
            this.lblCor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor1.Location = new System.Drawing.Point(18, 71);
            this.lblCor1.Name = "lblCor1";
            this.lblCor1.Size = new System.Drawing.Size(21, 15);
            this.lblCor1.TabIndex = 8;
            this.lblCor1.Text = "    ";
            this.lblCor1.Click += new System.EventHandler(this.lblCor1_Click);
            this.lblCor1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCor1_MouseClick);
            this.lblCor1.MouseEnter += new System.EventHandler(this.lblCor1_MouseEnter);
            this.lblCor1.MouseLeave += new System.EventHandler(this.lblCor1_MouseLeave);
            // 
            // lblDescC3
            // 
            this.lblDescC3.AutoSize = true;
            this.lblDescC3.Location = new System.Drawing.Point(43, 121);
            this.lblDescC3.Name = "lblDescC3";
            this.lblDescC3.Size = new System.Drawing.Size(147, 13);
            this.lblDescC3.TabIndex = 21;
            this.lblDescC3.Text = "(Parte do background inferior)";
            // 
            // lblCor3
            // 
            this.lblCor3.AutoSize = true;
            this.lblCor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor3.Location = new System.Drawing.Point(18, 121);
            this.lblCor3.Name = "lblCor3";
            this.lblCor3.Size = new System.Drawing.Size(21, 15);
            this.lblCor3.TabIndex = 9;
            this.lblCor3.Text = "    ";
            this.lblCor3.Click += new System.EventHandler(this.lblCor3_Click);
            this.lblCor3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCor3_MouseClick);
            this.lblCor3.MouseEnter += new System.EventHandler(this.lblCor3_MouseEnter);
            this.lblCor3.MouseLeave += new System.EventHandler(this.lblCor3_MouseLeave);
            // 
            // lblDescC4
            // 
            this.lblDescC4.AutoSize = true;
            this.lblDescC4.Location = new System.Drawing.Point(43, 146);
            this.lblDescC4.Name = "lblDescC4";
            this.lblDescC4.Size = new System.Drawing.Size(88, 13);
            this.lblDescC4.TabIndex = 20;
            this.lblDescC4.Text = "(cores dos cards)";
            // 
            // lblCor2
            // 
            this.lblCor2.AutoSize = true;
            this.lblCor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor2.Location = new System.Drawing.Point(18, 96);
            this.lblCor2.Name = "lblCor2";
            this.lblCor2.Size = new System.Drawing.Size(21, 15);
            this.lblCor2.TabIndex = 10;
            this.lblCor2.Text = "    ";
            this.lblCor2.Click += new System.EventHandler(this.lblCor2_Click);
            this.lblCor2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCor2_MouseClick);
            this.lblCor2.MouseEnter += new System.EventHandler(this.lblCor2_MouseEnter);
            this.lblCor2.MouseLeave += new System.EventHandler(this.lblCor2_MouseLeave);
            // 
            // lblDescC5
            // 
            this.lblDescC5.AutoSize = true;
            this.lblDescC5.Location = new System.Drawing.Point(43, 171);
            this.lblDescC5.Name = "lblDescC5";
            this.lblDescC5.Size = new System.Drawing.Size(41, 13);
            this.lblDescC5.TabIndex = 19;
            this.lblDescC5.Text = "label11";
            // 
            // lblCorAviso
            // 
            this.lblCorAviso.AutoSize = true;
            this.lblCorAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCorAviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCorAviso.Location = new System.Drawing.Point(18, 221);
            this.lblCorAviso.Name = "lblCorAviso";
            this.lblCorAviso.Size = new System.Drawing.Size(21, 15);
            this.lblCorAviso.TabIndex = 11;
            this.lblCorAviso.Text = "    ";
            this.lblCorAviso.Click += new System.EventHandler(this.lblCorAviso_Click);
            this.lblCorAviso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCorAviso_MouseClick);
            this.lblCorAviso.MouseEnter += new System.EventHandler(this.lblCorAviso_MouseEnter);
            this.lblCorAviso.MouseLeave += new System.EventHandler(this.lblCorAviso_MouseLeave);
            // 
            // lblDescC6
            // 
            this.lblDescC6.AutoSize = true;
            this.lblDescC6.Location = new System.Drawing.Point(43, 196);
            this.lblDescC6.Name = "lblDescC6";
            this.lblDescC6.Size = new System.Drawing.Size(41, 13);
            this.lblDescC6.TabIndex = 18;
            this.lblDescC6.Text = "label10";
            // 
            // lblCor4
            // 
            this.lblCor4.AutoSize = true;
            this.lblCor4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor4.Location = new System.Drawing.Point(18, 146);
            this.lblCor4.Name = "lblCor4";
            this.lblCor4.Size = new System.Drawing.Size(21, 15);
            this.lblCor4.TabIndex = 12;
            this.lblCor4.Text = "    ";
            this.lblCor4.Click += new System.EventHandler(this.lblCor4_Click);
            this.lblCor4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCor4_MouseClick);
            this.lblCor4.MouseEnter += new System.EventHandler(this.lblCor4_MouseEnter);
            this.lblCor4.MouseLeave += new System.EventHandler(this.lblCor4_MouseLeave);
            // 
            // lblDescC7
            // 
            this.lblDescC7.AutoSize = true;
            this.lblDescC7.Location = new System.Drawing.Point(43, 221);
            this.lblDescC7.Name = "lblDescC7";
            this.lblDescC7.Size = new System.Drawing.Size(35, 13);
            this.lblDescC7.TabIndex = 17;
            this.lblDescC7.Text = "label9";
            // 
            // lblCor6
            // 
            this.lblCor6.AutoSize = true;
            this.lblCor6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor6.Location = new System.Drawing.Point(18, 196);
            this.lblCor6.Name = "lblCor6";
            this.lblCor6.Size = new System.Drawing.Size(21, 15);
            this.lblCor6.TabIndex = 13;
            this.lblCor6.Text = "    ";
            // 
            // lblCor5
            // 
            this.lblCor5.AutoSize = true;
            this.lblCor5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor5.Location = new System.Drawing.Point(18, 171);
            this.lblCor5.Name = "lblCor5";
            this.lblCor5.Size = new System.Drawing.Size(21, 15);
            this.lblCor5.TabIndex = 14;
            this.lblCor5.Text = "    ";
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAcessibilidade);
            this.Controls.Add(this.rgbPCores);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnAltTamFont);
            this.Controls.Add(this.lblConfiguracoes);
            this.Controls.Add(this.btnPersonalizacao);
            this.Name = "frmConfiguracoes";
            this.Text = "frmConfiguracoes";
            this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.rgbPCores.ResumeLayout(false);
            this.rgbPCores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.Button btnPersonalizacao;
        private System.Windows.Forms.ColorDialog cldPersonalizacao;
        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.Button btnAltTamFont;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblCor1;
        private System.Windows.Forms.Label lblCor3;
        private System.Windows.Forms.Label lblCor2;
        private System.Windows.Forms.Label lblCorAviso;
        private System.Windows.Forms.Label lblCor4;
        private System.Windows.Forms.Label lblCor6;
        private System.Windows.Forms.Label lblCor5;
        private System.Windows.Forms.Label lblDescC1;
        private System.Windows.Forms.Label lblDescC7;
        private System.Windows.Forms.Label lblDescC6;
        private System.Windows.Forms.Label lblDescC5;
        private System.Windows.Forms.Label lblDescC4;
        private System.Windows.Forms.Label lblDescC3;
        private System.Windows.Forms.Label lblDescC2;
        private RoundedGroupBox rgbPCores;
        private System.Windows.Forms.Label lblAcessibilidade;
    }
}