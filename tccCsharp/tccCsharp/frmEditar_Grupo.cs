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
    public partial class frmEditar_Grupo : Form
    {
        public Head cabecalho = new Head();
        public List<GroupSteps> grupos = new List<GroupSteps>();
        public int IdGrupo;
        public GroupSteps grupoEditando = new GroupSteps();

        public frmEditar_Grupo(int IdRecebido)
        {
            InitializeComponent();
            IdGrupo = IdRecebido;
        }

        private void DoDesign()
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
            RGBDados2.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBDados3.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            RGBDados4.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            txtNomeGrupo.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

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

        private void frmEditar_Grupo_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DoDesign();
            AtualizaCabecalho();
            grupos = Banco.ConsultaGrupos(IdGrupo);

            if (grupos.Count < 2)
            {
                TLPEntreGrupos.Visible = false;
            }
            else
            {
                TLPEntreGrupos.Visible = true;

                comboDepois.DataSource = grupos;
                comboDepois.ValueMember = "ordenador";
                comboDepois.DisplayMember = "nome_grupo";
                comboDepois.SelectedIndex = 0;
            }

            if (radMeio.Checked == false)
            {
                TLPSelecionaCombo.Enabled = false;
            }

            radInicio.Checked = true;
            radMeio.Checked = false;
            radFim.Checked = false;
            TLPSelecionaCombo.Enabled = false;

            grupoEditando = Banco.RecarregaGrupo(IdGrupo);

            txtNomeGrupo.Text = grupoEditando.nome_grupo;

            comboDepois.SelectedIndex = -1;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeGrupo_Leave(object sender, EventArgs e)
        {
            customLine1.LineColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNomeGrupo.Text == String.Empty)
            {
                customLine1.LineColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                txtNomeGrupo.Focus();
                return;
            }


            GroupSteps grupoAlterado = new GroupSteps();
            grupoAlterado.id_grupo = grupoEditando.id_grupo;

            grupoAlterado.nome_grupo = txtNomeGrupo.Text;
            if (BoxSim.Checked == true)
                grupoAlterado.mostrar_porcentagem = true;
            else
                grupoAlterado.mostrar_porcentagem = false;

            if (radInicio.Checked == true)
            {
                if(grupoEditando.ordenador != 1)
                {
                    Banco.AlteraOrdenadorGrupo(Program.id_projeto_atual, 1, 1);
                    Banco.AlteraOrdenadorGrupo(Program.id_projeto_atual, grupoEditando.ordenador + 1, -1);
                    grupoAlterado.ordenador = 1;
                }
            }
            else if (radFim.Checked == true)
            {
                Banco.AlteraOrdenadorGrupo(Program.id_projeto_atual, grupoEditando.ordenador, -1);
                int fim = Convert.ToInt32(grupos[grupos.Count - 1].ordenador + 1);
                grupoAlterado.ordenador = fim -1;

            }
            else
            {
                int mid = Convert.ToInt32(comboDepois.SelectedValue) + 1;

                Banco.AlteraOrdenadorGrupo(Program.id_projeto_atual, mid, 1);
                Banco.AlteraOrdenadorGrupo(Program.id_projeto_atual, grupoEditando.ordenador, -1);
                grupoAlterado.ordenador = mid - 1;

            }


            Banco.AtualizaGrupo(grupoAlterado);
            MessageBox.Show("Grupo atualizado com sucesso!!", "Sucesso", MessageBoxButtons.OK);
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Banco.DeleteGroup(grupoEditando.id_grupo);
            Banco.AlteraOrdenadorGrupo(Program.id_projeto_atual, grupoEditando.ordenador, -1);
            MessageBox.Show("Grupo excluido com sucesso!!", "Sucesso", MessageBoxButtons.OK);
            this.Close();
        }

        private void OPBRecarregar_Click(object sender, EventArgs e)
        {
            Banco.AlteraOrdenadorGrupo(Program.id_projeto_atual, grupoEditando.ordenador, -1);
        }
    }
}