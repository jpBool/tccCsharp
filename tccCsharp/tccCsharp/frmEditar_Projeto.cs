﻿using System;
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
    public partial class frmEditar_Projeto : Form
    {
        public Project editando = new Project();
        public Head cabecalho = new Head();

        public frmEditar_Projeto()
        {
            InitializeComponent();
        }

        public void DoDesign()
        {
            TLP_Mãe.Font = Program.fonte;
            TLPHead1.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);

            TLPHead2.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBHead2.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBHead2.ForeColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);

            TLPConteudo.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);

            RGBNome.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBEmail.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBAutores.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBLinguagem.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBBreve.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBSite.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBYoutube.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBPalavras.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBCampos.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBDetalhada.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBButtons.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            RGBNome.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBEmail.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBAutores.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBLinguagem.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBBreve.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBSite.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBYoutube.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBPalavras.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBCampos.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBDetalhada.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBButtons.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);

            txtNomeProjeto.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            txtEmail.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            txtAutores.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            txtLinguagem.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            txtDescricaoBreve.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            txtSite.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            txtVideo.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            btnCancelar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnCancelar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnCancelar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnCancelar.AutoHoover = true;
            btnCancelar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnCancelar.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnCancelar.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnAtualizar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnAtualizar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnAtualizar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnAtualizar.AutoHoover = true;
            btnAtualizar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnAtualizar.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnAtualizar.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnExcluir.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnExcluir.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnExcluir.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnExcluir.AutoHoover = true;
            btnExcluir.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnExcluir.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnExcluir.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnColaboradores.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnColaboradores.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnColaboradores.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnColaboradores.AutoHoover = true;
            btnColaboradores.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnColaboradores.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnColaboradores.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnImagens.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnImagens.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnImagens.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnImagens.AutoHoover = true;
            btnImagens.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnImagens.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnImagens.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnEtapas.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnEtapas.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnEtapas.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnEtapas.AutoHoover = true;
            btnEtapas.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnEtapas.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnEtapas.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            OPBLogout._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBConfiguracoes._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBRecarregar._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);

            lblTitulo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            lblPorcentagem.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblCriadoquando.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblCriador.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblAtualizadoquando.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblAtualizador.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

            groupPorcentagem.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            groupPorcentagem.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            groupPorcentagem2.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);

            OPBConfiguracoes.AutoHoover = true;
            OPBRecarregar.AutoHoover = true;
            OPBLogout.AutoHoover = true;

            OPBConfiguracoes.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBRecarregar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBLogout.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);

            OPBLogout.BordaPrincipal = Color.Transparent;
            OPBConfiguracoes.BordaPrincipal = Color.Transparent;
            OPBRecarregar.BordaPrincipal = Color.Transparent;

            Logo(Program.logo);

            clAtualizar.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clAtualizar.LineColor = Color.Transparent;
            clCancelar.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clCancelar.LineColor = Color.Transparent;
            clColaboradores.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clColaboradores.LineColor = Color.Transparent;
            clConfig.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clConfig.LineColor = Color.Transparent;
            clEtapas.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clEtapas.LineColor = Color.Transparent;
            clExcluir.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clExcluir.LineColor = Color.Transparent;
            clImagens.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clImagens.LineColor = Color.Transparent;
            clLogout.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clLogout.LineColor = Color.Transparent;
            clRecarregar.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clRecarregar.LineColor = Color.Transparent;
        }

        public string PalavrasChave()
        {
            String PalavrasEntra = txtPalavras.Text;
            Boolean EspaçoDuplo = true;
            Boolean InicioPalavra = true;
            String Palavras = "";

            PalavrasEntra = PalavrasEntra.Replace("\n", "");
            PalavrasEntra = PalavrasEntra.Replace("\t", "");
            PalavrasEntra = PalavrasEntra.Replace(";", " ");
            PalavrasEntra = PalavrasEntra.Replace(",", "");
            PalavrasEntra = PalavrasEntra.Replace(".", "");
            PalavrasEntra = PalavrasEntra.Replace("'", "");
            PalavrasEntra = PalavrasEntra.Replace("\"", "");

            foreach (char c in PalavrasEntra)
            {
                if (c == ' ')
                {
                    if (EspaçoDuplo == false)
                    {
                        Palavras += c;
                        InicioPalavra = true;
                    }
                    EspaçoDuplo = true;
                }
                else
                {
                    if (InicioPalavra == true)
                    {
                        Palavras += char.ToUpper(c);
                    }
                    else
                    {
                        Palavras += c;
                    }
                    EspaçoDuplo = false;
                    InicioPalavra = false;
                }
            }

            Palavras = Palavras.Replace(" ", "; ");
            Palavras = Palavras.TrimEnd(' ');
            Palavras = Palavras.TrimEnd(';');
            Palavras += ".";

            return Palavras;
        }

        private void AtualizaCabecalho()
        {
            cabecalho = Banco.CabecalhoProjeto();
            lblCriadoquando.Text = "Criado em  " + Convert.ToDateTime(cabecalho.criacao).ToShortDateString();
            lblCriador.Text = "Criador: " + cabecalho.criador_nome;
            lblAtualizadoquando.Text = "Atualizado em " + Convert.ToDateTime(cabecalho.atualizacao).ToShortDateString();
            lblAtualizador.Text = "Atualizador: " + cabecalho.atualizador_nome;
            lblPorcentagem.Text = cabecalho.porcentagem_int.ToString() + "%";

            if (cabecalho.porcentagem_int == 100)
                groupPorcentagem2.Width = groupPorcentagem.Width;
            else
            {
                groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(groupPorcentagem.Width) / 100) * Convert.ToDouble(cabecalho.porcentagem_int));
                if (groupPorcentagem2.Width < 45)
                    groupPorcentagem2.Width = 45;
            }
        }

        private void AtualizaCampos()
        {
            editando = Banco.RecarregaSelecionado();

            txtNomeProjeto.Text = editando.nome_projeto;
            txtNomeProjeto.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            txtDescricaoBreve.Text = editando.descricao_breve;
            txtDescricaoBreve.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            if (!String.IsNullOrWhiteSpace(editando.email_contato))
            {
                txtEmail.Text = editando.email_contato;
                txtEmail.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }

            if (!String.IsNullOrWhiteSpace(editando.autores))
            {
                txtAutores.Text = editando.autores;
                txtAutores.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }

            if (!String.IsNullOrWhiteSpace(editando.linguagem))
            {
                txtLinguagem.Text = editando.linguagem;
                txtLinguagem.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }

            if (!String.IsNullOrWhiteSpace(editando.link_site))
            {
                txtSite.Text = editando.link_site;
                txtSite.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }

            if (!String.IsNullOrWhiteSpace(editando.link_youtube))
            {
                txtVideo.Text = editando.link_youtube;
                txtVideo.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }

            if (!String.IsNullOrWhiteSpace(editando.palavras_chave))
            {
                txtPalavras.Text = editando.palavras_chave;
                txtPalavras.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }

            if (!String.IsNullOrWhiteSpace(editando.descricao_detalhada))
            {
                txtDetalhada.Text = editando.descricao_detalhada;
                txtDetalhada.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }

            if (!editando.previsao.HasValue)
            {
                boxSemPrevisao.Checked = true;
                dtpPrevisao.Visible = false;
            }
            else
            {
                boxSemPrevisao.Checked = false;
                dtpPrevisao.Visible = true;
                dtpPrevisao.Value = Convert.ToDateTime(editando.previsao.Value);
            }
            if (editando.publico == true)
            {
                radioSim.Checked = true;
            }
            else
            {
                radioNão.Checked = true;
            }

            comboStatus.SelectedIndex = editando.status - 1;
        }

        private void frmEditar_Projeto_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            if (Program.lista_status.Count == 0)
                Program.lista_status = Banco.CarregaStatus();

            comboStatus.DataSource = Program.lista_status;
            comboStatus.ValueMember = "id_status";
            comboStatus.DisplayMember = "status";

            dtpPrevisao.Value = DateTime.Today.AddYears(1);

            AtualizaCabecalho();
            AtualizaCampos();
            DoDesign();
        }

        private void boxSemPrevisao_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSemPrevisao.Checked == true)
                dtpPrevisao.Visible = false;
            else
                dtpPrevisao.Visible = true;
        }

        private void btnEtapas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEtapas splash = new frmEtapas(editando.nome_projeto);
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
            }
        }

        private void groupPorcentagem_SizeChanged(object sender, EventArgs e)
        {
            if (cabecalho.porcentagem_int == 100)
                groupPorcentagem2.Width = groupPorcentagem.Width;
            else
            {
                groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(groupPorcentagem.Width) / 100) * Convert.ToDouble(cabecalho.porcentagem_int));
                if (groupPorcentagem2.Width < 45)
                    groupPorcentagem2.Width = 45;
            }
        }

        private void OPBRecarregar_Click(object sender, EventArgs e)
        {
            AtualizaCabecalho();
            AtualizaCampos();
            DoDesign();
        }

        private void OPBLogout_Click(object sender, EventArgs e)
        {
            Program.projetos.Clear();
            Program.id_usuario = 0;
            this.Close();
        }

        private void OPBConfiguracoes_Click(object sender, EventArgs e)
        {
            //apenas teste
            frmConfiguracoes formC = new frmConfiguracoes();
            formC.ShowDialog();

            /*frmPersonalizacao formP = new frmPersonalizacao();
            formP.ShowDialog();*/
        }



        //TEXTBOX FOCUS ENTER

        private void txtPalavras_Enter(object sender, EventArgs e)
        {
            if (txtPalavras.Text == "Ex. Tecnologia; Inovação; Automação...")
            {
                txtPalavras.Clear();
                txtPalavras.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }
        }

        private void txtNomeProjeto_Enter(object sender, EventArgs e)
        {
            if (txtNomeProjeto.Text == "Digite o nome do projeto (Obrigatório)")
            {
                txtNomeProjeto.Clear();
                txtNomeProjeto.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-mail para que enteressados entrem em contato")
            {
                txtEmail.Clear();
                txtEmail.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }
        }

        private void txtAutores_Enter(object sender, EventArgs e)
        {
            if (txtAutores.Text == "Nome dos responsáveis pelo projeto")
            {
                txtAutores.Clear();
                txtAutores.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }
        }

        private void txtLinguagem_Enter(object sender, EventArgs e)
        {
            if (txtLinguagem.Text == "Linguagens de programação utilizadas")
            {
                txtLinguagem.Clear();
                txtLinguagem.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }
        }

        private void txtDescricaoBreve_Enter(object sender, EventArgs e)
        {
            if (txtDescricaoBreve.Text == "Defina seu projeto em poucas palavras (Obrigatório)")
            {
                txtDescricaoBreve.Clear();
                txtDescricaoBreve.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }
        }

        private void txtSite_Enter(object sender, EventArgs e)
        {
            if (txtSite.Text == "Site do projeto")
            {
                txtSite.Clear();
                txtSite.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }
        }

        private void txtVideo_Enter(object sender, EventArgs e)
        {
            if (txtVideo.Text == "Vídeo demonstrativo do projeto no YouTube")
            {
                txtVideo.Clear();
                txtVideo.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }
        }

        private void txtDetalhada_Enter(object sender, EventArgs e)
        {
            if (txtDetalhada.Text == "Objetivo, Escopo, Funcionalidades principais, Tecnologias utilizadas, Futuras Melhorias...")
            {
                txtDetalhada.Clear();
                txtDetalhada.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            }
        }

        //TEXTBOX FOCUS LEAVE

        private void txtPalavras_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPalavras.Text))
            {
                txtPalavras.Text = "Ex. Tecnologia; Inovação; Automação...";
                txtPalavras.ForeColor = Color.Gray;
            }
            else
            {
                txtPalavras.Text = PalavrasChave();
            }
        }

        private void txtNomeProjeto_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNomeProjeto.Text))
            {
                txtNomeProjeto.Text = "Digite o nome do projeto (Obrigatório)";
                txtNomeProjeto.ForeColor = Color.Gray;
            }
            customLine1.LineColor = Color.Black;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "E-mail para que enteressados entrem em contato";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtAutores_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAutores.Text))
            {
                txtAutores.Text = "Nome dos responsáveis pelo projeto";
                txtAutores.ForeColor = Color.Gray;
            }
        }

        private void txtLinguagem_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLinguagem.Text))
            {
                txtLinguagem.Text = "Linguagens de programação utilizadas";
                txtLinguagem.ForeColor = Color.Gray;
            }
        }

        private void txtDescricaoBreve_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescricaoBreve.Text))
            {
                txtDescricaoBreve.Text = "Defina seu projeto em poucas palavras (Obrigatório)";
                txtDescricaoBreve.ForeColor = Color.Gray;
            }
            customLine5.LineColor = Color.Black;
        }

        private void txtSite_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSite.Text))
            {
                txtSite.Text = "Site do projeto";
                txtSite.ForeColor = Color.Gray;
            }
        }

        private void txtVideo_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtVideo.Text))
            {
                txtVideo.Text = "Vídeo demonstrativo do projeto no YouTube";
                txtVideo.ForeColor = Color.Gray;
            }
        }

        private void txtDetalhada_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDetalhada.Text))
            {
                txtDetalhada.Text = "Objetivo, Escopo, Funcionalidades principais, Tecnologias utilizadas, Futuras Melhorias...";
                txtDetalhada.ForeColor = Color.Gray;
            }
        }

        private void btnImagens_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGerenciamentoImagens splash = new frmGerenciamentoImagens();
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
            }
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            if(Banco.PodeGerenciar() == false)
            {
                MessageBox.Show("Você não tem permissão para Gerenciar os colaboradores desse projeto, é preciso ser um colaborador administrativo.","Editar Projeto", MessageBoxButtons.OK);
                return;
            }
            
            this.Visible = false;
            frmGerenciamentoColaboradores splash = new frmGerenciamentoColaboradores(editando.nome_projeto);
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
            }
        }

        public void Logo(int logo)
        {
            switch (logo)
            {
                case 0:
                    opbLogo.Image = global::tccCsharp.Properties.Resources.Logo_White2; 
                    OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_Black;
                    OPBRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_Black;
                    OPBConfiguracoes.Image = global::tccCsharp.Properties.Resources.Config_Black;
                    break;

                case 1:
                    opbLogo.Image = global::tccCsharp.Properties.Resources.Logo_Black2; 
                    OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_White;
                    OPBRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_White;
                    OPBConfiguracoes.Image = global::tccCsharp.Properties.Resources.Config_White;
                    break;
            }
        }

        private void clColaboradores_Enter(object sender, EventArgs e)
        {
            btnColaboradores.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnColaboradores.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clColaboradores_Leave(object sender, EventArgs e)
        {
            btnColaboradores.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnColaboradores.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void clColaboradores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnColaboradores.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                btnColaboradores.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                btnColaboradores_Click(sender, e);
            }
        }

        private void clImagens_Enter(object sender, EventArgs e)
        {
            btnImagens.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnImagens.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clImagens_Leave(object sender, EventArgs e)
        {
            btnImagens.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnImagens.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void clImagens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnImagens.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                btnImagens.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                btnImagens_Click(sender, e);
            }
        }

        private void clEtapas_Enter(object sender, EventArgs e)
        {
            btnEtapas.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnEtapas.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clEtapas_Leave(object sender, EventArgs e)
        {
            btnEtapas.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnEtapas.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void clEtapas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEtapas.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                btnEtapas.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                btnEtapas_Click(sender, e);
            }
        }

        private void clExcluir_Enter(object sender, EventArgs e)
        {
            btnExcluir.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnExcluir.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clExcluir_Leave(object sender, EventArgs e)
        {
            btnExcluir.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnExcluir.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void clExcluir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnExcluir.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                btnExcluir.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                btnExcluir_Click(sender, e);
            }
        }

        private void clCancelar_Enter(object sender, EventArgs e)
        {
            btnCancelar.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnCancelar.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clCancelar_Leave(object sender, EventArgs e)
        {
            btnCancelar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnCancelar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void clCancelar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCancelar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                btnCancelar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                btnCancelar_Click(sender, e);
            }
        }

        private void clAtualizar_Enter(object sender, EventArgs e)
        {
            btnAtualizar.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnAtualizar.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clAtualizar_Leave(object sender, EventArgs e)
        {
            btnAtualizar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnAtualizar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void clAtualizar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAtualizar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                btnAtualizar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                btnAtualizar_Click(sender, e);
            }
        }

        private void clConfig_Enter(object sender, EventArgs e)
        {
            OPBConfiguracoes._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clConfig_Leave(object sender, EventArgs e)
        {
            OPBConfiguracoes._bordercolor = Color.Transparent;
        }

        private void clConfig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OPBConfiguracoes._bordercolor = Color.Transparent;
                OPBConfiguracoes_Click(sender, e);

            }
        }

        private void clRecarregar_Enter(object sender, EventArgs e)
        {
            OPBRecarregar._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clRecarregar_Leave(object sender, EventArgs e)
        {
            OPBRecarregar._bordercolor = Color.Transparent;
        }

        private void clRecarregar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OPBRecarregar._bordercolor = Color.Transparent;
                OPBRecarregar_Click(sender, e);

            }
        }

        private void clLogout_Enter(object sender, EventArgs e)
        {
            OPBLogout._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clLogout_Leave(object sender, EventArgs e)
        {
            OPBLogout._bordercolor = Color.Transparent;
        }

        private void clLogout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OPBLogout._bordercolor = Color.Transparent;
                OPBLogout_Click(sender, e);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Program.id_projeto_atual = 0;
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Banco.PodeGerenciar() == false)
            {
                MessageBox.Show("Você não tem permissão para Excluir esse projeto, é preciso ser um colaborador administrativo.", "Editar Projeto", MessageBoxButtons.OK);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja mesmo excluir seu projeto agora?", "Editando Projeto", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Banco.ExcluirProjeto();
                MessageBox.Show("Projeto excluído com sucesso", "Sucesso", MessageBoxButtons.OK);
                this.Close();
            }
            else if (resultado == DialogResult.No)
            {
                return;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNomeProjeto.Text) || txtNomeProjeto.Text == "Digite o nome do projeto (Obrigatório)")
            {
                txtNomeProjeto.Focus();
                txtNomeProjeto.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
                customLine1.LineColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                return;
            }
            else
                editando.nome_projeto = txtNomeProjeto.Text;

            if (String.IsNullOrWhiteSpace(txtDescricaoBreve.Text) || txtDescricaoBreve.Text == "Defina seu projeto em poucas palavras (Obrigatório)")
            {
                txtDescricaoBreve.Focus();
                txtDescricaoBreve.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
                customLine5.LineColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                return;
            }
            else
                editando.descricao_breve = txtDescricaoBreve.Text;

            if (comboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Status", "Criando Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboStatus.Focus();
                return;
            }

            else
                editando.status = comboStatus.SelectedIndex + 1;

            if (String.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text == "E-mail para que enteressados entrem em contato")
                editando.email_contato = null;
            else
                editando.email_contato = txtEmail.Text;

            if (String.IsNullOrWhiteSpace(txtAutores.Text) || txtAutores.Text == "Nome dos responsáveis pelo projeto")
                editando.autores = null;
            else
                editando.autores = txtAutores.Text;

            if (String.IsNullOrWhiteSpace(txtLinguagem.Text) || txtLinguagem.Text == "Linguagens de programação utilizadas")
                editando.linguagem = null;
            else editando.linguagem = txtLinguagem.Text;

            if (String.IsNullOrWhiteSpace(txtSite.Text) || txtSite.Text == "Site do projeto")
                editando.link_site = null;
            else
                editando.link_site = txtSite.Text;

            if (String.IsNullOrWhiteSpace(txtVideo.Text) || txtVideo.Text == "Vídeo demonstrativo do projeto no YouTube")
                editando.link_youtube = null;
            else
                editando.link_youtube = txtVideo.Text;

            if (String.IsNullOrWhiteSpace(txtPalavras.Text) || txtPalavras.Text == "Ex. Tecnologia; Inovação; Automação...")
                editando.palavras_chave = null;
            else
                editando.palavras_chave = PalavrasChave();

            if (boxSemPrevisao.Checked == true)
                editando.previsao = new DateTime(1, 1, 1);
            else
                editando.previsao = dtpPrevisao.Value;

            if (radioSim.Checked == true)
                editando.publico = true;
            else
                editando.publico = false;

            if (String.IsNullOrWhiteSpace(txtDetalhada.Text) || txtDetalhada.Text == "Objetivo, Escopo, Funcionalidades principais, Tecnologias utilizadas, Futuras Melhorias...")
                editando.descricao_detalhada = null;
            else
                editando.descricao_detalhada = txtDetalhada.Text;

            if (Program.id_usuario == 0)
            {
                MessageBox.Show("Ocorreu um erro ao resgatar suas informações!!!", "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                editando.atualizador = Program.id_usuario;


            editando.data_atualizacao = DateTime.Now;

            Banco.AtualizarProjeto(editando);
            MessageBox.Show("Projeto atualizado com sucesso!!", "Sucesso", MessageBoxButtons.OK);
        }
    }
}
