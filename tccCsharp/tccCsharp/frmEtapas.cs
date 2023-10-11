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
        public Head cabecalho = new Head();
        int y = 0;
        int x1 = 0;
        int x2 = 0;
        public String NomeProjeto;
        int index_btn = 0;

        public frmEtapas(String NomeRecebido)
        {
            InitializeComponent();
            NomeProjeto = NomeRecebido;
        }

        public void DoDesign()
        {
            TLP_Mãe.Font = Program.fonte;
            TLPHead1.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblTitulo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            TLPHead2.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBHead2.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBHead2.ForeColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);

            groupPorcentagem.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            lblPorcentagem.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

            TLPConteudo.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);

            btnADDEtapa.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            BtnADDGrupo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            BtnVoltar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnADDEtapa.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            BtnADDGrupo.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            BtnVoltar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnADDEtapa.AutoHoover = true;
            BtnADDGrupo.AutoHoover = true;
            BtnVoltar.AutoHoover= true;
            btnADDEtapa.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            BtnADDGrupo.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            BtnVoltar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnADDEtapa.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            BtnADDGrupo.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            BtnVoltar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);

            btnADDEtapa.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnADDEtapa.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            BtnADDGrupo.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            BtnADDGrupo.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            BtnVoltar.BordaPrincipal = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            BtnVoltar.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

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
            Etapa22groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            Etapa21groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            Etapa23groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);

            OPBConfiguracoes._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBLogout._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBRecarregar._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            opbEditarP11._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            opbEditarP12._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            opbEditarP13._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            opbEditarP21._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            opbEditarP22._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            opbEditarP23._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            opbEditarE1._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            opbEditarE2._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            OPBConfiguracoes.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBLogout.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBRecarregar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarP11.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarP12.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarP13.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarP21.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarP22.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarP23.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarE1.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbEditarE2.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);

            OPBConfiguracoes.AutoHoover = true;
            OPBLogout.AutoHoover = true;
            OPBRecarregar.AutoHoover = true;
            opbEditarP11.AutoHoover = true;
            opbEditarP12.AutoHoover = true;
            opbEditarP13.AutoHoover = true;
            opbEditarP21.AutoHoover = true;
            opbEditarP22.AutoHoover = true;
            opbEditarP23.AutoHoover = true;
            opbEditarE1.AutoHoover = true;
            opbEditarE2.AutoHoover = true;

            OPBLeft1._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            OPBLeft2._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            OPBRight1._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            OPBRight2._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            OPBUp._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            OPBDown._bordercolor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            OPBLeft1.BordaPrincipal = Color.Transparent;
            OPBLeft2.BordaPrincipal = Color.Transparent;
            OPBRight1.BordaPrincipal = Color.Transparent;
            OPBRight2.BordaPrincipal = Color.Transparent;
            OPBUp.BordaPrincipal = Color.Transparent;
            OPBDown.BordaPrincipal = Color.Transparent;

            OPBLeft1.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBLeft1.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBLeft2.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBRight1.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBRight2.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBUp.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBDown.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            //////////
            OPBLeft1.AutoHoover = true;
            OPBLeft2.AutoHoover = true;
            OPBRight1.AutoHoover = true;
            OPBRight2.AutoHoover = true;
            OPBUp.AutoHoover = true;
            OPBDown.AutoHoover = true;

            OPBConfiguracoes.BordaPrincipal = Color.Transparent;
            OPBLogout.BordaPrincipal = Color.Transparent;
            OPBRecarregar.BordaPrincipal = Color.Transparent;
            opbEditarP11.BordaPrincipal = Color.Transparent;
            opbEditarP12.BordaPrincipal = Color.Transparent;
            opbEditarP13.BordaPrincipal = Color.Transparent;
            opbEditarP21.BordaPrincipal = Color.Transparent;
            opbEditarP22.BordaPrincipal = Color.Transparent;
            opbEditarP23.BordaPrincipal = Color.Transparent;
            opbEditarE1.BordaPrincipal = Color.Transparent;
            opbEditarE2.BordaPrincipal = Color.Transparent;

            Logo(Program.logo);
        }

        public void Refresh_steps()
        {
            if (y == 0)
                OPBUp.Visible = false;
            else
                OPBUp.Visible = true;

            if (grupos.Count() <= y + 2)
                OPBDown.Visible = false;
            else
                OPBDown.Visible = true;

            if (x1 == 0)
                OPBLeft1.Visible = false;
            else
                OPBLeft1.Visible = true;

            if (x2 == 0)
                OPBLeft2.Visible = false; 
            else
                OPBLeft2.Visible = true;


            GroupSteps grupo1 = new GroupSteps();
            if (grupos.Count > y + 0)
            {
                GPBGrupo1.Visible = true;
                grupo1 = grupos[y + 0];
                lblTituloGrupo1.Text = grupo1.nome_grupo;
                if (grupo1.etapas.Count <= x1 + 3)
                {
                    OPBRight1.Visible = false;
                }
                else
                {
                    OPBRight1.Visible = true;
                }
                if(grupo1.mostrar_porcentagem == true)
                {
                    lblPorcentagemGP1.Visible = true;
                    Grupo1groupPorcentagem1.Visible = true;
                    Grupo1groupPorcentagem2.Visible = true;

                    lblPorcentagemGP1.Text = Convert.ToInt32(grupo1.porcentagem).ToString() + "%";
                    if (Convert.ToInt32(grupo1.porcentagem) == 100)
                        Grupo1groupPorcentagem2.Width = Grupo1groupPorcentagem1.Width;
                    else
                    {
                        Grupo1groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(Grupo1groupPorcentagem1.Width) / 100) * Convert.ToDouble(grupo1.porcentagem));
                        if (Grupo1groupPorcentagem2.Width < 28)
                            Grupo1groupPorcentagem2.Width = 28;
                    }
                }
                else 
                {
                    lblPorcentagemGP1.Visible = false;
                    Grupo1groupPorcentagem1.Visible = false;
                    Grupo1groupPorcentagem2.Visible = false;
                }

                Step etapa11 = new Step();
                if(grupo1.etapas.Count > x1 + 0)
                {
                    GPBEtapa11.Visible = true;
                    etapa11 = grupo1.etapas[x1 + 0];
                    lblNomeEtapa11.Text = etapa11.nome_etapa;
                    lblDescricaoEtapa11.Text = etapa11.descricao_etapa;
                    lblPorcentagemET11.Text = Convert.ToInt32(etapa11.porcentagem).ToString() + "%";

                    if (Convert.ToInt32(etapa11.porcentagem) == 100)
                        Etapa11groupPorcentagem2.Width = Etapa11groupPorcentagem1.Width;
                    else
                    {
                        Etapa11groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(Etapa11groupPorcentagem1.Width) / 100) * Convert.ToDouble(etapa11.porcentagem));
                        if (Etapa11groupPorcentagem2.Width < 28)
                            Etapa11groupPorcentagem2.Width = 28;
                    }

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
                    lblPorcentagemET12.Text = Convert.ToInt32(etapa12.porcentagem).ToString() + "%";
                    
                    if (Convert.ToInt32(etapa12.porcentagem) == 100)
                        Etapa12groupPorcentagem2.Width = Etapa12groupPorcentagem1.Width;
                    else
                    {
                        Etapa12groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(Etapa12groupPorcentagem1.Width) / 100) * Convert.ToDouble(etapa12.porcentagem));
                        if (Etapa12groupPorcentagem2.Width < 28)
                            Etapa12groupPorcentagem2.Width = 28;
                    }

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
                    lblPorcentagemET13.Text = Convert.ToInt32(etapa13.porcentagem).ToString() + "%";

                    if (Convert.ToInt32(etapa13.porcentagem) == 100)
                        Etapa13groupPorcentagem2.Width = Etapa13groupPorcentagem1.Width;
                    else
                    {
                        Etapa13groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(Etapa13groupPorcentagem1.Width) / 100) * Convert.ToDouble(etapa13.porcentagem));
                        if (Etapa13groupPorcentagem2.Width < 28)
                            Etapa13groupPorcentagem2.Width = 28;
                    }
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
                if (grupo2.etapas.Count <= x2 + 3)
                {
                    OPBRight2.Visible = false;
                }
                else
                {
                    OPBRight2.Visible = true;
                }

                if(grupo2.mostrar_porcentagem == true)
                {
                    lblPorcentagemGP2.Visible = true;
                    Grupo2groupPorcentagem1.Visible = true;
                    Grupo2groupPorcentagem2.Visible = true;

                    lblPorcentagemGP2.Text = Convert.ToInt32(grupo2.porcentagem).ToString() + "%";
                    if (Convert.ToInt32(grupo2.porcentagem) == 100)
                        Grupo2groupPorcentagem2.Width = Grupo2groupPorcentagem1.Width;
                    else
                    {
                        Grupo2groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(Grupo2groupPorcentagem1.Width) / 100) * Convert.ToDouble(grupo2.porcentagem));
                        if (Grupo2groupPorcentagem2.Width < 28)
                            Grupo2groupPorcentagem2.Width = 28;
                    }
                }
                else
                {
                    lblPorcentagemGP2.Visible = false;
                    Grupo2groupPorcentagem1.Visible = false;
                    Grupo2groupPorcentagem2.Visible = false;
                }
                

                Step etapa21 = new Step();
                if (grupo2.etapas.Count > x2 + 0)
                {
                    GPBEtapa21.Visible = true;
                    etapa21 = grupo2.etapas[x2 + 0];
                    lblNomeEtapa21.Text = etapa21.nome_etapa;
                    lblDescricaoEtapa21.Text = etapa21.descricao_etapa;
                    lblPorcentagemET21.Text = Convert.ToInt32(etapa21.porcentagem).ToString() + "%";

                    if (Convert.ToInt32(etapa21.porcentagem) == 100)
                        Etapa21groupPorcentagem2.Width = Etapa21groupPorcentagem1.Width;
                    else
                    {
                        Etapa21groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(Etapa21groupPorcentagem1.Width) / 100) * Convert.ToDouble(etapa21.porcentagem));
                        if (Etapa21groupPorcentagem2.Width < 28)
                            Etapa21groupPorcentagem2.Width = 28;
                    }
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
                    lblPorcentagemET22.Text = Convert.ToInt32(etapa22.porcentagem).ToString() + "%";

                    if (Convert.ToInt32(etapa22.porcentagem) == 100)
                        Etapa22groupPorcentagem2.Width = Etapa22groupPorcentagem1.Width;
                    else
                    {
                        Etapa22groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(Etapa22groupPorcentagem1.Width) / 100) * Convert.ToDouble(etapa22.porcentagem));
                        if (Etapa22groupPorcentagem2.Width < 28)
                            Etapa22groupPorcentagem2.Width = 28;
                    }
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
                    lblPorcentagemET23.Text = Convert.ToInt32(etapa23.porcentagem).ToString() + "%";

                    if (Convert.ToInt32(etapa23.porcentagem) == 100)
                        Etapa23groupPorcentagem2.Width = Etapa23groupPorcentagem1.Width;
                    else
                    {
                        Etapa23groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(Etapa23groupPorcentagem1.Width) / 100) * Convert.ToDouble(etapa23.porcentagem));
                        if (Etapa23groupPorcentagem2.Width < 28)
                            Etapa23groupPorcentagem2.Width = 28;
                    }
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
            OPBRight1.Visible = false;
            OPBRight2.Visible = false;
            Refresh_steps();
            AtualizaCabecalho();
            lblTitulo.Text = "ETAPAS DO PROJETO " + NomeProjeto.ToUpper();
        }

        private void OPBLogout_Click(object sender, EventArgs e)
        {
            Program.projetos.Clear();
            Program.id_usuario = 0;
            this.Close();
        }

        private void OPBRecarregar_Click(object sender, EventArgs e)
        {
            grupos.Clear();
            DoDesign();
            Banco.CarregarEtapas(grupos);
            Refresh_steps();
            AtualizaCabecalho();
        }

        private void OPBConfiguracoes_Click(object sender, EventArgs e)
        {
            //apenas teste
            frmConfiguracoes formC = new frmConfiguracoes();
            formC.ShowDialog();

            /*frmPersonalizacao formP = new frmPersonalizacao();
            formP.ShowDialog();*/
        }


        ///////////////////Botões de movimentação

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEtapas_Resize(object sender, EventArgs e)
        {
            if (cabecalho.porcentagem_int == 100)
                groupPorcentagem2.Width = groupPorcentagem.Width;
            else
            {
                groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(groupPorcentagem.Width) / 100) * Convert.ToDouble(cabecalho.porcentagem_int));
                if (groupPorcentagem2.Width < 45)
                    groupPorcentagem2.Width = 45;
            }
            Refresh_steps();
        }

        private void OPBRight1_Click(object sender, EventArgs e)
        {
            x1 += 3;
            Refresh_steps();
        }

        private void OPBRight2_Click(object sender, EventArgs e)
        {
            x2 += 3;
            Refresh_steps();
        }

        private void OPBLeft1_Click_1(object sender, EventArgs e)
        {
            x1 -= 3;
            Refresh_steps();
        }

        private void OPBLeft2_Click(object sender, EventArgs e)
        {
            x2 -= 3;
            Refresh_steps();
        }

        private void OPBDown_Click(object sender, EventArgs e)
        {
            y += 2;
            x1 = 0;
            x2 = 0;
            Refresh_steps();
        }

        private void OPBUp_Click(object sender, EventArgs e)
        {
            y -= 2;
            x1 = 0;
            x2 = 0;
            Refresh_steps();
        }

        private void BtnADDGrupo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCriar_Grupo splash = new frmCriar_Grupo();
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
                grupos.Clear();
                Banco.CarregarEtapas(grupos);
                Refresh_steps();

            }
        }
        private void AtualizaCabecalho()
        {
            cabecalho = Banco.CabecalhoProjeto();
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

        private void opbEditarE1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEditar_Grupo splash = new frmEditar_Grupo(grupos[y+0].id_grupo);
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
                grupos.Clear();
                Banco.CarregarEtapas(grupos);
                Refresh_steps();

            }
        }

        private void opbEditarE2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEditar_Grupo splash = new frmEditar_Grupo(grupos[y + 1].id_grupo);
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
                grupos.Clear();
                Banco.CarregarEtapas(grupos);
                Refresh_steps();

            }
        }

        private void btnADDEtapa_Click(object sender, EventArgs e)
        {
            if (grupos.Count <1) return;
            
            this.Visible = false;
            frmCriar_Etapa splash = new frmCriar_Etapa();
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
                grupos.Clear();
                Banco.CarregarEtapas(grupos);
                Refresh_steps();

            }
        }

        private void opbEditarP11_Click(object sender, EventArgs e)
        {
            GroupSteps grupo1 = new GroupSteps();
            grupo1 = grupos[y + 0];
            Step etapa11 = new Step();
            etapa11 = grupo1.etapas[x1 + 0];

            this.Visible = false;
            frmEditar_Etapa splash = new frmEditar_Etapa(etapa11.id_etapa, grupo1.numero_etapas);
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
                grupos.Clear();
                Banco.CarregarEtapas(grupos);
                Refresh_steps();
            }
        }

        private void opbEditarP12_Click(object sender, EventArgs e)
        {
            GroupSteps grupo1 = new GroupSteps();
            grupo1 = grupos[y + 0];
            Step etapa12 = new Step();
            etapa12 = grupo1.etapas[x1 + 1];

            this.Visible = false;
            frmEditar_Etapa splash = new frmEditar_Etapa(etapa12.id_etapa, grupo1.numero_etapas);
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
                grupos.Clear();
                Banco.CarregarEtapas(grupos);
                Refresh_steps();
            }
        }

        private void opbEditarP13_Click(object sender, EventArgs e)
        {
            GroupSteps grupo1 = new GroupSteps();
            grupo1 = grupos[y + 0];
            Step etapa13 = new Step();
            etapa13 = grupo1.etapas[x1 + 2];

            this.Visible = false;
            frmEditar_Etapa splash = new frmEditar_Etapa(etapa13.id_etapa, grupo1.numero_etapas);
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
                grupos.Clear();
                Banco.CarregarEtapas(grupos);
                Refresh_steps();
            }
        }

        private void opbEditarP21_Click(object sender, EventArgs e)
        {
            GroupSteps grupo2 = new GroupSteps();
            grupo2 = grupos[y + 1];
            Step etapa21 = new Step();
            etapa21 = grupo2.etapas[x2 + 0];

            this.Visible = false;
            frmEditar_Etapa splash = new frmEditar_Etapa(etapa21.id_etapa, grupo2.numero_etapas);
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
                grupos.Clear();
                Banco.CarregarEtapas(grupos);
                Refresh_steps();
            }
        }

        private void opbEditarP22_Click(object sender, EventArgs e)
        {
            GroupSteps grupo2 = new GroupSteps();
            grupo2 = grupos[y + 1];
            Step etapa22 = new Step();
            etapa22 = grupo2.etapas[x2 + 1];

            this.Visible = false;
            frmEditar_Etapa splash = new frmEditar_Etapa(etapa22.id_etapa, grupo2.numero_etapas);
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
                grupos.Clear();
                Banco.CarregarEtapas(grupos);
                Refresh_steps();
            }
        }

        private void opbEditarP23_Click(object sender, EventArgs e)
        {
            GroupSteps grupo2 = new GroupSteps();
            grupo2 = grupos[y + 1];
            Step etapa23 = new Step();
            etapa23 = grupo2.etapas[x2 + 2];

            this.Visible = false;
            frmEditar_Etapa splash = new frmEditar_Etapa(etapa23.id_etapa, grupo2.numero_etapas);
            splash.ShowDialog();
            if (Program.id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
                AtualizaCabecalho();
                grupos.Clear();
                Banco.CarregarEtapas(grupos);
                Refresh_steps();
            }
        }

        private void RGBHead1_Enter(object sender, EventArgs e)
        {

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

                    opbEditarE1.Image = global::tccCsharp.Properties.Resources.Edit_White;
                    opbEditarP11.Image = global::tccCsharp.Properties.Resources.Edit_White;
                    opbEditarP12.Image = global::tccCsharp.Properties.Resources.Edit_White;
                    opbEditarP13.Image = global::tccCsharp.Properties.Resources.Edit_White;

                    opbEditarE2.Image = global::tccCsharp.Properties.Resources.Edit_White;
                    opbEditarP21.Image = global::tccCsharp.Properties.Resources.Edit_White;
                    opbEditarP22.Image = global::tccCsharp.Properties.Resources.Edit_White;
                    opbEditarP23.Image = global::tccCsharp.Properties.Resources.Edit_White;

                    OPBLeft1.Image = global::tccCsharp.Properties.Resources.Left_White;
                    OPBLeft2.Image = global::tccCsharp.Properties.Resources.Left_White;
                    OPBRight1.Image = global::tccCsharp.Properties.Resources.Right_White;
                    OPBRight2.Image = global::tccCsharp.Properties.Resources.Right_White;
                    OPBUp.Image = global::tccCsharp.Properties.Resources.Up_White;
                    OPBDown.Image = global::tccCsharp.Properties.Resources.Down_White;

                    break;

                case 1:
                    opbLogo.Image = global::tccCsharp.Properties.Resources.Logo_Black2; 

                    OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_White;
                    OPBRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_White;
                    OPBConfiguracoes.Image = global::tccCsharp.Properties.Resources.Config_White;

                    opbEditarE1.Image = global::tccCsharp.Properties.Resources.Edit_Black;
                    opbEditarP11.Image = global::tccCsharp.Properties.Resources.Edit_Black;
                    opbEditarP12.Image = global::tccCsharp.Properties.Resources.Edit_Black;
                    opbEditarP13.Image = global::tccCsharp.Properties.Resources.Edit_Black;

                    opbEditarE2.Image = global::tccCsharp.Properties.Resources.Edit_Black;
                    opbEditarP21.Image = global::tccCsharp.Properties.Resources.Edit_Black;
                    opbEditarP22.Image = global::tccCsharp.Properties.Resources.Edit_Black;
                    opbEditarP23.Image = global::tccCsharp.Properties.Resources.Edit_Black;

                    OPBLeft1.Image = global::tccCsharp.Properties.Resources.Left_Black;
                    OPBLeft2.Image = global::tccCsharp.Properties.Resources.Left_Black;
                    OPBRight1.Image = global::tccCsharp.Properties.Resources.Right_Black;
                    OPBRight2.Image = global::tccCsharp.Properties.Resources.Right_Black;
                    OPBUp.Image = global::tccCsharp.Properties.Resources.Up_Black;
                    OPBDown.Image = global::tccCsharp.Properties.Resources.Down_Black;
                    break;
            }
        }

        private void frmEtapas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                index_btn++;
                if (index_btn == 21)
                    index_btn = 1;

                switch (index_btn)
                {
                    case 1:
                        btnADDEtapa.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        btnADDEtapa.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        OPBLogout._bordercolor = Color.Transparent;
                        break;
                    case 2:
                        btnADDEtapa.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                        btnADDEtapa.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                        BtnADDGrupo.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        BtnADDGrupo.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        break; 
                    case 3:
                        BtnADDGrupo.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                        BtnADDGrupo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                        BtnVoltar.BorderColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        BtnVoltar.ForeColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
             
                        break;
                    case 4: 
                        BtnVoltar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                        BtnVoltar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                        OPBUp._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (OPBUp.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;
                        
                    case 5:
                        OPBUp._bordercolor = Color.Transparent;
                        opbEditarE1._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (opbEditarE1.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;

                    case 6:
                        opbEditarE1._bordercolor = Color.Transparent;
                        opbEditarE2._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (opbEditarE2.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;

                    case 7:
                        opbEditarE2._bordercolor = Color.Transparent;
                        OPBDown._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (OPBDown.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;

                    case 8:
                        OPBDown._bordercolor = Color.Transparent;
                        OPBLeft1._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (OPBLeft1.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;

                    case 9:
                        OPBLeft1._bordercolor = Color.Transparent;
                        opbEditarP11._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (opbEditarP11.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;

                    case 10:
                        opbEditarP11._bordercolor = Color.Transparent;
                        opbEditarP12._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (opbEditarP12.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;

                    case 11:
                        opbEditarP12._bordercolor = Color.Transparent;
                        opbEditarP13._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (opbEditarP13.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;
 
                    case 12:
                        opbEditarP13._bordercolor = Color.Transparent;
                        OPBRight1._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (OPBRight1.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;

                    case 13:
                        OPBRight1._bordercolor = Color.Transparent;
                        OPBLeft2._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (OPBLeft2.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;

                    case 14:
                        OPBLeft2._bordercolor = Color.Transparent;
                        opbEditarP21._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (opbEditarP21.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;

                    case 15:
                        opbEditarP21._bordercolor = Color.Transparent;
                        opbEditarP22._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (opbEditarP22.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;

                    case 16:
                        opbEditarP22._bordercolor = Color.Transparent;
                        opbEditarP23._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (opbEditarP23.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;

                    case 17:
                        opbEditarP23._bordercolor = Color.Transparent;
                        OPBRight2._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        if (OPBRight2.Visible == false)
                        {
                            frmEtapas_KeyDown(sender, e);
                        }
                        break;

                    
                    case 18:
                        OPBRight2._bordercolor = Color.Transparent;
                        OPBConfiguracoes._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        break;
                    
                    case 19:
                        OPBConfiguracoes._bordercolor = Color.Transparent;
                        OPBRecarregar._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        break;

                    case 20:
                        OPBRecarregar._bordercolor = Color.Transparent;
                        OPBLogout._bordercolor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
                        break;
                        

                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                switch (index_btn)
                {
                    case 1:
                        index_btn = 0;
                        btnADDEtapa.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                        btnADDEtapa.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                        btnADDEtapa_Click(sender, e);
                        break;
                    case 2:
                        index_btn = 0;
                        BtnADDGrupo.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                        BtnADDGrupo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                        BtnADDGrupo_Click(sender, e);
                        break;
                    case 3:
                        index_btn = 0;
                        BtnVoltar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
                        BtnVoltar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
                        BtnVoltar_Click(sender, e);
                        break;
                    case 4:
                        index_btn = 0;
                        OPBUp._bordercolor = Color.Transparent;
                        OPBUp_Click(sender, e);
                        break;
                    case 5:
                        index_btn = 0;
                        opbEditarE1._bordercolor = Color.Transparent;
                        opbEditarE1_Click(sender, e);
                        break;
                    case 6:
                        index_btn = 0;
                        opbEditarE2._bordercolor = Color.Transparent;
                        opbEditarE2_Click(sender, e);
                        break;
                    case 7:
                        index_btn = 0;
                        OPBDown._bordercolor = Color.Transparent;
                        OPBDown_Click(sender, e);
                        break;
                    case 8:
                        index_btn = 0;
                        OPBLeft1._bordercolor = Color.Transparent;
                        OPBLeft1_Click_1(sender, e);
                        break;
                    case 9:
                        index_btn = 0;
                        opbEditarP11._bordercolor = Color.Transparent;
                        opbEditarP11_Click(sender, e);
                        break;
                    case 10:
                        index_btn = 0;
                        opbEditarP12._bordercolor = Color.Transparent;
                        opbEditarP12_Click(sender, e);
                        break;
                    case 11:
                        index_btn = 0;
                        opbEditarP13._bordercolor = Color.Transparent;
                        opbEditarP13_Click(sender, e);
                        break;
                    case 12:
                        index_btn = 0;
                        OPBRight1._bordercolor = Color.Transparent;
                        OPBRight1_Click(sender, e);
                        break;
                    case 13:
                        index_btn = 0;
                        OPBLeft2._bordercolor = Color.Transparent;
                        OPBLeft2_Click(sender, e);
                        break;
                    case 14:
                        index_btn = 0;
                        opbEditarP21._bordercolor = Color.Transparent;
                        opbEditarP21_Click(sender, e);
                        break;
                    case 15:
                        index_btn = 0;
                        opbEditarP22._bordercolor = Color.Transparent;
                        opbEditarP22_Click(sender, e);
                        break;
                    case 16:
                        index_btn = 0;
                        opbEditarP23._bordercolor = Color.Transparent;
                        opbEditarP23_Click(sender, e);
                        break;
                    case 17:
                        index_btn = 0;
                        OPBRight2._bordercolor = Color.Transparent;
                        OPBRight2_Click(sender, e);
                        break;
                    case 18:
                        index_btn = 0;
                        OPBConfiguracoes._bordercolor = Color.Transparent;
                        OPBConfiguracoes_Click(sender, e);
                        break;
                    case 19:
                        index_btn = 0;
                        OPBRecarregar._bordercolor = Color.Transparent;
                        OPBRecarregar_Click(sender, e);
                        break;
                    case 20:
                        index_btn = 0;
                        OPBLogout._bordercolor = Color.Transparent;
                        OPBLogout_Click(sender, e);
                        break;
                }

            }
        }
    }
}
