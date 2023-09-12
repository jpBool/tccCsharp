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
        public Project projeto_editado = new Project();
        public List<Collaborators> Colaboradores = new List<Collaborators>(); 
        public List<Collaborators> OutrosUser = new List<Collaborators>();
        public bool Editando = false;
        public Collaborators selecionado = new Collaborators();
        public bool FimCarregamento = false;

        public frmGerenciamentoColaboradores()
        {
            InitializeComponent();
        }

        public void DoDesign()
        {
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

            btnNovo.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnNovo.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnNovo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnNovo.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnNovo.AutoHoover = true;

            btnSalvar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnSalvar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnSalvar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnSalvar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnSalvar.AutoHoover = true;

            btnExcluir.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnExcluir.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnExcluir.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnExcluir.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnExcluir.AutoHoover = true;



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
            //rgbImagensP.BackColor = 

            //rgbNomeImagem.BackColor = 

            rgbNomeP.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbNomeP.BackColor = 

            rgbOpcoes.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbOpcoes.BackColor = 

            RGBDados.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbUpload.BackColor = 
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
        }

        private void AtualizaCabecalho()
        {
            cabecalho = Banco.CabecalhoProjeto();
            lblCriadoquando.Text = "Criado em  " + Convert.ToDateTime(cabecalho.criacao).ToShortDateString();
            lblCriador.Text = "Criador: " + cabecalho.criador_nome;
            lblAtualizadoquando.Text = "Atualizado em " + Convert.ToDateTime(cabecalho.atualizacao).ToShortDateString();
            lblAtualizador.Text = "Atualizador: " + cabecalho.atualizador_nome;
            lblPorcentagem.Text = cabecalho.porcentagem_int.ToString() + "%";
            lblNomeProjeto.Text = projeto_editado.nome_projeto;

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
            Colaboradores = Banco.CarrregaColaboradores();
            DGVColaboradores.DataSource = Colaboradores;
            DGVColaboradores.Columns["avatar"].Visible = false;
            DGVColaboradores.Columns["idColaborador"].Visible = false;

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

            FimCarregamento = true;
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
    }
}
