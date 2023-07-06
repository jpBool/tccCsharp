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
            lblCor1.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            //alterar a oartir daqui
            lblCor2.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblCor3.BackColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            lblCor4.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblCor5.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblCor6.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            lblCorAviso.BackColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            btnAltTamF.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnPersonalizar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
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
    }

        
}
