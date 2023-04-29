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
            this.btnLogar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.npgsqlCommandBuilder2 = new Npgsql.NpgsqlCommandBuilder();
            this.tlpLogin = new System.Windows.Forms.TableLayoutPanel();
            this.rgbLoginMSup = new tccCsharp.RoundedGroupBox();
            this.rgbLoginMInf = new tccCsharp.RoundedGroupBox();
            this.rgbLogin = new tccCsharp.RoundedGroupBox();
            this.tlpLogin.SuspendLayout();
            this.rgbLoginMSup.SuspendLayout();
            this.rgbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogar
            // 
            this.btnLogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLogar.AutoSize = true;
            this.btnLogar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.Location = new System.Drawing.Point(239, 181);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(59, 28);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(130, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 18);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.White;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(130, 125);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 18);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AllowDrop = true;
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(234, 26);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(87, 29);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = " Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmail.Location = new System.Drawing.Point(204, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSenha.Location = new System.Drawing.Point(204, 118);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(208, 20);
            this.txtSenha.TabIndex = 2;
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
            // tlpLogin
            // 
            this.tlpLogin.ColumnCount = 3;
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.9393F));
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.0607F));
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tlpLogin.Controls.Add(this.rgbLoginMSup, 1, 0);
            this.tlpLogin.Controls.Add(this.rgbLoginMInf, 1, 2);
            this.tlpLogin.Controls.Add(this.rgbLogin, 1, 1);
            this.tlpLogin.Location = new System.Drawing.Point(336, 74);
            this.tlpLogin.Name = "tlpLogin";
            this.tlpLogin.RowCount = 3;
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.53086F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.46914F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpLogin.Size = new System.Drawing.Size(710, 497);
            this.tlpLogin.TabIndex = 9;
            this.tlpLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // rgbLoginMSup
            // 
            this.rgbLoginMSup.BackgroundColor = System.Drawing.Color.White;
            this.rgbLoginMSup.BorderWidth = 1F;
            this.rgbLoginMSup.Controls.Add(this.lblLogin);
            this.rgbLoginMSup.CornerRadius = 10;
            this.rgbLoginMSup.Location = new System.Drawing.Point(84, 3);
            this.rgbLoginMSup.Name = "rgbLoginMSup";
            this.rgbLoginMSup.Size = new System.Drawing.Size(539, 92);
            this.rgbLoginMSup.TabIndex = 10;
            this.rgbLoginMSup.TabStop = false;
            // 
            // rgbLoginMInf
            // 
            this.rgbLoginMInf.BackgroundColor = System.Drawing.Color.White;
            this.rgbLoginMInf.BorderWidth = 1F;
            this.rgbLoginMInf.CornerRadius = 10;
            this.rgbLoginMInf.Location = new System.Drawing.Point(84, 437);
            this.rgbLoginMInf.Name = "rgbLoginMInf";
            this.rgbLoginMInf.Size = new System.Drawing.Size(539, 57);
            this.rgbLoginMInf.TabIndex = 10;
            this.rgbLoginMInf.TabStop = false;
            // 
            // rgbLogin
            // 
            this.rgbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgbLogin.BackgroundColor = System.Drawing.Color.White;
            this.rgbLogin.BorderWidth = 1F;
            this.rgbLogin.Controls.Add(this.btnLogar);
            this.rgbLogin.Controls.Add(this.txtEmail);
            this.rgbLogin.Controls.Add(this.txtSenha);
            this.rgbLogin.Controls.Add(this.lblEmail);
            this.rgbLogin.Controls.Add(this.lblSenha);
            this.rgbLogin.CornerRadius = 10;
            this.rgbLogin.Location = new System.Drawing.Point(84, 101);
            this.rgbLogin.Name = "rgbLogin";
            this.rgbLogin.Size = new System.Drawing.Size(539, 330);
            this.rgbLogin.TabIndex = 10;
            this.rgbLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tlpLogin);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.tlpLogin.ResumeLayout(false);
            this.rgbLoginMSup.ResumeLayout(false);
            this.rgbLoginMSup.PerformLayout();
            this.rgbLogin.ResumeLayout(false);
            this.rgbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder2;
        private System.Windows.Forms.TableLayoutPanel tlpLogin;
        private RoundedGroupBox rgbLogin;
        private RoundedGroupBox rgbLoginMSup;
        private RoundedGroupBox rgbLoginMInf;
    }
}

