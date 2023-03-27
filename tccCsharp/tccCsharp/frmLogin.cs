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

namespace tccCsharp
{
    public  partial class  frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultados.Text = "";
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (string.IsNullOrWhiteSpace(email) == true)
            {
                lblResultados.Text += "Preencha o campo Email\n";
                return;
            }
            string senha = txtSenha.Text;
            if (string.IsNullOrWhiteSpace(senha) == true)
            {
                lblResultados.Text += "Preemcha o campo Senha\n";
                return;
            }
            Program.id_usuario = Banco.logar(email, senha);
            if(Program.id_usuario == 0)
            {
                lblResultados.Text += "E-mail ou Senha Incorreto(s), verifique !!!\n";
            }
            else if (Program.id_usuario == -1)
            {
                lblResultados.Text += "Ocorreu um erro ao logar no sistema.\n";
            }
            else
            {
                lblResultados.Text += "Login efetuado com succeso.\n";
                this.Close();
            }

        }
        
    }
}

