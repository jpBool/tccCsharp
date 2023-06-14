using System.Drawing;
using System.Windows.Forms;

public class CustomLine : Control
{
    private Color lineColor;
    private int lineWidth;

    public CustomLine()
    {
        lineColor = Color.Black; // cor padrão da linha
        lineWidth = 1; // espessura padrão da linha
        SetStyle(ControlStyles.ResizeRedraw, true);
    }

    public Color LineColor
    {
        get { return lineColor; }
        set
        {
            lineColor = value;
            Invalidate();
        }
    }

    public int LineWidth
    {
        get { return lineWidth; }
        set
        {
            lineWidth = value;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (Pen pen = new Pen(lineColor, lineWidth))
        {
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            int startX = 0;
            int startY = Height / 2;
            int endX = Width;
            int endY = Height / 2;

            e.Graphics.DrawLine(pen, startX, startY, endX, endY);
        }
    }
}