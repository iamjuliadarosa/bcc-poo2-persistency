using Biblioteca.Classes;
using Biblioteca.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class ViewLivro : Form {
        Repository repository = Repository.GetInstance();
        private Livro? ModelLivro;
        public ViewLivro() {
            InitializeComponent();
        }
        public ViewLivro(Livro livro) : this() {
            ModelLivro = livro;
        }

        private void ViewLivro_Load(object sender, EventArgs e) {
            try {
                List<Autor> Autores = repository.BuscaAutores();
                if (Autores != null && Autores.Count > 0) {
                    CB_Livro_Autores.Items.Clear();
                    Dictionary<int, string> Autores_DataSource = new Dictionary<int, string>();
                    foreach (Autor autor in Autores) {
                        Autores_DataSource.Add(autor.ID, autor.Nome);
                    }
                    CB_Livro_Autores.DataSource = new BindingSource(Autores_DataSource, null);
                    CB_Livro_Autores.DisplayMember = "Value";
                    CB_Livro_Autores.ValueMember = "Key";
                }

                List<Editora> Editoras = repository.BuscaEditoras();
                if (Editoras != null && Editoras.Count > 0) {
                    CB_Livro_Editoras.Items.Clear();
                    Dictionary<int, string> Editoras_DataSource = new Dictionary<int, string>();
                    foreach (Editora editora in Editoras) {
                        Editoras_DataSource.Add(editora.EditoraID, editora.Nome);
                    }
                    CB_Livro_Editoras.DataSource = new BindingSource(Editoras_DataSource, null);
                    CB_Livro_Editoras.DisplayMember = "Value";
                    CB_Livro_Editoras.ValueMember = "Key";
                }
            } catch (Exception ex) {

            }
            Init_DGV_Exemplares();
            if (ModelLivro != null) {
                TB_Livro_ISBN.Text = ModelLivro.ISBN.ToString();
                TB_Livro_ISBN.ReadOnly = true;
                TB_Livro_Titulo.Text = ModelLivro.Titulo;
                CB_Livro_Autores.SelectedValue = ModelLivro.Autor.ID;
                CB_Livro_Editoras.SelectedValue = ModelLivro.Editora.EditoraID;
                List<Exemplar> Exemplares = repository.BuscaExemplares(ModelLivro.ISBN);
                if(Exemplares != null) {
                    foreach (Exemplar item in Exemplares) {
                        DGV_Exemplares.Rows.Add(new string[] {
                        item.Numero.ToString(),
                        item.Codigo.ToString(),
                        item.Disponivel?"Disponível": "Em emprestimo",
                        item.Tipo? "Consulta":"Normal"
                        });
                    }
                }
            }
        }
        private void Init_DGV_Exemplares() {
            DGV_Exemplares.ColumnCount = 4;
            DGV_Exemplares.Columns[0].Name = "Número";
            DGV_Exemplares.Columns[1].Name = "Código";
            DGV_Exemplares.Columns[2].Name = "Disponível";
            DGV_Exemplares.Columns[3].Name = "Tipo";
            DGV_Exemplares.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            DGV_Exemplares.MultiSelect = false;
            DGV_Exemplares.Rows.Clear();
        }
        private void BT_Livro_Salvar_Click(object sender, EventArgs e) {
            if(ModelLivro == null) {
                ModelLivro = new Livro();
            }
            if(long.TryParse(TB_Livro_ISBN.Text, out long ISBN)) {
                ModelLivro.ISBN = ISBN;
            } else {
                MessageBox.Show("ISBN inválido!");
                DialogResult = DialogResult.Cancel;
                return;
            }
            
            ModelLivro.Titulo = TB_Livro_Titulo.Text;

            List<Autor> Autores = repository.BuscaAutores(CB_Livro_Autores.SelectedValue.ToString());
            if(Autores !=  null && Autores.Count > 0) {
                ModelLivro.Autor = Autores.FirstOrDefault();
            } else {
                MessageBox.Show("Autor inválido!");
                DialogResult = DialogResult.Cancel;
                return;
            }

            List<Editora> editoras = repository.BuscaEditoras(CB_Livro_Editoras.SelectedValue.ToString());
            if (editoras != null && editoras.Count > 0) {
                ModelLivro.Editora = editoras.FirstOrDefault();
            } else {
                MessageBox.Show("Editora inválida!");
                DialogResult = DialogResult.Cancel;
                return;
            }

            repository.CreateLivro(ModelLivro);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void BT_Livro_Apagar_Click(object sender, EventArgs e) {
            if (ModelLivro.ISBN != null && ModelLivro.ISBN != 0) {
                repository.DeleteLivro(ModelLivro);
                Close();
            } else {
                MessageBox.Show("Autor não existe!");
                Close();
            }
        }
    }
}
