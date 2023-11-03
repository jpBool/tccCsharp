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
    public partial class frmGerenciamentoColaboradores : Form
    {
        public Head cabecalho = new Head();
        public List<Collaborators> Colaboradores = new List<Collaborators>(); 
        public List<Collaborators> OutrosUser = new List<Collaborators>();
        public bool Editando = false;
        public string nomeProjeto;
        public Collaborators selecionado = new Collaborators();
        public bool FimCarregamento = false;

        public frmGerenciamentoColaboradores(string nomeRecebido)
        {
            InitializeComponent();
            nomeProjeto = nomeRecebido;
        }

        public void Avatar(int avatar)
        {
            switch (avatar)
            {
                case 0: opcAvatar.Image = global::tccCsharp.Properties.Resources.Classic_Chess_King_Black; break;
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

        public void DoDesign()
        {
            tlpBase1.Font = Program.fonte;
            lblProjeto.Font = Program.fonte;
            lblColaboradores.Font = Program.fonte;
            btnNovo.Font = Program.fonte;
            btnExcluir.Font = Program.fonte;
            btnSalvar.Font = Program.fonte;
            btnSairSSalvar.Font = Program.fonte;

            tlpBase1.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            TLPInfoshead.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            //TXT


            //LABELS
            lblTitulo.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblTitulo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            lblColaboradores.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            lblColaboradores.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblNomeProjeto.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblNomeProjeto.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            //BOTOES
            btnSairSSalvar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnSairSSalvar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnSairSSalvar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnSairSSalvar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnSairSSalvar.AutoHoover = true;
            btnSairSSalvar.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnSairSSalvar.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnNovo.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnNovo.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnNovo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnNovo.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnNovo.AutoHoover = true;
            btnNovo.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnNovo.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnSalvar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnSalvar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnSalvar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnSalvar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnSalvar.AutoHoover = true;
            btnSalvar.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnSalvar.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnExcluir.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnExcluir.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnExcluir.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnExcluir.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnExcluir.AutoHoover = true;
            btnExcluir.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnExcluir.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            //rgbDescricaoImg.BackColor = 

            rgbHeadImgs1.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            rgbHeadImgs1.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            TLPHead1.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            //rgbHeadImgs1.BackColor = 

            TLPHead2.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            rgbHeadImgs2.ForeColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            rgbHeadImgs2.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            //rgbHeadImgs2.BackColor = 
            TLPInfoshead.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            TLPInfoshead.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);


            RGBColaboradores.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            
            rgbNomeP.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            
            rgbOpcoes.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);           

            RGBDados.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            
            RGBDados.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);

            //Porcentagem
            groupPorcentagem.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            groupPorcentagem.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            groupPorcentagem2.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);

            OPBLogout._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBConfiguracoes._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBRecarregar._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBConfiguracoes.AutoHoover = true;
            OPBRecarregar.AutoHoover = true;
            OPBLogout.AutoHoover = true;
            OPBConfiguracoes.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBRecarregar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBLogout.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);

            OPBLogout.BordaPrincipal = Color.Transparent;
            OPBRecarregar.BordaPrincipal = Color.Transparent;
            OPBConfiguracoes.BordaPrincipal = Color.Transparent;

            
            clAdicionar.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clProcurar.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clRemover.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clLogout.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clRecarregar.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clConfig.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clVoltar.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            clAdicionar.LineColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clProcurar.LineColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clRemover.LineColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clLogout.LineColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clRecarregar.LineColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clConfig.LineColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            clVoltar.LineColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);


            Logo(Program.logo);
        }

        private void AtualizaCabecalho()
        {
            cabecalho = Banco.CabecalhoProjeto();
            lblCriadoquando.Text = "Criado em  " + Convert.ToDateTime(cabecalho.criacao).ToShortDateString();
            lblCriador.Text = "Criador: " + cabecalho.criador_nome;
            lblAtualizadoquando.Text = "Atualizado em " + Convert.ToDateTime(cabecalho.atualizacao).ToShortDateString();
            lblAtualizador.Text = "Atualizador: " + cabecalho.atualizador_nome;
            lblPorcentagem.Text = cabecalho.porcentagem_int.ToString() + "%";
            lblNomeProjeto.Text = nomeProjeto; 

            if (cabecalho.porcentagem_int == 100)
                groupPorcentagem2.Width = groupPorcentagem.Width;
            else
            {
                groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(groupPorcentagem.Width) / 100) * Convert.ToDouble(cabecalho.porcentagem_int));
                if (groupPorcentagem2.Width < 45)
                    groupPorcentagem2.Width = 45;
            }
        }

        private void frmGerenciamentoColaboradores_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            DoDesign();
            AtualizaCabecalho();
            Colaboradores = Banco.CarrregaColaboradores();
            DGVColaboradores.DataSource = Colaboradores;
            DGVColaboradores.Columns["avatar"].Visible = false;
            DGVColaboradores.Columns["idColaborador"].Visible = false;
            opcAvatar.Image = global::tccCsharp.Properties.Resources.Classic_Chess_King_Black; 

            textNome.Visible = false;
            textEmail.Visible = false;
            textTelefone.Visible = false;
            
            OutrosUser = Banco.CarrregaOutrosUser();
            comboNome.DataSource = OutrosUser;
            comboEmail.DataSource = OutrosUser;
            comboTelefone.DataSource = OutrosUser;
            comboNome.ValueMember = "idColaborador";
            comboNome.DisplayMember = "nome";
            comboNome.SelectedIndex = -1;
            comboEmail.ValueMember = "idColaborador";
            comboEmail.DisplayMember = "email";
            comboEmail.SelectedIndex = -1;
            comboTelefone.DisplayMember = "telefone";
            comboTelefone.ValueMember = "idColaborador";
            comboTelefone.SelectedIndex = -1;

            Collaborators Criador = new Collaborators();
            Criador = Banco.CarregaCriador();
            string[] novaLinha = new string[] { Criador.nome, Criador.email, Criador.telefone };
            dgvCriador.Rows.Add(novaLinha);
            dgvCriador.Enabled = false;
            dgvCriador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVColaboradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            FimCarregamento = true;

            //teste
            comboNome.TabIndex = 1;
            comboTelefone.TabIndex = 2;
            comboEmail.TabIndex = 3;

            

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

        private void DGVColaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGVColaboradores.Rows[e.RowIndex];
                selecionado.idColaborador = Convert.ToInt32(row.Cells[0].Value);
                selecionado.nome = Convert.ToString(row.Cells[1].Value);
                selecionado.email = Convert.ToString(row.Cells[2].Value);
                selecionado.telefone = Convert.ToString(row.Cells[3].Value);
                selecionado.avatar = Convert.ToInt32(row.Cells[4].Value);
                selecionado.isAdmin = Convert.ToBoolean(row.Cells[5].Value);

                textEmail.Visible = true;
                textNome.Visible = true;
                textTelefone.Visible = true;
                textNome.Text = selecionado.nome;
                textEmail.Text = selecionado.email;
                textTelefone.Text = selecionado.telefone;
                if(selecionado.isAdmin == true)
                {
                    radSim.Checked = true;
                    radNao.Checked = false;
                }
                else
                {
                    radSim.Checked = false;
                    radNao.Checked = true;
                }
                comboEmail.SelectedIndex = -1;
                comboEmail.Visible = false;
                comboNome.SelectedIndex = -1;
                comboNome.Visible = false;
                comboTelefone.SelectedIndex = -1;
                comboTelefone.Visible = false;
                Avatar(selecionado.avatar);

                Editando = true;
            }
        }

        private void comboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FimCarregamento == true) 
            { 
                if(comboEmail.SelectedIndex != comboNome.SelectedIndex)
                { 
                    comboEmail.SelectedIndex = comboNome.SelectedIndex;
                }
                if (comboTelefone.SelectedIndex != comboNome.SelectedIndex)
                {
                    comboTelefone.SelectedIndex = comboNome.SelectedIndex;
                }
                if (comboNome.SelectedIndex != -1)
                    Avatar(OutrosUser[comboNome.SelectedIndex].avatar);
            }
        }

        private void comboEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FimCarregamento == true)
            {
                if (comboNome.SelectedIndex != comboEmail.SelectedIndex)
                {
                    comboNome.SelectedIndex = comboEmail.SelectedIndex;
                }
                if (comboTelefone.SelectedIndex != comboEmail.SelectedIndex)
                {
                    comboTelefone.SelectedIndex = comboEmail.SelectedIndex;
                }
                if (comboEmail.SelectedIndex != -1)
                    Avatar(OutrosUser[comboEmail.SelectedIndex].avatar);
            }
        }

        private void comboTelefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FimCarregamento == true)
            {
                if (comboNome.SelectedIndex != comboTelefone.SelectedIndex)
                {
                    comboNome.SelectedIndex = comboTelefone.SelectedIndex;
                }
                if (comboEmail.SelectedIndex != comboTelefone.SelectedIndex)
                {
                    comboEmail.SelectedIndex = comboTelefone.SelectedIndex;
                }
                if (comboTelefone.SelectedIndex != -1)
                    Avatar(OutrosUser[comboTelefone.SelectedIndex].avatar);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Editando = false;
            textEmail.Visible = false;
            textNome.Visible = false;
            textTelefone.Visible = false;
            comboEmail.Visible = true;
            comboTelefone.Visible = true;
            comboNome.Visible = true;
            comboNome.SelectedIndex = -1;
            radNao.Checked = true;
            radSim.Checked = false;
            opcAvatar.Image = global::tccCsharp.Properties.Resources.Classic_Chess_King_Black;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Editando == false)
            {
                comboNome.SelectedIndex = -1;
            }
            else
            {
                Banco.DeleteCollaborator(selecionado.idColaborador);
                FimCarregamento = false;
                Colaboradores.Clear();
                OutrosUser.Clear();
                
                Colaboradores = Banco.CarrregaColaboradores();
                DGVColaboradores.DataSource = Colaboradores;
                DGVColaboradores.Columns["avatar"].Visible = false;
                DGVColaboradores.Columns["idColaborador"].Visible = false;

                textNome.Visible = false;
                textEmail.Visible = false;
                textTelefone.Visible = false;
                comboEmail.Visible = true;
                comboTelefone.Visible = true;
                comboNome.Visible = true;

                OutrosUser = Banco.CarrregaOutrosUser();
                comboNome.DataSource = OutrosUser;
                comboEmail.DataSource = OutrosUser;
                comboTelefone.DataSource = OutrosUser;
                comboNome.ValueMember = "idColaborador";
                comboNome.DisplayMember = "nome";
                comboNome.SelectedIndex = -1;
                comboEmail.ValueMember = "idColaborador";
                comboEmail.DisplayMember = "email";
                comboEmail.SelectedIndex = -1;
                comboTelefone.DisplayMember = "telefone";
                comboTelefone.ValueMember = "idColaborador";
                comboTelefone.SelectedIndex = -1;
                opcAvatar.Image = global::tccCsharp.Properties.Resources.Classic_Chess_King_Black;
                FimCarregamento = true;
                Editando = false;
                selecionado = new Collaborators();
            }
        }

        private void btnSairSSalvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Editando == false)
            {
                if (comboNome.SelectedIndex == -1)
                {
                    comboNome.Focus();
                    return;
                }
                else
                {
                    bool IsAdm = false;
                    if (radSim.Checked == true)
                    {
                        IsAdm = true;
                    }
                    Banco.InsereColaborador(Convert.ToInt32(comboNome.SelectedValue), Program.id_projeto_atual, IsAdm);
                }
            }
            else
            {
                bool IsAdmNow = false;
                if (radSim.Checked == true) 
                {
                    IsAdmNow = true;
                }
                if (IsAdmNow == selecionado.isAdmin)
                {
                    //Mudou nada
                    textNome.Visible = false;
                    textEmail.Visible = false;
                    textTelefone.Visible = false;
                    comboEmail.Visible = true;
                    comboTelefone.Visible = true;
                    comboNome.Visible = true;
                    comboNome.SelectedIndex = -1;
                    comboEmail.SelectedIndex = -1;
                    comboTelefone.SelectedIndex = -1;
                    Editando = false;
                    return;
                }
                else
                {
                    Banco.AlteraColaborador(selecionado.idColaborador, Program.id_projeto_atual, IsAdmNow);
                }
            }
            FimCarregamento = false;
            Colaboradores.Clear();
            OutrosUser.Clear();

            Colaboradores = Banco.CarrregaColaboradores();
            DGVColaboradores.DataSource = Colaboradores;
            DGVColaboradores.Columns["avatar"].Visible = false;
            DGVColaboradores.Columns["idColaborador"].Visible = false;

            textNome.Visible = false;
            textEmail.Visible = false;
            textTelefone.Visible = false;
            comboEmail.Visible = true;
            comboTelefone.Visible = true;
            comboNome.Visible = true;

            OutrosUser = Banco.CarrregaOutrosUser();
            comboNome.DataSource = OutrosUser;
            comboEmail.DataSource = OutrosUser;
            comboTelefone.DataSource = OutrosUser;
            comboNome.ValueMember = "idColaborador";
            comboNome.DisplayMember = "nome";
            comboNome.SelectedIndex = -1;
            comboEmail.ValueMember = "idColaborador";
            comboEmail.DisplayMember = "email";
            comboEmail.SelectedIndex = -1;
            comboTelefone.DisplayMember = "telefone";
            comboTelefone.ValueMember = "idColaborador";
            comboTelefone.SelectedIndex = -1;
            opcAvatar.Image = global::tccCsharp.Properties.Resources.Classic_Chess_King_Black;
            FimCarregamento = true;
            Editando = false;
            selecionado = new Collaborators();
        }

        private void OPBLogout_Click(object sender, EventArgs e)
        {
            Program.projetos.Clear();
            Program.id_usuario = 0;
            this.Close();
        }

        private void OPBRecarregar_Click(object sender, EventArgs e)
        {
            DoDesign();
            FimCarregamento = false;
            Colaboradores.Clear();
            OutrosUser.Clear();

            Colaboradores = Banco.CarrregaColaboradores();
            DGVColaboradores.DataSource = Colaboradores;
            DGVColaboradores.Columns["avatar"].Visible = false;
            DGVColaboradores.Columns["idColaborador"].Visible = false;

            textNome.Visible = false;
            textEmail.Visible = false;
            textTelefone.Visible = false;
            comboEmail.Visible = true;
            comboTelefone.Visible = true;
            comboNome.Visible = true;

            OutrosUser = Banco.CarrregaOutrosUser();
            comboNome.DataSource = OutrosUser;
            comboEmail.DataSource = OutrosUser;
            comboTelefone.DataSource = OutrosUser;
            comboNome.ValueMember = "idColaborador";
            comboNome.DisplayMember = "nome";
            comboNome.SelectedIndex = -1;
            comboEmail.ValueMember = "idColaborador";
            comboEmail.DisplayMember = "email";
            comboEmail.SelectedIndex = -1;
            comboTelefone.DisplayMember = "telefone";
            comboTelefone.ValueMember = "idColaborador";
            comboTelefone.SelectedIndex = -1;

            FimCarregamento = true;
            Editando = false;
            selecionado = new Collaborators();
        }

        

        private void OPBConfiguracoes_Click(object sender, EventArgs e)
        {
            //apenas teste
            frmConfiguracoes formC = new frmConfiguracoes();
            formC.ShowDialog();

            /*frmPersonalizacao formP = new frmPersonalizacao();
            formP.ShowDialog();*/
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

        private void dgvCriador_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2])), e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

        private void DGVColaboradores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
                if (e.RowIndex == -1 && e.ColumnIndex >= 0)
                {
                    e.PaintBackground(e.CellBounds, true);
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2])), e.CellBounds);
                    e.PaintContent(e.CellBounds);
                    e.Handled = true;
                }
            }

        private void clProcurar_Enter(object sender, EventArgs e)
        {
            btnNovo.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnNovo.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clProcurar_Leave(object sender, EventArgs e)
        {
            btnNovo.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnNovo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void clProcurar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNovo.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                btnNovo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                btnNovo_Click(sender, e);
            }
        }

        private void clRemover_Enter(object sender, EventArgs e)
        {
            btnExcluir.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnExcluir.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clRemover_Leave(object sender, EventArgs e)
        {
            btnExcluir.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnExcluir.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void clRemover_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnExcluir.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                btnExcluir.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                btnExcluir_Click(sender, e);
            }
        }

        private void clAdicionar_Enter(object sender, EventArgs e)
        {
            btnSalvar.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnSalvar.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clAdicionar_Leave(object sender, EventArgs e)
        {
            btnSalvar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnSalvar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void clAdicionar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                btnSalvar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                btnExcluir_Click(sender, e);
            }
        }

        private void clVoltar_Enter(object sender, EventArgs e)
        {
            btnSairSSalvar.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnSairSSalvar.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clVoltar_Leave(object sender, EventArgs e)
        {
            btnSairSSalvar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnSairSSalvar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void clVoltar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSairSSalvar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                btnSairSSalvar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                btnSairSSalvar_Click(sender, e);
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

        //TESTE
        /*private void clNome_Enter(object sender, EventArgs e)
        {
            //comboNome.BackColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void clNome_Leave(object sender, EventArgs e)
        {
            //comboNome.BackColor = Color.Red;
        }

        private void clNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboNome.BackColor = Color.Plum;
            }
        }*/      
    }
}
