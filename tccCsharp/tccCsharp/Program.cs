using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace tccCsharp
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 
        public static int id_usuario = 2;
        public static List<Project> projetos = new List<Project>();
        public static List<Status> lista_status = new List<Status>();
        public static int id_projeto_atual = 0;
        //public static int id_projeto_atual = 23;

        public static int[] Cor1 = new int[3] { 0, 0, 0 };
        public static int[] Cor2 = new int[3] { 16, 39, 62 };
        public static int[] Cor3 = new int[3] { 54, 78, 101 };
        public static int[] Cor4 = new int[3] { 138, 182, 213 };
        public static int[] Cor5 = new int[3] { 170, 210, 229 };
        public static int[] Cor6 = new int[3] { 229, 241, 243 };
        public static int[] Cor7 = new int[3] { 255,255, 255 };

        public static int[] CorTexto1 = new int[3] { 0, 0, 0 };
        public static int[] CorTexto2 = new int[3] { 255, 255, 255 };

        public static int[] CorAviso1 = new int[3] { 204, 255, 51 };
        public static int[] CorAviso2 = new int[3] { 242, 92, 84 };

        public static int logo = 1;

        public static Font fonte = new Font("Microsoft Sans Serif", 12); //max 16 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SetarConfiguracoesIniciais();
            ResgataConfig();

            Application.Run(new frmLogin());

            
        }
        public static void ResgataConfig()
        {
            Cor1[0] = Properties.Settings.Default.Cor1.R;
            Cor1[1] = Properties.Settings.Default.Cor1.G;
            Cor1[2] = Properties.Settings.Default.Cor1.B;

            Cor2[0] = Properties.Settings.Default.Cor2.R;
            Cor2[1] = Properties.Settings.Default.Cor2.G;
            Cor2[2] = Properties.Settings.Default.Cor2.B;

            Cor3[0] = Properties.Settings.Default.Cor3.R;
            Cor3[1] = Properties.Settings.Default.Cor3.G;
            Cor3[2] = Properties.Settings.Default.Cor3.B;

            Cor4[0] = Properties.Settings.Default.Cor4.R;
            Cor4[1] = Properties.Settings.Default.Cor4.G;
            Cor4[2] = Properties.Settings.Default.Cor4.B;

            Cor5[0] = Properties.Settings.Default.Cor5.R;
            Cor5[1] = Properties.Settings.Default.Cor5.G;
            Cor5[2] = Properties.Settings.Default.Cor5.B;

            Cor6[0] = Properties.Settings.Default.Cor6.R;
            Cor6[1] = Properties.Settings.Default.Cor6.G;
            Cor6[2] = Properties.Settings.Default.Cor6.B;

            Cor7[0] = Properties.Settings.Default.Cor7.R;
            Cor7[1] = Properties.Settings.Default.Cor7.G;
            Cor7[2] = Properties.Settings.Default.Cor7.B;

            CorTexto1[0] = Properties.Settings.Default.CorTexto1.R;
            CorTexto1[1] = Properties.Settings.Default.CorTexto1.G;
            CorTexto1[2] = Properties.Settings.Default.CorTexto1.B;

            CorTexto2[0] = Properties.Settings.Default.CorTexto2.R;
            CorTexto2[1] = Properties.Settings.Default.CorTexto2.G;
            CorTexto2[2] = Properties.Settings.Default.CorTexto2.B;

            CorAviso1[0] = Properties.Settings.Default.CorAviso1.R;
            CorAviso1[1] = Properties.Settings.Default.CorAviso1.G;
            CorAviso1[2] = Properties.Settings.Default.CorAviso1.B;

            CorAviso2[0] = Properties.Settings.Default.CorAviso2.R;
            CorAviso2[1] = Properties.Settings.Default.CorAviso2.G;
            CorAviso2[2] = Properties.Settings.Default.CorAviso2.B;

            fonte = Properties.Settings.Default.fonte;

            logo = Properties.Settings.Default.logo;
        }

        public static void SetarConfiguracoesIniciais()
        {
            if (Properties.Settings.Default.Cor1 == Color.Transparent)
                Properties.Settings.Default.Cor1 = Color.FromArgb(0, 0, 0);

            if (Properties.Settings.Default.Cor2 == Color.Transparent)
                Properties.Settings.Default.Cor2 = Color.FromArgb(16, 39, 62);

            if (Properties.Settings.Default.Cor3 == Color.Transparent)
                Properties.Settings.Default.Cor3 = Color.FromArgb(54, 78, 101);

            if (Properties.Settings.Default.Cor4 == Color.Transparent)
                Properties.Settings.Default.Cor4 = Color.FromArgb(138, 182, 213);

            if (Properties.Settings.Default.Cor5 == Color.Transparent)
                Properties.Settings.Default.Cor5 = Color.FromArgb(170, 210, 229);

            if (Properties.Settings.Default.Cor6 == Color.Transparent)
                Properties.Settings.Default.Cor6 = Color.FromArgb(229, 241, 243);

            if (Properties.Settings.Default.Cor7 == Color.Transparent)
                Properties.Settings.Default.Cor7 = Color.FromArgb(255, 255, 255);

            if (Properties.Settings.Default.CorTexto1 == Color.Transparent)
                Properties.Settings.Default.CorTexto1 = Color.FromArgb(0, 0, 0);

            if (Properties.Settings.Default.CorTexto2 == Color.Transparent)
                Properties.Settings.Default.CorTexto2 = Color.FromArgb(255, 255, 255);

            if (Properties.Settings.Default.CorAviso1 == Color.Transparent)
                Properties.Settings.Default.CorAviso1 = Color.FromArgb(204, 255, 51);

            if (Properties.Settings.Default.CorAviso2 == Color.Transparent)
            { Properties.Settings.Default.CorAviso2 = Color.FromArgb(242, 92, 84); }

            if (Properties.Settings.Default.fonte == new Font("Microsoft Sans Serif", 12))
                Properties.Settings.Default.fonte = new Font("Microsoft Sans Serif", 12);
            
            if (Properties.Settings.Default.logo == 1)
            Properties.Settings.Default.logo = 1;

            // Salvar as alterações nas configurações
            Properties.Settings.Default.Save();
        }



    }

}
