using Biblioteca.Classes;
using Biblioteca.Recursos;

namespace Biblioteca.Forms {
    public partial class Main : Form {
        Repository repository = Repository.GetInstance();
        public Main() {
            InitializeComponent();
        }
        private void BT_Buscar_Click(object sender, EventArgs e) {
            string busca = TB_Buscar.Text.Trim();
            RemoveEventsFromDGV_Busca();
            if (RB_Livro.Checked) {
                InitDGV_Busca_Livro();
                List<Livro> livros = repository.BuscaLivros(busca);
                if (livros != null && livros.Count > 0) {
                    foreach (Livro livro in livros) {
                        DGV_Busca.Rows.Add(new string[] {
                        livro.ISBN.ToString(),
                        livro.Titulo,
                        livro.Autor.Nome,
                        livro.Editora.Nome
                    });
                    }
                } else {
                    MessageBox.Show("Não localizado resultados para a busca!");
                }

            } else if (RB_Autor.Checked) {
                InitDGV_Busca_Autor();
                List<Autor> autors = repository.BuscaAutores(busca);
                if (autors != null && autors.Count > 0) {
                    foreach (Autor autor in autors) {
                        DGV_Busca.Rows.Add(new string[] {
                            autor.ID.ToString(),
                            autor.Nome
                        });
                    }
                } else {
                    MessageBox.Show("Não localizado resultados para a busca!");
                }
            } else if (RB_Editora.Checked) {
                InitDGV_Busca_Editora();
                List<Editora> editoras = repository.BuscaEditoras(busca);
                if (editoras != null && editoras.Count > 0) {
                    foreach (Editora editora in editoras) {
                        DGV_Busca.Rows.Add(new string[] {
                            editora.EditoraID.ToString(),
                            editora.Nome
                        });
                    }
                    DGV_Busca.ClearSelection();
                } else {
                    MessageBox.Show("Não localizado resultados para a busca!");
                }
            }else if (RB_Cliente.Checked) {
                InitDGV_Busca_Cliente();
                List<Cliente> clientes = repository.BuscaClientes(busca);
                if (clientes != null && clientes.Count > 0) {
                    foreach (Cliente cliente in clientes) {
                        DGV_Busca.Rows.Add(new string[] {
                            cliente.ID.ToString(),
                            cliente.Nome
                        });
                    }
                    DGV_Busca.ClearSelection();
                } else {
                    MessageBox.Show("Não localizado resultados para a busca!");
                }
            }
        }
        private void RemoveEventsFromDGV_Busca() {
            DGV_Busca.CellClick -= DGV_Busca_Cliente_Selection;
            DGV_Busca.CellClick -= DGV_Busca_Livro_Selection;
            DGV_Busca.CellClick -= DGV_Busca_Autor_Selection;
            DGV_Busca.CellClick -= DGV_Busca_Editora_Selection;
        }
        private void InitDGV_Busca_Cliente() {
            DGV_Busca.ColumnCount = 2;
            DGV_Busca.Columns[0].Name = "ID";
            DGV_Busca.Columns[1].Name = "Nome";
            DGV_Busca.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            DGV_Busca.MultiSelect = false;
            DGV_Busca.Rows.Clear();
            DGV_Busca.EditMode = DataGridViewEditMode.EditProgrammatically;
            DGV_Busca.CellClick -= DGV_Busca_Cliente_Selection;
            DGV_Busca.CellClick += DGV_Busca_Cliente_Selection;
        }
        private void DGV_Busca_Cliente_Selection(object? sender, EventArgs e) {
            List<Cliente> clientes = repository.BuscaClientes((sender as DataGridView).Rows[(e as DataGridViewCellEventArgs).RowIndex].Cells[0].Value.ToString());
            if (clientes != null && clientes.Count > 0) {
                OnEditeCliente(clientes.First());
            } else {
                throw new Exception("Não foi possível localizar Cliente para edição.");
            }
        }
        protected void InitDGV_Busca_Livro() {
            DGV_Busca.ColumnCount = 4;
            DGV_Busca.Columns[0].Name = "ISBN";
            DGV_Busca.Columns[1].Name = "Título";
            DGV_Busca.Columns[2].Name = "Autor";
            DGV_Busca.Columns[3].Name = "Editora";
            DGV_Busca.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            DGV_Busca.MultiSelect = false;
            DGV_Busca.Rows.Clear();
            DGV_Busca.EditMode = DataGridViewEditMode.EditProgrammatically;
            DGV_Busca.CellClick -= DGV_Busca_Livro_Selection;
            DGV_Busca.CellClick += DGV_Busca_Livro_Selection;
        }

        private void DGV_Busca_Livro_Selection(object? sender, EventArgs e) {
            List<Livro> livros = repository.BuscaLivros((sender as DataGridView).Rows[(e as DataGridViewCellEventArgs).RowIndex].Cells[0].Value.ToString());
            if (livros != null && livros.Count > 0) {
                OnEditeLivro(livros.First());
            } else {
                throw new Exception("Não foi possível localizar livro para edição.");
            }
        }
        private void OnCreateLivro() {
            ViewLivro Livro = new ViewLivro();
            if (Livro.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Sucesso ao criar o Livro.");
            } else {
                MessageBox.Show("Operação cancelada.");
            }
        }
        private void OnEditeLivro(Livro livro) {
            ViewLivro Livro = new ViewLivro(livro);
            if (Livro.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Sucesso ao editar o Livro.");
            } else {
                MessageBox.Show("Operação cancelada.");
            }
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e) {
            OnCreateLivro();
        }
        protected void InitDGV_Busca_Editora() {
            DGV_Busca.ColumnCount = 2;
            DGV_Busca.Columns[0].Name = "ID";
            DGV_Busca.Columns[1].Name = "Nome";
            DGV_Busca.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            DGV_Busca.MultiSelect = false;
            DGV_Busca.Rows.Clear();
            DGV_Busca.EditMode = DataGridViewEditMode.EditProgrammatically;
            DGV_Busca.CellClick -= DGV_Busca_Editora_Selection;
            DGV_Busca.CellClick += DGV_Busca_Editora_Selection;
        }
        private void DGV_Busca_Editora_Selection(object? sender, EventArgs e) {
            List<Editora> editoras = repository.BuscaEditoras((sender as DataGridView).Rows[(e as DataGridViewCellEventArgs).RowIndex].Cells[0].Value.ToString());
            if (editoras != null && editoras.Count > 0) {
                OnEditeEditora(editoras.First());
            } else {
                throw new Exception("Não foi possível localizar livro para edição.");
            }
        }
        private void OnCreateEditora() {
            ViewEditora viewEditora = new ViewEditora();
            if (viewEditora.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Sucesso ao criar a Editora.");
            }
        }
        private void OnEditeEditora(Editora editora) {
            ViewEditora viewEditora = new ViewEditora(editora);
            if (viewEditora.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Sucesso ao editar a Editora.");
            }
        }
        private void editoraToolStripMenuItem_Click(object sender, EventArgs e) {
            OnCreateEditora();
        }
        protected void InitDGV_Busca_Autor() {
            DGV_Busca.ColumnCount = 2;
            DGV_Busca.Columns[0].Name = "ID";
            DGV_Busca.Columns[1].Name = "Nome";
            DGV_Busca.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            DGV_Busca.MultiSelect = false;
            DGV_Busca.Rows.Clear();
            DGV_Busca.EditMode = DataGridViewEditMode.EditProgrammatically;
            DGV_Busca.CellClick -= DGV_Busca_Autor_Selection;
            DGV_Busca.CellClick += DGV_Busca_Autor_Selection;
        }
        private void DGV_Busca_Autor_Selection(object? sender, EventArgs e) {
            List<Autor> autores = repository.BuscaAutores((sender as DataGridView).Rows[(e as DataGridViewCellEventArgs).RowIndex].Cells[0].Value.ToString());
            if (autores != null && autores.Count > 0) {
                OnEditeAutor(autores.First());
            } else {
                throw new Exception("Não foi possível localizar Autor para edição.");
            }
        }
        private void OnCreateAutor() {
            ViewAutor viewAutor = new ViewAutor();
            if (viewAutor.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Sucesso ao criar o Autor.");
            } else {
                MessageBox.Show("Operação cancelada.");
            }
        }
        private void OnEditeAutor(Autor autor) {
            ViewAutor viewAutor = new ViewAutor(autor);
            if (viewAutor.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Sucesso ao editar o Autor.");
            } else {
                MessageBox.Show("Operação cancelada.");
            }
        }
        private void autorToolStripMenuItem_Click(object sender, EventArgs e) {
            OnCreateAutor();
        }
        private void OnCreateCliente() {
            ViewCliente viewCliente = new ViewCliente();
            if (viewCliente.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Sucesso ao criar o Autor.");
            } else {
                MessageBox.Show("Operação cancelada.");
            }
        }
        private void OnEditeCliente(Cliente Cliente) {
            ViewCliente viewCliente = new ViewCliente(Cliente);
            if (viewCliente.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Sucesso ao editar o Cliente.");
            } else {
                MessageBox.Show("Operação cancelada.");
            }
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e) {
            OnCreateCliente();
        }
    }
}
