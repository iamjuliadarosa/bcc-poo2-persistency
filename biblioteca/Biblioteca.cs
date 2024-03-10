using Biblioteca.Classes;
using Biblioteca.Recursos;

namespace Biblioteca {
    public partial class Biblioteca : Form {
        public Biblioteca() {
            InitializeComponent();
        }
        private void BTN_Entrar_Click(object sender, EventArgs e) {
            if (RB_JSON.Checked) {
                Repository repository = Repository.GetInstance();
            } else if (RB_XML.Checked) {
                Repository repository = Repository.GetInstance();
            } else if (RB_DB.Checked) {
                Repository repository = Repository.GetInstance(new DBRepository());
            } else {
                MessageBox.Show("Selecione uma persistencia de dados!");
            }
            Forms.Main main = new Forms.Main();
            Hide();
            if(main.ShowDialog() == DialogResult.OK) {
                Close();
            } else {
                Show();
            }
        }

        private void Biblioteca_Load(object sender, EventArgs e) {

        }
    }
}
