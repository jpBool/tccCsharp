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
            if(Program.id_usuario == 0)
            {
                //E-mail ou senha incorretos
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
        }

        
    }
}

