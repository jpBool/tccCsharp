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
    public partial class frmEtapas : Form
    {
        public frmEtapas()
        {
            InitializeComponent();
        }

        public void DoDesign()
        {
            TLPHead1.BackColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.BackgroundColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            RGBHead1.ForeColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            lblTitulo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);

            TLPHead2.BackColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBHead2.BackgroundColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);
            RGBHead2.ForeColor = Color.FromArgb(Program.Cor4[0], Program.Cor4[1], Program.Cor4[2]);

            groupPorcentagem.BackgroundColor = Color.FromArgb(Program.Cor7[0], Program.Cor7[1], Program.Cor7[2]);
            groupPorcentagem.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);
            groupPorcentagem2.BackgroundColor = Color.FromArgb(Program.Cor3[0], Program.Cor3[1], Program.Cor3[2]);
            groupPorcentagem2.ForeColor = Color.FromArgb(Program.Cor1[0], Program.Cor1[1], Program.Cor1[2]);

            TLPConteudo.BackColor = Color.FromArgb(Program.Cor6[0], Program.Cor6[1], Program.Cor6[2]);

            btnADDEtapa.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            BtnADDGrupo.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            BtnVoltar.ForeColor = Color.FromArgb(Program.CorTexto2[0], Program.CorTexto2[1], Program.CorTexto2[2]);
            btnADDEtapa.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            BtnADDGrupo.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);
            BtnVoltar.ButtonColor = Color.FromArgb(Program.Cor2[0], Program.Cor2[1], Program.Cor2[2]);

            GPBEtapa11.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBEtapa12.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBEtapa13.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBEtapa21.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBEtapa22.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBEtapa23.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBGrupo1.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
            GPBGrupo2.BackgroundColor = Color.FromArgb(Program.Cor5[0], Program.Cor5[1], Program.Cor5[2]);
        }

            private void frmEtapas_Load(object sender, EventArgs e)
        {
            DoDesign();
        }
    }
}
