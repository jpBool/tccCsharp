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
            this.opbConfiguracoes = new tccCsharp.OvalPictureBox();
            this.opbRecarregar = new tccCsharp.OvalPictureBox();
            this.OPBLogout = new tccCsharp.OvalPictureBox();
            this.tlpBaseConfig1 = new System.Windows.Forms.TableLayoutPanel();
            this.rgbMenu = new tccCsharp.RoundedGroupBox();
            this.tlpBaseConfig2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBaseConfig3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTutoriais = new RoundButton();
            this.btnAltTamF = new RoundButton();
            this.btnPersonalizar = new RoundButton();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.tlpBaseConfig4 = new System.Windows.Forms.TableLayoutPanel();
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
            this.nudFonte = new System.Windows.Forms.NumericUpDown();
            this.btnVoltar = new RoundButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.opbConfiguracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbRecarregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPBLogout)).BeginInit();
            this.tlpBaseConfig1.SuspendLayout();
            this.rgbMenu.SuspendLayout();
            this.tlpBaseConfig2.SuspendLayout();
            this.tlpBaseConfig3.SuspendLayout();
            this.tlpBaseConfig4.SuspendLayout();
            this.rgbPCores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFonte)).BeginInit();
            this.SuspendLayout();
            // 
            // opbConfiguracoes
            // 
            this.opbConfiguracoes._bordercolor = System.Drawing.Color.Red;
            this.opbConfiguracoes._borderwidth = 5F;
            this.opbConfiguracoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.opbConfiguracoes.Image = global::tccCsharp.Properties.Resources.configuracoes;
            this.opbConfiguracoes.Location = new System.Drawing.Point(926, 0);
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
            this.opbRecarregar.Location = new System.Drawing.Point(872, 0);
            this.opbRecarregar.Name = "opbRecarregar";
            this.opbRecarregar.Size = new System.Drawing.Size(48, 48);
            this.opbRecarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.opbRecarregar.TabIndex = 31;
            this.opbRecarregar.TabStop = false;
            this.opbRecarregar.Click += new System.EventHandler(this.opbRecarregar_Click);
            // 
            // OPBLogout
            // 
            this.OPBLogout._bordercolor = System.Drawing.Color.Red;
            this.OPBLogout._borderwidth = 5F;
            this.OPBLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OPBLogout.BackColor = System.Drawing.Color.White;
            this.OPBLogout.Image = global::tccCsharp.Properties.Resources._logout_;
            this.OPBLogout.Location = new System.Drawing.Point(818, 0);
            this.OPBLogout.Name = "OPBLogout";
            this.OPBLogout.Size = new System.Drawing.Size(48, 48);
            this.OPBLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.OPBLogout.TabIndex = 29;
            this.OPBLogout.TabStop = false;
            this.OPBLogout.Click += new System.EventHandler(this.OPBLogout_Click);
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
            this.tlpBaseConfig1.Size = new System.Drawing.Size(995, 453);
            this.tlpBaseConfig1.TabIndex = 35;
            // 
            // rgbMenu
            // 
            this.rgbMenu.BackgroundColor = System.Drawing.Color.White;
            this.rgbMenu.BorderWidth = 1F;
            this.rgbMenu.Controls.Add(this.OPBLogout);
            this.rgbMenu.Controls.Add(this.opbRecarregar);
            this.rgbMenu.Controls.Add(this.opbConfiguracoes);
            this.rgbMenu.CornerRadius = 10;
            this.rgbMenu.Location = new System.Drawing.Point(3, 3);
            this.rgbMenu.Name = "rgbMenu";
            this.rgbMenu.Size = new System.Drawing.Size(989, 53);
            this.rgbMenu.TabIndex = 36;
            this.rgbMenu.TabStop = false;
            // 
            // tlpBaseConfig2
            // 
            this.tlpBaseConfig2.ColumnCount = 2;
            this.tlpBaseConfig2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35389F));
            this.tlpBaseConfig2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.64611F));
            this.tlpBaseConfig2.Controls.Add(this.tlpBaseConfig3, 0, 1);
            this.tlpBaseConfig2.Controls.Add(this.tlpBaseConfig4, 1, 1);
            this.tlpBaseConfig2.Location = new System.Drawing.Point(3, 64);
            this.tlpBaseConfig2.Name = "tlpBaseConfig2";
            this.tlpBaseConfig2.RowCount = 2;
            this.tlpBaseConfig2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.105263F));
            this.tlpBaseConfig2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.89474F));
            this.tlpBaseConfig2.Size = new System.Drawing.Size(989, 385);
            this.tlpBaseConfig2.TabIndex = 35;
            this.tlpBaseConfig2.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpBaseConfig2_Paint);
            // 
            // tlpBaseConfig3
            // 
            this.tlpBaseConfig3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBaseConfig3.ColumnCount = 3;
            this.tlpBaseConfig3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.82353F));
            this.tlpBaseConfig3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.17647F));
            this.tlpBaseConfig3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlpBaseConfig3.Controls.Add(this.label1, 1, 1);
            this.tlpBaseConfig3.Controls.Add(this.btnTutoriais, 1, 7);
            this.tlpBaseConfig3.Controls.Add(this.btnAltTamF, 1, 6);
            this.tlpBaseConfig3.Controls.Add(this.btnPersonalizar, 1, 5);
            this.tlpBaseConfig3.Controls.Add(this.lblConfiguracoes, 1, 3);
            this.tlpBaseConfig3.Location = new System.Drawing.Point(3, 11);
            this.tlpBaseConfig3.Name = "tlpBaseConfig3";
            this.tlpBaseConfig3.RowCount = 9;
            this.tlpBaseConfig3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.26415F));
            this.tlpBaseConfig3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.73585F));
            this.tlpBaseConfig3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpBaseConfig3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpBaseConfig3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tlpBaseConfig3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpBaseConfig3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpBaseConfig3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpBaseConfig3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpBaseConfig3.Size = new System.Drawing.Size(491, 371);
            this.tlpBaseConfig3.TabIndex = 33;
            this.tlpBaseConfig3.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpBaseConfig3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Configurações gerais";
            // 
            // btnTutoriais
            // 
            this.btnTutoriais.BorderColor = System.Drawing.Color.Black;
            this.btnTutoriais.BorderRadius = 10;
            this.btnTutoriais.BorderThickness = 2;
            this.btnTutoriais.ButtonColor = System.Drawing.Color.White;
            this.btnTutoriais.Location = new System.Drawing.Point(47, 255);
            this.btnTutoriais.Name = "btnTutoriais";
            this.btnTutoriais.Size = new System.Drawing.Size(143, 23);
            this.btnTutoriais.TabIndex = 29;
            this.btnTutoriais.Text = "Tutoriais de usabilidade";
            this.btnTutoriais.UseVisualStyleBackColor = true;
            this.btnTutoriais.Click += new System.EventHandler(this.btnTutoriais_Click);
            // 
            // btnAltTamF
            // 
            this.btnAltTamF.BorderColor = System.Drawing.Color.Black;
            this.btnAltTamF.BorderRadius = 10;
            this.btnAltTamF.BorderThickness = 2;
            this.btnAltTamF.ButtonColor = System.Drawing.Color.White;
            this.btnAltTamF.Location = new System.Drawing.Point(47, 204);
            this.btnAltTamF.Name = "btnAltTamF";
            this.btnAltTamF.Size = new System.Drawing.Size(143, 23);
            this.btnAltTamF.TabIndex = 27;
            this.btnAltTamF.Text = "Alterar o tamanho da fonte";
            this.btnAltTamF.UseVisualStyleBackColor = true;
            this.btnAltTamF.Click += new System.EventHandler(this.btnAltTamF_Click);
            // 
            // btnPersonalizar
            // 
            this.btnPersonalizar.BorderColor = System.Drawing.Color.Black;
            this.btnPersonalizar.BorderRadius = 10;
            this.btnPersonalizar.BorderThickness = 2;
            this.btnPersonalizar.ButtonColor = System.Drawing.Color.White;
            this.btnPersonalizar.Location = new System.Drawing.Point(47, 156);
            this.btnPersonalizar.Name = "btnPersonalizar";
            this.btnPersonalizar.Size = new System.Drawing.Size(143, 23);
            this.btnPersonalizar.TabIndex = 28;
            this.btnPersonalizar.Text = "Personalizar cores";
            this.btnPersonalizar.UseVisualStyleBackColor = true;
            this.btnPersonalizar.Click += new System.EventHandler(this.btnPersonalizar_Click);
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracoes.Location = new System.Drawing.Point(47, 94);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(300, 19);
            this.lblConfiguracoes.TabIndex = 27;
            this.lblConfiguracoes.Text = "Configurações gerais e Acessibilidade";
            this.lblConfiguracoes.Click += new System.EventHandler(this.lblConfiguracoes_Click);
            // 
            // tlpBaseConfig4
            // 
            this.tlpBaseConfig4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBaseConfig4.ColumnCount = 4;
            this.tlpBaseConfig4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.93886F));
            this.tlpBaseConfig4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.06113F));
            this.tlpBaseConfig4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpBaseConfig4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpBaseConfig4.Controls.Add(this.rgbPCores, 1, 1);
            this.tlpBaseConfig4.Controls.Add(this.nudFonte, 0, 1);
            this.tlpBaseConfig4.Controls.Add(this.btnVoltar, 1, 3);
            this.tlpBaseConfig4.Location = new System.Drawing.Point(500, 11);
            this.tlpBaseConfig4.Name = "tlpBaseConfig4";
            this.tlpBaseConfig4.RowCount = 5;
            this.tlpBaseConfig4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.605863F));
            this.tlpBaseConfig4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.39413F));
            this.tlpBaseConfig4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpBaseConfig4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpBaseConfig4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpBaseConfig4.Size = new System.Drawing.Size(486, 371);
            this.tlpBaseConfig4.TabIndex = 33;
            this.tlpBaseConfig4.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpBaseConfig4_Paint);
            // 
            // rgbPCores
            // 
            this.rgbPCores.BackgroundColor = System.Drawing.Color.White;
            this.rgbPCores.BorderWidth = 1F;
            this.rgbPCores.Controls.Add(this.label2);
            this.rgbPCores.Controls.Add(this.label3);
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
            this.rgbPCores.Location = new System.Drawing.Point(77, 11);
            this.rgbPCores.Name = "rgbPCores";
            this.rgbPCores.Size = new System.Drawing.Size(364, 289);
            this.rgbPCores.TabIndex = 23;
            this.rgbPCores.TabStop = false;
            this.rgbPCores.Text = "Personalização de cores";
            this.rgbPCores.Visible = false;
            this.rgbPCores.Enter += new System.EventHandler(this.rgbPCores_Enter);
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
            // 
            // lblDescC5
            // 
            this.lblDescC5.AutoSize = true;
            this.lblDescC5.Location = new System.Drawing.Point(43, 203);
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
            this.lblCorAviso.Location = new System.Drawing.Point(92, 233);
            this.lblCorAviso.Name = "lblCorAviso";
            this.lblCorAviso.Size = new System.Drawing.Size(21, 15);
            this.lblCorAviso.TabIndex = 11;
            this.lblCorAviso.Text = "    ";
            this.lblCorAviso.Click += new System.EventHandler(this.lblCorAviso_Click);
            // 
            // lblDescC6
            // 
            this.lblDescC6.AutoSize = true;
            this.lblDescC6.Location = new System.Drawing.Point(43, 233);
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
            // 
            // lblDescC7
            // 
            this.lblDescC7.AutoSize = true;
            this.lblDescC7.Location = new System.Drawing.Point(117, 233);
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
            this.lblCor6.Location = new System.Drawing.Point(18, 233);
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
            this.lblCor5.Location = new System.Drawing.Point(18, 203);
            this.lblCor5.Name = "lblCor5";
            this.lblCor5.Size = new System.Drawing.Size(21, 15);
            this.lblCor5.TabIndex = 14;
            this.lblCor5.Text = "    ";
            this.lblCor5.Click += new System.EventHandler(this.lblCor5_Click);
            // 
            // nudFonte
            // 
            this.nudFonte.Location = new System.Drawing.Point(3, 11);
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
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.BorderRadius = 10;
            this.btnVoltar.BorderThickness = 2;
            this.btnVoltar.ButtonColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(390, 336);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "label11";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(92, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "    ";
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(182)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.tlpBaseConfig1);
            this.Name = "frmConfiguracoes";
            this.Text = "frmConfiguracoes";
            this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opbConfiguracoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbRecarregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPBLogout)).EndInit();
            this.tlpBaseConfig1.ResumeLayout(false);
            this.rgbMenu.ResumeLayout(false);
            this.tlpBaseConfig2.ResumeLayout(false);
            this.tlpBaseConfig3.ResumeLayout(false);
            this.tlpBaseConfig3.PerformLayout();
            this.tlpBaseConfig4.ResumeLayout(false);
            this.rgbPCores.ResumeLayout(false);
            this.rgbPCores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFonte)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private RoundButton btnTutoriais;
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
        private System.Windows.Forms.Label lblCorAviso;
        private System.Windows.Forms.Label lblDescC6;
        private System.Windows.Forms.Label lblCor4;
        private System.Windows.Forms.Label lblDescC7;
        private System.Windows.Forms.Label lblCor6;
        private System.Windows.Forms.Label lblCor5;
        private System.Windows.Forms.NumericUpDown nudFonte;
        private RoundButton btnVoltar;
        private RoundedGroupBox rgbMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}