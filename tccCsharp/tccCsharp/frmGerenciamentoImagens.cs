using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tccCsharp
{
    public partial class frmGerenciamentoImagens : Form
    {
        public Head cabecalho = new Head();
        public Project projeto_editado = new Project();

        //public string arquivo;
        public frmGerenciamentoImagens()
        {
            InitializeComponent();
            
        }

        private void frmGerenciamentoImagens_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            DoDesign();
            projeto_editado = Banco.RecarregaSelecionado();
            AtualizaCabecalho();
            //ObterArquivos();
            pcbUpload.Visible = false;
        }

        private void AtualizaCabecalho()
        {
            cabecalho = Banco.CabecalhoProjeto();
            lblCriadoquando.Text = "Criado em  " + Convert.ToDateTime(cabecalho.criacao).ToShortDateString();
            lblCriador.Text = "Criador: " + cabecalho.criador_nome;
            lblAtualizadoquando.Text = "Atualizado em " + Convert.ToDateTime(cabecalho.atualizacao).ToShortDateString();
            lblAtualizador.Text = "Atualizador: " + cabecalho.atualizador_nome;
            lblPorcentagem.Text = cabecalho.porcentagem_int.ToString() + "%";
            lblNomeProjeto.Text = projeto_editado.nome_projeto;

            if (cabecalho.porcentagem_int == 100)
                groupPorcentagem2.Width = groupPorcentagem.Width;
            else
            {
                groupPorcentagem2.Width = Convert.ToInt32((Convert.ToDouble(groupPorcentagem.Width) / 100) * Convert.ToDouble(cabecalho.porcentagem_int));
                if (groupPorcentagem2.Width < 45)
                    groupPorcentagem2.Width = 45;
            }
        }

        private void ObterArquivos(string[] rota)
        {
            //string[] arquivos = Directory.GetFiles(rota); //, "*.jpg"); //MUDAR PARA OPEN FILE DIALOG
            //string[] arquivos = Directory.GetFiles(rota, "*.jpg, .png, .jpeg"); //MUDAR PARA OPEN FILE DIALOG
            
            
            for(int i = 0; i < rota.Length; i++) 
            {
                var pcbImagem = new PictureBox();
                pcbImagem.Size = new Size(150, 150);
                pcbImagem.SizeMode = PictureBoxSizeMode.Zoom;
                //pcbImagem.Image = Image.FromFile(arquivo); //MUDAR PARA OPEN FILE DIALOG???
                pcbImagem.Tag = rota[i];
                pcbImagem.Click += pcbUpload_Click;
                pcbImagem.ImageLocation = rota[i];

                lblStatus.Text = rota[i];
                lblStatus.Refresh();
                //flpImagens.Controls.Add(pcbImagem);
                flpUpload.Controls.Add(pcbImagem);


            } 

            //lblStatus.Text = $"{i} arquivos encontrados";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            /*var folderBrowser = new FolderBrowserDialog(); //MUDAR PARA OPEN FILE DIALOG

            if (folderBrowser.ShowDialog() == DialogResult.OK) //MUDAR PARA OPEN FILE DIALOG
            {
                ObterArquivos(folderBrowser.SelectedPath); //MUDAR PARA OPEN FILE DIALOG
            }*/

            var openFile = new OpenFileDialog(); //MUDAR PARA OPEN FILE DIALOG
            //openFile.Multiselect = true;
            if (openFile.ShowDialog() == DialogResult.OK) //MUDAR PARA OPEN FILE DIALOG
            {
                string sFileName = openFile.FileName;
                //lblTest.Text = sFileName;
                string[] arrAllFiles = openFile.FileNames;
                ObterArquivos(arrAllFiles); //MUDAR PARA OPEN FILE DIALOG
            }
        }

        private void pcbImagem_Click(object sender, EventArgs e)
        {
            
        }


        private void pcbUpload_Click(object sender, EventArgs e)
        {
            PictureBox pict = (PictureBox)sender;
            //string pictName = pict.Name;
            string arquivo = pict.Tag.ToString();
            //MessageBox.Show($"Picture {pictName} \nArquivo: {arquivo}");

            using (var frm = new frmImagem(arquivo))
            {
                frm.ShowDialog(); //tinha mexido aqui
            }
            
        }

        public void DoDesign()
        {
            tlpBase1.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            TLPInfoshead.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            //TXT
            txtDescricaoImg.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            txtNomeImagem.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            

            //LABELS
            lblTitulo.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblTitulo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            lblImagens.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            lblImagens.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblNomeProjeto.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);
            lblNomeProjeto.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            //BOTOES
            btnAtualizar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnAtualizar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnCancelar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnCancelar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnGerenciarColaboradores.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnGerenciarColaboradores.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnGerenciarEtapasP.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnGerenciarEtapasP.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnLimparForm.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnLimparForm.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnSairSSalvar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnSairSSalvar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            btnSalvar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnSalvar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            //COMPONENTES DE AGRUPAMENTO
            rgbDescricaoImg.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbDescricaoImg.BackColor = 

            rgbHeadImgs1.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            rgbHeadImgs1.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            TLPHead1.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            //rgbHeadImgs1.BackColor = 

            rgbHeadImgs2.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            //rgbHeadImgs2.BackColor = 
            TLPInfoshead.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);

            rgbImagensP.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbImagensP.BackColor = 
            flpImagens.BackColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);

            rgbNomeImagem.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbNomeImagem.BackColor = 

            rgbNomeP.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbNomeP.BackColor = 

            rgbOpcoes.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbOpcoes.BackColor = 
            tlpBaseOpcoes1.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            tlpBaseOpcoes2.BackColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);

            rgbUpload.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbUpload.BackColor = 
            pcbUpload.BackColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);

            //Porcentagem
            groupPorcentagem.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            groupPorcentagem.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            groupPorcentagem2.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);


        }

        
    }
}
