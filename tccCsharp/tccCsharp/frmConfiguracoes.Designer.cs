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
            this.cldPersonalizacao = new System.Windows.Forms.ColorDialog();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.nudFonte = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.OPBLogout = new tccCsharp.OvalPictureBox();
            this.opbConfiguracoes = new tccCsharp.OvalPictureBox();
            this.opbRecarregar = new tccCsharp.OvalPictureBox();
            this.btnPersonalizar = new RoundButton();
            this.btnAltTamF = new RoundButton();
            this.btnVoltar = new RoundButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudFonte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPBLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbConfiguracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbRecarregar)).BeginInit();
            this.rgbPCores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracoes.Location = new System.Drawing.Point(38, 153);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(300, 19);
            this.lblConfiguracoes.TabIndex = 1;
            this.lblConfiguracoes.Text = "Configurações gerais e Acessibilidade";
            // 
            // nudFonte
            // 
            this.nudFonte.Location = new System.Drawing.Point(484, 129);
            this.nudFonte.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudFonte.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudFonte.Name = "nudFonte";
            this.nudFonte.Size = new System.Drawing.Size(52, 20);
            this.nudFonte.TabIndex = 7;
            this.nudFonte.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudFonte.Visible = false;
            this.nudFonte.ValueChanged += new System.EventHandler(this.nudFonte_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Configurações gerais";
            // 
            // OPBLogout
            // 
            this.OPBLogout._bordercolor = System.Drawing.Color.Red;
            this.OPBLogout._borderwidth = 5F;
            this.OPBLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OPBLogout.BackColor = System.Drawing.Color.White;
            this.OPBLogout.Image = global::tccCsharp.Properties.Resources._logout_;
            this.OPBLogout.Location = new System.Drawing.Point(777, 12);
            this.OPBLogout.Name = "OPBLogout";
            this.OPBLogout.Size = new System.Drawing.Size(48, 48);
            this.OPBLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.OPBLogout.TabIndex = 29;
            this.OPBLogout.TabStop = false;
            // 
            // opbConfiguracoes
            // 
            this.opbConfiguracoes._bordercolor = System.Drawing.Color.Red;
            this.opbConfiguracoes._borderwidth = 5F;
            this.opbConfiguracoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.opbConfiguracoes.Image = global::tccCsharp.Properties.Resources.configuracoes;
            this.opbConfiguracoes.Location = new System.Drawing.Point(922, 12);
            this.opbConfiguracoes.Name = "opbConfiguracoes";
            this.opbConfiguracoes.Size = new System.Drawing.Size(48, 48);
            this.opbConfiguracoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.opbConfiguracoes.TabIndex = 30;
            this.opbConfiguracoes.TabStop = false;
            // 
            // opbRecarregar
            // 
            this.opbRecarregar._bordercolor = System.Drawing.Color.Red;
            this.opbRecarregar._borderwidth = 5F;
            this.opbRecarregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.opbRecarregar.Image = global::tccCsharp.Properties.Resources.recarregar;
            this.opbRecarregar.Location = new System.Drawing.Point(848, 12);
            this.opbRecarregar.Name = "opbRecarregar";
            this.opbRecarregar.Size = new System.Drawing.Size(48, 48);
            this.opbRecarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.opbRecarregar.TabIndex = 31;
            this.opbRecarregar.TabStop = false;
            this.opbRecarregar.Click += new System.EventHandler(this.opbRecarregar_Click);
            // 
            // btnPersonalizar
            // 
            this.btnPersonalizar.BorderColor = System.Drawing.Color.Black;
            this.btnPersonalizar.BorderRadius = 10;
            this.btnPersonalizar.BorderThickness = 2;
            this.btnPersonalizar.ButtonColor = System.Drawing.Color.White;
            this.btnPersonalizar.Location = new System.Drawing.Point(42, 227);
            this.btnPersonalizar.Name = "btnPersonalizar";
            this.btnPersonalizar.Size = new System.Drawing.Size(143, 23);
            this.btnPersonalizar.TabIndex = 28;
            this.btnPersonalizar.Text = "Personalizar cores";
            this.btnPersonalizar.UseVisualStyleBackColor = true;
            this.btnPersonalizar.Click += new System.EventHandler(this.btnPersonalizar_Click);
            // 
            // btnAltTamF
            // 
            this.btnAltTamF.BorderColor = System.Drawing.Color.Black;
            this.btnAltTamF.BorderRadius = 10;
            this.btnAltTamF.BorderThickness = 2;
            this.btnAltTamF.ButtonColor = System.Drawing.Color.White;
            this.btnAltTamF.Location = new System.Drawing.Point(42, 277);
            this.btnAltTamF.Name = "btnAltTamF";
            this.btnAltTamF.Size = new System.Drawing.Size(143, 23);
            this.btnAltTamF.TabIndex = 27;
            this.btnAltTamF.Text = "Alterar o tamanho da fonte";
            this.btnAltTamF.UseVisualStyleBackColor = true;
            this.btnAltTamF.Click += new System.EventHandler(this.btnAltTamF_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.BorderRadius = 10;
            this.btnVoltar.BorderThickness = 2;
            this.btnVoltar.ButtonColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(905, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
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
            this.rgbPCores.Location = new System.Drawing.Point(556, 116);
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
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.btnPersonalizar);
            this.Controls.Add(this.btnAltTamF);
            this.Controls.Add(this.opbConfiguracoes);
            this.Controls.Add(this.OPBLogout);
            this.Controls.Add(this.opbRecarregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.rgbPCores);
            this.Controls.Add(this.nudFonte);
            this.Controls.Add(this.lblConfiguracoes);
            this.Name = "frmConfiguracoes";
            this.Text = "frmConfiguracoes";
            this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFonte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPBLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbConfiguracoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbRecarregar)).EndInit();
            this.rgbPCores.ResumeLayout(false);
            this.rgbPCores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion
        private System.Windows.Forms.ColorDialog cldPersonalizacao;
        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.NumericUpDown nudFonte;
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
        private RoundButton btnVoltar;
        private System.Windows.Forms.Label label1;
        private RoundButton btnAltTamF;
        private RoundButton btnPersonalizar;
        private OvalPictureBox opbRecarregar;
        private OvalPictureBox OPBLogout;
        private OvalPictureBox opbConfiguracoes;
    }
}