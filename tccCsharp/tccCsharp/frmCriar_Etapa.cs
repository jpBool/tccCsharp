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
    public partial class frmCriar_Etapa : Form
    {
        public Head cabecalho = new Head();
        public List<GroupSteps> grupos = new List<GroupSteps>();
        public List<Step> etapas = new List<Step>();
        public Boolean liberado = false;

        public frmCriar_Etapa()
        {
            InitializeComponent();
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

        public void DoDesign()
        {
            TLPHead1.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);

            TLPHead2.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBHead2.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBHead2.ForeColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);

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

            TLPConteudo.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            TLPOpcoes.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            RGBNome.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            txtNomeEtapa.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            txtNomeEtapa.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            txtDescriImpedimento.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            txtDescricao.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);

            OPBLogout._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBConfiguracoes._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBRecarregar._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBConfiguracoes.AutoHoover = true;
            OPBRecarregar.AutoHoover = true;
            OPBLogout.AutoHoover = true;
            OPBConfiguracoes.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBRecarregar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBLogout.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);

            btnCancelar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnCancelar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnCancelar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnCancelar.AutoHoover = true;
            btnCancelar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);

            btnSalvar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnSalvar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnSalvar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnSalvar.AutoHoover = true;
            btnSalvar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);

            RGBButtons.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBCampos.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBDetalhada.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1],Program.Cor5[2]);
            RGBDecri1.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBDescri2.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBPrioridade.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            trackPercent.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

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

            if (cabecalho.porcentagem_int == 100)
                groupPorcentagem2.Width = groupPorcentagem.Width;
            else
            {
                groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(groupPorcentagem.Width) / 100) * Convert.ToDouble(cabecalho.porcentagem_int));
                if (groupPorcentagem2.Width < 45)
                    groupPorcentagem2.Width = 45;
            }
        }

        private void frmCriar_Etapa_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DoDesign();
            AtualizaCabecalho();

            if (Program.lista_status.Count == 0)
                Program.lista_status = Banco.CarregaStatus();
            comboStatus.DataSource = Program.lista_status;
            comboStatus.ValueMember = "id_status";
            comboStatus.DisplayMember = "status";

            grupos = Banco.ConsultaGrupos(0);
            comboGrupo.DataSource = grupos;
            comboGrupo.ValueMember = "id_grupo";
            comboGrupo.DisplayMember = "nome_grupo";
            comboGrupo.SelectedIndex = 0;

            etapas = Banco.ConsultaEtapas(Convert.ToInt32(comboGrupo.SelectedValue),0);
            if (etapas.Count < 2)
            {
                TLPEntreGrupos.Visible = false;
            }
            else
            {
                TLPEntreGrupos.Visible = true;

                comboDepois.DataSource = etapas;
                comboDepois.ValueMember = "ordenador";
                comboDepois.DisplayMember = "nome_etapa";
                comboDepois.SelectedIndex = 0;
            }

            TLPSelecionaCombo.Enabled = false;
            liberado = true;
        }

        private void trackPercent_ValueChanged(object sender, EventArgs e)
        {
            numPercent.Value = trackPercent.Value;
        }

        private void numPercent_Leave(object sender, EventArgs e)
        {
            trackPercent.Value = Convert.ToInt32(numPercent.Value);
        }

        private void radInicio_Click(object sender, EventArgs e)
        {
            radInicio.Checked = true;
            radMeio.Checked = false;
            radFim.Checked = false;
            TLPSelecionaCombo.Enabled = false;
        }

        private void radMeio_Click(object sender, EventArgs e)
        {
            radInicio.Checked = false;
            radMeio.Checked = true;
            radFim.Checked = false;
            TLPSelecionaCombo.Enabled = true;
            comboDepois.SelectedIndex = 0;
        }

        private void radFim_Click(object sender, EventArgs e)
        {
            radInicio.Checked = false;
            radMeio.Checked = false;
            radFim.Checked = true;
            TLPSelecionaCombo.Enabled = false;
        }

        private void comboDepois_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboDepois.SelectedIndex;
            int lastIndex = comboDepois.Items.Count - 1;

            if (selectedIndex == lastIndex)
            {
                radFim.Checked = true;
                radMeio.Checked = false;
                TLPSelecionaCombo.Enabled = false;
            }
        }

        private void comboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboGrupo.SelectedIndex >= 0 && liberado == true)
            {
                etapas.Clear();
                etapas = Banco.ConsultaEtapas(Convert.ToInt32(comboGrupo.SelectedValue), 0);
                if (etapas.Count < 2)
                {
                    TLPEntreGrupos.Visible = false;
                }
                else
                {
                    TLPEntreGrupos.Visible = true;

                    comboDepois.DataSource = etapas;
                    comboDepois.ValueMember = "ordenador";
                    comboDepois.DisplayMember = "nome_etapa";
                    comboDepois.SelectedIndex = 0;
                }
                radFim.Checked = true; 
                radMeio.Checked = false; 
                radInicio.Checked = false;
                TLPSelecionaCombo.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNomeEtapa.Text))
            {
                customLine1.LineColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                txtNomeEtapa.Focus();
                return;
            }

            if(Convert.ToInt32(comboGrupo.SelectedIndex) == -1)
            {
                comboGrupo.SelectedIndex = 0;
                comboGrupo.Focus();
                MessageBox.Show("Selecione um Grupo", "Criando Etapa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Step novaEtapa = new Step();
            novaEtapa.id_grupo = Convert.ToInt32(comboGrupo.SelectedValue);
            novaEtapa.nome_etapa = txtNomeEtapa.Text;
            novaEtapa.peso = Convert.ToInt32(numPeso.Value);
            novaEtapa.porcentagem = Convert.ToInt32(numPercent.Value);
            novaEtapa.descricao_etapa = txtDescricao.Text;
            novaEtapa.prioridade = Convert.ToInt32(numPrioridade.Value);
            novaEtapa.responsavel = txtResponsavel.Text;
            novaEtapa.email_responsavel = txtEmail.Text;    
            if (boxSim.Checked == true)
            {
                novaEtapa.impedimento = true;
                novaEtapa.descricao_impedimento = txtDescriImpedimento.Text;
            }
            else
            {
                novaEtapa.impedimento = false;
                novaEtapa.descricao_impedimento = string.Empty;
            }
            novaEtapa.data_criacao = DateTime.Today;
            novaEtapa.data_atualizacao = DateTime.Now;
            novaEtapa.atualizador = Program.id_usuario;
            novaEtapa.excluido = false;

            if (comboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Status", "Criando Etapa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboStatus.Focus();
                return;
            }
            else
            {
                novaEtapa.status = comboStatus.SelectedIndex + 1;
            }

            
            if (radInicio.Checked == true || etapas.Count == 0)
            {
                Banco.AlteraOrdenadorEtapa(novaEtapa.id_grupo, 1, 1);
                novaEtapa.ordenador = 1;
            }
            else if (radFim.Checked == true)
            {
                int last = etapas.Count();
                novaEtapa.ordenador = etapas[last - 1].ordenador + 1;
            }
            else
            {
                int mid = Convert.ToInt32(comboDepois.SelectedValue) + 1;
                Banco.AlteraOrdenadorEtapa(novaEtapa.id_grupo, mid, 1);
                novaEtapa.ordenador = mid;
            }

            Banco.InsereEtapa(novaEtapa);
            this.Close();
        }

        private void txtNomeEtapa_Leave(object sender, EventArgs e)
        {
            customLine1.LineColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
        }

        private void boxSim_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSim.Checked == false)
            {
                txtDescriImpedimento.Text = string.Empty;
                txtDescriImpedimento.Enabled = false;
            }
            else
            {
                txtDescriImpedimento.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboDepois_Leave(object sender, EventArgs e)
        {
            int selectedIndex = comboDepois.SelectedIndex;
            if (selectedIndex == -1)
            {
                radInicio.Checked = true;
                radFim.Checked = false;
                radMeio.Checked = false;
                comboDepois.SelectedIndex = 0;
                TLPSelecionaCombo.Enabled = false;
            }
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

        private void OPBRecarregar_Click(object sender, EventArgs e)
        {
            DoDesign();
            AtualizaCabecalho();
        }

        public void Logo(int logo)
        {
            switch (logo)
            {
                case 0:
                    opbLogo.Image = global::tccCsharp.Properties.Resources.Logo_White2; //mudar img
                    OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_Black;
                    OPBRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_Black;
                    OPBConfiguracoes.Image = global::tccCsharp.Properties.Resources.Config_Black;
                    break;

                case 1:
                    opbLogo.Image = global::tccCsharp.Properties.Resources.Logo_Black2; //mudar img
                    OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_White;
                    OPBRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_White;
                    OPBConfiguracoes.Image = global::tccCsharp.Properties.Resources.Config_White;
                    break;
            }
        }
    }
}
