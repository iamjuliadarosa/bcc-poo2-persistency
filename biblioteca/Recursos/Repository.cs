using Biblioteca.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Recursos {
    public class Repository {
        private static Repository? Instance { get; set; }
        public static Repository GetInstance(IBibliotecaRepository IBibliotecaRepository) {
            if (Instance == null) {
                Instance = new Repository(IBibliotecaRepository);
            }
            return Instance;
        }
        public static Repository GetInstance() {
            if (Instance == null) {
                throw new Exception("Não definida dependência da Persistência de Dados!");
            }
            return Instance;
        }

        public List<Livro> BuscaLivros(string search) {
            return IBibliotecaRepository.BuscaLivros(search);
        }

        public List<Autor> BuscaAutores(string search) {
            return IBibliotecaRepository.BuscaAutores(search);
        }

        public List<Editora> BuscaEditoras(string search) {
            return IBibliotecaRepository.BuscaEditoras(search);
        }

        private IBibliotecaRepository IBibliotecaRepository { get; set; }
        private Repository(IBibliotecaRepository iBibliotecaRepository) {
            IBibliotecaRepository = iBibliotecaRepository;
        }
    }
}
