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
        int index_btn = 0;

        public frmPerfil()
        {
            InitializeComponent();
        }

        public void Refresh_projects(List<Project> projetos)
        {
            if (X == 0)
                OPBLeft.Visible = false;
            else
                OPBLeft.Visible = true;

            if (projetos.Count() <= X + 3)
                OPBRight.Visible = false;
            else
                OPBRight.Visible = true;

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

        public void Logo(int logo)
        {
            switch (logo)
            {
                case 0:

                    opbLogo.Image = global::tccCsharp.Properties.Resources.Logo_White2;
                    opbLogout.Image = global::tccCsharp.Properties.Resources.Logout_Black;
                    opbRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_Black;
                    opbConfiguracoes.Image = global::tccCsharp.Properties.Resources.Config_Black;

                    opbEditarP1.Image = global::tccCsharp.Properties.Resources.Edit_White;  
                    opbEditarP2.Image = global::tccCsharp.Properties.Resources.Edit_White;
                    opbEditarP3.Image = global::tccCsharp.Properties.Resources.Edit_White;

                    OPBLeft.Image = global::tccCsharp.Properties.Resources.Left_White;
                    OPBRight.Image = global::tccCsharp.Properties.Resources.Right_White;

                    break;

                case 1:
                    opbLogo.Image = global::tccCsharp.Properties.Resources.Logo_Black2;
                    opbLogout.Image = global::tccCsharp.Properties.Resources.Logout_White;
                    opbRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_White;
                    opbConfiguracoes.Image = global::tccCsharp.Properties.Resources.Config_White;

                    opbEditarP1.Image = global::tccCsharp.Properties.Resources.Edit_Black; 
                    opbEditarP2.Image = global::tccCsharp.Properties.Resources.Edit_Black;
                    opbEditarP3.Image = global::tccCsharp.Properties.Resources.Edit_Black;

                    OPBLeft.Image = global::tccCsharp.Properties.Resources.Left_Black;
                    OPBRight.Image = global::tccCsharp.Properties.Resources.Right_Black;

                    break;
            }
        }

        public void DoDesign()
        {
            TLP_Mãe.Font = Program.fonte;
            
            Logo(Program.logo);
            TLPHead1.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);

            TLP_Mãe.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]); //cor anterior comentada
            TLP_Filha1.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            TLP_Filha2.BackColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            //TLPMenu2.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);

            RGBNeta1.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            RGBNeta1.CornerRadius = 20;
            RGBNeta1.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);

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
            btnAdicionar.AutoHoover = true;
            btnAdicionar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnAdicionar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnAdicionar.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnAdicionar.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);


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
            opbEditarP2._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            opbEditarP1._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            OPBLeft._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            OPBRight._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            opbLogout.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbRecarregar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbConfiguracoes.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarP3.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarP2.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarP1.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBLeft.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBRight.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);

            opbLogout.AutoHoover = true;
            opbRecarregar.AutoHoover = true;
            opbConfiguracoes.AutoHoover = true;
            opbEditarP3.AutoHoover = true;
            opbEditarP2.AutoHoover = true;
            opbEditarP1.AutoHoover = true;
            OPBLeft.AutoHoover = true;
            OPBRight.AutoHoover = true;

            opbLogout.BordaPrincipal = Color.Transparent;
            opbRecarregar.BordaPrincipal = Color.Transparent;
            opbConfiguracoes.BordaPrincipal = Color.Transparent;
            opbEditarP3.BordaPrincipal = Color.Transparent;
            opbEditarP2.BordaPrincipal = Color.Transparent;
            opbEditarP1.BordaPrincipal = Color.Transparent;
            OPBLeft.BordaPrincipal = Color.Transparent;
            OPBRight.BordaPrincipal = Color.Transparent;



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
            usuario.avatar = 2;
            Banco.CarregaPerfil(usuario);
            lblNome.Text = usuario.nome.ToString();
            lblBio.Text = usuario.bio.ToString();
            lblAMD.Text = usuario.inscricao.ToShortDateString();
            lblEmail.Text = usuario.email.ToString();
            lblCommits.Text = usuario.commits.ToString();

            int seguidores = 0;
            int seguidos = 0;
            int[] seguimentos = new int[2] { 0, 0 };
            seguimentos = Banco.seguimentos();
            seguidores = seguimentos[0];
            seguidos = seguimentos[1];
            lblSeguidores.Text = seguidores.ToString();
            lblSeguindo.Text = seguidos.ToString();

            switch (usuario.avatar)
            {
                case 0: break;
                case 1: opcAvatar.Image = global::tccCsharp.Properties.Resources._1; break;
                case 2: opcAvatar.Image = global::tccCsharp.Properties.Resources._2; break;
                case 3: opcAvatar.Image = global::tccCsharp.Properties.Resources._3; break;
                case 4: opcAvatar.Image = global::tccCsharp.Properties.Resources._4; break;
                case 5: opcAvatar.Image = global::tccCsharp.Properties.Resources._5; break;
                case 6: opcAvatar.Image = global::tccCsharp.Properties.Resources._6; break;
                case 7: opcAvatar.Image = global::tccCsharp.Properties.Resources._7; break;
                case 8: opcAvatar.Image = global::tccCsharp.Properties.Resources._8; break;
                case 9: opcAvatar.Image = global::tccCsharp.Properties.Resources._9; break;
                case 10: opcAvatar.Image = global::tccCsharp.Properties.Resources._10; break;
                case 11: opcAvatar.Image = global::tccCsharp.Properties.Resources._11; break;
                case 12: opcAvatar.Image = global::tccCsharp.Properties.Resources._12; break;
                case 13: opcAvatar.Image = global::tccCsharp.Properties.Resources._13; break;
                case 14: opcAvatar.Image = global::tccCsharp.Properties.Resources._14; break;
                case 15: opcAvatar.Image = global::tccCsharp.Properties.Resources._15; break;
                case 16: opcAvatar.Image = global::tccCsharp.Properties.Resources._16; break;
                case 17: opcAvatar.Image = global::tccCsharp.Properties.Resources._17; break;
                case 18: opcAvatar.Image = global::tccCsharp.Properties.Resources._18; break;
                case 19: opcAvatar.Image = global::tccCsharp.Properties.Resources._19; break;
                case 20: opcAvatar.Image = global::tccCsharp.Properties.Resources._20; break;
                case 21: opcAvatar.Image = global::tccCsharp.Properties.Resources._21; break;
                case 22: opcAvatar.Image = global::tccCsharp.Properties.Resources._22; break;
                case 23: opcAvatar.Image = global::tccCsharp.Properties.Resources._23; break;
                case 24: opcAvatar.Image = global::tccCsharp.Properties.Resources._24; break;
                case 25: opcAvatar.Image = global::tccCsharp.Properties.Resources._25; break;
                case 26: opcAvatar.Image = global::tccCsharp.Properties.Resources._26; break;
                case 27: opcAvatar.Image = global::tccCsharp.Properties.Resources._27; break;
                case 28: opcAvatar.Image = global::tccCsharp.Properties.Resources._28; break;
                case 29: opcAvatar.Image = global::tccCsharp.Properties.Resources._29; break;
                case 30: opcAvatar.Image = global::tccCsharp.Properties.Resources._30; break;
                case 31: opcAvatar.Image = global::tccCsharp.Properties.Resources._31; break;
                case 32: opcAvatar.Image = global::tccCsharp.Properties.Resources._32; break;
                case 33: opcAvatar.Image = global::tccCsharp.Properties.Resources._33; break;
                case 34: opcAvatar.Image = global::tccCsharp.Properties.Resources._34; break;
            }
            

        }
        //BOTÔES 

        

        //MOUSE CLiCK

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

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            X += 3;
            Refresh_projects(Program.projetos);
        }

        private void ovalPictureBox2_Click(object sender, EventArgs e)
        {
            X -= 3;
            Refresh_projects(Program.projetos);
        }

        private void opbConfiguracoes_Click_1(object sender, EventArgs e)
        {
            frmConfiguracoes formC = new frmConfiguracoes();
            formC.ShowDialog();
        }

        private void opbRecarregar_Click_1(object sender, EventArgs e)
        {
            DoDesign();
            Program.projetos = Banco.CarregarProjetos(Program.projetos);
            Refresh_projects(Program.projetos);
        }

        private void opbLogout_Click_1(object sender, EventArgs e)
        {
            Program.projetos.Clear();
            Program.id_usuario = 0;
            this.Close();
        }

        private void frmPerfil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                index_btn++;
                if (index_btn == 10)
                    index_btn = 1;

                switch (index_btn)
                {
                    case 1:
                        btnAdicionar.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        btnAdicionar.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        opbLogout._bordercolor = Color.Transparent;
                        break;
                    case 2:
                        btnAdicionar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                        btnAdicionar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                        opbEditarP1._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]); //
                        if (opbEditarP1.Visible == false)
                        {
                            frmPerfil_KeyDown(sender, e);
                        }
                        break;

                    case 3:
                        opbEditarP1._bordercolor = Color.Transparent;
                        opbEditarP2._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (opbEditarP2.Visible == false)
                        {
                            frmPerfil_KeyDown(sender, e);
                        }
                        break;
                    
                    case 4:
                        opbEditarP2._bordercolor = Color.Transparent;
                        opbEditarP3._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (opbEditarP3.Visible == false)
                        {
                            frmPerfil_KeyDown(sender, e);
                        }
                        break;

                    case 5:
                        opbEditarP3._bordercolor = Color.Transparent;
                        OPBLeft._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (OPBLeft.Visible == false)
                        {
                            frmPerfil_KeyDown(sender, e);
                        }
                        break;

                    case 6:                     
                        OPBLeft._bordercolor = Color.Transparent;
                        OPBRight._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (OPBRight.Visible == false)
                        {
                            frmPerfil_KeyDown(sender, e);
                        }                     
                        break;

                    case 7:
                        OPBRight._bordercolor = Color.Transparent;
                        opbConfiguracoes._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        break;

                    case 8:
                        opbConfiguracoes._bordercolor = Color.Transparent;
                        opbRecarregar._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        break;

                    case 9:
                        opbRecarregar._bordercolor = Color.Transparent;
                        opbLogout._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        break;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                switch (index_btn)
                { 
                    case 1:
                        index_btn = 0;
                        btnAdicionar.BorderColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
                        btnAdicionar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                        btnAdicionar_Click(sender, e);
                        break;
                    case 2:
                        index_btn = 0;
                        opbEditarP1._bordercolor = Color.Transparent;
                        opbEditarP1_Click(sender, e);
                        break;
                    case 3:
                        index_btn = 0;
                        opbEditarP2._bordercolor = Color.Transparent;
                        opbEditarP2_Click(sender, e);
                        break;
                    case 4:
                        index_btn = 0;
                        opbEditarP3._bordercolor = Color.Transparent;
                        opbEditarP3_Click(sender, e);
                        break;
                    case 5:
                        index_btn = 0;
                        OPBLeft._bordercolor = Color.Transparent;
                        ovalPictureBox2_Click(sender, e);
                        break;
                    case 6:
                        index_btn = 0;
                        OPBRight._bordercolor = Color.Transparent;
                        ovalPictureBox1_Click(sender, e);
                        break;
                    case 7:
                        index_btn = 0;
                        opbConfiguracoes._bordercolor = Color.Transparent;
                        opbConfiguracoes_Click_1(sender, e);
                        break;
                    case 8:
                        index_btn = 0;
                        opbRecarregar._bordercolor = Color.Transparent;
                        opbRecarregar_Click_1(sender, e);
                        break;
                    case 9:
                        index_btn = 0;
                        opbLogout._bordercolor = Color.Transparent;
                        opbLogout_Click_1(sender, e);
                        break;

                }

            }
        }
    }
}
