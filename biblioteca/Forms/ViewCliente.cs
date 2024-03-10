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
    public partial class ViewCliente : Form {
        private Repository repository = Repository.GetInstance();
        private Cliente? ModelCliente;
        public ViewCliente() {
            InitializeComponent();
        }
        public ViewCliente(Cliente cliente) : this() {
            ModelCliente = cliente;
        }

        private void BT_CLiente_Salvar_Click(object sender, EventArgs e) {
            if (ModelCliente == null) {
                ModelCliente = new Cliente();
            }

            ModelCliente.Nome = TB_Cliente_Nome.Text;
            ModelCliente.Email = TB_EMail.Text;

            repository.CreateCliente(ModelCliente);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BT_Cliente_Apagar_Click(object sender, EventArgs e) {

        }

        private void ViewCliente_Load(object sender, EventArgs e) {
            if (ModelCliente != null) {
                TB_ID.Text = ModelCliente.ID.ToString();
                TB_Cliente_Nome.Text = ModelCliente.Nome;
                TB_EMail.Text = ModelCliente.Email;
            }

        }
    }
}
