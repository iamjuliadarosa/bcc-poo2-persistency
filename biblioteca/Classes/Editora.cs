using Newtonsoft.Json;
using System;
namespace Biblioteca.Classes
{
    public class Editora
    {
        [JsonProperty("id")]
        public int EditoraID { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("endereco")]
        public string Endereco { get; set; }
    }
}
