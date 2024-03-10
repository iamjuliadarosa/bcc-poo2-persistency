using Biblioteca.Classes;
using Biblioteca.Recursos;

namespace Biblioteca
{
    public partial class Biblioteca : Form
    {
        Repository repository = Repository.GetInstance(new DBRepository());
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void BT_Autor_Salvar_Click(object sender, EventArgs e)
        {
            //BD.InserirAutor(TB_Autor_Nome.Text, TB_Autor_Email.Text);
        }

        private void BT_Autor_Procurar_Click(object sender, EventArgs e)
        {
            //Autor autor = BD.BuscarAutorPorNome(TB_Autor_Nome.Text);
            //if (autor != null)
            //{
            //    TB_Autor_Email.Text = autor.Email;
            //}

        }

        private void BT_Autor_Apagar_Click(object sender, EventArgs e)
        {
            //Autor autor = BD.BuscarAutorPorNome(TB_Autor_Nome.Text);
            //if (autor != null)
            //{
            //    BD.ExcluirAutor(autor.ID);
            //    TB_Autor_Nome.Text = "";
            //    TB_Autor_Email.Text = "";
            //}
        }

        private void BT_Livro_Select_Click(object sender, EventArgs e)
        {

        }

        private void BT_Livro_Salvar_Click(object sender, EventArgs e)
        {
             //BD.InserirLivro(long.Parse(TB_Livro_ISBN.Text), TB_Livro_Titulo.Text, CB_Livro_Autores.SelectedItem as string, CB_Livro_Editoras.SelectedItem as string);
        }

        private void BT_Livro_Apagar_Click(object sender, EventArgs e)
        {

        }

        private void BT_Editora_Salvar_Click(object sender, EventArgs e)
        {
            //BD.InserirEditora(TB_Editora_Nome.Text, TB_Editora_Endereço.Text);
        }

        private void BT_Editora_Apagar_Click(object sender, EventArgs e)
        {
            //Editora editora = BD.BuscarEditoraPorNome(TB_Editora_Nome.Text);
            //if (editora != null)
            //{
            //    BD.ExcluirEditora(editora.EditoraID);
            //    TB_Editora_Nome.Text = "";
            //    TB_Editora_Endereço.Text = "";
            //}
        }

        private void BT_Editora_Procurar_Click(object sender, EventArgs e)
        {
            //Editora editora = BD.BuscarEditoraPorNome(TB_Editora_Nome.Text);
            //if (editora != null)
            //{
            //    TB_Editora_Endereço.Text = editora.Endereco;
            //}
        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            string tipo_busca = "Livro";
            string busca = TB_Buscar.Text.Trim();
            if (tipo_busca == "Livro")
            {
                InitDGV_Busca_Livro();
                List<Livro> livros = repository.BuscaLivros(busca);
                if(livros != null) {
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
        }
    }
}
