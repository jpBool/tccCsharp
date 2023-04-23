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
            Program.id_usuario = Banco.logar(email, senha);
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
            WindowState = FormWindowState.Maximized;

            
            groupBox1.Text = "";
            groupBox1.CornerRadius = 20;
            groupBox1.Size = new Size(200, 100);
            groupBox1.Location = new Point(10, 10);
            groupBox1.BackgroundColor = Color.LightBlue;
            groupBox1.BorderWidth = 2.0f;

            this.Controls.Add(groupBox1);
        }




    }
}

