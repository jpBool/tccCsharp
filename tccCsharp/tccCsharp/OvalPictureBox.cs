using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace tccCsharp
{
    public class OvalPictureBox : PictureBox
    {
        private Color Bordercolor = Color.Red;

        public float _borderwidth { get; set; } = 3;


        private Color bordaPrincippal = Color.Black;
        private Color bordaHoover = Color.Green;
        private bool autoHoover = false;

        public Color BordaPrincipal
        {
            get { return bordaPrincippal; }
            set
            {
                bordaPrincippal = value;
                Refresh();
            }
        }

        public Color _bordercolor
        {
            get { return Bordercolor; }
            set
            {
                Bordercolor = value;
                Refresh();
            }
            
        }

        public Color BordaHoover
        {
            get { return bordaHoover; }
            set
            {
                bordaHoover = value;
                Refresh();
            }
        }

        public bool AutoHoover
        {
            get { return autoHoover; }
            set
            {
                autoHoover = value;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            

        GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Defina a cor e a espessura da borda
            Pen pen = new Pen(_bordercolor, _borderwidth);

            // Desenhe a borda ao redor do caminho da elipse
            e.Graphics.DrawPath(pen, g);

            base.OnPaint(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (AutoHoover == true)
            {
                BordaPrincipal = _bordercolor;
                _bordercolor = BordaHoover;
                ForeColor = BordaHoover;
                Refresh();
            }
            else
            {
                base.OnMouseEnter(e);
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (AutoHoover == true)
            {
                _bordercolor = BordaPrincipal;
                Refresh();
            }
            else
            {
                base.OnMouseLeave(e);
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            if (AutoHoover == true)
            {
                BordaPrincipal = _bordercolor;
                _bordercolor = BordaHoover;
                ForeColor = BordaHoover;
                Refresh();
            }
            else
            {
                base.OnGotFocus(e);
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (AutoHoover == true)
            {
                _bordercolor = BordaPrincipal;
                Refresh();
            }
            else
            {
                base.OnLostFocus(e);
            }
        }
    }
}

