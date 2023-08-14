using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tccCsharp
{
    public class Photo
    {
        public int id_imagem { get; set; }
        public int id_projeto { get; set; }
        public string diretorio { get; set; }
        public string nome { get; set; }
        public string descricao_imagem { get; set; }
        public bool imagem_principal { get; set; }
        public string status { get; set; }
    }
}
