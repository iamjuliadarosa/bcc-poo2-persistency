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
        private void InitializeComponent() {
            GB_TipoPersistencia = new GroupBox();
            RB_XML = new RadioButton();
            RB_JSON = new RadioButton();
            RB_DB = new RadioButton();
            BTN_Entrar = new Button();
            GB_TipoPersistencia.SuspendLayout();
            SuspendLayout();
            // 
            // GB_TipoPersistencia
            // 
            GB_TipoPersistencia.Controls.Add(RB_XML);
            GB_TipoPersistencia.Controls.Add(RB_JSON);
            GB_TipoPersistencia.Controls.Add(RB_DB);
            GB_TipoPersistencia.Location = new Point(80, 12);
            GB_TipoPersistencia.Name = "GB_TipoPersistencia";
            GB_TipoPersistencia.Size = new Size(137, 100);
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
            // BTN_Entrar
            // 
            BTN_Entrar.Location = new Point(113, 133);
            BTN_Entrar.Name = "BTN_Entrar";
            BTN_Entrar.Size = new Size(75, 23);
            BTN_Entrar.TabIndex = 4;
            BTN_Entrar.Text = "Entrar";
            BTN_Entrar.UseVisualStyleBackColor = true;
            BTN_Entrar.Click += BTN_Entrar_Click;
            // 
            // Biblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 181);
            Controls.Add(BTN_Entrar);
            Controls.Add(GB_TipoPersistencia);
            Name = "Biblioteca";
            Text = "Biblioteca";
            Load += Biblioteca_Load;
            GB_TipoPersistencia.ResumeLayout(false);
            GB_TipoPersistencia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox GB_TipoPersistencia;
        private RadioButton RB_XML;
        private RadioButton RB_JSON;
        private RadioButton RB_DB;
        private Button BTN_Entrar;
    }
}
