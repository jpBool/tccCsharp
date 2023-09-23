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
            btnAltTamF.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnPersonalizar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnPersonalizar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnTutoriais.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnTutoriais.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnVoltar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnVoltar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnPersonalizar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnAltTamF.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnTutoriais.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
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
            FontDialog fd = new FontDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            {
                //frmPerfil.Font = fd.Font; //frms n possuem a definicao .Font??
                //Program.Font = fd.Font; //program n contem uma definicao p .font

                //frmConfigs
                tlpBaseConfig1.Font = fd.Font;
                tlpBaseConfig2.Font = fd.Font;
                tlpBaseConfig3.Font = fd.Font;
                tlpBaseConfig4.Font = fd.Font;
                //teste
                lblConfigsG.Font = fd.Font;
                lblConfiguracoes.Font = fd.Font;

                //frmPerfil
                /*TLP_Mae.Font = fd.Font;
                  TLP_Filha1.Font = fd.Font;
                  TLP_Filha2.Font = fd.Font;
                  TLP_Neta1.Font = fd.Font;
                  TLP_Neta2.Font = fd.Font;
                  TLPAvatar.Font = fd.Font;
                  TLPHead1.Font = fd.Font;
                  tlpOpcoes.Font = fd.Font;
                */

                //frmLogin
                /*
                */

                //frmCriar_Projeto
                /*
                */

                //frmEditar_Projeto
                /*
                */
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
            //visible false
            //lblPCores.Visible = false;
            //lblCoresElementos.Visible = false;
           // lblCoresTexto.Visible = false;
           // lblCoresAviso.Visible = false;
           // lblTrocaIcones.Visible = false;

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
            /*
            //COMPONENTES DE AGRUPAMENTO
            this.tlpBaseConfig1.BackColor = Color.FromArgb(229, 241, 243);
            this.rgbMenu.BackgroundColor = Color.FromArgb(16, 39, 62);
            this.rgbMenu.BackColor = Color.FromArgb(16, 39, 62);

            //LABELS DE COR
            lblCor1.BackColor = Color.FromArgb(0, 0, 0);
            lblCor2.BackColor = Color.FromArgb(16, 39, 62);
            lblCor3.BackColor = Color.FromArgb(54, 78, 101);
            lblCor4.BackColor = Color.FromArgb(138, 182, 213);
            lblCor5.BackColor = Color.FromArgb(170, 210, 229);
            lblCor6.BackColor = Color.FromArgb(229, 241, 243);
            lblCor7.BackColor = Color.FromArgb(255, 255, 255);
            lblCorAviso1.BackColor = Color.FromArgb(204, 255, 51);
            lblCorAviso2.BackColor = Color.FromArgb(242, 92, 84);
            lblCorTexto1.BackColor = Color.FromArgb(0, 0, 0);
            lblCorTexto2.BackColor = Color.FromArgb(255, 255, 255);

            //OUTRAS LABELS
            lblConfigsG.ForeColor = Color.FromArgb(0, 0, 0);
            lblConfiguracoes.ForeColor = Color.FromArgb(0, 0, 0);
            lblCoresElementos.ForeColor = Color.FromArgb(0, 0, 0);
            lblCoresTexto.ForeColor = Color.FromArgb(0, 0, 0);
            lblCoresAviso.ForeColor = Color.FromArgb(0, 0, 0);
            lblPCores.ForeColor = Color.FromArgb(0, 0, 0);

            //BOTÕES
            btnAltTamF.ButtonColor = Color.FromArgb(16, 39, 62);
            btnAltTamF.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnPersonalizar.ButtonColor = Color.FromArgb(16, 39, 62);
            btnPersonalizar.ForeColor = Color.FromArgb( 255, 255, 255);
            btnTutoriais.ButtonColor = Color.FromArgb(16, 39, 62);
            btnTutoriais.ForeColor = Color.FromArgb(255, 255, 255);
            btnVoltar.ButtonColor = Color.FromArgb(16, 39, 62);
            btnVoltar.ForeColor = Color.FromArgb(255, 255, 255);
            btnPersonalizar.ForeColor = Color.FromArgb(255, 255, 255);
            btnAltTamF.ForeColor = Color.FromArgb(255, 255, 255);
            btnTutoriais.ForeColor = Color.FromArgb( 255, 255, 255);
            */

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

            


        }

        private void radPreto_CheckedChanged(object sender, EventArgs e)
        {
            if (radPreto.Checked == true)
            {
                Program.logo = 0;
                OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_Black;
                opbRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_Black;
                opbConfiguracoes.Image = global::tccCsharp.Properties.Resources.Config_Black;
            }
        }

        private void radBranco_CheckedChanged(object sender, EventArgs e)
        {
            if (radBranco.Checked == true)
            {
                Program.logo = 1;
                OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_White;
                opbRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_White;
                opbConfiguracoes.Image = global::tccCsharp.Properties.Resources.Config_White;
            }
                
        }

        public void Logo(int logo)
        {
            switch(logo)
            {
                case 0: opbLogo.Image = global::tccCsharp.Properties.Resources.Logo_White2; //mudar img
                        OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_Black; 
                        opbRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_Black;
                        opbConfiguracoes.Image = global::tccCsharp.Properties.Resources.Config_Black;
                        break;

                case 1:
                        opbLogo.Image = global::tccCsharp.Properties.Resources.Logo_Black2; //mudar img
                        OPBLogout.Image = global::tccCsharp.Properties.Resources.Logout_White;
                        opbRecarregar.Image = global::tccCsharp.Properties.Resources.Refresh_White;
                        opbConfiguracoes.Image = global::tccCsharp.Properties.Resources.Config_White;
                        break;
            }
        }
    }
 
}
