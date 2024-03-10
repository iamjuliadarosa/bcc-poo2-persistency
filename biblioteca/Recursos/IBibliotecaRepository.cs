using Biblioteca.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Recursos
{
    public interface IBibliotecaRepository
    {
        void InserirAutor(string nome, string email);
        void InserirEditora(string nome, string endereco);
        void InserirLivro(long isbn, string titulo, int autorID, int editoraID);
        void InserirExemplar(int numero, long isbn, bool disponivel);
        void InserirCliente(string nome, string email);
        void InserirEmprestimo(int exemplarNumero, int clienteID, DateTime dataEmprestimo, DateTime dataDevolucao, bool devolvido);

        void AtualizarAutor(int autorID, string nome, string email);
        void AtualizarEditora(int editoraID, string nome, string endereco);
        void AtualizarLivro(long isbn, string titulo, int autorID, int editoraID);
        void AtualizarExemplar(int numero, long isbn, bool disponivel);
        void AtualizarCliente(int clienteID, string nome, string email);
        void AtualizarEmprestimo(int emprestimoID, int exemplarNumero, int clienteID, DateTime dataEmprestimo, DateTime dataDevolucao, bool devolvido);

        void ExcluirAutor(int autorID);
        void ExcluirEditora(int editoraID);
        void ExcluirLivro(long isbn);
        void ExcluirExemplar(int numero);
        void ExcluirCliente(int clienteID);
        void ExcluirEmprestimo(int emprestimoID);

        public List<Livro> BuscaLivros(string search);
        public List<Autor> BuscaAutores(string search = null);
        public List<Editora> BuscaEditoras(string search = null);
        public void CreateEditora(Editora editora);
        public void CreateAutor(Autor autor);
        public void CreateLivro(Livro livro);
        public List<Exemplar> BuscaExemplares(long iSBN);
        public void CreateExemplares(long iSBN, int quantidade_novos_exemplares);
        public Exemplar BuscaExemplar(int codigo_exemplar);
        public void UpdateExemplar(Exemplar exemplar);
        public void CreateCliente(Cliente modelCliente);
        public List<Cliente> BuscaClientes(string busca);
    }
}
