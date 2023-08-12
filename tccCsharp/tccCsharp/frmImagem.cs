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
    public partial class frmImagem : Form
    {
        public frmImagem(string arquivo)
        {
            InitializeComponent();

            //v joao
            //frmGerenciamentoImagens frmOrigem = new frmGerenciamentoImagens();
            //lbl1.Text = frmOrigem.arquivo;

            //PictureBox picImagem = new PictureBox();
            Text = arquivo;
            picImagem.Image = Image.FromFile(arquivo);
            //pcbUpload.Image = Image.FromFile(arquivo);
            //picImagem.Image = Image.FromFile(arquivo);
        }

        private void frmImagem_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnGerenciarImg_Click(object sender, EventArgs e)
        {
            frmGerenciamentoImagens frmGImagens = new frmGerenciamentoImagens();
            frmGImagens.ShowDialog();

            //frmGerenciamentoImagens(picImagem);
            
        }
    }
}
