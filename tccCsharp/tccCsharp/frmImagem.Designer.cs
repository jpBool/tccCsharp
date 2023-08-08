namespace tccCsharp
{
    partial class frmImagem
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
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new RoundButton();
            this.btnGerenciarImg = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(26, 33);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(440, 405);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BorderColor = System.Drawing.Color.Black;
            this.btnExcluir.BorderRadius = 10;
            this.btnExcluir.BorderThickness = 2;
            this.btnExcluir.ButtonColor = System.Drawing.Color.White;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(504, 415);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarImg
            // 
            this.btnGerenciarImg.BorderColor = System.Drawing.Color.Black;
            this.btnGerenciarImg.BorderRadius = 10;
            this.btnGerenciarImg.BorderThickness = 2;
            this.btnGerenciarImg.ButtonColor = System.Drawing.Color.White;
            this.btnGerenciarImg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarImg.Location = new System.Drawing.Point(642, 415);
            this.btnGerenciarImg.Name = "btnGerenciarImg";
            this.btnGerenciarImg.Size = new System.Drawing.Size(110, 23);
            this.btnGerenciarImg.TabIndex = 2;
            this.btnGerenciarImg.Text = "Editar";
            this.btnGerenciarImg.UseVisualStyleBackColor = true;
            // 
            // frmImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btnGerenciarImg);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.picImagem);
            this.Name = "frmImagem";
            this.Text = "frmImagem";
            this.Load += new System.EventHandler(this.frmImagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagem;
        private RoundButton btnExcluir;
        private RoundButton btnGerenciarImg;
    }
}