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
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            User usuario = new User();
            Banco.CarregaPerfil(usuario);
            lblNome.Text = usuario.nome.ToString();
            lblBio.Text = usuario.bio.ToString();
            lblAvatar.Text =  usuario.avatar.ToString();
            lblNaturalidade.Text = usuario.naturalidade.ToString();
            lblNascimento.Text = usuario.nascimento.ToShortDateString();
            lblInscricao.Text = usuario.inscricao.ToShortDateString();
            lblEmail.Text = usuario.email.ToString();
            lblTelefone.Text = usuario.telefone.ToString();
            lblCommits.Text = usuario.commits.ToString();
        }
    }
}
