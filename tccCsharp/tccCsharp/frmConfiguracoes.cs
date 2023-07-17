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
            
            //LABELS
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

            //BOTÕES
            btnAltTamF.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnAltTamF.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnPersonalizar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnPersonalizar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnTutoriais.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
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

            }
        }
        private void lblCor5_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {

                Program.Cor5[0] = cldPersonalizacao.Color.R;
                Program.Cor5[1] = cldPersonalizacao.Color.G;
                Program.Cor5[2] = cldPersonalizacao.Color.B;

            }
        }

        private void lblCor6_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {

                Program.Cor6[0] = cldPersonalizacao.Color.R;
                Program.Cor6[1] = cldPersonalizacao.Color.G;
                Program.Cor6[2] = cldPersonalizacao.Color.B;

            }
        }

        private void lblCor7_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {

                Program.Cor7[0] = cldPersonalizacao.Color.R;
                Program.Cor7[1] = cldPersonalizacao.Color.G;
                Program.Cor7[2] = cldPersonalizacao.Color.B;

            }
        }

        private void lblCorAviso1_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                Program.CorAviso1[0] = cldPersonalizacao.Color.R;
                Program.CorAviso1[1] = cldPersonalizacao.Color.G;
                Program.CorAviso1[2] = cldPersonalizacao.Color.B;
            }
           
        }

        private void lblCorAviso2_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                Program.CorAviso2[0] = cldPersonalizacao.Color.R;
                Program.CorAviso2[1] = cldPersonalizacao.Color.G;
                Program.CorAviso2[2] = cldPersonalizacao.Color.B;
            }
            
        }

        private void lblCorTexto1_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                Program.CorTexto1[0] = cldPersonalizacao.Color.R;
                Program.CorTexto1[1] = cldPersonalizacao.Color.G;
                Program.CorTexto1[2] = cldPersonalizacao.Color.B;
            }
            
        }

        private void lblCorTexto2_Click(object sender, EventArgs e)
        {
            if (cldPersonalizacao.ShowDialog() == DialogResult.OK)
            {
                Program.CorTexto2[0] = cldPersonalizacao.Color.R;
                Program.CorTexto2[1] = cldPersonalizacao.Color.G;
                Program.CorTexto2[2] = cldPersonalizacao.Color.B;
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
            nudFonte.Visible = toggle;
            
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

        
    }
 
}
