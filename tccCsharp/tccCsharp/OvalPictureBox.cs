using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace tccCsharp
{
    public class OvalPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0,0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(e);
        }
    }
}

