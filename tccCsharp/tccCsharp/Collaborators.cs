﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tccCsharp
{
    public class Collaborators
    {
        public int idColaborador { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        public int avatar { get; set; }
        public bool isAdmin { get; set; }
    }
}
