﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
#pragma warning disable IDE1006

//using System.Windows.Controls;

namespace tccCsharp
{
    public partial class frmConfiguracoes : Form
    {
        public bool toggle = false;
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void frmConfiguracoes_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            //cldPersonalizacao = new ColorDialog();
            //cldPersonalizacao = new ColorDialog()
            //;
            //frmConfiguracoes.BackgroundColor
            if (Program.logo == 0)
            {
                radPreto.Checked = true;
                radBranco.Checked = false;
            }
            else
            {
                radPreto.Checked = false;
                radBranco.Checked = true;
            }
            DoDesign();
        }

        public void DoDesign()
        {
            //COMPONENTES DE AGRUPAMENTO
            tlpBaseConfig1.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            rgbMenu.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            rgbMenu.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            
            //LABELS DE COR
            lblCor1.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblCor2.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblCor3.BackColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            lblCor4.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblCor5.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            lblCor6.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            lblCor7.BackColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            lblCorAviso1.BackColor = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            lblCorAviso2.BackColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
            lblCorTexto1.BackColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblCorTexto2.BackColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            //OUTRAS LABELS
            lblConfigsG.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblConfiguracoes.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblCoresElementos.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblCoresTexto.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblCoresAviso.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblPCores.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);

            //BOTÕES
            btnAltTamF.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnAltTamF.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnAltTamF.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnAltTamF.AutoHoover = true;


            btnPersonalizar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnPersonalizar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnPersonalizar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnPersonalizar.AutoHoover = true;

            btnTutoriais.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnTutoriais.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnTutoriais.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnTutoriais.AutoHoover = true;

            btnVoltar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnVoltar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnVoltar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnVoltar.AutoHoover = true;

            btnRestaurarPadrao.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnRestaurarPadrao.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnRestaurarPadrao.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnRestaurarPadrao.AutoHoover = true;

            OPBLogout._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBLogout.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBLogout.AutoHoover = true;

            opbRecarregar._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            opbRecarregar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            opbRecarregar.AutoHoover = true;

            /////volta os botoes ao normal:

            btnAltTamF.BordaPrincipal = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            btnAltTamF.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnPersonalizar.BordaPrincipal = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            btnPersonalizar.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnTutoriais.BordaPrincipal = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            btnTutoriais.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnVoltar.BordaPrincipal = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            btnVoltar.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnRestaurarPadrao.BordaPrincipal = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            btnRestaurarPadrao.TextoPrincipal = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            OPBLogout.BordaPrincipal = Color.Transparent;           
            opbRecarregar.BordaPrincipal = Color.Transparent;

            Logo(Program.logo);
        }


        private void btnPersonalizacao_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnPersonalizacao_Click(object sender, EventArgs e)
        {

            
        }

        private void btnPersonalizacao_MouseLeave(object sender, EventArgs e)
        {

        }

        private void lblCor1_Click(object sender, EventArgs e)
        {
            //background superior azul escuro
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                Program.Cor1[0] = cldPersonalizacao.Color.R;
                Program.Cor1[1] = cldPersonalizacao.Color.G;
                Program.Cor1[2] = cldPersonalizacao.Color.B;
                lblCor1.BackColor = cldPersonalizacao.Color;
            }

        }

        private void lblCor2_Click(object sender, EventArgs e)
        {
            //cores internas dos cards e outros elementos internos lavanda(azul ameno)
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                Program.Cor2[0] = cldPersonalizacao.Color.R;
                Program.Cor2[1] = cldPersonalizacao.Color.G;
                Program.Cor2[2] = cldPersonalizacao.Color.B;
                lblCor2.BackColor = cldPersonalizacao.Color;
            }
        }
        private void lblCor3_Click(object sender, EventArgs e)
        {
            //background inferior branco
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {

                Program.Cor3[0] = cldPersonalizacao.Color.R;
                Program.Cor3[1] = cldPersonalizacao.Color.G;
                Program.Cor3[2] = cldPersonalizacao.Color.B;
                lblCor3.BackColor = cldPersonalizacao.Color;
            }
        }
        private void lblCor4_Click(object sender, EventArgs e)
        {
            //cores dos cards azul claro
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                Program.Cor4[0] = cldPersonalizacao.Color.R;
                Program.Cor4[1] = cldPersonalizacao.Color.G;
                Program.Cor4[2] = cldPersonalizacao.Color.B;
                lblCor4.BackColor = cldPersonalizacao.Color;
            }
        }
        private void lblCor5_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {

                Program.Cor5[0] = cldPersonalizacao.Color.R;
                Program.Cor5[1] = cldPersonalizacao.Color.G;
                Program.Cor5[2] = cldPersonalizacao.Color.B;
                lblCor5.BackColor = cldPersonalizacao.Color;
            }
        }

        private void lblCor6_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {

                Program.Cor6[0] = cldPersonalizacao.Color.R;
                Program.Cor6[1] = cldPersonalizacao.Color.G;
                Program.Cor6[2] = cldPersonalizacao.Color.B;
                lblCor6.BackColor = cldPersonalizacao.Color;
            }
        }

        private void lblCor7_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {

                Program.Cor7[0] = cldPersonalizacao.Color.R;
                Program.Cor7[1] = cldPersonalizacao.Color.G;
                Program.Cor7[2] = cldPersonalizacao.Color.B;
                lblCor7.BackColor = cldPersonalizacao.Color;
            }
        }

        private void lblCorAviso1_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                Program.CorAviso1[0] = cldPersonalizacao.Color.R;
                Program.CorAviso1[1] = cldPersonalizacao.Color.G;
                Program.CorAviso1[2] = cldPersonalizacao.Color.B;
                lblCorAviso1.BackColor = cldPersonalizacao.Color;
            }
           
        }

        private void lblCorAviso2_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                Program.CorAviso2[0] = cldPersonalizacao.Color.R;
                Program.CorAviso2[1] = cldPersonalizacao.Color.G;
                Program.CorAviso2[2] = cldPersonalizacao.Color.B;
                lblCorAviso1.BackColor = cldPersonalizacao.Color;
            }
            
        }

        private void lblCorTexto1_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                Program.CorTexto1[0] = cldPersonalizacao.Color.R;
                Program.CorTexto1[1] = cldPersonalizacao.Color.G;
                Program.CorTexto1[2] = cldPersonalizacao.Color.B;
                lblCorTexto1.BackColor = cldPersonalizacao.Color;
            }
            
        }

        private void lblCorTexto2_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                Program.CorTexto2[0] = cldPersonalizacao.Color.R;
                Program.CorTexto2[1] = cldPersonalizacao.Color.G;
                Program.CorTexto2[2] = cldPersonalizacao.Color.B;
                lblCorTexto2.BackColor = cldPersonalizacao.Color;
            }

        }

        private void btnAltTamF_Click(object sender, EventArgs e)
        {
            //Matheus ->
            FontDialog fd = new FontDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            {

                Font Nova = new Font("Microsoft Sans Serif", 12);

                if (fd.Font.Size > 36 /*    fd.Font.Height > X  */)//Verifica se é mt grande 
                {
                    Nova = new Font(fd.Font.FontFamily, 12, fd.Font.Style);
                }
                else
                {
                    Nova = fd.Font;
                }
                Program.fonte = Nova;


                // No doDesign de cada form: TLP_Mãe.Font = Program.fonte;
                //  (fiz no frmPerfil, funciona quase totalmente)

                tlpBaseConfig1.Font = fd.Font;
                tlpBaseConfig2.Font = fd.Font;
                tlpBaseConfig3.Font = fd.Font;
                tlpBaseConfig4.Font = fd.Font;

                lblConfigsG.Font = fd.Font;
                lblConfiguracoes.Font = fd.Font;
            }


            toggle = !toggle;
            //nudFonte.Visible = toggle;
            
        }

        private void btnPersonalizar_Click(object sender, EventArgs e)
        {
            //frmPersonalizacao formP = new frmPersonalizacao();
            //formP.ShowDialog();

            //NÃO APAGAR O TRECHO ABAIXO
            /*if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                //background superior azul escuro
                Program.Cor1[0] = cldPersonalizacao.Color.R; 
                Program.Cor1[1] = cldPersonalizacao.Color.G;
                Program.Cor1[2] = cldPersonalizacao.Color.B;

                //cores internas dos cards e outros elementos internos lavanda(azul ameno)
                Program.Cor2[0] = cldPersonalizacao.Color.R;
                Program.Cor2[1] = cldPersonalizacao.Color.G;
                Program.Cor2[2] = cldPersonalizacao.Color.B;

                //background inferior branco
                Program.Cor3[0] = cldPersonalizacao.Color.R;
                Program.Cor3[1] = cldPersonalizacao.Color.G;
                Program.Cor3[2] = cldPersonalizacao.Color.B;

                //cores dos cards azul claro
                Program.Cor4[0] = cldPersonalizacao.Color.R;
                Program.Cor4[1] = cldPersonalizacao.Color.G;
                Program.Cor4[2] = cldPersonalizacao.Color.B;
                  
                //Não estao sendo usados 
                Program.Cor5[0] = cldPersonalizacao.Color.R;
                Program.Cor5[1] = cldPersonalizacao.Color.G;
                Program.Cor5[2] = cldPersonalizacao.Color.B;

                Program.Cor6[0] = cldPersonalizacao.Color.R;
                Program.Cor6[1] = cldPersonalizacao.Color.G;
                Program.Cor6[2] = cldPersonalizacao.Color.B;

                //colocar cor do texto e aviso tbm?

            }
            */
            //rgbPCores.Visible= true;
            toggle = !toggle;
            rgbPCores.Visible = toggle;
        }

        private void opbRecarregar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblConfiguracoes_Click(object sender, EventArgs e)
        {

        }

        private void btnTutoriais_Click(object sender, EventArgs e)
        {
            Process.Start("https://chat.openai.com/c/15dd028c-3306-4a87-bb70-9351762c50e1");
            //subtituir link
        }

        private void OPBLogout_Click(object sender, EventArgs e)
        {

        }

        private void tlpBaseConfig2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpBaseConfig3_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rgbPCores_Enter(object sender, EventArgs e)
        {

        }

        private void tlpBaseConfig4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCorAviso_Click(object sender, EventArgs e)
        {

        }

        private void lblCoresAviso_Click(object sender, EventArgs e)
        {

        }

        private void lblConfigsG_Click(object sender, EventArgs e)
        {

        }

        private void lblPCores_Click(object sender, EventArgs e)
        {

        }

        private void lblIconePreto_Click(object sender, EventArgs e)
        {
            //AlteraIcones()
        }

        private void btnRestaurarPadrao_Click(object sender, EventArgs e)
        {
            

            Program.Cor1[0] = 0;  //{ 0, 0, 0 };
            Program.Cor1[1] = 0;
            Program.Cor1[2] = 0;

            Program.Cor2[0] = 16;  //{ 16, 39, 62 };
            Program.Cor2[1] = 39;
            Program.Cor2[2] = 62;

            Program.Cor3[0] = 54;  //{ 54, 78, 101 };
            Program.Cor3[1] = 78;
            Program.Cor3[2] = 101;

            Program.Cor4[0] = 138;   //{ 138, 182, 213 };
            Program.Cor4[1] = 182;
            Program.Cor4[2] = 213;

            Program.Cor5[0] = 170;  //{ 170, 210, 229 };
            Program.Cor5[1] = 210;
            Program.Cor5[2] = 229;

            Program.Cor6[0] = 229;  //{ 229, 241, 243 };
            Program.Cor6[1] = 241;
            Program.Cor6[2] = 243;

            Program.Cor7[0] = 255;  //{ 255,255, 255 };
            Program.Cor7[1] = 255;
            Program.Cor7[2] = 255;

            //////////////CORES DE TEXTO E AVISO/////////////////
            

            Program.CorTexto1[0] = 0;   
            Program.CorTexto1[1] = 0;
            Program.CorTexto1[2] = 0;

            Program.CorTexto2[0] = 255;  
            Program.CorTexto2[1] = 255;
            Program.CorTexto2[2] = 255;

            /////

            Program.CorAviso1[0] = 204;   //{ 204, 255, 51 };
            Program.CorAviso1[1] = 255;
            Program.CorAviso1[2] = 51;

            Program.CorAviso2[0] = 242;   //{ 242, 92, 84 };
            Program.CorAviso2[1] = 92;
            Program.CorAviso2[2] = 84;


            Program.logo = 1;
            ///////////////////ÍCONES E LOGO/////////////////////


        }

        private void radPreto_CheckedChanged(object sender, EventArgs e)
        {
            if (radPreto.Checked == true)
            {
                Program.logo = 0;
                OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_Black;
                opbRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_Black;
               
            }
        }

        private void radBranco_CheckedChanged(object sender, EventArgs e)
        {
            if (radBranco.Checked == true)
            {
                Program.logo = 1;
                OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_White;
                opbRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_White;
                
            }
                
        }

        public void Logo(int logo)
        {
            switch(logo)
            {
                case 0: opbLogo.Image = global::tccCsharp.Properties.Resources.Logo_White2; 
                        OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_Black; 
                        opbRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_Black;
                        
                        break;

                case 1:
                        opbLogo.Image = global::tccCsharp.Properties.Resources.Logo_Black2; 
                        OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_White;
                        opbRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_White;
                       
                        break;
            }
        }
    }
 
}
