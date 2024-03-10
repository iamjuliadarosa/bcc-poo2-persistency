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
                if (editoras != null && editoras.Count>0) {
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
            DGV_Busca.CellClick -= DGV_Busca_Livro_Selection;
            DGV_Busca.CellClick += DGV_Busca_Livro_Selection;
        }

        private void DGV_Busca_Livro_Selection(object? sender, EventArgs e) {
            ViewLivro Livro = new ViewLivro();
            Livro.Show();
        }

        protected void InitDGV_Busca_Autor() {
            DGV_Busca.ColumnCount = 2;
            DGV_Busca.Columns[0].Name = "ID";
            DGV_Busca.Columns[1].Name = "Nome";
            DGV_Busca.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            DGV_Busca.MultiSelect = false;
            DGV_Busca.Rows.Clear();
            DGV_Busca.CellClick -= DGV_Busca_Autor_Selection;
            DGV_Busca.CellClick += DGV_Busca_Autor_Selection;
        }
        private void DGV_Busca_Autor_Selection(object? sender, EventArgs e) {
            ViewAutor Autor = new ViewAutor();
            Autor.Show();
        }
        protected void InitDGV_Busca_Editora() {
            DGV_Busca.ColumnCount = 2;
            DGV_Busca.Columns[0].Name = "ID";
            DGV_Busca.Columns[1].Name = "Nome";
            DGV_Busca.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            DGV_Busca.MultiSelect = false;
            DGV_Busca.Rows.Clear();
            DGV_Busca.CellClick -= DGV_Busca_Editora_Selection;
            DGV_Busca.CellClick += DGV_Busca_Editora_Selection;
        }
        private void DGV_Busca_Editora_Selection(object? sender, EventArgs e) {
            ViewEditora Editora = new ViewEditora();
            Editora.Show();
        }
    }
}
