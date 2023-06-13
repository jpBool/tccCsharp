using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class RoundedButton : Button
    {
        private int borderRadius = 10; // Raio das bordas
        private int borderThickness = 2; // Espessura da borda
        private Color borderColor = Color.Black; // Cor da borda
        private Color backgroundColor = Color.White; // Cor do fundo

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        public int BorderThickness
        {
            get { return borderThickness; }
            set
            {
                borderThickness = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;


            // Desenha o fundo arredondado
            using (SolidBrush backgroundBrush = new SolidBrush(BackgroundColor))
            {
                RectangleF backgroundRect = new RectangleF(
                    BorderThickness,
                    BorderThickness,
                    Width - (BorderThickness * 2),
                    Height - (BorderThickness * 2)
                );

                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphics.FillRectangle(backgroundBrush, backgroundRect);
            }

            // Desenha a borda arredondada
            using (Pen borderPen = new Pen(BorderColor, BorderThickness))
            {
                RectangleF borderRect = new RectangleF(
                    BorderThickness / 2,
                    BorderThickness / 2,
                    Width - BorderThickness,
                    Height - BorderThickness
                );

                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphics.DrawArc(borderPen, borderRect.X, borderRect.Y, BorderRadius, BorderRadius, 180, 90);
                graphics.DrawArc(borderPen, borderRect.X + borderRect.Width - BorderRadius, borderRect.Y, BorderRadius, BorderRadius, 270, 90);
                graphics.DrawArc(borderPen, borderRect.X, borderRect.Y + borderRect.Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
                graphics.DrawArc(borderPen, borderRect.X + borderRect.Width - BorderRadius, borderRect.Y + borderRect.Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);

                graphics.DrawLine(borderPen, BorderThickness / 2 + BorderRadius / 2, BorderThickness / 2, Width - BorderThickness / 2 - BorderRadius / 2, BorderThickness / 2);
                graphics.DrawLine(borderPen, Width - BorderThickness / 2, BorderThickness / 2 + BorderRadius / 2, Width - BorderThickness / 2, Height - BorderThickness / 2 - BorderRadius / 2);
                graphics.DrawLine(borderPen, Width - BorderThickness / 2 - BorderRadius / 2, Height - BorderThickness / 2, BorderThickness / 2 + BorderRadius / 2, Height - BorderThickness / 2);
                graphics.DrawLine(borderPen, BorderThickness / 2, Height - BorderThickness / 2 - BorderRadius / 2, BorderThickness / 2, BorderThickness / 2 + BorderRadius / 2);
            }

            // Desenha o texto do botão
            TextRenderer.DrawText(graphics, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}