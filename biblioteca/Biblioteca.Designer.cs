namespace Biblioteca
{
    partial class Biblioteca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            TP_Livro = new TabPage();
            DGV_Busca = new DataGridView();
            TP_Autor = new TabPage();
            BT_Autor_Apagar = new Button();
            BT_Autor_Salvar = new Button();
            BT_Autor_Procurar = new Button();
            TB_Autor_Nome = new TextBox();
            label5 = new Label();
            TB_Autor_Email = new TextBox();
            label6 = new Label();
            TP_Editora = new TabPage();
            BT_Editora_Apagar = new Button();
            BT_Editora_Salvar = new Button();
            BT_Editora_Procurar = new Button();
            TB_Editora_Nome = new TextBox();
            label7 = new Label();
            TB_Editora_Endereço = new TextBox();
            label8 = new Label();
            TP_Cliente = new TabPage();
            BT_Cliente_Apagar = new Button();
            BT_CLiente_Salvar = new Button();
            BT_Cliente_Procurar = new Button();
            TB_Cliente_Nome = new TextBox();
            label9 = new Label();
            TB_Cliente_Email = new TextBox();
            label10 = new Label();
            TP_Emprestimo = new TabPage();
            GB_TipoPersistencia = new GroupBox();
            RB_XML = new RadioButton();
            RB_JSON = new RadioButton();
            RB_DB = new RadioButton();
            TB_Buscar = new TextBox();
            BT_Buscar = new Button();
            tabControl1.SuspendLayout();
            TP_Livro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Busca).BeginInit();
            TP_Autor.SuspendLayout();
            TP_Editora.SuspendLayout();
            TP_Cliente.SuspendLayout();
            GB_TipoPersistencia.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TP_Livro);
            tabControl1.Controls.Add(TP_Autor);
            tabControl1.Controls.Add(TP_Editora);
            tabControl1.Controls.Add(TP_Cliente);
            tabControl1.Controls.Add(TP_Emprestimo);
            tabControl1.Location = new Point(23, 131);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(765, 307);
            tabControl1.TabIndex = 2;
            // 
            // TP_Livro
            // 
            TP_Livro.Controls.Add(BT_Buscar);
            TP_Livro.Controls.Add(TB_Buscar);
            TP_Livro.Controls.Add(DGV_Busca);
            TP_Livro.Location = new Point(4, 24);
            TP_Livro.Name = "TP_Livro";
            TP_Livro.Padding = new Padding(3);
            TP_Livro.Size = new Size(757, 279);
            TP_Livro.TabIndex = 0;
            TP_Livro.Text = "Livro";
            TP_Livro.UseVisualStyleBackColor = true;
            // 
            // DGV_Busca
            // 
            DGV_Busca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Busca.Location = new Point(16, 39);
            DGV_Busca.Name = "DGV_Busca";
            DGV_Busca.Size = new Size(735, 234);
            DGV_Busca.TabIndex = 8;
            // 
            // TP_Autor
            // 
            TP_Autor.Controls.Add(BT_Autor_Apagar);
            TP_Autor.Controls.Add(BT_Autor_Salvar);
            TP_Autor.Controls.Add(BT_Autor_Procurar);
            TP_Autor.Controls.Add(TB_Autor_Nome);
            TP_Autor.Controls.Add(label5);
            TP_Autor.Controls.Add(TB_Autor_Email);
            TP_Autor.Controls.Add(label6);
            TP_Autor.Location = new Point(4, 24);
            TP_Autor.Name = "TP_Autor";
            TP_Autor.Padding = new Padding(3);
            TP_Autor.Size = new Size(757, 279);
            TP_Autor.TabIndex = 2;
            TP_Autor.Text = "Autor";
            TP_Autor.UseVisualStyleBackColor = true;
            // 
            // BT_Autor_Apagar
            // 
            BT_Autor_Apagar.Location = new Point(89, 64);
            BT_Autor_Apagar.Name = "BT_Autor_Apagar";
            BT_Autor_Apagar.Size = new Size(75, 23);
            BT_Autor_Apagar.TabIndex = 18;
            BT_Autor_Apagar.Text = "Apagar";
            BT_Autor_Apagar.UseVisualStyleBackColor = true;
            BT_Autor_Apagar.Click += BT_Autor_Apagar_Click;
            // 
            // BT_Autor_Salvar
            // 
            BT_Autor_Salvar.Location = new Point(8, 64);
            BT_Autor_Salvar.Name = "BT_Autor_Salvar";
            BT_Autor_Salvar.Size = new Size(75, 23);
            BT_Autor_Salvar.TabIndex = 17;
            BT_Autor_Salvar.Text = "Salvar";
            BT_Autor_Salvar.UseVisualStyleBackColor = true;
            BT_Autor_Salvar.Click += BT_Autor_Salvar_Click;
            // 
            // BT_Autor_Procurar
            // 
            BT_Autor_Procurar.Location = new Point(266, 6);
            BT_Autor_Procurar.Name = "BT_Autor_Procurar";
            BT_Autor_Procurar.Size = new Size(75, 23);
            BT_Autor_Procurar.TabIndex = 15;
            BT_Autor_Procurar.Text = "Procurar";
            BT_Autor_Procurar.UseVisualStyleBackColor = true;
            BT_Autor_Procurar.Click += BT_Autor_Procurar_Click;
            // 
            // TB_Autor_Nome
            // 
            TB_Autor_Nome.Location = new Point(160, 6);
            TB_Autor_Nome.Name = "TB_Autor_Nome";
            TB_Autor_Nome.Size = new Size(100, 23);
            TB_Autor_Nome.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 6);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 13;
            label5.Text = "Nome";
            // 
            // TB_Autor_Email
            // 
            TB_Autor_Email.Location = new Point(160, 35);
            TB_Autor_Email.Name = "TB_Autor_Email";
            TB_Autor_Email.Size = new Size(100, 23);
            TB_Autor_Email.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 35);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "E-Mail";
            // 
            // TP_Editora
            // 
            TP_Editora.Controls.Add(BT_Editora_Apagar);
            TP_Editora.Controls.Add(BT_Editora_Salvar);
            TP_Editora.Controls.Add(BT_Editora_Procurar);
            TP_Editora.Controls.Add(TB_Editora_Nome);
            TP_Editora.Controls.Add(label7);
            TP_Editora.Controls.Add(TB_Editora_Endereço);
            TP_Editora.Controls.Add(label8);
            TP_Editora.Location = new Point(4, 24);
            TP_Editora.Name = "TP_Editora";
            TP_Editora.Padding = new Padding(3);
            TP_Editora.Size = new Size(757, 279);
            TP_Editora.TabIndex = 4;
            TP_Editora.Text = "Editora";
            TP_Editora.UseVisualStyleBackColor = true;
            // 
            // BT_Editora_Apagar
            // 
            BT_Editora_Apagar.Location = new Point(98, 64);
            BT_Editora_Apagar.Name = "BT_Editora_Apagar";
            BT_Editora_Apagar.Size = new Size(75, 23);
            BT_Editora_Apagar.TabIndex = 5;
            BT_Editora_Apagar.Text = "Apagar";
            BT_Editora_Apagar.UseVisualStyleBackColor = true;
            BT_Editora_Apagar.Click += BT_Editora_Apagar_Click;
            // 
            // BT_Editora_Salvar
            // 
            BT_Editora_Salvar.Location = new Point(17, 64);
            BT_Editora_Salvar.Name = "BT_Editora_Salvar";
            BT_Editora_Salvar.Size = new Size(75, 23);
            BT_Editora_Salvar.TabIndex = 4;
            BT_Editora_Salvar.Text = "Salvar";
            BT_Editora_Salvar.UseVisualStyleBackColor = true;
            BT_Editora_Salvar.Click += BT_Editora_Salvar_Click;
            // 
            // BT_Editora_Procurar
            // 
            BT_Editora_Procurar.Location = new Point(275, 6);
            BT_Editora_Procurar.Name = "BT_Editora_Procurar";
            BT_Editora_Procurar.Size = new Size(75, 23);
            BT_Editora_Procurar.TabIndex = 2;
            BT_Editora_Procurar.Text = "Procurar";
            BT_Editora_Procurar.UseVisualStyleBackColor = true;
            BT_Editora_Procurar.Click += BT_Editora_Procurar_Click;
            // 
            // TB_Editora_Nome
            // 
            TB_Editora_Nome.Location = new Point(169, 6);
            TB_Editora_Nome.Name = "TB_Editora_Nome";
            TB_Editora_Nome.Size = new Size(100, 23);
            TB_Editora_Nome.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 6);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 20;
            label7.Text = "Nome";
            // 
            // TB_Editora_Endereço
            // 
            TB_Editora_Endereço.Location = new Point(169, 35);
            TB_Editora_Endereço.Name = "TB_Editora_Endereço";
            TB_Editora_Endereço.Size = new Size(100, 23);
            TB_Editora_Endereço.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 35);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 18;
            label8.Text = "Endereço";
            // 
            // TP_Cliente
            // 
            TP_Cliente.Controls.Add(BT_Cliente_Apagar);
            TP_Cliente.Controls.Add(BT_CLiente_Salvar);
            TP_Cliente.Controls.Add(BT_Cliente_Procurar);
            TP_Cliente.Controls.Add(TB_Cliente_Nome);
            TP_Cliente.Controls.Add(label9);
            TP_Cliente.Controls.Add(TB_Cliente_Email);
            TP_Cliente.Controls.Add(label10);
            TP_Cliente.Location = new Point(4, 24);
            TP_Cliente.Name = "TP_Cliente";
            TP_Cliente.Padding = new Padding(3);
            TP_Cliente.Size = new Size(757, 279);
            TP_Cliente.TabIndex = 5;
            TP_Cliente.Text = "Cliente";
            TP_Cliente.UseVisualStyleBackColor = true;
            // 
            // BT_Cliente_Apagar
            // 
            BT_Cliente_Apagar.Location = new Point(102, 64);
            BT_Cliente_Apagar.Name = "BT_Cliente_Apagar";
            BT_Cliente_Apagar.Size = new Size(75, 23);
            BT_Cliente_Apagar.TabIndex = 5;
            BT_Cliente_Apagar.Text = "Apagar";
            BT_Cliente_Apagar.UseVisualStyleBackColor = true;
            // 
            // BT_CLiente_Salvar
            // 
            BT_CLiente_Salvar.Location = new Point(21, 64);
            BT_CLiente_Salvar.Name = "BT_CLiente_Salvar";
            BT_CLiente_Salvar.Size = new Size(75, 23);
            BT_CLiente_Salvar.TabIndex = 4;
            BT_CLiente_Salvar.Text = "Salvar";
            BT_CLiente_Salvar.UseVisualStyleBackColor = true;
            // 
            // BT_Cliente_Procurar
            // 
            BT_Cliente_Procurar.Location = new Point(279, 6);
            BT_Cliente_Procurar.Name = "BT_Cliente_Procurar";
            BT_Cliente_Procurar.Size = new Size(75, 23);
            BT_Cliente_Procurar.TabIndex = 2;
            BT_Cliente_Procurar.Text = "Procurar";
            BT_Cliente_Procurar.UseVisualStyleBackColor = true;
            // 
            // TB_Cliente_Nome
            // 
            TB_Cliente_Nome.Location = new Point(173, 6);
            TB_Cliente_Nome.Name = "TB_Cliente_Nome";
            TB_Cliente_Nome.Size = new Size(100, 23);
            TB_Cliente_Nome.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 6);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 20;
            label9.Text = "Nome";
            // 
            // TB_Cliente_Email
            // 
            TB_Cliente_Email.Location = new Point(173, 35);
            TB_Cliente_Email.Name = "TB_Cliente_Email";
            TB_Cliente_Email.Size = new Size(100, 23);
            TB_Cliente_Email.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 35);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 18;
            label10.Text = "E-Mail";
            // 
            // TP_Emprestimo
            // 
            TP_Emprestimo.Location = new Point(4, 24);
            TP_Emprestimo.Name = "TP_Emprestimo";
            TP_Emprestimo.Padding = new Padding(3);
            TP_Emprestimo.Size = new Size(757, 279);
            TP_Emprestimo.TabIndex = 6;
            TP_Emprestimo.Text = "Empréstimo";
            TP_Emprestimo.UseVisualStyleBackColor = true;
            // 
            // GB_TipoPersistencia
            // 
            GB_TipoPersistencia.Controls.Add(RB_XML);
            GB_TipoPersistencia.Controls.Add(RB_JSON);
            GB_TipoPersistencia.Controls.Add(RB_DB);
            GB_TipoPersistencia.Location = new Point(12, 8);
            GB_TipoPersistencia.Name = "GB_TipoPersistencia";
            GB_TipoPersistencia.Size = new Size(140, 100);
            GB_TipoPersistencia.TabIndex = 3;
            GB_TipoPersistencia.TabStop = false;
            GB_TipoPersistencia.Text = "Tipo de Persistencia";
            // 
            // RB_XML
            // 
            RB_XML.AutoSize = true;
            RB_XML.Location = new Point(19, 72);
            RB_XML.Name = "RB_XML";
            RB_XML.Size = new Size(49, 19);
            RB_XML.TabIndex = 2;
            RB_XML.TabStop = true;
            RB_XML.Text = "XML";
            RB_XML.UseVisualStyleBackColor = true;
            // 
            // RB_JSON
            // 
            RB_JSON.AutoSize = true;
            RB_JSON.Location = new Point(19, 47);
            RB_JSON.Name = "RB_JSON";
            RB_JSON.Size = new Size(53, 19);
            RB_JSON.TabIndex = 1;
            RB_JSON.TabStop = true;
            RB_JSON.Text = "JSON";
            RB_JSON.UseVisualStyleBackColor = true;
            // 
            // RB_DB
            // 
            RB_DB.AutoSize = true;
            RB_DB.Location = new Point(19, 22);
            RB_DB.Name = "RB_DB";
            RB_DB.Size = new Size(40, 19);
            RB_DB.TabIndex = 0;
            RB_DB.TabStop = true;
            RB_DB.Text = "DB";
            RB_DB.UseVisualStyleBackColor = true;
            // 
            // TB_Buscar
            // 
            TB_Buscar.Location = new Point(16, 10);
            TB_Buscar.Name = "TB_Buscar";
            TB_Buscar.Size = new Size(629, 23);
            TB_Buscar.TabIndex = 10;
            // 
            // BT_Buscar
            // 
            BT_Buscar.Location = new Point(651, 10);
            BT_Buscar.Name = "BT_Buscar";
            BT_Buscar.Size = new Size(100, 23);
            BT_Buscar.TabIndex = 11;
            BT_Buscar.Text = "Buscar";
            BT_Buscar.UseVisualStyleBackColor = true;
            BT_Buscar.Click += BT_Buscar_Click;
            // 
            // Biblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GB_TipoPersistencia);
            Controls.Add(tabControl1);
            Name = "Biblioteca";
            Text = "Biblioteca";
            tabControl1.ResumeLayout(false);
            TP_Livro.ResumeLayout(false);
            TP_Livro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Busca).EndInit();
            TP_Autor.ResumeLayout(false);
            TP_Autor.PerformLayout();
            TP_Editora.ResumeLayout(false);
            TP_Editora.PerformLayout();
            TP_Cliente.ResumeLayout(false);
            TP_Cliente.PerformLayout();
            GB_TipoPersistencia.ResumeLayout(false);
            GB_TipoPersistencia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        public TabPage TP_Livro;
        public TabPage TP_Autor;
        public TabPage TP_Editora;
        public TabPage TP_Cliente;
        public TabPage TP_Emprestimo;
        private Button BT_Autor_Apagar;
        private Button BT_Autor_Salvar;
        private Button BT_Autor_Procurar;
        private TextBox TB_Autor_Nome;
        private Label label5;
        private TextBox TB_Autor_Email;
        private Label label6;
        private Button BT_Editora_Apagar;
        private Button BT_Editora_Salvar;
        private Button BT_Editora_Procurar;
        private TextBox TB_Editora_Nome;
        private Label label7;
        private TextBox TB_Editora_Endereço;
        private Label label8;
        private Button BT_Cliente_Apagar;
        private Button BT_CLiente_Salvar;
        private Button BT_Cliente_Procurar;
        private TextBox TB_Cliente_Nome;
        private Label label9;
        private TextBox TB_Cliente_Email;
        private Label label10;
        private GroupBox GB_TipoPersistencia;
        private RadioButton RB_XML;
        private RadioButton RB_JSON;
        private RadioButton RB_DB;
        private DataGridView DGV_Busca;
        private Button BT_Buscar;
        private TextBox TB_Buscar;
    }
}
