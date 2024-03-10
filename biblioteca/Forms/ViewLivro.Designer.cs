namespace Biblioteca.Forms
{
    partial class ViewLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label11 = new Label();
            DGV_Exemplares = new DataGridView();
            BT_Livro_Apagar = new Button();
            BT_Livro_Salvar = new Button();
            TB_Livro_ISBN = new TextBox();
            label4 = new Label();
            CB_Livro_Editoras = new ComboBox();
            label3 = new Label();
            CB_Livro_Autores = new ComboBox();
            label2 = new Label();
            TB_Livro_Titulo = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            BT_Add_Exemplares = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Exemplares).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(18, 153);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 21;
            label11.Text = "Exemplares";
            // 
            // DGV_Exemplares
            // 
            DGV_Exemplares.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Exemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Exemplares.Location = new Point(18, 171);
            DGV_Exemplares.Name = "DGV_Exemplares";
            DGV_Exemplares.Size = new Size(473, 214);
            DGV_Exemplares.TabIndex = 20;
            // 
            // BT_Livro_Apagar
            // 
            BT_Livro_Apagar.Location = new Point(416, 391);
            BT_Livro_Apagar.Name = "BT_Livro_Apagar";
            BT_Livro_Apagar.Size = new Size(75, 23);
            BT_Livro_Apagar.TabIndex = 19;
            BT_Livro_Apagar.Text = "Apagar";
            BT_Livro_Apagar.UseVisualStyleBackColor = true;
            BT_Livro_Apagar.Click += BT_Livro_Apagar_Click;
            // 
            // BT_Livro_Salvar
            // 
            BT_Livro_Salvar.Location = new Point(335, 391);
            BT_Livro_Salvar.Name = "BT_Livro_Salvar";
            BT_Livro_Salvar.Size = new Size(75, 23);
            BT_Livro_Salvar.TabIndex = 17;
            BT_Livro_Salvar.Text = "Salvar";
            BT_Livro_Salvar.UseVisualStyleBackColor = true;
            BT_Livro_Salvar.Click += BT_Livro_Salvar_Click;
            // 
            // TB_Livro_ISBN
            // 
            TB_Livro_ISBN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TB_Livro_ISBN.Location = new Point(82, 16);
            TB_Livro_ISBN.Name = "TB_Livro_ISBN";
            TB_Livro_ISBN.Size = new Size(203, 23);
            TB_Livro_ISBN.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(28, 16);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 18;
            label4.Text = "ISBN";
            // 
            // CB_Livro_Editoras
            // 
            CB_Livro_Editoras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CB_Livro_Editoras.FormattingEnabled = true;
            CB_Livro_Editoras.Location = new Point(82, 100);
            CB_Livro_Editoras.Name = "CB_Livro_Editoras";
            CB_Livro_Editoras.Size = new Size(409, 23);
            CB_Livro_Editoras.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(28, 105);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 14;
            label3.Text = "Editora";
            // 
            // CB_Livro_Autores
            // 
            CB_Livro_Autores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CB_Livro_Autores.FormattingEnabled = true;
            CB_Livro_Autores.Location = new Point(82, 71);
            CB_Livro_Autores.Name = "CB_Livro_Autores";
            CB_Livro_Autores.Size = new Size(409, 23);
            CB_Livro_Autores.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(28, 76);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 12;
            label2.Text = "Autor";
            // 
            // TB_Livro_Titulo
            // 
            TB_Livro_Titulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TB_Livro_Titulo.Location = new Point(82, 45);
            TB_Livro_Titulo.Name = "TB_Livro_Titulo";
            TB_Livro_Titulo.Size = new Size(409, 23);
            TB_Livro_Titulo.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(28, 45);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 10;
            label1.Text = "Título";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(BT_Add_Exemplares);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(BT_Livro_Apagar);
            panel1.Controls.Add(BT_Livro_Salvar);
            panel1.Controls.Add(DGV_Exemplares);
            panel1.Controls.Add(TB_Livro_ISBN);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CB_Livro_Editoras);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CB_Livro_Autores);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TB_Livro_Titulo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 428);
            panel1.TabIndex = 22;
            // 
            // BT_Add_Exemplares
            // 
            BT_Add_Exemplares.Location = new Point(335, 145);
            BT_Add_Exemplares.Name = "BT_Add_Exemplares";
            BT_Add_Exemplares.Size = new Size(156, 23);
            BT_Add_Exemplares.TabIndex = 22;
            BT_Add_Exemplares.Text = "Adicionar Exemplares";
            BT_Add_Exemplares.UseVisualStyleBackColor = true;
            // 
            // ViewLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 442);
            Controls.Add(panel1);
            Name = "ViewLivro";
            Text = "Livro";
            Load += ViewLivro_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Exemplares).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label11;
        private DataGridView DGV_Exemplares;
        private Button BT_Livro_Apagar;
        private Button BT_Livro_Salvar;
        private TextBox TB_Livro_ISBN;
        private Label label4;
        private ComboBox CB_Livro_Editoras;
        private Label label3;
        private ComboBox CB_Livro_Autores;
        private Label label2;
        private TextBox TB_Livro_Titulo;
        private Label label1;
        private Panel panel1;
        private Button BT_Add_Exemplares;
    }
}