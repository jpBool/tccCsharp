using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tccCsharp
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 
        public static int id_usuario = 0;
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

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmLogin());
            //Application.Run(new frmPersonalizacao());

            
        }

        public static void AlteraIcones()
        {
           
        }



    }

}
