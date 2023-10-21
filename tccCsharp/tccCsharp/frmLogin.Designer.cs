namespace tccCsharp
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.npgsqlCommandBuilder2 = new Npgsql.NpgsqlCommandBuilder();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rgbLogin = new tccCsharp.RoundedGroupBox();
            this.tlpLoginBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTexto = new System.Windows.Forms.TableLayoutPanel();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.opbLogo = new System.Windows.Forms.PictureBox();
            this.lblFacaLogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tlpLoginBase2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.tlpLoginBase3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogar = new RoundButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.rgbLogin.SuspendLayout();
            this.tlpLoginBase.SuspendLayout();
            this.tlpTexto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opbLogo)).BeginInit();
            this.tlpLoginBase2.SuspendLayout();
            this.tlpLoginBase3.SuspendLayout();
            this.SuspendLayout();
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // npgsqlCommandBuilder2
            // 
            this.npgsqlCommandBuilder2.QuotePrefix = "\"";
            this.npgsqlCommandBuilder2.QuoteSuffix = "\"";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rgbLogin, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 680F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 680);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // rgbLogin
            // 
            this.rgbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rgbLogin.BackgroundColor = System.Drawing.Color.White;
            this.rgbLogin.BorderWidth = 1F;
            this.rgbLogin.Controls.Add(this.tlpLoginBase);
            this.rgbLogin.CornerRadius = 30;
            this.rgbLogin.Location = new System.Drawing.Point(205, 126);
            this.rgbLogin.Margin = new System.Windows.Forms.Padding(0);
            this.rgbLogin.Name = "rgbLogin";
            this.rgbLogin.Size = new System.Drawing.Size(853, 427);
            this.rgbLogin.TabIndex = 11;
            this.rgbLogin.TabStop = false;
            // 
            // tlpLoginBase
            // 
            this.tlpLoginBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoginBase.ColumnCount = 2;
            this.tlpLoginBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.66265F));
            this.tlpLoginBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.33735F));
            this.tlpLoginBase.Controls.Add(this.tlpTexto, 1, 0);
            this.tlpLoginBase.Controls.Add(this.tlpLoginBase2, 0, 0);
            this.tlpLoginBase.Location = new System.Drawing.Point(17, 19);
            this.tlpLoginBase.Name = "tlpLoginBase";
            this.tlpLoginBase.RowCount = 1;
            this.tlpLoginBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLoginBase.Size = new System.Drawing.Size(830, 376);
            this.tlpLoginBase.TabIndex = 0;
            // 
            // tlpTexto
            // 
            this.tlpTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTexto.ColumnCount = 2;
            this.tlpTexto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTexto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpTexto.Controls.Add(this.lblBoasVindas, 0, 1);
            this.tlpTexto.Controls.Add(this.opbLogo, 0, 2);
            this.tlpTexto.Controls.Add(this.lblFacaLogin, 0, 3);
            this.tlpTexto.Controls.Add(this.button1, 0, 0);
            this.tlpTexto.Location = new System.Drawing.Point(465, 3);
            this.tlpTexto.Name = "tlpTexto";
            this.tlpTexto.RowCount = 4;
            this.tlpTexto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.74453F));
            this.tlpTexto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.25547F));
            this.tlpTexto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tlpTexto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tlpTexto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTexto.Size = new System.Drawing.Size(362, 370);
            this.tlpTexto.TabIndex = 0;
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBoasVindas.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.Location = new System.Drawing.Point(51, 69);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(211, 45);
            this.lblBoasVindas.TabIndex = 9;
            this.lblBoasVindas.Text = "Bem-vindo ao";
            // 
            // opbLogo
            // 
            this.opbLogo.BackColor = System.Drawing.Color.Transparent;
            this.opbLogo.Image = global::tccCsharp.Properties.Resources.Logo_White2;
            this.opbLogo.Location = new System.Drawing.Point(3, 121);
            this.opbLogo.Name = "opbLogo";
            this.opbLogo.Size = new System.Drawing.Size(285, 101);
            this.opbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.opbLogo.TabIndex = 33;
            this.opbLogo.TabStop = false;
            // 
            // lblFacaLogin
            // 
            this.lblFacaLogin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacaLogin.Location = new System.Drawing.Point(25, 226);
            this.lblFacaLogin.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.lblFacaLogin.Name = "lblFacaLogin";
            this.lblFacaLogin.Size = new System.Drawing.Size(263, 70);
            this.lblFacaLogin.TabIndex = 10;
            this.lblFacaLogin.Text = "Faça login para entrar para o nosso time!";
            this.lblFacaLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tlpLoginBase2
            // 
            this.tlpLoginBase2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoginBase2.ColumnCount = 1;
            this.tlpLoginBase2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLoginBase2.Controls.Add(this.lblAviso, 0, 3);
            this.tlpLoginBase2.Controls.Add(this.tlpLoginBase3, 0, 2);
            this.tlpLoginBase2.Controls.Add(this.lblLogin, 0, 1);
            this.tlpLoginBase2.Controls.Add(this.btnLogar, 0, 4);
            this.tlpLoginBase2.Location = new System.Drawing.Point(3, 3);
            this.tlpLoginBase2.Name = "tlpLoginBase2";
            this.tlpLoginBase2.RowCount = 6;
            this.tlpLoginBase2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tlpLoginBase2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tlpLoginBase2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpLoginBase2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpLoginBase2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpLoginBase2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpLoginBase2.Size = new System.Drawing.Size(456, 370);
            this.tlpLoginBase2.TabIndex = 1;
            // 
            // lblAviso
            // 
            this.lblAviso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(73, 264);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(309, 39);
            this.lblAviso.TabIndex = 8;
            this.lblAviso.Text = "Email ou senha inválidos. Digite novamente";
            // 
            // tlpLoginBase3
            // 
            this.tlpLoginBase3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoginBase3.ColumnCount = 5;
            this.tlpLoginBase3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.46939F));
            this.tlpLoginBase3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.53061F));
            this.tlpLoginBase3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tlpLoginBase3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tlpLoginBase3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpLoginBase3.Controls.Add(this.lblEmail, 1, 1);
            this.tlpLoginBase3.Controls.Add(this.lblSenha, 1, 3);
            this.tlpLoginBase3.Controls.Add(this.txtEmail, 3, 1);
            this.tlpLoginBase3.Controls.Add(this.txtSenha, 3, 3);
            this.tlpLoginBase3.Location = new System.Drawing.Point(3, 117);
            this.tlpLoginBase3.Name = "tlpLoginBase3";
            this.tlpLoginBase3.RowCount = 5;
            this.tlpLoginBase3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.37705F));
            this.tlpLoginBase3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.62295F));
            this.tlpLoginBase3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpLoginBase3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpLoginBase3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpLoginBase3.Size = new System.Drawing.Size(450, 144);
            this.tlpLoginBase3.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(22, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 26);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.White;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(22, 90);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 22);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.Location = new System.Drawing.Point(99, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSenha.Location = new System.Drawing.Point(99, 93);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(244, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // lblLogin
            // 
            this.lblLogin.AllowDrop = true;
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(171, 61);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(113, 53);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = " Login";
            // 
            // btnLogar
            // 
            this.btnLogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLogar.AutoHoover = true;
            this.btnLogar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogar.BordaHoover = System.Drawing.Color.Green;
            this.btnLogar.BordaPrincipal = System.Drawing.Color.Black;
            this.btnLogar.BorderColor = System.Drawing.Color.Black;
            this.btnLogar.BorderRadius = 20;
            this.btnLogar.BorderThickness = 4;
            this.btnLogar.ButtonColor = System.Drawing.Color.White;
            this.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnLogar.Location = new System.Drawing.Point(143, 306);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(169, 34);
            this.btnLogar.TabIndex = 10;
            this.btnLogar.Text = "ENTRAR";
            this.btnLogar.TextoPrincipal = System.Drawing.Color.Black;
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            this.btnLogar.Enter += new System.EventHandler(this.btnLogar_Enter);
            this.btnLogar.Leave += new System.EventHandler(this.btnLogar_Leave);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmLogin";
            this.Text = "Sensei";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.rgbLogin.ResumeLayout(false);
            this.tlpLoginBase.ResumeLayout(false);
            this.tlpTexto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.opbLogo)).EndInit();
            this.tlpLoginBase2.ResumeLayout(false);
            this.tlpLoginBase2.PerformLayout();
            this.tlpLoginBase3.ResumeLayout(false);
            this.tlpLoginBase3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedGroupBox rgbLogin;
        private System.Windows.Forms.TableLayoutPanel tlpLoginBase;
        private System.Windows.Forms.TableLayoutPanel tlpTexto;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Label lblFacaLogin;
        private System.Windows.Forms.TableLayoutPanel tlpLoginBase2;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.TableLayoutPanel tlpLoginBase3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblLogin;
        private RoundButton btnLogar;
        private System.Windows.Forms.PictureBox opbLogo;
        private System.Windows.Forms.Button button1;
    }
}

