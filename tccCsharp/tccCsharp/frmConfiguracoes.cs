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
            //alterar a oartir daqui
            lblCor2.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblCor3.BackColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            lblCor4.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblCor5.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblCor6.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblCorAviso.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);

            //BOTÕES
            btnAltTamF.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnAltTamF.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnPersonalizar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnPersonalizar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnTutoriais.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnTutoriais.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
        }

        private void TamanhoFonte()
        {
            //nudFonte = new nudFonte();
            //nudFonte();
            //nudFonte.Value = ;

            //frmPersonalizacao formP = new frmPersonalizacao();
            nudFonte.Value = 12;
            nudFonte.Minimum = 12;
            nudFonte.Maximum = 18;
            //frmPerfil.DefaultFont.Size = num.value;
            if (nudFonte.Value == 18)
            {
                
                //frmPerfil.DefaultFont.Size = 13;

                //frmPerfil.DefaultFont.Size("Arial", 24);

                //frmPerfil.Default.Text.Size("Arial", 24);
                
                //this.Font = new Font("Arial", 18); //editar

                //frmPerfil.ControlFont = new Font("Arial", 24);
                //frmPerfil.setFont(new Font("Serif", Font.BOLD, 24));
                //frmPerfil(new Font("Serif", Font.BOLD, 24));

                //tlpBaseConfig1.Font = new Font("Arial", 18);


                //Program.Font = new Font("Arial", 24);
                //receber pparametro do combo box

                //control.font?
            }

        }



        private void btnAltTamFont_Click(object sender, EventArgs e)
        {
            
            
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

        private void lblCor1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void lblCor1_MouseEnter(object sender, EventArgs e)
        {

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

        private void lblCor2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void lblCor2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void lblCor1_MouseClick(object sender, MouseEventArgs e)
        {

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

        private void lblCor3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void lblCor2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lblCor3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void lblCor3_MouseClick(object sender, MouseEventArgs e)
        {

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

        private void lblCor4_MouseLeave(object sender, EventArgs e)
        {

        }

        private void lblCor4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void lblCor4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lblCorAviso_Click(object sender, EventArgs e)
        {

        }

        private void lblCorAviso_MouseLeave(object sender, EventArgs e)
        {

        }

        private void lblCorAviso_MouseEnter(object sender, EventArgs e)
        {

        }

        private void lblCorAviso_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void nudFonte_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAltTamF_Click(object sender, EventArgs e)
        {
            //n funciona
            /*frmPerfil form = new frmPerfil();
            form.Font = new Font("Arial", 28); *///n funciona

            //frmConfigs
            tlpBaseConfig1.Font = new Font("Arial", 24);
            tlpBaseConfig2.Font = new Font("Arial", 24);
            tlpBaseConfig3.Font = new Font("Arial", 24);
            tlpBaseConfig4.Font = new Font("Arial", 24);

            //frmPerfil
            /*TLP_Mae.Font = new Font("Arial", 24);
              TLP_Filha1.Font = new Font("Arial", 24);
              TLP_Filha2.Font = new Font("Arial", 24);
              TLP_Neta1.Font = new Font("Arial", 24);
              TLP_Neta2.Font = new Font("Arial", 24);
              TLPAvatar.Font = new Font("Arial", 24);
              TLPHead1.Font = new Font("Arial", 24);
              tlpOpcoes.Font = new Font("Arial", 24);
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



            //this.Font = new Font("Arial", 24); //editar
            //Program.Font = new Font("Arial", 24);
            //receber pparametro do combo box
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

        private void lblConfiguracoes_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTutoriais_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
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

        
        private void lblCor5_Click(object sender, EventArgs e)
        {

        }

        private void lblCor6_Click(object sender, EventArgs e)
        {

        }

        private void tlpBaseConfig4_Paint(object sender, PaintEventArgs e)
        {

        }
    }

        
}
