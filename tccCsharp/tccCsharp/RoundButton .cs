using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundButton : Button
{
    private int borderRadius = 10; // Raio da borda
    private int borderThickness = 2; // Espessura da borda
    private Color borderColor = Color.Black; // Cor da borda
    private Color buttonColor = Color.White; // Cor do botão

    private Color bordaPrincippal = Color.Black;
    private Color bordaHoover = Color.Green;
    private Color textoPrincipal = Color.Black;
    private bool autoHoover = false;


    public int BorderRadius
    {
        get { return borderRadius; }
        set
        {
            borderRadius = value;
            Refresh();
        }
    }

    public int BorderThickness
    {
        get { return borderThickness; }
        set
        {
            borderThickness = value;
            Refresh();
        }
    }

    public Color BorderColor
    {
        get { return borderColor; }
        set
        {
            borderColor = value;
            Refresh();
        }
    }

    public Color BordaPrincipal
    {
        get { return bordaPrincippal; }
        set
        {
            bordaPrincippal = value;
            Refresh();
        }
    }

    public Color TextoPrincipal
    {
        get { return textoPrincipal; }
        set
        {
            textoPrincipal = value;
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

    public Color ButtonColor
    {
        get { return buttonColor; }
        set
        {
            buttonColor = value;
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
        GraphicsPath path = new GraphicsPath();
        path.AddArc(ClientRectangle.Left, ClientRectangle.Top, borderRadius, borderRadius, 180, 90);
        path.AddArc(ClientRectangle.Right - borderRadius, ClientRectangle.Top, borderRadius, borderRadius, 270, 90);
        path.AddArc(ClientRectangle.Right - borderRadius, ClientRectangle.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
        path.AddArc(ClientRectangle.Left, ClientRectangle.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
        path.CloseAllFigures();

        Region = new Region(path);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Desenhe o botão
        using (SolidBrush brush = new SolidBrush(buttonColor))
        {
            e.Graphics.FillPath(brush, path);
        }

        // Desenhe a borda
        using (Pen pen = new Pen(borderColor, borderThickness))
        {
            e.Graphics.DrawPath(pen, path);
        }

        // Desenhe o texto do botão
        TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        // Verifique se o clique está dentro da área das bordas arredondadas
        GraphicsPath path = new GraphicsPath();
        path.AddArc(ClientRectangle.Left, ClientRectangle.Top, borderRadius, borderRadius, 180, 90);
        path.AddArc(ClientRectangle.Right - borderRadius, ClientRectangle.Top, borderRadius, borderRadius, 270, 90);
        path.AddArc(ClientRectangle.Right - borderRadius, ClientRectangle.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
        path.AddArc(ClientRectangle.Left, ClientRectangle.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
        path.CloseAllFigures();

        if (path.IsVisible(e.Location))
        {
            base.OnMouseDown(e);
        }
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        if (AutoHoover == true)
        {
            BordaPrincipal = BorderColor;
            TextoPrincipal = ForeColor;
            BorderColor = BordaHoover;
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
            BorderColor = BordaPrincipal;
            ForeColor = TextoPrincipal;
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
            BordaPrincipal = BorderColor;
            TextoPrincipal = ForeColor;
            BorderColor = BordaHoover;
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
            BorderColor = BordaPrincipal;
            ForeColor = TextoPrincipal;
            Refresh();
        }
        else
        {
            base.OnLostFocus(e);
        }
    }
}