namespace Biblioteca.Forms {
    partial class ViewEditora {
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
            BT_Editora_Apagar = new Button();
            BT_Editora_Salvar = new Button();
            TB_Editora_Nome = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BT_Editora_Apagar
            // 
            BT_Editora_Apagar.Location = new Point(271, 109);
            BT_Editora_Apagar.Name = "BT_Editora_Apagar";
            BT_Editora_Apagar.Size = new Size(75, 23);
            BT_Editora_Apagar.TabIndex = 25;
            BT_Editora_Apagar.Text = "Apagar";
            BT_Editora_Apagar.UseVisualStyleBackColor = true;
            BT_Editora_Apagar.Click += BT_Editora_Apagar_Click;
            // 
            // BT_Editora_Salvar
            // 
            BT_Editora_Salvar.Location = new Point(190, 109);
            BT_Editora_Salvar.Name = "BT_Editora_Salvar";
            BT_Editora_Salvar.Size = new Size(75, 23);
            BT_Editora_Salvar.TabIndex = 24;
            BT_Editora_Salvar.Text = "Salvar";
            BT_Editora_Salvar.UseVisualStyleBackColor = true;
            // 
            // TB_Editora_Nome
            // 
            TB_Editora_Nome.Location = new Point(78, 41);
            TB_Editora_Nome.Name = "TB_Editora_Nome";
            TB_Editora_Nome.Size = new Size(268, 23);
            TB_Editora_Nome.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 44);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 27;
            label7.Text = "Nome";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BT_Editora_Apagar);
            panel1.Controls.Add(BT_Editora_Salvar);
            panel1.Controls.Add(TB_Editora_Nome);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 140);
            panel1.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 23);
            textBox1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 15);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 29;
            label1.Text = "ID";
            // 
            // ViewEditora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 156);
            Controls.Add(panel1);
            Name = "ViewEditora";
            Text = "Editora";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BT_Editora_Apagar;
        private Button BT_Editora_Salvar;
        private TextBox TB_Editora_Nome;
        private Label label7;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
    }
}