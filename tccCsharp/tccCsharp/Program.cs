﻿using System;
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

        public static int[] Cor1 = new int[3] { 10, 6, 34 };
        public static int[] Cor2 = new int[3] { 138, 182, 213 };
        public static int[] Cor3 = new int[3] { 229, 241, 243 };
        public static int[] Cor4 = new int[3] { 187, 225, 243 };
        public static int[] Cor5 = new int[3] { 36, 42, 62 };
        public static int[] CorTexto1 = new int[3] { 0, 0, 0 };
        public static int[] CorTexto2 = new int[3] { 255, 255, 255 };

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmLogin());
            Application.Run(new frmPerfil());
        }

    }
}
