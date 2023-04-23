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
                RGPProjeto1.Visible = true;
                projeto1 = projetos[X + 0];
                lblNomeP1.Text = projeto1.nome_projeto;
            }
            else
            {
                RGPProjeto1.Visible = false;
            }

            Project projeto2 = new Project();
            if (projetos.Count() > X + 1)
            {
                RGPProjeto2.Visible = true;
                projeto2 = projetos[X + 1];
                lblNomeP2.Text = projeto2.nome_projeto;
            }
            else
            {
                RGPProjeto2.Visible = false;
            }

            Project projeto3 = new Project();
            if (projetos.Count() > X + 2)
            {
                RGPProjeto3.Visible = true;
                projeto3 = projetos[X + 2];
                lblNomeP3.Text = projeto3.nome_projeto;
            }
            else
            {
                RGPProjeto3.Visible = false;
            }

        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            TLP_Mãe.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            TLP_Filha1.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            TLP_Filha2.BackColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            TLPMenu2.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);

            RGBNeta1.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBNeta1.CornerRadius = 20;

            RGBNeta2.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBNeta2.CornerRadius = 20;

            RGBSeguidores.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBSeguidores.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblSeguidores.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblNSeguidores.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            RGBSeguidores.CornerRadius = 20;

            RGBSeguindo.BackgroundColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBSeguindo.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblSeguindo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            lblNSeguindo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            RGBSeguindo.CornerRadius = 20;

            RGBCommits.BackgroundColor = Color.Transparent;
            RGBCommits.ForeColor = Color.Transparent;
            lblCommits.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblNCommits.ForeColor= Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblAtivoDesde.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblAMD.ForeColor= Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

            RGPProjeto1.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGPProjeto2.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGPProjeto3.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGPProjeto1.CornerRadius = 20;
            RGPProjeto2.CornerRadius = 20;
            RGPProjeto3.CornerRadius = 20;
            RGPProjeto1.BorderWidth = 2;
            RGPProjeto2.BorderWidth = 2;
            RGPProjeto3.BorderWidth = 2;

            RGBNaturalidade.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBNaturalidade.CornerRadius = 20;
            RGBNaturalidade.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblNaturalidade.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

            RGBBio.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBBio.CornerRadius = 20;
            RGBBio.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblBio.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);


            RGBDescricaoP1.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBDescricaoP1.CornerRadius = 20;
            RGBDescricaoP1.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblDescricaoP1.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

            RGBDescricaoP2.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBDescricaoP2.CornerRadius = 20;
            RGBDescricaoP2.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblDescricaoP2.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

            RGBDescricaoP3.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBDescricaoP3.CornerRadius = 20;
            RGBDescricaoP3.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblDescricaoP3.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

            btnAdicionar.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            btnAdicionar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnLogoff.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            btnLogoff.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);


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

        private void RGB_btnAdicionar_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }
    }
}
