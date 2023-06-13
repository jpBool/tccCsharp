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
            this.opbExcluir = new tccCsharp.OvalPictureBox();
            this.opbCompartilhar = new tccCsharp.OvalPictureBox();
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
            // Coisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opbExcluir);
            this.Controls.Add(this.opbCompartilhar);
            this.Name = "Coisas";
            this.Text = "Coisas";
            ((System.ComponentModel.ISupportInitialize)(this.opbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbCompartilhar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OvalPictureBox opbExcluir;
        private OvalPictureBox opbCompartilhar;
    }
}