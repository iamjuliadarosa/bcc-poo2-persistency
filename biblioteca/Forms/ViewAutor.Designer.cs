namespace Biblioteca.Forms {
    partial class ViewAutor {
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
            BT_Autor_Apagar = new Button();
            BT_Autor_Salvar = new Button();
            TB_Autor_Nome = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            TB_ID = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BT_Autor_Apagar
            // 
            BT_Autor_Apagar.Location = new Point(288, 89);
            BT_Autor_Apagar.Name = "BT_Autor_Apagar";
            BT_Autor_Apagar.Size = new Size(75, 23);
            BT_Autor_Apagar.TabIndex = 25;
            BT_Autor_Apagar.Text = "Apagar";
            BT_Autor_Apagar.UseVisualStyleBackColor = true;
            BT_Autor_Apagar.Click += BT_Autor_Apagar_Click;
            // 
            // BT_Autor_Salvar
            // 
            BT_Autor_Salvar.Location = new Point(207, 89);
            BT_Autor_Salvar.Name = "BT_Autor_Salvar";
            BT_Autor_Salvar.Size = new Size(75, 23);
            BT_Autor_Salvar.TabIndex = 24;
            BT_Autor_Salvar.Text = "Salvar";
            BT_Autor_Salvar.UseVisualStyleBackColor = true;
            BT_Autor_Salvar.Click += BT_Autor_Salvar_Click;
            // 
            // TB_Autor_Nome
            // 
            TB_Autor_Nome.Location = new Point(74, 44);
            TB_Autor_Nome.Name = "TB_Autor_Nome";
            TB_Autor_Nome.Size = new Size(289, 23);
            TB_Autor_Nome.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 47);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 20;
            label5.Text = "Nome";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(TB_ID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BT_Autor_Apagar);
            panel1.Controls.Add(BT_Autor_Salvar);
            panel1.Controls.Add(TB_Autor_Nome);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 132);
            panel1.TabIndex = 26;
            // 
            // TB_ID
            // 
            TB_ID.Location = new Point(74, 15);
            TB_ID.Name = "TB_ID";
            TB_ID.ReadOnly = true;
            TB_ID.Size = new Size(100, 23);
            TB_ID.TabIndex = 27;
            TB_ID.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 26;
            label1.Text = "ID";
            // 
            // ViewAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 153);
            Controls.Add(panel1);
            MaximumSize = new Size(422, 192);
            MinimumSize = new Size(422, 192);
            Name = "ViewAutor";
            Text = "Autor";
            Load += ViewAutor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BT_Autor_Apagar;
        private Button BT_Autor_Salvar;
        private TextBox TB_Autor_Nome;
        private Label label5;
        private Panel panel1;
        private TextBox TB_ID;
        private Label label1;
    }
}