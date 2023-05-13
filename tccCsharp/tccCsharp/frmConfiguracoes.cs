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
    public partial class frmConfiguracoes : Form
    {
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void frmConfiguracoes_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonalizacao_Click(object sender, EventArgs e)
        {
            frmPersonalizacao formP = new frmPersonalizacao();
            formP.ShowDialog();
        }
    }
}
