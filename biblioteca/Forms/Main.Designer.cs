﻿namespace Biblioteca.Forms {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            tabControl1 = new TabControl();
            TP_Buscar = new TabPage();
            GB_TipoBusca = new GroupBox();
            RB_Editora = new RadioButton();
            RB_Autor = new RadioButton();
            RB_Livro = new RadioButton();
            BT_Buscar = new Button();
            TB_Buscar = new TextBox();
            DGV_Busca = new DataGridView();
            tabControl1.SuspendLayout();
            TP_Buscar.SuspendLayout();
            GB_TipoBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Busca).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TP_Buscar);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 3;
            // 
            // TP_Buscar
            // 
            TP_Buscar.Controls.Add(GB_TipoBusca);
            TP_Buscar.Controls.Add(BT_Buscar);
            TP_Buscar.Controls.Add(TB_Buscar);
            TP_Buscar.Controls.Add(DGV_Busca);
            TP_Buscar.Location = new Point(4, 24);
            TP_Buscar.Name = "TP_Buscar";
            TP_Buscar.Padding = new Padding(3);
            TP_Buscar.Size = new Size(768, 398);
            TP_Buscar.TabIndex = 0;
            TP_Buscar.Text = "Buscar";
            TP_Buscar.UseVisualStyleBackColor = true;
            // 
            // GB_TipoBusca
            // 
            GB_TipoBusca.Controls.Add(RB_Editora);
            GB_TipoBusca.Controls.Add(RB_Autor);
            GB_TipoBusca.Controls.Add(RB_Livro);
            GB_TipoBusca.Location = new Point(6, 10);
            GB_TipoBusca.Name = "GB_TipoBusca";
            GB_TipoBusca.Size = new Size(197, 63);
            GB_TipoBusca.TabIndex = 12;
            GB_TipoBusca.TabStop = false;
            GB_TipoBusca.Text = "Tipo de Busca";
            // 
            // RB_Editora
            // 
            RB_Editora.AutoSize = true;
            RB_Editora.Location = new Point(131, 29);
            RB_Editora.Name = "RB_Editora";
            RB_Editora.Size = new Size(62, 19);
            RB_Editora.TabIndex = 15;
            RB_Editora.TabStop = true;
            RB_Editora.Text = "Editora";
            RB_Editora.UseVisualStyleBackColor = true;
            // 
            // RB_Autor
            // 
            RB_Autor.AutoSize = true;
            RB_Autor.Location = new Point(70, 29);
            RB_Autor.Name = "RB_Autor";
            RB_Autor.Size = new Size(55, 19);
            RB_Autor.TabIndex = 14;
            RB_Autor.TabStop = true;
            RB_Autor.Text = "Autor";
            RB_Autor.UseVisualStyleBackColor = true;
            // 
            // RB_Livro
            // 
            RB_Livro.AutoSize = true;
            RB_Livro.Location = new Point(13, 29);
            RB_Livro.Name = "RB_Livro";
            RB_Livro.Size = new Size(51, 19);
            RB_Livro.TabIndex = 13;
            RB_Livro.TabStop = true;
            RB_Livro.Text = "Livro";
            RB_Livro.UseVisualStyleBackColor = true;
            // 
            // BT_Buscar
            // 
            BT_Buscar.Location = new Point(662, 76);
            BT_Buscar.Name = "BT_Buscar";
            BT_Buscar.Size = new Size(100, 23);
            BT_Buscar.TabIndex = 11;
            BT_Buscar.Text = "Buscar";
            BT_Buscar.UseVisualStyleBackColor = true;
            BT_Buscar.Click += BT_Buscar_Click;
            // 
            // TB_Buscar
            // 
            TB_Buscar.Location = new Point(6, 76);
            TB_Buscar.Name = "TB_Buscar";
            TB_Buscar.Size = new Size(650, 23);
            TB_Buscar.TabIndex = 10;
            // 
            // DGV_Busca
            // 
            DGV_Busca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Busca.Location = new Point(6, 105);
            DGV_Busca.Name = "DGV_Busca";
            DGV_Busca.Size = new Size(756, 287);
            DGV_Busca.TabIndex = 8;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Main";
            Text = "Main";
            tabControl1.ResumeLayout(false);
            TP_Buscar.ResumeLayout(false);
            TP_Buscar.PerformLayout();
            GB_TipoBusca.ResumeLayout(false);
            GB_TipoBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Busca).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        public TabPage TP_Buscar;
        private GroupBox GB_TipoBusca;
        private RadioButton RB_Editora;
        private RadioButton RB_Autor;
        private RadioButton RB_Livro;
        private Button BT_Buscar;
        private TextBox TB_Buscar;
        private DataGridView DGV_Busca;
    }
}