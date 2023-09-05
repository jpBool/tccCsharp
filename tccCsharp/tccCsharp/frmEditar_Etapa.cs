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
    public partial class frmEditar_Etapa : Form
    {
        public Head cabecalho = new Head();
        public List<GroupSteps> grupos = new List<GroupSteps>();
        public List<Step> etapas = new List<Step>();
        public Boolean liberado = false;
        public Step EtapaEditando = new Step();
        public int IdEtapa;
        public int numGrupos;

        public frmEditar_Etapa(int idRecebido, int quantRecebido)
        {
            InitializeComponent();
            IdEtapa = idRecebido;
            numGrupos = quantRecebido;
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

            btnAtualizar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnAtualizar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnAtualizar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnAtualizar.AutoHoover = true;
            btnAtualizar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);

            btnExcluir.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnExcluir.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnExcluir.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnExcluir.AutoHoover = true;
            btnExcluir.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);

            RGBButtons.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBCampos.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBDetalhada.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBDecri1.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBDescri2.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBPrioridade.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            trackPercent.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
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

        public void CarregaInfo()
        {
            EtapaEditando = Banco.RecarregaEtapa(IdEtapa);
            txtNomeEtapa.Text = EtapaEditando.nome_etapa;
            txtDescricao.Text = EtapaEditando.descricao_etapa;

            if (EtapaEditando.impedimento == true)
            {
                boxSim.Checked = true;
                txtDescriImpedimento.Text = EtapaEditando.descricao_impedimento;
            }
            else
            {
                boxSim.Checked = false;
                txtDescriImpedimento.Enabled = false;
                txtDescriImpedimento.Text = String.Empty;
            }
            
            if (Program.lista_status.Count == 0)
                Program.lista_status = Banco.CarregaStatus();
            comboStatus.DataSource = Program.lista_status;
            comboStatus.ValueMember = "id_status";
            comboStatus.DisplayMember = "status";
            comboStatus.SelectedIndex = EtapaEditando.status - 1;

            txtResponsavel.Text = EtapaEditando.responsavel;
            txtEmail.Text = EtapaEditando.email_responsavel;

            grupos = Banco.ConsultaGrupos(0);
            comboGrupo.DataSource = grupos;
            comboGrupo.ValueMember = "id_grupo";
            comboGrupo.DisplayMember = "nome_grupo";
            comboGrupo.SelectedValue = EtapaEditando.id_grupo;

            etapas = Banco.ConsultaEtapas(Convert.ToInt32(comboGrupo.SelectedValue), EtapaEditando.id_etapa);
            if(EtapaEditando.ordenador == 1)
            {
                radInicio.Checked = true;
                radMeio.Checked = false;
                TLPSelecionaCombo.Visible = false;
                radFim.Checked = false;

            }else if (EtapaEditando.ordenador == numGrupos)
            {
                radFim.Checked = true;
                radMeio.Checked = false;
                radInicio.Checked = false;
                TLPSelecionaCombo.Visible = false;
            }
            else
            {
                 TLPEntreGrupos.Visible = true;
                 radFim.Checked = false;
                 radMeio.Checked = true;
                 radInicio.Checked = false;

                comboDepois.DataSource = etapas;
                 comboDepois.ValueMember = "ordenador";
                 comboDepois.DisplayMember = "nome_etapa";
                 comboDepois.SelectedValue = EtapaEditando.ordenador - 1;               
            }

            numPrioridade.Value = EtapaEditando.prioridade;
            numPeso.Value = EtapaEditando.peso;
            numPercent.Value = Convert.ToInt32(EtapaEditando.porcentagem);
            trackPercent.Value = Convert.ToInt32(EtapaEditando.porcentagem);  
        }

        private void frmEditar_Etapa_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DoDesign();
            AtualizaCabecalho();
            CarregaInfo();
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
            if (comboGrupo.SelectedIndex >= 0 && liberado == true)
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
            }
            TLPSelecionaCombo.Visible = true;
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
            if (comboGrupo.SelectedIndex >= 0 && liberado == true)
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
                TLPSelecionaCombo.Visible = true;
                radFim.Checked = true;
                radMeio.Checked = false;
                radInicio.Checked = false;
                TLPSelecionaCombo.Enabled = false;
            }
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Banco.DeleteStep(EtapaEditando.id_etapa, EtapaEditando.id_grupo);
            Banco.AlteraOrdenadorEtapa(Program.id_projeto_atual, EtapaEditando.ordenador, -1);
            MessageBox.Show("Etapa excluida com sucesso!!", "Sucesso", MessageBoxButtons.OK);
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNomeEtapa.Text == String.Empty)
            {
                customLine1.LineColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                txtNomeEtapa.Focus();
                return;
            }

            if (Convert.ToInt32(comboGrupo.SelectedIndex) == -1)
            {
                comboGrupo.SelectedIndex = 0;
                comboGrupo.Focus();
                MessageBox.Show("Selecione um Grupo", "Criando Etapa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Step EtapaAtualizada = new Step();
            EtapaAtualizada.id_grupo = Convert.ToInt32(comboGrupo.SelectedValue);
            EtapaAtualizada.nome_etapa = txtNomeEtapa.Text;
            EtapaAtualizada.peso = Convert.ToInt32(numPeso.Value);
            EtapaAtualizada.porcentagem = Convert.ToInt32(numPercent.Value);
            EtapaAtualizada.descricao_etapa = txtDescricao.Text;
            EtapaAtualizada.prioridade = Convert.ToInt32(numPrioridade.Value);
            EtapaAtualizada.responsavel = txtResponsavel.Text;
            EtapaAtualizada.email_responsavel = txtEmail.Text;
            if (boxSim.Checked == true)
            {
                EtapaAtualizada.impedimento = true;
                EtapaAtualizada.descricao_impedimento = txtDescriImpedimento.Text;
            }
            else
            {
                EtapaAtualizada.impedimento = false;
                EtapaAtualizada.descricao_impedimento = string.Empty;
            }
            EtapaAtualizada.data_atualizacao = DateTime.Now;
            EtapaAtualizada.atualizador = Program.id_usuario;
            EtapaAtualizada.excluido = false;

            if (comboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Status", "Criando Etapa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboStatus.Focus();
                return;
            }
            else
            {
                EtapaAtualizada.status = comboStatus.SelectedIndex + 1;
            }

            Banco.AlteraOrdenadorEtapa(Program.id_projeto_atual, EtapaEditando.ordenador, -1);

            if (radInicio.Checked == true)
            {
                Banco.AlteraOrdenadorEtapa(EtapaAtualizada.id_grupo, 1, 1);
                EtapaAtualizada.ordenador = 1;
            }
            else if (radFim.Checked == true)
            {
                int last = etapas.Count();
                EtapaAtualizada.ordenador = etapas[last - 1].ordenador + 1;
            }
            else
            {
                int mid = Convert.ToInt32(comboDepois.SelectedValue) + 1;
                Banco.AlteraOrdenadorEtapa(EtapaAtualizada.id_grupo, mid, 1);
                EtapaAtualizada.ordenador = mid;
            }

            if(EtapaAtualizada.id_grupo != EtapaEditando.id_grupo)
            {
                Banco.StepNumAlt(EtapaEditando.id_grupo, -1);
            }

            Banco.AtualizaEtapa(EtapaAtualizada);
            this.Close();
        }
    }
}
