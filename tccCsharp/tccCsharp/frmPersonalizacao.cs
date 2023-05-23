using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tccCsharp
{
    public partial class frmPersonalizacao : Form
    {
        public frmPersonalizacao()
        {
            InitializeComponent();
        }

        private void frmPersonalizacao_Load(object sender, EventArgs e)
        {
            cldAcessibilidade = new ColorDialog();
        }

        private void btnSelecaoCorP_Click(object sender, EventArgs e)
        {
            if(cldAcessibilidade.ShowDialog() == DialogResult.OK)
            {
                Program.Cor1[0] = cldAcessibilidade.Color.R;
                Program.Cor1[1] = cldAcessibilidade.Color.G;
                Program.Cor1[2] = cldAcessibilidade.Color.B;

                Program.Cor2[0] = cldAcessibilidade.Color.R;
                Program.Cor2[1] = cldAcessibilidade.Color.G;
                Program.Cor2[2] = cldAcessibilidade.Color.B;

                Program.Cor3[0] = cldAcessibilidade.Color.R;
                Program.Cor3[1] = cldAcessibilidade.Color.G;
                Program.Cor3[2] = cldAcessibilidade.Color.B;

                Program.Cor4[0] = cldAcessibilidade.Color.R;
                Program.Cor4[1] = cldAcessibilidade.Color.G;
                Program.Cor4[2] = cldAcessibilidade.Color.B;

                Program.Cor5[0] = cldAcessibilidade.Color.R;
                Program.Cor5[1] = cldAcessibilidade.Color.G;
                Program.Cor5[2] = cldAcessibilidade.Color.B;

                Program.Cor6[0] = cldAcessibilidade.Color.R;
                Program.Cor6[1] = cldAcessibilidade.Color.G;
                Program.Cor6[2] = cldAcessibilidade.Color.B;

                //colocar cor do texto e aviso tbm?
            }
            
        }
    }
}
