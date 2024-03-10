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
        void InserirLivro(long isbn, string titulo, string nomeAutor, string nomeEditora);
        void InserirExemplar(int numero, long isbn, bool disponivel);
        void InserirCliente(string nome, string email);
        void InserirEmprestimo(int exemplarNumero, int clienteID, DateTime dataEmprestimo, DateTime dataDevolucao, bool devolvido);

        void AtualizarAutor(int autorID, string nome, string email);
        void AtualizarEditora(int editoraID, string nome, string endereco);
        void AtualizarLivro(long isbn, string titulo, string nomeAutor, string nomeEditora);
        void AtualizarExemplar(int numero, long isbn, bool disponivel);
        void AtualizarCliente(int clienteID, string nome, string email);
        void AtualizarEmprestimo(int emprestimoID, int exemplarNumero, int clienteID, DateTime dataEmprestimo, DateTime dataDevolucao, bool devolvido);

        void ExcluirAutor(int autorID);
        void ExcluirEditora(int editoraID);
        void ExcluirLivro(long isbn);
        void ExcluirExemplar(int numero);
        void ExcluirCliente(int clienteID);
        void ExcluirEmprestimo(int emprestimoID);

        Autor BuscarAutorPorNome(string nome);
        Editora BuscarEditoraPorNome(string nome);
        Cliente BuscarClientePorNome(string nome);
        public List<Livro> BuscaLivros(string search);
    }
}
