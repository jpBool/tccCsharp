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
            List<Project> projetos = new List<Project>();

            projetos = Banco.CarregarProjetos(projetos);

            btnVoltar.Enabled = false;
            Project projeto1 = new Project();
            if (projetos.Count > 0 )
            {
                projeto1 = projetos[0];
                lblNomeP1.Text = projeto1.nome_projeto;
            }
            else
            {
                gpbProjeto1.Visible= false;
            }

            Project projeto2 = new Project();
            if (projetos.Count() > 1)
            {
                projeto2 = projetos[1];
                lblNomeP2.Text = projeto2.nome_projeto;
            }
            else
            {
                gpbProjeto2.Visible= false;
            }
            
            Project projeto3 = new Project();
            if (projetos.Count() > 2 )
            {
                projeto3 = projetos[2];
                lblNomeP3.Text = projeto3.nome_projeto;
            }
            else
            {
                gpbProjeto3.Visible= false;
            }
            if (projetos.Count() <= 3)
            { 
                btnAvancar.Enabled= false;
            }


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
