using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace tccCsharp
{
    public class OvalPictureBox : PictureBox
    {
        public Color _bordercolor { get; set; } = Color.Red;

        public float _borderwidth { get; set; } = 3;
        protected override void OnPaint(PaintEventArgs e)
        {
            

        GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);

            // Defina a cor e a espessura da borda
            Pen pen = new Pen(_bordercolor, _borderwidth);

            // Desenhe a borda ao redor do caminho da elipse
            e.Graphics.DrawPath(pen, g);

            base.OnPaint(e);
        }
    }
    
}

