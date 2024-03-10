using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Exemplar
    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; }
        [JsonProperty("numero")]
        public int Numero { get; set; }

        [JsonProperty("livro")]
        public long ISBN { get; set; }

        [JsonProperty("disponivel")]
        public bool Disponivel { get; set; }

        [JsonProperty("tipo")]
        public bool Tipo { get; set; }
    }
}
