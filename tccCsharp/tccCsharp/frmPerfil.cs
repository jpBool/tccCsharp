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
        int X = 0;

        public frmPerfil()
        {
            InitializeComponent();
        }

        public void refresh_projects(List<Project> projetos)
        {
            if (X == 0)
                btnVoltar.Enabled = false;
            else
                btnVoltar.Enabled = true;

            if (projetos.Count() <= X + 3)
                btnAvancar.Enabled = false;
            else
                btnAvancar.Enabled = true;

            Project projeto1 = new Project();
            if (projetos.Count > X + 0)
            {
                gpbProjeto1.Visible = true;
                projeto1 = projetos[X + 0];
                lblNomeP1.Text = projeto1.nome_projeto;
            }
            else
            {
                gpbProjeto1.Visible = false;
            }

            Project projeto2 = new Project();
            if (projetos.Count() > X + 1)
            {
                gpbProjeto2.Visible = true;
                projeto2 = projetos[X + 1];
                lblNomeP2.Text = projeto2.nome_projeto;
            }
            else
            {
                gpbProjeto2.Visible = false;
            }

            Project projeto3 = new Project();
            if (projetos.Count() > X + 2)
            {
                gpbProjeto3.Visible = true;
                projeto3 = projetos[X + 2];
                lblNomeP3.Text = projeto3.nome_projeto;
            }
            else
            {
                gpbProjeto3.Visible = false;
            }

        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            /*refresh_projects(Program.projetos);

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
            lblCommits.Text = usuario.commits.ToString();*/
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            X += 3;
            refresh_projects(Program.projetos);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            X -= 3;
            refresh_projects(Program.projetos);
        }



        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Program.projetos.Clear();
            Program.id_usuario = 0;
            this.Close();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {

        }
    }
}
