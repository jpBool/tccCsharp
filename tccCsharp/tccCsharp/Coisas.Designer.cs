namespace tccCsharp
{
    partial class Coisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coisas));
            this.opbExcluir = new tccCsharp.OvalPictureBox();
            this.opbCompartilhar = new tccCsharp.OvalPictureBox();
            this.Bot = new System.Windows.Forms.Label();
            this.roundedButton1 = new WindowsFormsApp.RoundedButton();
            this.roundedButton2 = new WindowsFormsApp.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.opbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbCompartilhar)).BeginInit();
            this.SuspendLayout();
            // 
            // opbExcluir
            // 
            this.opbExcluir._bordercolor = System.Drawing.Color.Red;
            this.opbExcluir._borderwidth = 3F;
            this.opbExcluir.Image = global::tccCsharp.Properties.Resources.excluir;
            this.opbExcluir.Location = new System.Drawing.Point(346, 201);
            this.opbExcluir.Name = "opbExcluir";
            this.opbExcluir.Size = new System.Drawing.Size(48, 48);
            this.opbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.opbExcluir.TabIndex = 7;
            this.opbExcluir.TabStop = false;
            // 
            // opbCompartilhar
            // 
            this.opbCompartilhar._bordercolor = System.Drawing.Color.Red;
            this.opbCompartilhar._borderwidth = 3F;
            this.opbCompartilhar.Image = global::tccCsharp.Properties.Resources.compartilhar;
            this.opbCompartilhar.Location = new System.Drawing.Point(406, 201);
            this.opbCompartilhar.Name = "opbCompartilhar";
            this.opbCompartilhar.Size = new System.Drawing.Size(48, 48);
            this.opbCompartilhar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.opbCompartilhar.TabIndex = 6;
            this.opbCompartilhar.TabStop = false;
            // 
            // Bot
            // 
            this.Bot.AutoSize = true;
            this.Bot.Location = new System.Drawing.Point(435, 76);
            this.Bot.Name = "Bot";
            this.Bot.Size = new System.Drawing.Size(329, 91);
            this.Bot.TabIndex = 9;
            this.Bot.Text = resources.GetString("Bot.Text");
            this.Bot.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.Magenta;
            this.roundedButton1.BorderRadius = 50;
            this.roundedButton1.BorderThickness = 6;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Location = new System.Drawing.Point(89, 76);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(121, 101);
            this.roundedButton1.TabIndex = 10;
            this.roundedButton1.Text = "roundedButton1";
            this.roundedButton1.UseMnemonic = false;
            this.roundedButton1.UseVisualStyleBackColor = true;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackgroundColor = System.Drawing.Color.White;
            this.roundedButton2.BorderColor = System.Drawing.Color.Black;
            this.roundedButton2.BorderRadius = 50;
            this.roundedButton2.BorderThickness = 6;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundedButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Location = new System.Drawing.Point(120, 282);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(124, 98);
            this.roundedButton2.TabIndex = 11;
            this.roundedButton2.Text = "roundedButton2";
            this.roundedButton2.UseVisualStyleBackColor = true;
            // 
            // Coisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.Bot);
            this.Controls.Add(this.opbExcluir);
            this.Controls.Add(this.opbCompartilhar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Coisas";
            this.Text = "Coisas";
            this.Load += new System.EventHandler(this.Coisas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbCompartilhar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OvalPictureBox opbExcluir;
        private OvalPictureBox opbCompartilhar;
        private System.Windows.Forms.Label Bot;
        private WindowsFormsApp.RoundedButton roundedButton1;
        private WindowsFormsApp.RoundedButton roundedButton2;
    }
}