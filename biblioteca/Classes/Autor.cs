using Newtonsoft.Json;
using System;

namespace Biblioteca.Classes
{
    public class Autor
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
