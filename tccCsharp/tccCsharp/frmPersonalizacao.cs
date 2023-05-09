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
            cldPersonalizacao = new ColorDialog();
        }

        private void btnSelecaoCorP_Click(object sender, EventArgs e)
        {
            if(cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                Program.Cor1[0] = cldPersonalizacao.Color.R;
                Program.Cor1[1] = cldPersonalizacao.Color.G;
                Program.Cor1[2] = cldPersonalizacao.Color.B;
            }
            
        }
    }
}
