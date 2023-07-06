using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
#pragma warning disable IDE1006

namespace tccCsharp
{
    public  partial class  frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblAviso.Visible = false; //aqui
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DesignLogin();
        }

        public void DesignLogin()
        {
            WindowState = FormWindowState.Maximized;
            rgbLogin.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblLogin.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblEmail.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblSenha.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            btnLogar.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblAviso.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblAviso.ForeColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);

            lblBoasVindas.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblBoasVindas.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblFacaLogin.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            lblFacaLogin.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
          
            tlpLoginBase.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            tlpLoginBase2.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            tlpLoginBase3.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (string.IsNullOrWhiteSpace(email) == true)
            {
                return;
            }
            string senha = txtSenha.Text;
            if (string.IsNullOrWhiteSpace(senha) == true)
            {
                return;
            }
            Program.id_usuario = Banco.Logar(email, senha);
            if (Program.id_usuario == 0)
            {
                //E-mail ou senha incorretos
                lblAviso.Visible = true; //aqui
                return;
            }
            else if (Program.id_usuario == -1)
            {
                //Aconteceu algum erro no banco
                return;
            }
            else
            {
                txtSenha.Clear();
                this.Visible = false;
                Program.projetos = Banco.CarregarProjetos(Program.projetos);
                frmPerfil splash = new frmPerfil();
                splash.ShowDialog();
                if (Program.id_usuario == 0)
                    this.Visible = true;
                else
                    this.Close();
            }
        }
    }
}

