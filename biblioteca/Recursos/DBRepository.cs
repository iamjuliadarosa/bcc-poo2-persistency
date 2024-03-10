using Biblioteca.Classes;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Biblioteca.Recursos {
    public class DBRepository : IBibliotecaRepository {
        private MySqlConnection connection;
        private string host = "187.85.164.154";
        private string database = "darosadev_services_db";
        private string user = "darosadev_tests";
        private string password = "9W27iu*'QT<u";
        public DBRepository() {
            connection = new MySqlConnection($"server={host};User Id={user};database={database}; password={password}");
            Open();
        }
        private void Open() {
            if (connection.State != System.Data.ConnectionState.Open) {
                connection.Open();
            }
        }
        public void InserirAutor(string nome, string email) {
            string query = "INSERT INTO Autor (Nome, Email) VALUES (@Nome, @Email)";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Email", email);

                command.ExecuteNonQuery();
            }
        }

        public void InserirEditora(string nome, string endereco) {
            string query = "INSERT INTO Editora (Nome, Endereco) VALUES (@Nome, @Endereco)";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Endereco", endereco);

                command.ExecuteNonQuery();
            }
        }

        public void InserirLivro(long isbn, string titulo, int autorID, int editoraID) {

            string query = "INSERT INTO Livro (ISBN, Titulo, AutorID, EditoraID) VALUES (@ISBN, @Titulo, @AutorID, @EditoraID)";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@ISBN", isbn);
                command.Parameters.AddWithValue("@Titulo", titulo);
                command.Parameters.AddWithValue("@AutorID", autorID);
                command.Parameters.AddWithValue("@EditoraID", editoraID);

                command.ExecuteNonQuery();
            }
        }

        public void InserirExemplar(int numero, long isbn, bool disponivel) {
            int livroID = ObterID("Livro", "ISBN", isbn);
            string query = "INSERT INTO Exemplar (Numero, LivroISBN, Disponivel) VALUES (@Numero, @LivroISBN, @Disponivel)";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@Numero", numero);
                command.Parameters.AddWithValue("@LivroISBN", isbn);
                command.Parameters.AddWithValue("@Disponivel", disponivel);

                command.ExecuteNonQuery();
            }
        }

        public void InserirCliente(string nome, string email) {
            string query = "INSERT INTO Cliente (Nome, Email) VALUES (@Nome, @Email)";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Email", email);

                command.ExecuteNonQuery();
            }
        }

        public void InserirEmprestimo(int exemplarNumero, int clienteID, DateTime dataEmprestimo, DateTime dataDevolucao, bool devolvido) {
            int exemplarID = ObterID("Exemplar", "Numero", exemplarNumero);

            string query = "INSERT INTO Emprestimo (ExemplarNumero, ClienteID, DataEmprestimo, DataDevolucao, Devolvido) " +
                           "VALUES (@ExemplarNumero, @ClienteID, @DataEmprestimo, @DataDevolucao, @Devolvido)";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@ExemplarNumero", exemplarNumero);
                command.Parameters.AddWithValue("@ClienteID", clienteID);
                command.Parameters.AddWithValue("@DataEmprestimo", dataEmprestimo);
                command.Parameters.AddWithValue("@DataDevolucao", dataDevolucao);
                command.Parameters.AddWithValue("@Devolvido", devolvido);

                command.ExecuteNonQuery();
            }
        }
        public void AtualizarAutor(int autorID, string nome, string email) {
            Open();

            string query = "UPDATE Autor SET Nome = @Nome, Email = @Email WHERE AutorID = @AutorID";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@AutorID", autorID);

                command.ExecuteNonQuery();
            }
        }

        public void AtualizarEditora(int editoraID, string nome, string endereco) {
            Open();

            string query = "UPDATE Editora SET Nome = @Nome, Endereco = @Endereco WHERE EditoraID = @EditoraID";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Endereco", endereco);
                command.Parameters.AddWithValue("@EditoraID", editoraID);

                command.ExecuteNonQuery();
            }
        }

        public void AtualizarLivro(long isbn, string titulo, int autorID, int editoraID) {
            Open();

            string query = string.Format("UPDATE Livro SET Titulo='{0}', AutorID={1}, EditoraID={2} WHERE ISBN={3};", titulo, autorID, editoraID, isbn);

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.ExecuteNonQuery();
            }
        }

        public void AtualizarExemplar(int numero, long isbn, bool disponivel) {
            throw new NotImplementedException();
        }

        public void AtualizarCliente(int clienteID, string nome, string email) {
            Open();

            string query = "UPDATE Cliente SET Nome = @Nome, Email = @Email WHERE ClienteID = @ClienteID";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@ClienteID", clienteID);

                command.ExecuteNonQuery();
            }
        }

        public void AtualizarEmprestimo(int emprestimoID, int exemplarNumero, int clienteID, DateTime dataEmprestimo, DateTime dataDevolucao, bool devolvido) {
            throw new NotImplementedException();
        }
        public void ExcluirAutor(int autorID) {
            Open();

            string query = "DELETE FROM Autor WHERE AutorID = @AutorID";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@AutorID", autorID);

                command.ExecuteNonQuery();
            }
        }

        public void ExcluirEditora(int editoraID) {
            Open();

            string query = "DELETE FROM Editora WHERE EditoraID = @EditoraID";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@EditoraID", editoraID);

                command.ExecuteNonQuery();
            }
        }

        public void ExcluirLivro(long isbn) {
            throw new NotImplementedException();
        }

        public void ExcluirExemplar(int numero) {
            throw new NotImplementedException();
        }

        public void ExcluirCliente(int clienteID) {
            Open();

            string query = "DELETE FROM Cliente WHERE ClienteID = @ClienteID";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@ClienteID", clienteID);

                command.ExecuteNonQuery();
            }
        }

        public void ExcluirEmprestimo(int emprestimoID) {
            throw new NotImplementedException();
        }
        public int ObterID(string tabela, string coluna, object valor) {
            string query = $"SELECT {tabela}ID FROM {tabela} WHERE {coluna} = @Valor";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@Valor", valor);

                var result = command.ExecuteScalar();
                return result == null ? -1 : Convert.ToInt32(result);
            }
        }
        public Autor BuscarAutorPorID(int autorID) {
            Open();

            string query = "SELECT * FROM Autor WHERE AutorID = @AutorID";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@AutorID", autorID);

            MySqlDataReader reader = command.ExecuteReader();
            Autor autor = null;
            if (reader.Read()) {
                autor = new Autor {
                    ID = reader.GetInt32("AutorID"),
                    Nome = reader.GetString("Nome")
                };
            }
            reader.Close();
            return autor;
        }

        public Editora BuscarEditoraPorID(int editoraID) {
            Open();

            string query = "SELECT * FROM Editora WHERE EditoraID = @EditoraID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@EditoraID", editoraID);

            MySqlDataReader reader = command.ExecuteReader();
            Editora editora = null;
            if (reader.Read()) {
                editora = new Editora {
                    EditoraID = reader.GetInt32("EditoraID"),
                    Nome = reader.GetString("Nome")
                };
            }
            reader.Close();
            return editora;
        }
        private List<Dictionary<string, string>> GetRows(MySqlDataReader reader) {
            List<Dictionary<string, string>> Rows = new List<Dictionary<string, string>>();
            while (reader.Read()) {
                Dictionary<string, string> Row = new Dictionary<string, string>();
                for (int i = 0; i < reader.FieldCount; i++) {
                    Row.Add(reader.GetName(i), reader.GetValue(i).ToString());
                }
                Rows.Add(Row);
            }
            reader.Close();
            return Rows;
        }
        public List<Livro> BuscaLivros(string search) {
            Open();
            if (string.IsNullOrEmpty(search)) {
                return null;
            } else if (long.TryParse(search, out long ISBN)) {
                string query = "SELECT * FROM Livro WHERE ISBN = @ISBN";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ISBN", ISBN);
                List<Dictionary<string, string>> Rows = GetRows(command.ExecuteReader());
                foreach (Dictionary<string, string> Row in Rows) {
                    return new List<Livro>()
                    {
                                new Livro
                                {
                                    ISBN = long.Parse(Row.GetValueOrDefault("ISBN")),
                                    Titulo = Row.GetValueOrDefault("Titulo"),
                                    Autor = BuscarAutorPorID(int.Parse(Row.GetValueOrDefault("AutorID"))),
                                    Editora = BuscarEditoraPorID(int.Parse(Row.GetValueOrDefault("EditoraID")))
                                }
                            };
                }
            } else {
                string query = string.Format("SELECT * FROM Livro WHERE Titulo like \'%{0}%\'", search);
                List<Livro> Result = new List<Livro>();
                MySqlCommand command = new MySqlCommand(query, connection);

                List<Dictionary<string, string>> Rows = GetRows(command.ExecuteReader());

                foreach (Dictionary<string, string> row in Rows) {
                    Autor autor = null;
                    if (row.TryGetValue("AutorID", out string? autor_id) && int.TryParse(autor_id, out int aid)) {
                        autor = BuscarAutorPorID(aid);
                    }

                    Editora editora = null;
                    if (row.TryGetValue("EditoraID", out string? editora_id) && int.TryParse(editora_id, out int eid)) {
                        editora = BuscarEditoraPorID(eid);
                    }
                    if (autor == null || editora == null) {
                        continue;
                    }
                    Livro livro = new Livro {
                        ISBN = long.Parse(row.GetValueOrDefault("ISBN")),
                        Titulo = row.GetValueOrDefault("Titulo"),
                        Autor = autor,
                        Editora = editora
                    };
                    Result.Add(livro);
                }
                return Result;
            }
            return null;
        }
        public List<Autor> BuscaAutores(string nome = null) {
            Open();
            List<Autor> result = new List<Autor>();
            string query = "SELECT * FROM Autor";
            if (nome != null) {
                if (int.TryParse(nome, out int AutorID)) {
                    query = string.Format("SELECT * FROM Autor WHERE AutorID = {0}", AutorID);
                } else {
                    query = string.Format("SELECT * FROM Autor WHERE Nome like '%{0}%'", nome);
                }
            }

            MySqlCommand command = new MySqlCommand(query, connection);

            List<Dictionary<string, string>> Rows = GetRows(command.ExecuteReader());
            foreach (Dictionary<string, string> row in Rows) {
                Autor autor = new Autor {
                    ID = int.Parse(row.GetValueOrDefault("AutorID")),
                    Nome = row.GetValueOrDefault("Nome")
                };
                result.Add(autor);
            }

            return result;
        }

        public List<Editora> BuscaEditoras(string nome = null) {
            Open();
            List<Editora> result = new List<Editora>();
            string query = "SELECT * FROM Editora";
            if (nome != null) {
                if (int.TryParse(nome, out int EditoraID)) {
                    query = string.Format("SELECT * FROM Editora where EditoraID = {0}", EditoraID);
                } else {
                    query = string.Format("SELECT * FROM Editora where Nome like '%{0}%'", nome);
                }
            }
            MySqlCommand command = new MySqlCommand(query, connection);

            List<Dictionary<string, string>> Rows = GetRows(command.ExecuteReader());

            foreach (Dictionary<string, string> row in Rows) {
                Editora editora = new Editora {
                    EditoraID = int.Parse(row.GetValueOrDefault("EditoraID")),
                    Nome = row.GetValueOrDefault("Nome")
                };
                result.Add(editora);
            }
            return result;
        }

        public Cliente BuscarClientePorNome(string nome) {
            Open();

            string query = "SELECT * FROM Cliente WHERE Nome = @Nome";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@Nome", nome);

                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        return new Cliente {
                            ID = reader.GetInt32("ClienteID"),
                            Nome = reader.GetString("Nome"),
                            Email = reader.GetString("Email")
                        };
                    }
                }

                return null;
            }
        }
        public void CreateEditora(Editora editora) {
            List<Editora> Editoras = BuscaEditoras(editora.EditoraID.ToString());
            if (Editoras != null && Editoras.Count > 0) {
                AtualizarEditora(editora.EditoraID, editora.Nome, "");
            } else {
                InserirEditora(editora.Nome, "");
            }
        }
        public void CreateAutor(Autor autor) {
            List<Autor> Autores = BuscaAutores(autor.ID.ToString());
            if (Autores != null && Autores.Count > 0) {
                AtualizarAutor(autor.ID, autor.Nome, "");
            } else {
                InserirAutor(autor.Nome, "");
            }
        }
        public void CreateLivro(Livro livro) {
            List<Livro> Livros = BuscaLivros(livro.ISBN.ToString());
            if (Livros != null && Livros.Count > 0) {
                AtualizarLivro(livro.ISBN, livro.Titulo, livro.Autor.ID, livro.Editora.EditoraID);
            } else {
                InserirLivro(livro.ISBN, livro.Titulo, livro.Autor.ID, livro.Editora.EditoraID);
            }
        }

        public List<Exemplar> BuscaExemplares(long iSBN) {
            Open();
            List<Exemplar> result = new List<Exemplar>();
            string query = string.Format("SELECT * FROM Exemplar WHERE LivroISBN = {0}", iSBN);

            MySqlCommand command = new MySqlCommand(query, connection);

            List<Dictionary<string, string>> Rows = GetRows(command.ExecuteReader());
            foreach (Dictionary<string, string> row in Rows) {
                Exemplar exemplar = new Exemplar {
                    Numero = int.Parse(row.GetValueOrDefault("NumeroExemplar")),
                    Codigo = int.Parse(row.GetValueOrDefault("CodigoExemplar")),
                    ISBN = long.Parse(row.GetValueOrDefault("LivroISBN")),
                    Disponivel = bool.Parse(row.GetValueOrDefault("Disponivel")),
                    Tipo = bool.Parse(row.GetValueOrDefault("Tipo"))
                };
                result.Add(exemplar);
            }

            return result;
        }
    }
}
