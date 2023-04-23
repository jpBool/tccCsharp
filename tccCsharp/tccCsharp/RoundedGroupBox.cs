using System.Drawing; // Biblioteca para recursos gráficos
using System.Windows.Forms; // Biblioteca para elementos de interface do usuário
using System.Drawing.Drawing2D; // Biblioteca para trabalhar com caminhos gráficos

// Define o namespace do projeto
namespace tccCsharp
{
    // Cria uma classe personalizada chamada RoundedGroupBox, que herda da classe GroupBox
    public class RoundedGroupBox : GroupBox
    {
        // Define um campo privado que armazena o raio da borda arredondada padrão
        private int _cornerRadius = 10;

        // Define um campo privado que armazena uma cor de fundo padrão
        private Color _backgroundColor = Color.White;

        // Define um campo privado que armazena uma espessura de borda padrão
        private float _borderWidth = 1.0f;

        // Define uma propriedade pública que permite o acesso ao campo privado _cornerRadius
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set { _cornerRadius = value; Invalidate(); } // Chama o método Invalidate() para atualizar a aparência do controle
        }

        // Define uma propriedade pública que permite o acesso ao campo privado _backgroundColor
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; Invalidate(); }
        }

        // Define uma propriedade pública que permite o acesso ao campo privado _borderWidth
        public float BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; Invalidate(); }
        }

        // Sobrescreve o método OnPaint para desenhar a aparência do controle
        protected override void OnPaint(PaintEventArgs e)
        {
            // Mede o tamanho do texto do GroupBox
            SizeF size = e.Graphics.MeasureString(Text, Font);

            // Cria um retângulo que define a área de desenho para o GroupBox, considerando o tamanho do texto
            Rectangle rect = new Rectangle(ClientRectangle.X, ClientRectangle.Y + (int)size.Height / 2, ClientRectangle.Width - 1, ClientRectangle.Height - (int)size.Height / 2 - 1);

            // Cria um objeto GraphicsPath para definir o caminho da borda arredondada
            GraphicsPath path = RoundedRect(rect, CornerRadius);

            // Define o modo de suavização para antialiasing
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Desenha o caminho da borda arredondada na superfície do controle com uma cor da caneta especificada
            e.Graphics.DrawPath(new Pen(ForeColor), path);

            // Preenche o caminho com uma cor sólida
            e.Graphics.FillPath(new SolidBrush(BackgroundColor), path);

            // Desenha o texto na posição (0,0) do controle
            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), new PointF(0, 0));

            // Altera a espessura da caneta (que desenha a borda) considerando a espessura definida
            using (Pen borderPen = new Pen(ForeColor, BorderWidth))
            {
                e.Graphics.DrawPath(borderPen, path);
            }
        }



        // Cria um método privado que retorna um objeto GraphicsPath para desenhar as bordas arredondadas
        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            // Calcula o diâmetro da borda arredondada
            int diameter = radius * 2;

            // Cria um tamanho com o diâmetro calculado
            Size size = new Size(diameter, diameter);

            // Cria um retângulo com base no tamanho e localização do retângulo passado
            Rectangle arc = new Rectangle(bounds.Location, size);

            // Cria um objeto GraphicsPath
            GraphicsPath path = new GraphicsPath();

            // Verifica se o raio da borda é zero e adiciona um retângulo ao objeto GraphicsPath
            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // Adiciona quatro arcos para o objeto GraphicsPath para formar as bordas arredondadas
            // O primeiro arco é o canto superior esquerdo
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }


    }
}