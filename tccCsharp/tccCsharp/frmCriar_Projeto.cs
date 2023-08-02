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
    public partial class frmCriar_Projeto : Form
    {
        public List<GroupSteps> grupos = new List<GroupSteps>();
        public frmCriar_Projeto()
        {
            InitializeComponent();
        }

        public void DoDesign()
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

        public void LimparCampos()
        {
            if (txtNomeProjeto.Text == "Digite o nome do projeto (Obrigatório)")
            {
                txtNomeProjeto.Clear();
                return;
            }
            if (txtDescricaoBreve.Text == "Defina seu projeto em poucas palavras (Obrigatório)")
            {
                txtDescricaoBreve.Clear();
                return;
            }
            if (comboStatus.SelectedIndex == -1)
            {
                return;
            }

            if (txtPalavras.Text == "Ex. Tecnologia; Inovação; Automação...")
            {
                txtPalavras.Clear();
            }
            if (txtEmail.Text == "E-mail para que enteressados entrem em contato")
            {
                txtEmail.Clear();
            }
            if (txtAutores.Text == "Nome dos responsáveis pelo projeto")
            {
                txtAutores.Clear();
            }
            if (txtLinguagem.Text == "Linguagens de programação utilizadas")
            {
                txtLinguagem.Clear();
            }
            if (txtSite.Text == "Site do projeto")
            {
                txtSite.Clear();
            }
            if (txtVideo.Text == "Vídeo demonstrativo do projeto no YouTube")
            {
                txtVideo.Clear();
            }
            if (txtDetalhada.Text == "Objetivo, Escopo, Funcionalidades principais, Tecnologias utilizadas, Futuras Melhorias...")
            {
                txtDetalhada.Clear();
            }
        }

        void AdicionarGrupo(string nomeGrupo, bool mostrarPorcentagem, int ordenador)
        {
            GroupSteps grupo = new GroupSteps()
            {
                id_projeto = Program.id_projeto_atual,
                porcentagem = 0,
                numero_etapas = 0,
                excluido = false,
                nome_grupo = nomeGrupo,
                mostrar_porcentagem = mostrarPorcentagem,
                ordenador = ordenador
            };

            grupos.Add(grupo);
        }


        public void ModelosEtapa ()
        {
            grupos.Clear();
            
            if (radioSemModelos.Checked == true)
            {
                AdicionarGrupo("Grupo 1", false, 1);
            }
            else if (radioKanban.Checked == true)
            {
                AdicionarGrupo("To Do", false, 1);
                AdicionarGrupo("Doing", true, 2);
                AdicionarGrupo("Testing", true, 3);
                AdicionarGrupo("Done", false, 4);
            }
            else if (radioScrum.Checked == true)
            {
                AdicionarGrupo("Product Backlog", false, 1);
                AdicionarGrupo("Sprint 1", true, 2);
                AdicionarGrupo("Sprint 2", true, 3);
            }
            else if (radioEquipes.Checked == true)
            {
                AdicionarGrupo("Tarefas da equipe 1", true, 1);
                AdicionarGrupo("Tarefas da equipe 2", true, 2);
            }
            else if (radioPrazos.Checked == true)
            {
                AdicionarGrupo("Tarefas dessa semana", true, 1);
                AdicionarGrupo("Tarefas da próxima semana", true, 2);
                AdicionarGrupo("Tarefas futuras", true, 3);
                AdicionarGrupo("Tarefas concluídas", true, 4);
            }

            Banco.InserirMultiplo(grupos);
        }

        private void frmCriar_Projeto_Load(object sender, EventArgs e)
        {
            TLP_Mãe.Font = new Font("Arial", 9);
            WindowState = FormWindowState.Maximized;
            DoDesign();

            if(Program.lista_status.Count == 0)
                Program.lista_status = Banco.CarregaStatus();

            comboStatus.DataSource = Program.lista_status;
            comboStatus.ValueMember = "id_status";
            comboStatus.DisplayMember = "status";
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            
            Project Novo = new Project();

            if (String.IsNullOrEmpty(txtNomeProjeto.Text))
            {
                txtNomeProjeto.Focus();
                txtNomeProjeto.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
                customLine1.LineColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                return;
            }
            else
                Novo.nome_projeto = txtNomeProjeto.Text;

            if (String.IsNullOrEmpty(txtDescricaoBreve.Text))
            {
                txtDescricaoBreve.Focus();
                txtDescricaoBreve.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
                customLine5.LineColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                return;
            }
            else
                Novo.descricao_breve = txtDescricaoBreve.Text;

            if (comboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Status", "Criando Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboStatus.Focus();
                return;
            }
                
            else
            Novo.status = comboStatus.SelectedIndex + 1;

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

            Program.id_projeto_atual = Banco.InserirProjeto(Novo);
            ModelosEtapa();

            DialogResult resultado = MessageBox.Show("Projeto criado com sucesso!\nDeseja editar seu projeto agora?","Criando Projeto",MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
            else if (resultado == DialogResult.No)
            {
                Program.id_projeto_atual = 0;
                this.Close();
            }
        }

        private void boxSemPrevisao_CheckedChanged(object sender, EventArgs e)
        { 
            if (boxSemPrevisao.Checked == true)
                dtpPrevisao.Visible = false;
            else
                dtpPrevisao.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OPBLogout_Click(object sender, EventArgs e)
        {
            Program.projetos.Clear();
            Program.id_usuario = 0;
            this.Close();
        }

        private void OPBConfiguracoes_Click_1(object sender, EventArgs e)
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
            if (String.IsNullOrEmpty(txtPalavras.Text))
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
            if (String.IsNullOrEmpty(txtNomeProjeto.Text))
            {
                txtNomeProjeto.Text = "Digite o nome do projeto (Obrigatório)";
                txtNomeProjeto.ForeColor = Color.Gray;
            }
            customLine1.LineColor = Color.Black;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Text = "E-mail para que enteressados entrem em contato";
                txtEmail.ForeColor = Color.Gray;
            }
        }    

        private void txtAutores_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAutores.Text))
            {
                txtAutores.Text = "Nome dos responsáveis pelo projeto";
                txtAutores.ForeColor = Color.Gray;
            }
        }
       
        private void txtLinguagem_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLinguagem.Text))
            {
                txtLinguagem.Text = "Linguagens de programação utilizadas";
                txtLinguagem.ForeColor = Color.Gray;
            }
        }

        private void txtDescricaoBreve_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescricaoBreve.Text))
            {
                txtDescricaoBreve.Text = "Defina seu projeto em poucas palavras (Obrigatório)";
                txtDescricaoBreve.ForeColor = Color.Gray;
            }
            customLine5.LineColor = Color.Black;
        }    

        private void txtSite_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSite.Text))
            {
                txtSite.Text = "Site do projeto";
                txtSite.ForeColor = Color.Gray;
            }
        } 

        private void txtVideo_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtVideo.Text))
            {
                txtVideo.Text = "Vídeo demonstrativo do projeto no YouTube";
                txtVideo.ForeColor = Color.Gray;
            }
        }    

        private void txtDetalhada_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDetalhada.Text))
            {
                txtDetalhada.Text = "Objetivo, Escopo, Funcionalidades principais, Tecnologias utilizadas, Futuras Melhorias...";
                txtDetalhada.ForeColor = Color.Gray;
            }
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

        private void txtAutores_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
