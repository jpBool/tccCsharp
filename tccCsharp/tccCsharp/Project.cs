using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tccCsharp
{
    internal class Project
    {
        public int id_projeto { get; set; }
        public int id_criador { get; set; }
        public string autores { get; set; }
        public string email_contato { get; set; }
        public string nome_projeto { get; set; }
        public string palavras_chave { get; set; }
        public bool publico { get; set; }
        public string descricao_breve { get; set; }
        public string descricao_detalhada { get; set; }
        public string link_site { get; set; }
        public string link_youtube { get; set; }
        public int status { get; set; }
        public decimal porcentagem { get; set; }
        public string imagem { get; set; }
        public DateTime data_criacao { get; set; }
        public DateTime data_atualizacao { get; set; }
        public int atualizador { get; set; }
        public bool excluido { get; set; }
        public string linguagem { get; set; }

    }
}
