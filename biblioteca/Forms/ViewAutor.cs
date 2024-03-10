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

namespace Biblioteca.Forms {
    public partial class ViewAutor : Form {
        private Repository repository = Repository.GetInstance();
        private Autor ModelAutor;
        public ViewAutor() {
            if (ModelAutor == null) {
                ModelAutor = new Autor();
            }
            InitializeComponent();
        }
        public ViewAutor(Autor autor) : this() {
            ModelAutor = autor;
        }
        private void BT_Autor_Apagar_Click(object sender, EventArgs e) {
            if (ModelAutor.ID != null && ModelAutor.ID != 0) {
                repository.DeleteAutor(ModelAutor);
                Close();
            } else {
                MessageBox.Show("Autor não existe!");
                Close();
            }
        }
        private void BT_Autor_Salvar_Click(object sender, EventArgs e) {
            ModelAutor.Nome = TB_Autor_Nome.Text;
            repository.CreateAutor(ModelAutor);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void ViewAutor_Load(object sender, EventArgs e) {
            if(ModelAutor != null) {
                TB_ID.Text = ModelAutor.ID.ToString();
                TB_Autor_Nome.Text = ModelAutor.Nome;
            }
        }
    }
}
