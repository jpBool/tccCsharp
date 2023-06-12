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
                lblDescricaoP1.Text = projeto1.descricao_breve;
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
                lblDescricaoP2.Text = projeto2.descricao_breve;
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
                lblDescricaoP3.Text = projeto3.descricao_breve;
            }
            else
            {
                RGPProjeto3.Visible = false;
            }

        }

        public void doDesing()
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
            lblNCommits.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblAtivoDesde.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblAMD.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

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

            RGBAdicionar.BackgroundColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblAdicionar.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblAdicionar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            opcAvatar.Height = TLPAvatar.Height / 2;
            opcAvatar.Width = opcAvatar.Height;

            RGBMenu1.BackgroundColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBMenu1.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            OPBLogout._borderwidth = 5;
            OPBLogout._bordercolor = Color.Black;
            OPBLogout.BackColor = Color.White;  
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            refresh_projects(Program.projetos);
            doDesing();

            User usuario = new User();
            Banco.CarregaPerfil(usuario);
            lblNome.Text = usuario.nome.ToString();
            lblBio.Text = usuario.bio.ToString();
            lblNaturalidade.Text = usuario.naturalidade.ToString();
            lblAMD.Text = usuario.inscricao.ToShortDateString();
            lblEmail.Text = usuario.email.ToString();
            lblCommits.Text = usuario.commits.ToString();
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





        private void btnAdicionar_MouseEnter(object sender, EventArgs e)
        {
            lblAdicionar.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            RGBAdicionar.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void btnAdicionar_MouseLeave(object sender, EventArgs e)
        {
            lblAdicionar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            RGBAdicionar.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
        }


        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            Program.projetos.Clear();
            Program.id_usuario = 0;
            this.Close();
        }



        private void OPBLogout_MouseEnter(object sender, EventArgs e)
        {
            OPBLogout.Height = 55;
            OPBLogout.Width = 55;
            OPBLogout._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void OPBLogout_MouseLeave(object sender, EventArgs e)
        {
            OPBLogout.Height = 48;
            OPBLogout.Width = 48;
            OPBLogout._bordercolor = Color.Black;
        }

        private void opbRecarregar_MouseEnter(object sender, EventArgs e)
        {
            opbRecarregar.Height = 55;
            opbRecarregar.Width = 55;
            opbRecarregar._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void opbRecarregar_MouseLeave(object sender, EventArgs e)
        {
            opbRecarregar.Height = 48;
            opbRecarregar.Width = 48;
            opbRecarregar._bordercolor = Color.Black;
        }

        private void opbConfiguracoes_MouseEnter(object sender, EventArgs e)
        {
            opbConfiguracoes.Height = 55;
            opbConfiguracoes.Width = 55;
            opbConfiguracoes._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }



        private void opbEditar_MouseEnter(object sender, EventArgs e)
        {
            opbEditar.Height = 55;
            opbEditar.Width = 55;
            opbEditar._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void opbEditar_MouseLeave(object sender, EventArgs e)
        {
            opbEditar.Height = 48;
            opbEditar.Width = 48;
            opbEditar._bordercolor = Color.Black;
        }

        private void opbCompartilhar_MouseEnter(object sender, EventArgs e)
        {
            opbCompartilhar.Height = 55;
            opbCompartilhar.Width = 55;
            opbCompartilhar._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }



        private void opbExcluir_MouseEnter(object sender, EventArgs e)
        {
            opbExcluir.Height = 55;
            opbExcluir.Width = 55;
            opbExcluir._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void opbExcluir_MouseLeave(object sender, EventArgs e)
        {
            opbExcluir.Height = 48;
            opbExcluir.Width = 48;
            opbExcluir._bordercolor = Color.Black;
        }
        private void OPBLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void lblAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void opbCompartilhar_Click(object sender, EventArgs e)
        {

        }

        private void opbExcluir_Click(object sender, EventArgs e)
        {

        }

        private void opbEditar_Click(object sender, EventArgs e)
        {

        }

        private void opbConfiguracoes_Click(object sender, EventArgs e)
        {
            //apenas teste
            frmConfiguracoes formC = new frmConfiguracoes();
            formC.ShowDialog();

            /*frmPersonalizacao formP = new frmPersonalizacao();
            formP.ShowDialog();*/
        }

        private void opbRecarregar_Click(object sender, EventArgs e)
        {
            TLP_Mãe.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]); //ok
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
            lblNCommits.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblAtivoDesde.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblAMD.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

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

            RGBAdicionar.BackgroundColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblAdicionar.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblAdicionar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            opcAvatar.Height = TLPAvatar.Height / 2;
            opcAvatar.Width = opcAvatar.Height;

            RGBMenu1.BackgroundColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBMenu1.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            OPBLogout._borderwidth = 5;
            OPBLogout._bordercolor = Color.Black;
            OPBLogout.BackColor = Color.White;
        }

        private void opbConfiguracoes_MouseLeave(object sender, EventArgs e)
        {
            opbConfiguracoes.Height = 48;
            opbConfiguracoes.Width = 48;
            opbConfiguracoes._bordercolor = Color.Black;
        }

        private void opbCompartilhar_MouseLeave(object sender, EventArgs e)
        {
            opbCompartilhar.Height = 48;
            opbCompartilhar.Width = 48;
            opbCompartilhar._bordercolor = Color.Black;
        }

        private void btnExcluir2_Click(object sender, EventArgs e)
        {

        }

        private void TLP_Mãe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCompartilhar2_Click(object sender, EventArgs e)
        {
            
        }
    }
   
    

}
