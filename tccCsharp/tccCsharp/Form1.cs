﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Banco.conectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

//hayashi presente  oojjopoioiiooihiohoihioh