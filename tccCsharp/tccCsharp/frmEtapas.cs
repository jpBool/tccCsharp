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
    public partial class frmEtapas : Form
    {
        List<GroupSteps> grupos = new List<GroupSteps>();
        int y = 0;
        int x1 = 0;
        int x2 = 0;

        public frmEtapas()
        {
            InitializeComponent();
        }

        public void DoDesign()
        {
            TLPHead1.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblTitulo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            TLPHead2.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBHead2.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBHead2.ForeColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);

            groupPorcentagem.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            //groupPorcentagem.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            //groupPorcentagem2.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);

            TLPConteudo.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);

            btnADDEtapa.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            BtnADDGrupo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            BtnVoltar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnADDEtapa.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            BtnADDGrupo.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            BtnVoltar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);

            GPBEtapa11.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBEtapa12.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBEtapa13.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBEtapa21.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBEtapa22.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBEtapa23.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBGrupo1.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBGrupo2.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            RGBDescricaoEtapa11.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBDescricaoEtapa12.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBDescricaoEtapa13.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBDescricaoEtapa21.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBDescricaoEtapa22.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBDescricaoEtapa23.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);

            Grupo1groupPorcentagem1.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            Grupo2groupPorcentagem1.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            Etapa11groupPorcentagem1.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            Etapa12groupPorcentagem1.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            Etapa13groupPorcentagem1.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            Etapa21groupPorcentagem1.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            Etapa22groupPorcentagem1.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            Etapa23groupPorcentagem1.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);

            Grupo1groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            Grupo2groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            Etapa11groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            Etapa12groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            Etapa13groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            Etapa21groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            Etapa22groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            Etapa23groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
        }

        public void Refresh_steps()
        {
            if (y == 0)
                BtnCima.Enabled = false;
            else
                BtnCima.Enabled = true;

            if (grupos.Count() <= y + 2)
                BtnBaixo.Enabled = false;
            else
                BtnBaixo.Enabled = true;

            GroupSteps grupo1 = new GroupSteps();
            if (grupos.Count > y + 0)
            {
                GPBGrupo1.Visible = true;
                grupo1 = grupos[y + 0];
                lblTituloGrupo1.Text = grupo1.nome_grupo;
                // porcentagem do grupo 1

                Step etapa11 = new Step();
                if(grupo1.etapas.Count > x1 + 0)
                {
                    GPBEtapa11.Visible = true;
                    etapa11 = grupo1.etapas[x1 + 0];
                    lblNomeEtapa11.Text = etapa11.nome_etapa;
                    lblDescricaoEtapa11.Text = etapa11.descricao_etapa;
                    // porcentagem etapa 11
                }
                else
                {
                    GPBEtapa11.Visible = false;
                }

                Step etapa12 = new Step();
                if (grupo1.etapas.Count > x1 + 1)
                {
                    GPBEtapa12.Visible = true;
                    etapa12 = grupo1.etapas[x1 + 1];
                    lblNomeEtapa12.Text = etapa12.nome_etapa;
                    lblDescricaoEtapa12.Text = etapa12.descricao_etapa;
                    // porcentagem etapa 12
                }
                else
                {
                    GPBEtapa12.Visible = false;
                }

                Step etapa13 = new Step();
                if (grupo1.etapas.Count > x1 + 2)
                {
                    GPBEtapa13.Visible = true;
                    etapa13 = grupo1.etapas[x1 + 2];
                    lblNomeEtapa13.Text = etapa13.nome_etapa;
                    lblDescricaoEtapa13.Text = etapa13.descricao_etapa;
                    // porcentagem etapa 13
                }
                else
                {
                    GPBEtapa13.Visible = false;
                }
            }
            else
            {
                GPBGrupo1.Visible = false;
                GPBEtapa11.Visible = false;
                GPBEtapa12.Visible = false;
                GPBEtapa13.Visible = false;
            }

            GroupSteps grupo2 = new GroupSteps();
            if (grupos.Count() > y +1)
            {
                GPBGrupo2.Visible = true;
                grupo2 = grupos[y + 1];
                lblTituloGrupo2.Text = grupo2.nome_grupo;
                // porcentagem grupo 2 

                Step etapa21 = new Step();
                if (grupo2.etapas.Count > x2 + 0)
                {
                    GPBEtapa21.Visible = true;
                    etapa21 = grupo2.etapas[x2 + 0];
                    lblNomeEtapa21.Text = etapa21.nome_etapa;
                    lblDescricaoEtapa21.Text = etapa21.descricao_etapa;
                    // porcentagem etapa 21
                }
                else
                {
                    GPBEtapa21.Visible = false;
                }

                Step etapa22 = new Step();
                if (grupo2.etapas.Count > x2 + 1)
                {
                    GPBEtapa22.Visible = true;
                    etapa22 = grupo2.etapas[x2 + 1];
                    lblNomeEtapa22.Text = etapa22.nome_etapa;
                    lblDescricaoEtapa22.Text = etapa22.descricao_etapa;
                    // porcentagem etapa 22
                }
                else
                {
                    GPBEtapa22.Visible = false;
                }

                Step etapa23 = new Step();
                if (grupo2.etapas.Count > x2 + 2)
                {
                    GPBEtapa23.Visible = true;
                    etapa23 = grupo2.etapas[x2 + 2];
                    lblNomeEtapa23.Text = etapa23.nome_etapa;
                    lblDescricaoEtapa23.Text = etapa23.descricao_etapa;
                    // porcentagem etapa 23
                }
                else
                {
                    GPBEtapa23.Visible = false;
                }
            }
            else
            {
                GPBGrupo2.Visible = false;
                GPBEtapa21.Visible = false;
                GPBEtapa22.Visible = false;
                GPBEtapa23.Visible = false;
            }


            
        }

        private void frmEtapas_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            DoDesign();
            Banco.CarregarEtapas(grupos);
            Refresh_steps();

            //Desabilitar avançar e voltar
        }
    }
}
