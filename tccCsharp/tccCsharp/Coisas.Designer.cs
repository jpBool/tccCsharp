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
            this.roundButton1 = new RoundButton();
            this.opbExcluir = new tccCsharp.OvalPictureBox();
            this.opbCompartilhar = new tccCsharp.OvalPictureBox();
            this.customGroupBox1 = new tccCsharp.CustomGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.opbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbCompartilhar)).BeginInit();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.BorderColor = System.Drawing.Color.Black;
            this.roundButton1.BorderRadius = 25;
            this.roundButton1.BorderThickness = 5;
            this.roundButton1.ButtonColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(112, 123);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(103, 38);
            this.roundButton1.TabIndex = 8;
            this.roundButton1.Text = "1";
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            this.roundButton1.MouseEnter += new System.EventHandler(this.roundButton1_MouseEnter);
            this.roundButton1.MouseLeave += new System.EventHandler(this.roundButton1_MouseLeave);
            // 
            // opbExcluir
            // 
            this.opbExcluir._bordercolor = System.Drawing.Color.Red;
            this.opbExcluir._borderwidth = 3F;
            this.opbExcluir.Location = new System.Drawing.Point(220, 201);
            this.opbExcluir.Name = "opbExcluir";
            this.opbExcluir.Size = new System.Drawing.Size(200, 200);
            this.opbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.opbExcluir.TabIndex = 7;
            this.opbExcluir.TabStop = false;
            // 
            // opbCompartilhar
            // 
            this.opbCompartilhar._bordercolor = System.Drawing.Color.Red;
            this.opbCompartilhar._borderwidth = 3F;
            this.opbCompartilhar.Location = new System.Drawing.Point(471, 201);
            this.opbCompartilhar.Name = "opbCompartilhar";
            this.opbCompartilhar.Size = new System.Drawing.Size(200, 200);
            this.opbCompartilhar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.opbCompartilhar.TabIndex = 6;
            this.opbCompartilhar.TabStop = false;
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.BackgroundColor = System.Drawing.Color.White;
            this.customGroupBox1.BorderWidth = 1F;
            this.customGroupBox1.CornerRadius = 41;
            this.customGroupBox1.Location = new System.Drawing.Point(443, 51);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.Size = new System.Drawing.Size(200, 83);
            this.customGroupBox1.TabIndex = 9;
            this.customGroupBox1.TabStop = false;
            // 
            // Coisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customGroupBox1);
            this.Controls.Add(this.roundButton1);
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

        }

        #endregion

        private OvalPictureBox opbExcluir;
        private OvalPictureBox opbCompartilhar;
        private RoundButton roundButton1;
        private CustomGroupBox customGroupBox1;
    }
}