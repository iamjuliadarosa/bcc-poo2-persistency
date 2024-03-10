using Newtonsoft.Json;
using System;

namespace Biblioteca.Classes
{
    public class Livro
    {
        [JsonProperty("isbn")]
        public long ISBN { get; set; }

        [JsonProperty("titulo")]
        public string Titulo { get; set; }

        [JsonProperty("autor")]
        public Autor Autor { get; set; }

        [JsonProperty("editora")]
        public Editora Editora { get; set; }
    }
}
