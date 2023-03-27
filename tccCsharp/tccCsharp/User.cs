﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tccCsharp
{
    internal class User
    {
        public int id_usuario { get; set; }
        public string name { get; set; }
        public string bio { get; set; }
        public int avatar { get; set; }
        public string naturalidade { get; set; }
        public DateTime nascimento { get; set; }
        public DateTime inscricao { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string telefone { get; set; }
        public string commits { get; set; }
        public bool excluido { get; set; }


    }
}
