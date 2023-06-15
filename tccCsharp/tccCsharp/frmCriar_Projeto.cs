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
    public partial class frmCriar_Projeto : Form
    {
        public frmCriar_Projeto()
        {
            InitializeComponent();
        }

        public void doDesign()
        {
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
            RGBModelos.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

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
            RGBModelos.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);

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

            btnCriar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnCriar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnCriar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);

            OPBLogout._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBConfiguracoes._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBRecarregar._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);

            lblTitulo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        public string PalavrasChave()
        {
            return null;
        }

        private void frmCriar_Projeto_Load(object sender, EventArgs e)
        {
            TLP_Mãe.Font = new Font("Arial", 9);
            WindowState = FormWindowState.Maximized;
            doDesign();
        }

        //MOUSE ENTER
        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnCancelar.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void btnCriar_MouseEnter(object sender, EventArgs e)
        {
            btnCriar.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnCriar.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void OPBLogout_MouseEnter(object sender, EventArgs e)
        {
            OPBLogout._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBLogout.Refresh();
        }

        private void OPBRecarregar_MouseEnter(object sender, EventArgs e)
        {
            OPBRecarregar._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBRecarregar.Refresh();
        }

        private void OPBConfiguracoes_MouseEnter(object sender, EventArgs e)
        {
            OPBConfiguracoes._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBConfiguracoes.Refresh();
        }

        //MOUSE LEAVE
        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnCancelar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void btnCriar_MouseLeave(object sender, EventArgs e)
        {
            btnCriar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnCriar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void OPBLogout_MouseLeave(object sender, EventArgs e)
        {
            OPBLogout._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBLogout.Refresh();
        }

        private void OPBRecarregar_MouseLeave(object sender, EventArgs e)
        {
            OPBRecarregar._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBRecarregar.Refresh();
        }

        private void OPBConfiguracoes_MouseLeave(object sender, EventArgs e)
        {
            OPBConfiguracoes._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBConfiguracoes.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Project Novo = new Project();

            if (String.IsNullOrEmpty(txtNomeProjeto.Text))
                return;
            else
                Novo.nome_projeto = txtNomeProjeto.Text;

            if (String.IsNullOrEmpty(txtEmail.Text))
                Novo.email_contato = null;
            else
                Novo.email_contato = txtEmail.Text;

            if (String.IsNullOrEmpty(txtAutores.Text))
                Novo.autores = null;
            else
                Novo.autores = txtAutores.Text;

            if (String.IsNullOrEmpty(txtLinguagem.Text))
                Novo.linguagem = null;
            else Novo.linguagem = txtLinguagem.Text;

            if (String.IsNullOrEmpty(txtDescricaoBreve.Text))
                return;
            else
                Novo.descricao_breve = txtDescricaoBreve.Text;

            if (String.IsNullOrEmpty(txtSite.Text))
                Novo.link_site = null;
            else
                Novo.link_site = txtSite.Text;

            if (String.IsNullOrEmpty(txtVideo.Text))
                Novo.link_youtube = null;
            else 
                Novo.link_youtube = txtVideo.Text;

            if (String.IsNullOrEmpty(txtPalavras.Text))
                Novo.palavras_chave = null;
            else
                Novo.palavras_chave = PalavrasChave();

            if (boxSemPrevisao.Checked == true)
                Novo.previsao = new DateTime(1, 1, 1);
            else
                Novo.previsao = dtpPrevisao.Value;

            //Novo.status = comboStatus.SelectedIndex;
            Novo.status = 0;

            if (radioSim.Checked == true)
                Novo.publico = true;
            else
                Novo.publico = false;

            if (String.IsNullOrEmpty(txtDetalhada.Text))
                Novo.descricao_detalhada = null;
            else
                Novo.descricao_detalhada = txtDetalhada.Text;

            if (Program.id_usuario == 0)
            {
                MessageBox.Show("Ocorreu um erro ao resgatar suas informações!!!", "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                Novo.id_criador = Program.id_usuario;

            Novo.porcentagem = 0;
            Novo.data_criacao = DateTime.Today;
            Novo.data_atualizacao = DateTime.Now;
            Novo.atualizador = Program.id_usuario;
            Novo.excluido = false;
            Novo.numero_grupos = 0;

            Banco.InserirProjeto(Novo);
            this.Close();
        }

        private void boxSemPrevisao_CheckedChanged(object sender, EventArgs e)
        { 
            if (boxSemPrevisao.Checked == true)
                dtpPrevisao.Visible = false;
            else
                dtpPrevisao.Visible = true;
        }
    }
}
