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
            this.tlpBaseConfig1 = new System.Windows.Forms.TableLayoutPanel();
            this.rgbMenu = new tccCsharp.RoundedGroupBox();
            this.OPBLogout = new tccCsharp.OvalPictureBox();
            this.opbRecarregar = new tccCsharp.OvalPictureBox();
            this.opbConfiguracoes = new tccCsharp.OvalPictureBox();
            this.tlpBaseConfig2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBaseConfig4 = new System.Windows.Forms.TableLayoutPanel();
            this.rgbPCores = new tccCsharp.RoundedGroupBox();
            this.lblCorBranca = new System.Windows.Forms.Label();
            this.lblIconeBranco = new System.Windows.Forms.Label();
            this.lblCorPreta = new System.Windows.Forms.Label();
            this.lblIconePreto = new System.Windows.Forms.Label();
            this.lblTrocaIcones = new System.Windows.Forms.Label();
            this.lblPCores = new System.Windows.Forms.Label();
            this.lblCoresTexto = new System.Windows.Forms.Label();
            this.lblCoresAviso = new System.Windows.Forms.Label();
            this.lblCoresElementos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorAviso2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCorTexto2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCorTexto1 = new System.Windows.Forms.Label();
            this.lblCorAviso1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCor7 = new System.Windows.Forms.Label();
            this.lblDescC1 = new System.Windows.Forms.Label();
            this.lblDescC2 = new System.Windows.Forms.Label();
            this.lblCor1 = new System.Windows.Forms.Label();
            this.lblDescC3 = new System.Windows.Forms.Label();
            this.lblCor3 = new System.Windows.Forms.Label();
            this.lblDescC4 = new System.Windows.Forms.Label();
            this.lblCor2 = new System.Windows.Forms.Label();
            this.lblDescC5 = new System.Windows.Forms.Label();
            this.lblDescC6 = new System.Windows.Forms.Label();
            this.lblCor4 = new System.Windows.Forms.Label();
            this.lblCor6 = new System.Windows.Forms.Label();
            this.lblCor5 = new System.Windows.Forms.Label();
            this.btnVoltar = new RoundButton();
            this.tlpBaseConfig3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBaseConfig5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblConfigsG = new System.Windows.Forms.Label();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.tlpBaseConfig6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAltTamF = new RoundButton();
            this.btnTutoriais = new RoundButton();
            this.btnPersonalizar = new RoundButton();
            this.btnRestaurarPadrao = new RoundButton();
            this.tlpBaseConfig1.SuspendLayout();
            this.rgbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OPBLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbRecarregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbConfiguracoes)).BeginInit();
            this.tlpBaseConfig2.SuspendLayout();
            this.tlpBaseConfig4.SuspendLayout();
            this.rgbPCores.SuspendLayout();
            this.tlpBaseConfig3.SuspendLayout();
            this.tlpBaseConfig5.SuspendLayout();
            this.tlpBaseConfig6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBaseConfig1
            // 
            this.tlpBaseConfig1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBaseConfig1.ColumnCount = 1;
            this.tlpBaseConfig1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBaseConfig1.Controls.Add(this.rgbMenu, 0, 0);
            this.tlpBaseConfig1.Controls.Add(this.tlpBaseConfig2, 0, 1);
            this.tlpBaseConfig1.Location = new System.Drawing.Point(0, 0);
            this.tlpBaseConfig1.Name = "tlpBaseConfig1";
            this.tlpBaseConfig1.RowCount = 2;
            this.tlpBaseConfig1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.68653F));
            this.tlpBaseConfig1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.31347F));
            this.tlpBaseConfig1.Size = new System.Drawing.Size(1086, 622);
            this.tlpBaseConfig1.TabIndex = 35;
            // 
            // rgbMenu
            // 
            this.rgbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgbMenu.BackgroundColor = System.Drawing.Color.White;
            this.rgbMenu.BorderWidth = 1F;
            this.rgbMenu.Controls.Add(this.OPBLogout);
            this.rgbMenu.Controls.Add(this.opbRecarregar);
            this.rgbMenu.Controls.Add(this.opbConfiguracoes);
            this.rgbMenu.CornerRadius = 10;
            this.rgbMenu.Location = new System.Drawing.Point(3, 3);
            this.rgbMenu.Name = "rgbMenu";
            this.rgbMenu.Size = new System.Drawing.Size(1080, 55);
            this.rgbMenu.TabIndex = 36;
            this.rgbMenu.TabStop = false;
            // 
            // OPBLogout
            // 
            this.OPBLogout._bordercolor = System.Drawing.Color.Red;
            this.OPBLogout._borderwidth = 5F;
            this.OPBLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OPBLogout.AutoHoover = false;
            this.OPBLogout.BackColor = System.Drawing.Color.Transparent;
            this.OPBLogout.BordaHoover = System.Drawing.Color.Green;
            this.OPBLogout.BordaPrincipal = System.Drawing.Color.Black;
            this.OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_White;
            this.OPBLogout.Location = new System.Drawing.Point(909, 1);
            this.OPBLogout.Name = "OPBLogout";
            this.OPBLogout.Size = new System.Drawing.Size(48, 48);
            this.OPBLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OPBLogout.TabIndex = 29;
            this.OPBLogout.TabStop = false;
            this.OPBLogout.Click += new System.EventHandler(this.OPBLogout_Click);
            // 
            // opbRecarregar
            // 
            this.opbRecarregar._bordercolor = System.Drawing.Color.Red;
            this.opbRecarregar._borderwidth = 5F;
            this.opbRecarregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opbRecarregar.AutoHoover = false;
            this.opbRecarregar.BackColor = System.Drawing.Color.Transparent;
            this.opbRecarregar.BordaHoover = System.Drawing.Color.Green;
            this.opbRecarregar.BordaPrincipal = System.Drawing.Color.Black;
            this.opbRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_White;
            this.opbRecarregar.Location = new System.Drawing.Point(963, 1);
            this.opbRecarregar.Name = "opbRecarregar";
            this.opbRecarregar.Size = new System.Drawing.Size(48, 48);
            this.opbRecarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.opbRecarregar.TabIndex = 31;
            this.opbRecarregar.TabStop = false;
            this.opbRecarregar.Click += new System.EventHandler(this.opbRecarregar_Click);
            // 
            // opbConfiguracoes
            // 
            this.opbConfiguracoes._bordercolor = System.Drawing.Color.Red;
            this.opbConfiguracoes._borderwidth = 5F;
            this.opbConfiguracoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opbConfiguracoes.AutoHoover = false;
            this.opbConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.opbConfiguracoes.BordaHoover = System.Drawing.Color.Green;
            this.opbConfiguracoes.BordaPrincipal = System.Drawing.Color.Black;
            this.opbConfiguracoes.Image = global::tccCsharp.Properties.Resources.Config_White;
            this.opbConfiguracoes.Location = new System.Drawing.Point(1017, 1);
            this.opbConfiguracoes.Name = "opbConfiguracoes";
            this.opbConfiguracoes.Size = new System.Drawing.Size(48, 48);
            this.opbConfiguracoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.opbConfiguracoes.TabIndex = 30;
            this.opbConfiguracoes.TabStop = false;
            // 
            // tlpBaseConfig2
            // 
            this.tlpBaseConfig2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBaseConfig2.ColumnCount = 2;
            this.tlpBaseConfig2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tlpBaseConfig2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tlpBaseConfig2.Controls.Add(this.tlpBaseConfig4, 1, 1);
            this.tlpBaseConfig2.Controls.Add(this.tlpBaseConfig3, 0, 1);
            this.tlpBaseConfig2.Location = new System.Drawing.Point(3, 88);
            this.tlpBaseConfig2.Name = "tlpBaseConfig2";
            this.tlpBaseConfig2.RowCount = 2;
            this.tlpBaseConfig2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.105263F));
            this.tlpBaseConfig2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.89474F));
            this.tlpBaseConfig2.Size = new System.Drawing.Size(1080, 531);
            this.tlpBaseConfig2.TabIndex = 35;
            this.tlpBaseConfig2.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpBaseConfig2_Paint);
            // 
            // tlpBaseConfig4
            // 
            this.tlpBaseConfig4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBaseConfig4.ColumnCount = 4;
            this.tlpBaseConfig4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.27553F));
            this.tlpBaseConfig4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.72447F));
            this.tlpBaseConfig4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpBaseConfig4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBaseConfig4.Controls.Add(this.rgbPCores, 1, 1);
            this.tlpBaseConfig4.Controls.Add(this.btnVoltar, 1, 3);
            this.tlpBaseConfig4.Location = new System.Drawing.Point(523, 14);
            this.tlpBaseConfig4.Name = "tlpBaseConfig4";
            this.tlpBaseConfig4.RowCount = 5;
            this.tlpBaseConfig4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.605863F));
            this.tlpBaseConfig4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.39413F));
            this.tlpBaseConfig4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpBaseConfig4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpBaseConfig4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpBaseConfig4.Size = new System.Drawing.Size(554, 514);
            this.tlpBaseConfig4.TabIndex = 33;
            this.tlpBaseConfig4.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpBaseConfig4_Paint);
            // 
            // rgbPCores
            // 
            this.rgbPCores.BackgroundColor = System.Drawing.Color.White;
            this.rgbPCores.BorderWidth = 1F;
            this.rgbPCores.Controls.Add(this.btnRestaurarPadrao);
            this.rgbPCores.Controls.Add(this.lblCorBranca);
            this.rgbPCores.Controls.Add(this.lblIconeBranco);
            this.rgbPCores.Controls.Add(this.lblCorPreta);
            this.rgbPCores.Controls.Add(this.lblIconePreto);
            this.rgbPCores.Controls.Add(this.lblTrocaIcones);
            this.rgbPCores.Controls.Add(this.lblPCores);
            this.rgbPCores.Controls.Add(this.lblCoresTexto);
            this.rgbPCores.Controls.Add(this.lblCoresAviso);
            this.rgbPCores.Controls.Add(this.lblCoresElementos);
            this.rgbPCores.Controls.Add(this.label1);
            this.rgbPCores.Controls.Add(this.lblCorAviso2);
            this.rgbPCores.Controls.Add(this.label4);
            this.rgbPCores.Controls.Add(this.lblCorTexto2);
            this.rgbPCores.Controls.Add(this.label6);
            this.rgbPCores.Controls.Add(this.label7);
            this.rgbPCores.Controls.Add(this.lblCorTexto1);
            this.rgbPCores.Controls.Add(this.lblCorAviso1);
            this.rgbPCores.Controls.Add(this.label2);
            this.rgbPCores.Controls.Add(this.lblCor7);
            this.rgbPCores.Controls.Add(this.lblDescC1);
            this.rgbPCores.Controls.Add(this.lblDescC2);
            this.rgbPCores.Controls.Add(this.lblCor1);
            this.rgbPCores.Controls.Add(this.lblDescC3);
            this.rgbPCores.Controls.Add(this.lblCor3);
            this.rgbPCores.Controls.Add(this.lblDescC4);
            this.rgbPCores.Controls.Add(this.lblCor2);
            this.rgbPCores.Controls.Add(this.lblDescC5);
            this.rgbPCores.Controls.Add(this.lblDescC6);
            this.rgbPCores.Controls.Add(this.lblCor4);
            this.rgbPCores.Controls.Add(this.lblCor6);
            this.rgbPCores.Controls.Add(this.lblCor5);
            this.rgbPCores.CornerRadius = 10;
            this.rgbPCores.Location = new System.Drawing.Point(20, 15);
            this.rgbPCores.Name = "rgbPCores";
            this.rgbPCores.Size = new System.Drawing.Size(496, 451);
            this.rgbPCores.TabIndex = 23;
            this.rgbPCores.TabStop = false;
            this.rgbPCores.Visible = false;
            this.rgbPCores.Enter += new System.EventHandler(this.rgbPCores_Enter);
            // 
            // lblCorBranca
            // 
            this.lblCorBranca.AutoSize = true;
            this.lblCorBranca.Location = new System.Drawing.Point(170, 363);
            this.lblCorBranca.Name = "lblCorBranca";
            this.lblCorBranca.Size = new System.Drawing.Size(87, 13);
            this.lblCorBranca.TabIndex = 41;
            this.lblCorBranca.Text = "Ícone em branco";
            // 
            // lblIconeBranco
            // 
            this.lblIconeBranco.AutoSize = true;
            this.lblIconeBranco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblIconeBranco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIconeBranco.Location = new System.Drawing.Point(143, 362);
            this.lblIconeBranco.Name = "lblIconeBranco";
            this.lblIconeBranco.Size = new System.Drawing.Size(21, 15);
            this.lblIconeBranco.TabIndex = 40;
            this.lblIconeBranco.Text = "    ";
            // 
            // lblCorPreta
            // 
            this.lblCorPreta.AutoSize = true;
            this.lblCorPreta.Location = new System.Drawing.Point(45, 362);
            this.lblCorPreta.Name = "lblCorPreta";
            this.lblCorPreta.Size = new System.Drawing.Size(78, 13);
            this.lblCorPreta.TabIndex = 39;
            this.lblCorPreta.Text = "Ícone em preto";
            // 
            // lblIconePreto
            // 
            this.lblIconePreto.AutoSize = true;
            this.lblIconePreto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblIconePreto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIconePreto.Location = new System.Drawing.Point(18, 361);
            this.lblIconePreto.Name = "lblIconePreto";
            this.lblIconePreto.Size = new System.Drawing.Size(21, 15);
            this.lblIconePreto.TabIndex = 38;
            this.lblIconePreto.Text = "    ";
            this.lblIconePreto.Click += new System.EventHandler(this.lblIconePreto_Click);
            // 
            // lblTrocaIcones
            // 
            this.lblTrocaIcones.AutoSize = true;
            this.lblTrocaIcones.BackColor = System.Drawing.Color.White;
            this.lblTrocaIcones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrocaIcones.Location = new System.Drawing.Point(18, 335);
            this.lblTrocaIcones.Name = "lblTrocaIcones";
            this.lblTrocaIcones.Size = new System.Drawing.Size(117, 18);
            this.lblTrocaIcones.TabIndex = 37;
            this.lblTrocaIcones.Text = "Cor dos ícones:";
            // 
            // lblPCores
            // 
            this.lblPCores.AutoSize = true;
            this.lblPCores.BackColor = System.Drawing.Color.White;
            this.lblPCores.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCores.Location = new System.Drawing.Point(100, 28);
            this.lblPCores.Name = "lblPCores";
            this.lblPCores.Size = new System.Drawing.Size(274, 27);
            this.lblPCores.TabIndex = 36;
            this.lblPCores.Text = "Personalização de cores";
            this.lblPCores.Click += new System.EventHandler(this.lblPCores_Click);
            // 
            // lblCoresTexto
            // 
            this.lblCoresTexto.AutoSize = true;
            this.lblCoresTexto.BackColor = System.Drawing.Color.White;
            this.lblCoresTexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoresTexto.Location = new System.Drawing.Point(15, 194);
            this.lblCoresTexto.Name = "lblCoresTexto";
            this.lblCoresTexto.Size = new System.Drawing.Size(114, 18);
            this.lblCoresTexto.TabIndex = 35;
            this.lblCoresTexto.Text = "Cores de texto:";
            // 
            // lblCoresAviso
            // 
            this.lblCoresAviso.AutoSize = true;
            this.lblCoresAviso.BackColor = System.Drawing.Color.White;
            this.lblCoresAviso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoresAviso.Location = new System.Drawing.Point(15, 265);
            this.lblCoresAviso.Name = "lblCoresAviso";
            this.lblCoresAviso.Size = new System.Drawing.Size(118, 18);
            this.lblCoresAviso.TabIndex = 34;
            this.lblCoresAviso.Text = "Cores de aviso:";
            this.lblCoresAviso.Click += new System.EventHandler(this.lblCoresAviso_Click);
            // 
            // lblCoresElementos
            // 
            this.lblCoresElementos.AutoSize = true;
            this.lblCoresElementos.BackColor = System.Drawing.Color.White;
            this.lblCoresElementos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoresElementos.Location = new System.Drawing.Point(15, 89);
            this.lblCoresElementos.Name = "lblCoresElementos";
            this.lblCoresElementos.Size = new System.Drawing.Size(161, 18);
            this.lblCoresElementos.TabIndex = 33;
            this.lblCoresElementos.Text = "Cores dos elementos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "corAviso2";
            // 
            // lblCorAviso2
            // 
            this.lblCorAviso2.AutoSize = true;
            this.lblCorAviso2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCorAviso2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCorAviso2.Location = new System.Drawing.Point(105, 291);
            this.lblCorAviso2.Name = "lblCorAviso2";
            this.lblCorAviso2.Size = new System.Drawing.Size(21, 15);
            this.lblCorAviso2.TabIndex = 31;
            this.lblCorAviso2.Text = "    ";
            this.lblCorAviso2.Click += new System.EventHandler(this.lblCorAviso2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "corAviso1";
            // 
            // lblCorTexto2
            // 
            this.lblCorTexto2.AutoSize = true;
            this.lblCorTexto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCorTexto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCorTexto2.Location = new System.Drawing.Point(105, 220);
            this.lblCorTexto2.Name = "lblCorTexto2";
            this.lblCorTexto2.Size = new System.Drawing.Size(21, 15);
            this.lblCorTexto2.TabIndex = 25;
            this.lblCorTexto2.Text = "    ";
            this.lblCorTexto2.Click += new System.EventHandler(this.lblCorTexto2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "corTexto1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "corTexto2";
            // 
            // lblCorTexto1
            // 
            this.lblCorTexto1.AutoSize = true;
            this.lblCorTexto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCorTexto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCorTexto1.Location = new System.Drawing.Point(21, 220);
            this.lblCorTexto1.Name = "lblCorTexto1";
            this.lblCorTexto1.Size = new System.Drawing.Size(21, 15);
            this.lblCorTexto1.TabIndex = 26;
            this.lblCorTexto1.Text = "    ";
            this.lblCorTexto1.Click += new System.EventHandler(this.lblCorTexto1_Click);
            // 
            // lblCorAviso1
            // 
            this.lblCorAviso1.AutoSize = true;
            this.lblCorAviso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCorAviso1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCorAviso1.Location = new System.Drawing.Point(18, 291);
            this.lblCorAviso1.Name = "lblCorAviso1";
            this.lblCorAviso1.Size = new System.Drawing.Size(21, 15);
            this.lblCorAviso1.TabIndex = 27;
            this.lblCorAviso1.Text = "    ";
            this.lblCorAviso1.Click += new System.EventHandler(this.lblCorAviso1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "cor7";
            // 
            // lblCor7
            // 
            this.lblCor7.AutoSize = true;
            this.lblCor7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor7.Location = new System.Drawing.Point(152, 148);
            this.lblCor7.Name = "lblCor7";
            this.lblCor7.Size = new System.Drawing.Size(21, 15);
            this.lblCor7.TabIndex = 23;
            this.lblCor7.Text = "    ";
            this.lblCor7.Click += new System.EventHandler(this.lblCor7_Click);
            // 
            // lblDescC1
            // 
            this.lblDescC1.AutoSize = true;
            this.lblDescC1.Location = new System.Drawing.Point(48, 116);
            this.lblDescC1.Name = "lblDescC1";
            this.lblDescC1.Size = new System.Drawing.Size(28, 13);
            this.lblDescC1.TabIndex = 15;
            this.lblDescC1.Text = "cor1";
            // 
            // lblDescC2
            // 
            this.lblDescC2.AutoSize = true;
            this.lblDescC2.Location = new System.Drawing.Point(115, 116);
            this.lblDescC2.Name = "lblDescC2";
            this.lblDescC2.Size = new System.Drawing.Size(28, 13);
            this.lblDescC2.TabIndex = 22;
            this.lblDescC2.Text = "cor2";
            // 
            // lblCor1
            // 
            this.lblCor1.AutoSize = true;
            this.lblCor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor1.Location = new System.Drawing.Point(18, 116);
            this.lblCor1.Name = "lblCor1";
            this.lblCor1.Size = new System.Drawing.Size(21, 15);
            this.lblCor1.TabIndex = 8;
            this.lblCor1.Text = "    ";
            this.lblCor1.Click += new System.EventHandler(this.lblCor1_Click);
            // 
            // lblDescC3
            // 
            this.lblDescC3.AutoSize = true;
            this.lblDescC3.Location = new System.Drawing.Point(182, 116);
            this.lblDescC3.Name = "lblDescC3";
            this.lblDescC3.Size = new System.Drawing.Size(28, 13);
            this.lblDescC3.TabIndex = 21;
            this.lblDescC3.Text = "cor3";
            // 
            // lblCor3
            // 
            this.lblCor3.AutoSize = true;
            this.lblCor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor3.Location = new System.Drawing.Point(152, 116);
            this.lblCor3.Name = "lblCor3";
            this.lblCor3.Size = new System.Drawing.Size(21, 15);
            this.lblCor3.TabIndex = 9;
            this.lblCor3.Text = "    ";
            this.lblCor3.Click += new System.EventHandler(this.lblCor3_Click);
            // 
            // lblDescC4
            // 
            this.lblDescC4.AutoSize = true;
            this.lblDescC4.Location = new System.Drawing.Point(249, 116);
            this.lblDescC4.Name = "lblDescC4";
            this.lblDescC4.Size = new System.Drawing.Size(28, 13);
            this.lblDescC4.TabIndex = 20;
            this.lblDescC4.Text = "cor4";
            // 
            // lblCor2
            // 
            this.lblCor2.AutoSize = true;
            this.lblCor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor2.Location = new System.Drawing.Point(85, 116);
            this.lblCor2.Name = "lblCor2";
            this.lblCor2.Size = new System.Drawing.Size(21, 15);
            this.lblCor2.TabIndex = 10;
            this.lblCor2.Text = "    ";
            this.lblCor2.Click += new System.EventHandler(this.lblCor2_Click);
            // 
            // lblDescC5
            // 
            this.lblDescC5.AutoSize = true;
            this.lblDescC5.Location = new System.Drawing.Point(48, 148);
            this.lblDescC5.Name = "lblDescC5";
            this.lblDescC5.Size = new System.Drawing.Size(28, 13);
            this.lblDescC5.TabIndex = 19;
            this.lblDescC5.Text = "cor5";
            // 
            // lblDescC6
            // 
            this.lblDescC6.AutoSize = true;
            this.lblDescC6.Location = new System.Drawing.Point(115, 148);
            this.lblDescC6.Name = "lblDescC6";
            this.lblDescC6.Size = new System.Drawing.Size(28, 13);
            this.lblDescC6.TabIndex = 18;
            this.lblDescC6.Text = "cor6";
            // 
            // lblCor4
            // 
            this.lblCor4.AutoSize = true;
            this.lblCor4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor4.Location = new System.Drawing.Point(219, 116);
            this.lblCor4.Name = "lblCor4";
            this.lblCor4.Size = new System.Drawing.Size(21, 15);
            this.lblCor4.TabIndex = 12;
            this.lblCor4.Text = "    ";
            this.lblCor4.Click += new System.EventHandler(this.lblCor4_Click);
            // 
            // lblCor6
            // 
            this.lblCor6.AutoSize = true;
            this.lblCor6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor6.Location = new System.Drawing.Point(85, 148);
            this.lblCor6.Name = "lblCor6";
            this.lblCor6.Size = new System.Drawing.Size(21, 15);
            this.lblCor6.TabIndex = 13;
            this.lblCor6.Text = "    ";
            this.lblCor6.Click += new System.EventHandler(this.lblCor6_Click);
            // 
            // lblCor5
            // 
            this.lblCor5.AutoSize = true;
            this.lblCor5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCor5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor5.Location = new System.Drawing.Point(18, 148);
            this.lblCor5.Name = "lblCor5";
            this.lblCor5.Size = new System.Drawing.Size(21, 15);
            this.lblCor5.TabIndex = 14;
            this.lblCor5.Text = "    ";
            this.lblCor5.Click += new System.EventHandler(this.lblCor5_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.AutoHoover = false;
            this.btnVoltar.BordaHoover = System.Drawing.Color.Green;
            this.btnVoltar.BordaPrincipal = System.Drawing.Color.Black;
            this.btnVoltar.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.BorderRadius = 10;
            this.btnVoltar.BorderThickness = 2;
            this.btnVoltar.ButtonColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(441, 480);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 22);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.TextoPrincipal = System.Drawing.Color.Black;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tlpBaseConfig3
            // 
            this.tlpBaseConfig3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpBaseConfig3.ColumnCount = 1;
            this.tlpBaseConfig3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.82353F));
            this.tlpBaseConfig3.Controls.Add(this.tlpBaseConfig5, 0, 0);
            this.tlpBaseConfig3.Controls.Add(this.tlpBaseConfig6, 0, 1);
            this.tlpBaseConfig3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBaseConfig3.Location = new System.Drawing.Point(3, 14);
            this.tlpBaseConfig3.Name = "tlpBaseConfig3";
            this.tlpBaseConfig3.RowCount = 3;
            this.tlpBaseConfig3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tlpBaseConfig3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.12987F));
            this.tlpBaseConfig3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tlpBaseConfig3.Size = new System.Drawing.Size(514, 514);
            this.tlpBaseConfig3.TabIndex = 33;
            this.tlpBaseConfig3.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpBaseConfig3_Paint);
            // 
            // tlpBaseConfig5
            // 
            this.tlpBaseConfig5.ColumnCount = 1;
            this.tlpBaseConfig5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBaseConfig5.Controls.Add(this.lblConfigsG, 0, 1);
            this.tlpBaseConfig5.Controls.Add(this.lblConfiguracoes, 0, 2);
            this.tlpBaseConfig5.Location = new System.Drawing.Point(4, 4);
            this.tlpBaseConfig5.Name = "tlpBaseConfig5";
            this.tlpBaseConfig5.RowCount = 4;
            this.tlpBaseConfig5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tlpBaseConfig5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tlpBaseConfig5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBaseConfig5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBaseConfig5.Size = new System.Drawing.Size(506, 181);
            this.tlpBaseConfig5.TabIndex = 0;
            // 
            // lblConfigsG
            // 
            this.lblConfigsG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfigsG.AutoSize = true;
            this.lblConfigsG.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigsG.Location = new System.Drawing.Point(3, 31);
            this.lblConfigsG.Name = "lblConfigsG";
            this.lblConfigsG.Size = new System.Drawing.Size(500, 37);
            this.lblConfigsG.TabIndex = 28;
            this.lblConfigsG.Text = "Configurações";
            this.lblConfigsG.Click += new System.EventHandler(this.lblConfigsG_Click);
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracoes.Location = new System.Drawing.Point(3, 100);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(500, 24);
            this.lblConfiguracoes.TabIndex = 27;
            this.lblConfiguracoes.Text = "Configurações gerais e Acessibilidade";
            this.lblConfiguracoes.Click += new System.EventHandler(this.lblConfiguracoes_Click);
            // 
            // tlpBaseConfig6
            // 
            this.tlpBaseConfig6.ColumnCount = 1;
            this.tlpBaseConfig6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBaseConfig6.Controls.Add(this.btnAltTamF, 0, 1);
            this.tlpBaseConfig6.Controls.Add(this.btnTutoriais, 0, 3);
            this.tlpBaseConfig6.Controls.Add(this.btnPersonalizar, 0, 5);
            this.tlpBaseConfig6.Location = new System.Drawing.Point(4, 209);
            this.tlpBaseConfig6.Name = "tlpBaseConfig6";
            this.tlpBaseConfig6.RowCount = 6;
            this.tlpBaseConfig6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.49685F));
            this.tlpBaseConfig6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.96227F));
            this.tlpBaseConfig6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.32076F));
            this.tlpBaseConfig6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.86842F));
            this.tlpBaseConfig6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpBaseConfig6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpBaseConfig6.Size = new System.Drawing.Size(506, 229);
            this.tlpBaseConfig6.TabIndex = 1;
            // 
            // btnAltTamF
            // 
            this.btnAltTamF.AutoHoover = false;
            this.btnAltTamF.BordaHoover = System.Drawing.Color.Green;
            this.btnAltTamF.BordaPrincipal = System.Drawing.Color.Black;
            this.btnAltTamF.BorderColor = System.Drawing.Color.Black;
            this.btnAltTamF.BorderRadius = 10;
            this.btnAltTamF.BorderThickness = 2;
            this.btnAltTamF.ButtonColor = System.Drawing.Color.White;
            this.btnAltTamF.Location = new System.Drawing.Point(3, 34);
            this.btnAltTamF.Name = "btnAltTamF";
            this.btnAltTamF.Size = new System.Drawing.Size(184, 23);
            this.btnAltTamF.TabIndex = 27;
            this.btnAltTamF.Text = "Alterar o tamanho da fonte";
            this.btnAltTamF.TextoPrincipal = System.Drawing.Color.Black;
            this.btnAltTamF.UseVisualStyleBackColor = true;
            this.btnAltTamF.Click += new System.EventHandler(this.btnAltTamF_Click);
            // 
            // btnTutoriais
            // 
            this.btnTutoriais.AutoHoover = false;
            this.btnTutoriais.BordaHoover = System.Drawing.Color.Green;
            this.btnTutoriais.BordaPrincipal = System.Drawing.Color.Black;
            this.btnTutoriais.BorderColor = System.Drawing.Color.Black;
            this.btnTutoriais.BorderRadius = 10;
            this.btnTutoriais.BorderThickness = 2;
            this.btnTutoriais.ButtonColor = System.Drawing.Color.White;
            this.btnTutoriais.Location = new System.Drawing.Point(3, 106);
            this.btnTutoriais.Name = "btnTutoriais";
            this.btnTutoriais.Size = new System.Drawing.Size(184, 23);
            this.btnTutoriais.TabIndex = 29;
            this.btnTutoriais.Text = "Tutoriais de usabilidade";
            this.btnTutoriais.TextoPrincipal = System.Drawing.Color.Black;
            this.btnTutoriais.UseVisualStyleBackColor = true;
            this.btnTutoriais.Click += new System.EventHandler(this.btnTutoriais_Click);
            // 
            // btnPersonalizar
            // 
            this.btnPersonalizar.AutoHoover = false;
            this.btnPersonalizar.BordaHoover = System.Drawing.Color.Green;
            this.btnPersonalizar.BordaPrincipal = System.Drawing.Color.Black;
            this.btnPersonalizar.BorderColor = System.Drawing.Color.Black;
            this.btnPersonalizar.BorderRadius = 10;
            this.btnPersonalizar.BorderThickness = 2;
            this.btnPersonalizar.ButtonColor = System.Drawing.Color.White;
            this.btnPersonalizar.Location = new System.Drawing.Point(3, 178);
            this.btnPersonalizar.Name = "btnPersonalizar";
            this.btnPersonalizar.Size = new System.Drawing.Size(184, 23);
            this.btnPersonalizar.TabIndex = 28;
            this.btnPersonalizar.Text = "Personalizar cores";
            this.btnPersonalizar.TextoPrincipal = System.Drawing.Color.Black;
            this.btnPersonalizar.UseVisualStyleBackColor = true;
            this.btnPersonalizar.Click += new System.EventHandler(this.btnPersonalizar_Click);
            // 
            // btnRestaurarPadrao
            // 
            this.btnRestaurarPadrao.AutoHoover = false;
            this.btnRestaurarPadrao.BordaHoover = System.Drawing.Color.Green;
            this.btnRestaurarPadrao.BordaPrincipal = System.Drawing.Color.Black;
            this.btnRestaurarPadrao.BorderColor = System.Drawing.Color.Black;
            this.btnRestaurarPadrao.BorderRadius = 10;
            this.btnRestaurarPadrao.BorderThickness = 2;
            this.btnRestaurarPadrao.ButtonColor = System.Drawing.Color.White;
            this.btnRestaurarPadrao.Location = new System.Drawing.Point(259, 411);
            this.btnRestaurarPadrao.Name = "btnRestaurarPadrao";
            this.btnRestaurarPadrao.Size = new System.Drawing.Size(209, 23);
            this.btnRestaurarPadrao.TabIndex = 42;
            this.btnRestaurarPadrao.Text = "Restaurar versão padrão";
            this.btnRestaurarPadrao.TextoPrincipal = System.Drawing.Color.Black;
            this.btnRestaurarPadrao.UseVisualStyleBackColor = true;
            this.btnRestaurarPadrao.Click += new System.EventHandler(this.btnRestaurarPadrao_Click);
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1083, 619);
            this.Controls.Add(this.tlpBaseConfig1);
            this.Name = "frmConfiguracoes";
            this.Text = "frmConfiguracoes";
            this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
            this.tlpBaseConfig1.ResumeLayout(false);
            this.rgbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OPBLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbRecarregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbConfiguracoes)).EndInit();
            this.tlpBaseConfig2.ResumeLayout(false);
            this.tlpBaseConfig4.ResumeLayout(false);
            this.rgbPCores.ResumeLayout(false);
            this.rgbPCores.PerformLayout();
            this.tlpBaseConfig3.ResumeLayout(false);
            this.tlpBaseConfig5.ResumeLayout(false);
            this.tlpBaseConfig5.PerformLayout();
            this.tlpBaseConfig6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       
        #endregion
        private System.Windows.Forms.ColorDialog cldPersonalizacao;
        private OvalPictureBox opbRecarregar;
        private OvalPictureBox opbConfiguracoes;
        private OvalPictureBox OPBLogout;
        private System.Windows.Forms.TableLayoutPanel tlpBaseConfig1;
        private System.Windows.Forms.TableLayoutPanel tlpBaseConfig2;
        private System.Windows.Forms.TableLayoutPanel tlpBaseConfig3;
        private System.Windows.Forms.Label lblConfigsG;
        private RoundButton btnAltTamF;
        private RoundButton btnPersonalizar;
        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.TableLayoutPanel tlpBaseConfig4;
        private RoundedGroupBox rgbPCores;
        private System.Windows.Forms.Label lblDescC1;
        private System.Windows.Forms.Label lblDescC2;
        private System.Windows.Forms.Label lblCor1;
        private System.Windows.Forms.Label lblDescC3;
        private System.Windows.Forms.Label lblCor3;
        private System.Windows.Forms.Label lblDescC4;
        private System.Windows.Forms.Label lblCor2;
        private System.Windows.Forms.Label lblDescC5;
        private System.Windows.Forms.Label lblDescC6;
        private System.Windows.Forms.Label lblCor4;
        private System.Windows.Forms.Label lblCor6;
        private System.Windows.Forms.Label lblCor5;
        private RoundButton btnVoltar;
        private RoundedGroupBox rgbMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCor7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorAviso2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCorTexto2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCorTexto1;
        private System.Windows.Forms.Label lblCorAviso1;
        private System.Windows.Forms.Label lblCoresTexto;
        private System.Windows.Forms.Label lblCoresAviso;
        private System.Windows.Forms.Label lblCoresElementos;
        private System.Windows.Forms.Label lblPCores;
        private RoundButton btnTutoriais;
        private System.Windows.Forms.Label lblCorBranca;
        private System.Windows.Forms.Label lblIconeBranco;
        private System.Windows.Forms.Label lblCorPreta;
        private System.Windows.Forms.Label lblIconePreto;
        private System.Windows.Forms.Label lblTrocaIcones;
        private System.Windows.Forms.TableLayoutPanel tlpBaseConfig5;
        private System.Windows.Forms.TableLayoutPanel tlpBaseConfig6;
        private RoundButton btnRestaurarPadrao;
    }
}