using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tccCsharp
{
    public class Step
    {
        public int id_etapa { get; set; }
        public int id_grupo { get; set; }
        public string nome_etapa { get; set; }
        public int peso { get; set; }
        public decimal porcentagem { get; set; }
        public string descricao_etapa { get; set; }
        public int status { get; set; }
        public int prioridade { get; set; }
        public int ordenador { get; set; }
        public string responsavel { get; set; }
        public string email_responsavel { get; set; }
        public bool impedimento { get; set; }
        public string descricao_impedimento { get; set; }
        public DateTime? data_criacao { get; set; }
        public DateTime? data_atualizacao { get; set; }
        public int atualizador { get; set; }
        public bool excluido { get; set; }
    }
}
