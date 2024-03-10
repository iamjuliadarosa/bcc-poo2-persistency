using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Emprestimo
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("exemplar")]
        public Exemplar Exemplar { get; set; }

        [JsonProperty("cliente")]
        public Cliente Cliente { get; set; }

        [JsonProperty("dataEmprestimo")]
        public DateTime DataEmprestimo { get; set; }

        [JsonProperty("dataDevolucao")]
        public DateTime DataDevolucao { get; set; }

        [JsonProperty("devolvido")]
        public bool Devolvido { get; set; }
    }
}
