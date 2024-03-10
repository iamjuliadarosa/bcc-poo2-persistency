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
    public partial class ViewEditora : Form {
        private Repository repository = Repository.GetInstance();
        private Editora ModelEditora;
        public ViewEditora() {
            if (ModelEditora == null) {
                ModelEditora = new Editora();
            }
            InitializeComponent();
        }
        public ViewEditora(Editora editora) : this() {
            ModelEditora = editora;
        }
        private void BT_Editora_Apagar_Click(object sender, EventArgs e) {
            if (ModelEditora.EditoraID != null && ModelEditora.EditoraID != 0) {
                repository.DeleteEditora(ModelEditora);
                Close();
            } else {
                MessageBox.Show("Editora não existe!");
                Close();
            }
        }
        private void BT_Editora_Salvar_Click(object sender, EventArgs e) {
            ModelEditora.Nome = TB_Editora_Nome.Text;
            repository.CreateEditora(ModelEditora);
            Close();
        }

        private void ViewEditora_Load(object sender, EventArgs e) {
            if(ModelEditora != null) {
                TB_ID.Text = ModelEditora.EditoraID.ToString();
                TB_Editora_Nome.Text = ModelEditora.Nome;
            }
        }
    }
}
