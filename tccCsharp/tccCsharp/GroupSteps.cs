using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tccCsharp
{
    internal class GroupSteps
    {
        //id_grupo, id_projeto, nome_grupo, porcentagem, mostrar_porcentagem, ordenador, excluido, num_etpas
        public int id_grupo { get; set; }
        public int id_projeto { get; set; }
        public string nome_grupo { get; set; }
        public decimal porcentagem { get; set; }
        public bool mostrar_porcentagem { get; set; }
        public int ordenador { get; set; }
        public int numero_etapas { get; set; }
        public bool excluido { get; set; }

    }
}
