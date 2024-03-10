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
        private IBibliotecaRepository IBibliotecaRepository { get; set; }
        private Repository(IBibliotecaRepository iBibliotecaRepository) {
            IBibliotecaRepository = iBibliotecaRepository;
        }
        public List<Livro> BuscaLivros(string search) {
            return IBibliotecaRepository.BuscaLivros(search);
        }
        public List<Autor> BuscaAutores(string search = null) {
            return IBibliotecaRepository.BuscaAutores(search);
        }
        public List<Editora> BuscaEditoras(string search = null) {
            return IBibliotecaRepository.BuscaEditoras(search);
        }
        public void CreateEditora(Editora editora) {
            try {
                IBibliotecaRepository.CreateEditora(editora);
            } catch {
                throw;
            }
        }
        public void DeleteEditora(Editora editora) {
            try {
                IBibliotecaRepository.ExcluirEditora(editora.EditoraID);
            } catch {
                throw;
            }
        }
        public void DeleteAutor(Autor autor) {
            try {
                IBibliotecaRepository.ExcluirAutor(autor.ID);
            } catch {
                throw;
            }
        }

        public void CreateAutor(Autor autor) {
            try {
                IBibliotecaRepository.CreateAutor(autor);
            } catch {
                throw;
            }
        }

        public void DeleteLivro(Livro Livro) {
            try {
                IBibliotecaRepository.ExcluirLivro(Livro.ISBN);
            } catch {
                throw;
            }
        }

        public void CreateLivro(Livro livro) {
            try {
                IBibliotecaRepository.CreateLivro(livro);
            } catch {
                throw;
            }
        }

        public List<Exemplar> BuscaExemplares(long iSBN) {
            return IBibliotecaRepository.BuscaExemplares(iSBN);
        }
    }
}
