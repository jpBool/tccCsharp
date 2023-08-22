using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable IDE1006


namespace tccCsharp
{
    public partial class frmPerfil : Form
    {
        int X = 0;

        public frmPerfil()
        {
            InitializeComponent();
        }

        public void Refresh_projects(List<Project> projetos)
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

        public void SetSelecionado(List<Project> projetos, int num)
        {
            Project projeto_selecionado = new Project();
            projeto_selecionado = projetos[X + num];
            Program.id_projeto_atual = projeto_selecionado.id_projeto;
        }

        public void DoDesign()
        {
            TLPHead1.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);

            TLP_Mãe.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]); //cor anterior comentada
            TLP_Filha1.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            TLP_Filha2.BackColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            //TLPMenu2.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);

            RGBNeta1.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            RGBNeta1.CornerRadius = 20;

            RGBSeguidores.BackgroundColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            RGBSeguidores.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblSeguidores.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblNSeguidores.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            RGBSeguidores.CornerRadius = 20;

            RGBSeguindo.BackgroundColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            RGBSeguindo.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblSeguindo.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblNSeguindo.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            RGBSeguindo.CornerRadius = 20;

            RGBCommits.BackgroundColor = Color.Transparent;
            RGBCommits.ForeColor = Color.Transparent;
            lblCommits.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblNCommits.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblAtivoDesde.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblAMD.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

            rgbProjetos.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            RGPProjeto1.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGPProjeto2.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGPProjeto3.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGPProjeto1.CornerRadius = 20;
            RGPProjeto2.CornerRadius = 20;
            RGPProjeto3.CornerRadius = 20;
            RGPProjeto1.BorderWidth = 2;
            RGPProjeto2.BorderWidth = 2;
            RGPProjeto3.BorderWidth = 2;

            
            btnAdicionar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnAdicionar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnEditarPerfil.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnEditarPerfil.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnAdicionar.AutoHoover = true;
            btnEditarPerfil.AutoHoover = true;
            btnAdicionar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnEditarPerfil.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);


            RGBBio.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            RGBBio.CornerRadius = 20;
            RGBBio.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblBio.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);


            RGBDescricaoP1.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]); //mexendo nessa
            RGBDescricaoP1.CornerRadius = 20;
            RGBDescricaoP1.ForeColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblDescricaoP1.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

            RGBDescricaoP2.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBDescricaoP2.CornerRadius = 20;
            RGBDescricaoP2.ForeColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblDescricaoP2.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

            RGBDescricaoP3.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBDescricaoP3.CornerRadius = 20;
            RGBDescricaoP3.ForeColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblDescricaoP3.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

            opcAvatar.Height = TLPAvatar.Height / 2;
            opcAvatar.Width = opcAvatar.Height;


            opbLogout._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            opbRecarregar._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            opbConfiguracoes._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            opbEditarP3._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            opbEditarP1._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            opbEditarP1._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            opbLogout.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbRecarregar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbConfiguracoes.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarP3.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarP1.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarP1.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);

            opbLogout.AutoHoover = true;
            opbRecarregar.AutoHoover = true;
            opbConfiguracoes.AutoHoover = true;
            opbEditarP3.AutoHoover = true;
            opbEditarP1.AutoHoover = true;
            opbEditarP1.AutoHoover = true;



            //teste
            lblNome.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblEmail.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblProjetos.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblNomeP1.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblNomeP2.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblNomeP3.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            Refresh_projects(Program.projetos);
            WindowState = FormWindowState.Maximized;
            DoDesign();

            User usuario = new User();
            Banco.CarregaPerfil(usuario);
            lblNome.Text = usuario.nome.ToString();
            lblBio.Text = usuario.bio.ToString();
            //lblNaturalidade.Text = usuario.naturalidade.ToString();
            lblAMD.Text = usuario.inscricao.ToShortDateString();
            lblEmail.Text = usuario.email.ToString();
            lblCommits.Text = usuario.commits.ToString();
        }
        //BOTÔES 

        

        //MOUSE CLiCK
        private void btnAvancar_Click(object sender, EventArgs e)
        {
            X += 3;
            Refresh_projects(Program.projetos);
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            X -= 3;
            Refresh_projects(Program.projetos);
        }
        private void OPBLogout_Click(object sender, EventArgs e)
        {
            Program.projetos.Clear();
            Program.id_usuario = 0;
            this.Close();
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
            DoDesign();
            Program.projetos = Banco.CarregarProjetos(Program.projetos);
            Refresh_projects(Program.projetos);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCriar_Projeto splash = new frmCriar_Projeto();
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                if (Program.id_projeto_atual == 0)
                {
                    this.Visible = true;
                }
                else
                {
                    frmEditar_Projeto splash2 = new frmEditar_Projeto();
                    splash2.ShowDialog();
                    if (Program.id_usuario == 0)
                    {
                        this.Close();
                    }
                    this.Visible = true;
                }
                Program.projetos = Banco.CarregarProjetos(Program.projetos);
                Refresh_projects(Program.projetos);
            }
        }

        private void opbEditarP1_Click(object sender, EventArgs e)
        {
            SetSelecionado(Program.projetos, 0);
            this.Visible = false;
            frmEditar_Projeto splash = new frmEditar_Projeto();
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            this.Visible = true;
            Program.id_projeto_atual = 0;
            Program.projetos = Banco.CarregarProjetos(Program.projetos);
            Refresh_projects(Program.projetos);
        }

        private void opbEditarP2_Click(object sender, EventArgs e)
        {
            SetSelecionado(Program.projetos, 1);
            this.Visible = false;
            frmEditar_Projeto splash = new frmEditar_Projeto();
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            this.Visible = true;
            Program.id_projeto_atual = 0;
            Program.projetos = Banco.CarregarProjetos(Program.projetos);
            Refresh_projects(Program.projetos);
        }

        private void opbEditarP3_Click(object sender, EventArgs e)
        {
            SetSelecionado(Program.projetos, 2);
            this.Visible = false;
            frmEditar_Projeto splash = new frmEditar_Projeto();
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            this.Visible = true;
            Program.id_projeto_atual = 0;
            Program.projetos = Banco.CarregarProjetos(Program.projetos);
            Refresh_projects(Program.projetos);
        }
    }
}
