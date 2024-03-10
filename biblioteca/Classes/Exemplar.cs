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
        [JsonProperty("numero")]
        public int Numero { get; set; }

        [JsonProperty("livro")]
        public Livro Livro { get; set; }

        [JsonProperty("disponivel")]
        public bool Disponivel { get; set; } = true;
    }
}
