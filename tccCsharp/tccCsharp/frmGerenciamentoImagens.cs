using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Renci.SshNet;
using static System.Net.Mime.MediaTypeNames;

namespace tccCsharp
{
    public partial class frmGerenciamentoImagens : Form
    {
        public Head cabecalho = new Head();
        public Project projeto_editado = new Project();
        List<Photo> Imagens = new List<Photo>();
        bool EditandoImagem;
        System.Drawing.Image verifica;


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
            Imagens = Banco.CarregaImagens(Imagens);


            AtualizaCabecalho();
            //ObterArquivos();
            pcbUpload.Visible = true;
            
            for(int i = 0; i < Imagens.Count; i++)
            {
                CarregarImagem(Imagens[i]);
            }
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

        private void CarregarImagem(Photo img)
        {
            var pcbImagem = new PictureBox();
            pcbImagem.Size = new Size(150, 150);
            pcbImagem.SizeMode = PictureBoxSizeMode.Zoom;
            pcbImagem.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            pcbImagem.BorderStyle = BorderStyle.FixedSingle;
            pcbImagem.Tag = img;
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData(img.diretorio);
                    using (var stream = new System.IO.MemoryStream(imageBytes))
                    {
                        System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
                        pcbImagem.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
            }
            flpImagens.Controls.Add(pcbImagem);

            pcbImagem.Click += (sender, e) =>
            {

                PictureBox clickedPictureBox = sender as PictureBox;
                if (clickedPictureBox != null)
                {
                    object foto = clickedPictureBox.Tag;
                    if (foto is Photo photoObj)
                    {
                        EditandoImagem = true;
                        pcbUpload.Image = clickedPictureBox.Image;
                        pcbUpload.Tag = photoObj;
                        txtNomeImagem.Text = photoObj.nome;
                        txtDescricaoImg.Text = photoObj.descricao_imagem;
                        verifica = pcbImagem.Image;
                        if (photoObj.imagem_principal == true)
                        {
                            radSim.Checked = true;
                            radNao.Checked = false;
                        }
                        else
                        {
                            radSim.Checked = false;
                            radNao.Checked = true;
                        }
                    }
                }
            };
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog(); 
            if (openFile.ShowDialog() == DialogResult.OK) 
            {
                string selectedFileName = openFile.FileName;
                pcbUpload.ImageLocation = selectedFileName;
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
            btnSairSSalvar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnSairSSalvar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnSairSSalvar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnSairSSalvar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnSairSSalvar.AutoHoover = true;

            btnLimparForm.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnLimparForm.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnLimparForm.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnLimparForm.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnLimparForm.AutoHoover = true;

            btnSalvar.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnSalvar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnSalvar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnSalvar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnSalvar.AutoHoover = true;

            btnExcluir.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnExcluir.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnExcluir.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnExcluir.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnExcluir.AutoHoover = true;

            btnUpload.BorderColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);
            btnUpload.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            btnUpload.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnUpload.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            btnUpload.AutoHoover = true;

            //COMPONENTES DE AGRUPAMENTO
            rgbDescricaoImg.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbDescricaoImg.BackColor = 

            rgbHeadImgs1.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            rgbHeadImgs1.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            TLPHead1.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            //rgbHeadImgs1.BackColor = 

            TLPHead2.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            rgbHeadImgs2.ForeColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            rgbHeadImgs2.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            //rgbHeadImgs2.BackColor = 
            TLPInfoshead.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            TLPInfoshead.ForeColor = Color.FromArgb(Program.CorTexto1[0], Program.CorTexto1[1], Program.CorTexto1[2]);


            rgbImagensP.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbImagensP.BackColor = 
            flpImagens.BackColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);

            rgbNomeImagem.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbNomeImagem.BackColor = 

            rgbNomeP.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbNomeP.BackColor = 

            rgbOpcoes.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbOpcoes.BackColor = 

            rgbUpload.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            //rgbUpload.BackColor = 
            pcbUpload.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);

            //Porcentagem
            groupPorcentagem.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            groupPorcentagem.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            groupPorcentagem2.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);

            OPBLogout._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBConfiguracoes._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBRecarregar._bordercolor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            OPBConfiguracoes.AutoHoover = true;
            OPBRecarregar.AutoHoover = true;
            OPBLogout.AutoHoover = true;
            OPBConfiguracoes.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBRecarregar.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
            OPBLogout.BordaHoover = Color.FromArgb(Program.CorAviso1[0], Program.CorAviso1[1], Program.CorAviso1[2]);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (EditandoImagem == false)
            {
                if (String.IsNullOrEmpty(txtNomeImagem.Text) == true)
                {
                    customLine2.LineColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                    customLine2.Invalidate();
                    txtNomeImagem.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(txtDescricaoImg.Text) == true)
                {
                    customLine3.LineColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                    customLine3.Invalidate();
                    txtDescricaoImg.Focus();
                    return;
                }
                if (pcbUpload.Image == null)
                {
                    pcbUpload.BackColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                    return;
                }

                Photo Foto = new Photo();
                Foto.descricao_imagem = txtDescricaoImg.Text;
                Foto.nome = txtNomeImagem.Text;
                Foto.id_projeto = projeto_editado.id_projeto;
                if (radSim.Checked == true)
                {
                    Banco.AlteraPrincipal();
                    Foto.imagem_principal = true;
                }
                else
                {
                    Foto.imagem_principal = false;
                }
                Foto.diretorio = "Vazio";

                int IdImagem = Banco.InsereImagem(Foto);

                string localFilePath = pcbUpload.ImageLocation.ToString();
                string remoteFilePath = "/public_sites/matheussoares/imagens";
                string remoteServer = "200.145.153.91";
                string remoteUsername = "matheussoares";
                string remotePassword = "cti";


                try
                {
                    using (var sshClient = new ScpClient(remoteServer, remoteUsername, remotePassword))
                    {
                        sshClient.Connect();
                        if (sshClient.IsConnected)
                        {
                            using (var fileStream = System.IO.File.OpenRead(localFilePath))
                            {
                                sshClient.Upload(fileStream, remoteFilePath + "/Imagem" + IdImagem + ".jpg"); ;
                            }
                            MessageBox.Show("Upload concluído com sucesso!");
                            Banco.AlteraDiretorio(IdImagem, "http://200.145.153.91" + "/matheussoares/imagens/Imagem" + IdImagem + ".jpg");
                            Foto.diretorio = "http://200.145.153.91" + "/matheussoares/imagens/Imagem" + IdImagem + ".jpg";
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível conectar ao servidor remoto.");
                            Banco.DeleteImagem(IdImagem);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro durante o upload: " + ex.Message);
                    Banco.DeleteImagem(IdImagem);
                }

                txtNomeImagem.Text = string.Empty;
                txtDescricaoImg.Text = string.Empty;
                pcbUpload.Image = null;
                Imagens = Banco.CarregaImagens(Imagens);
                CarregarImagem(Foto);

            }
            else
            {
                if (String.IsNullOrEmpty(txtNomeImagem.Text) == true)
                {
                    customLine2.LineColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                    customLine2.Invalidate();
                    txtNomeImagem.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(txtDescricaoImg.Text) == true)
                {
                    customLine3.LineColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                    customLine3.Invalidate();
                    txtDescricaoImg.Focus();
                    return;
                }
                if (pcbUpload.Image == null)
                {
                    pcbUpload.BackColor = Color.FromArgb(Program.CorAviso2[0], Program.CorAviso2[1], Program.CorAviso2[2]);
                    return;
                }

                string descri = txtDescricaoImg.Text;
                string nome = txtNomeImagem.Text;
                bool principal;
                if (radSim.Checked == true)
                {
                    Banco.AlteraPrincipal();
                    principal = true;
                }
                else
                {
                    principal = false;
                }

                int idImagem = 0;
                object foto = pcbUpload.Tag;
                if (foto is Photo photoObj)
                {
                     idImagem = photoObj.id_imagem;
                }
                else
                {
                    MessageBox.Show("Tem alguma coisa errada sua mula");
                }

                if (verifica == pcbUpload.Image)//Imagem continua a mesma
                {
                    Banco.UpdateImagem(nome, descri, principal, idImagem);
                }
                else//Imagem mudou
                {
                    Banco.UpdateImagem(nome, descri, principal, idImagem);

                    string localFilePath = pcbUpload.ImageLocation.ToString();
                    string remoteFilePath = "/public_sites/matheussoares/imagens";
                    string remoteServer = "200.145.153.91";
                    string remoteUsername = "matheussoares";
                    string remotePassword = "cti";

                    try
                    {
                        using (var sshClient = new ScpClient(remoteServer, remoteUsername, remotePassword))
                        {
                            sshClient.Connect();
                            if (sshClient.IsConnected)
                            {
                                using (var fileStream = System.IO.File.OpenRead(localFilePath))
                                {
                                    sshClient.Upload(fileStream, remoteFilePath + "/Imagem" + idImagem + ".jpg"); 
                                }
                                MessageBox.Show("Upload concluído com sucesso!");
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível conectar ao servidor remoto.");
                                Banco.DeleteImagem(idImagem);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro durante o upload: " + ex.Message);
                        Banco.DeleteImagem(idImagem);
                    }
                }
                flpImagens.Controls.Clear();
                Imagens.Clear();
                Imagens = Banco.CarregaImagens(Imagens);
                for (int i = 0; i < Imagens.Count; i++)
                {
                    CarregarImagem(Imagens[i]);
                }
                EditandoImagem = false;
                pcbUpload.Image = null;
                txtDescricaoImg.Text = string.Empty;
                txtNomeImagem.Text = string.Empty;
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (EditandoImagem == true)
            {
                //exclui
                int idImagem = 0;
                object foto = pcbUpload.Tag;
                if (foto is Photo photoObj)
                {
                    idImagem = photoObj.id_imagem;
                    Banco.DeleteImagem(idImagem);
                    flpImagens.Controls.Clear();
                    Imagens.Clear();
                    Imagens = Banco.CarregaImagens(Imagens);
                    for (int i = 0; i < Imagens.Count; i++)
                    {
                        CarregarImagem(Imagens[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Tem alguma coisa errada sua mula");
                }

            }
            pcbUpload.Image = null;
            pcbUpload.Tag = null;
            txtDescricaoImg.Text = string.Empty;
            txtNomeImagem.Text = string.Empty;
            EditandoImagem = false;
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            pcbUpload.Image = null;
            pcbUpload.Tag = null;
            txtDescricaoImg.Text = string.Empty;
            txtNomeImagem.Text = string.Empty;
            EditandoImagem = false;
        }

        private void btnSairSSalvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OPBLogout_Click(object sender, EventArgs e)
        {
            Program.projetos.Clear();
            Program.id_usuario = 0;
            this.Close();
        }

        private void OPBConfiguracoes_Click(object sender, EventArgs e)
        {
            //apenas teste
            frmConfiguracoes formC = new frmConfiguracoes();
            formC.ShowDialog();

            /*frmPersonalizacao formP = new frmPersonalizacao();
            formP.ShowDialog();*/
        }

        private void OPBRecarregar_Click(object sender, EventArgs e)
        {
            DoDesign();
            flpImagens.Controls.Clear();
            Imagens.Clear();
            Imagens = Banco.CarregaImagens(Imagens);
            for (int i = 0; i < Imagens.Count; i++)
            {
                CarregarImagem(Imagens[i]);
            }
            EditandoImagem = false;
            pcbUpload.Image = null;
            txtDescricaoImg.Text = string.Empty;
            txtNomeImagem.Text = string.Empty;
            cabecalho = Banco.CabecalhoProjeto();
            AtualizaCabecalho();
        }
    }
}


/*private void ObterArquivos(string[] rota)
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
               flpImagens.Controls.Add(pcbImagem);
               //flpUpload.Controls.Add(pcbImagem);


           } 

           //lblStatus.Text = $"{i} arquivos encontrados";
       }*/