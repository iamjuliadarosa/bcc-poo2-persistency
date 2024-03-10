namespace Biblioteca.Forms {
    partial class ViewCliente {
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
            BT_Cliente_Apagar = new Button();
            BT_CLiente_Salvar = new Button();
            TB_Cliente_Nome = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BT_Cliente_Apagar
            // 
            BT_Cliente_Apagar.Location = new Point(313, 123);
            BT_Cliente_Apagar.Name = "BT_Cliente_Apagar";
            BT_Cliente_Apagar.Size = new Size(75, 23);
            BT_Cliente_Apagar.TabIndex = 25;
            BT_Cliente_Apagar.Text = "Apagar";
            BT_Cliente_Apagar.UseVisualStyleBackColor = true;
            // 
            // BT_CLiente_Salvar
            // 
            BT_CLiente_Salvar.Location = new Point(232, 123);
            BT_CLiente_Salvar.Name = "BT_CLiente_Salvar";
            BT_CLiente_Salvar.Size = new Size(75, 23);
            BT_CLiente_Salvar.TabIndex = 24;
            BT_CLiente_Salvar.Text = "Salvar";
            BT_CLiente_Salvar.UseVisualStyleBackColor = true;
            // 
            // TB_Cliente_Nome
            // 
            TB_Cliente_Nome.Location = new Point(71, 55);
            TB_Cliente_Nome.Name = "TB_Cliente_Nome";
            TB_Cliente_Nome.Size = new Size(317, 23);
            TB_Cliente_Nome.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 58);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 27;
            label9.Text = "Nome";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BT_Cliente_Apagar);
            panel1.Controls.Add(BT_CLiente_Salvar);
            panel1.Controls.Add(TB_Cliente_Nome);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 160);
            panel1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 28;
            label1.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 29;
            // 
            // ViewCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 181);
            Controls.Add(panel1);
            Name = "ViewCliente";
            Text = "Cliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BT_Cliente_Apagar;
        private Button BT_CLiente_Salvar;
        private TextBox TB_Cliente_Nome;
        private Label label9;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
    }
}