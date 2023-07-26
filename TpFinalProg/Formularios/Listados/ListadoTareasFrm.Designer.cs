namespace TpFinalProg.Formularios.Listados {
    partial class ListadoTareasFrm {
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
            cbProyectos = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbProyectos
            // 
            cbProyectos.FormattingEnabled = true;
            cbProyectos.Location = new Point(243, 12);
            cbProyectos.Name = "cbProyectos";
            cbProyectos.Size = new Size(311, 23);
            cbProyectos.TabIndex = 0;
            cbProyectos.TextChanged += cbProyectos_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Proyecto";
            // 
            // ListadoTareasFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cbProyectos);
            Name = "ListadoTareasFrm";
            Text = "ListadoTareasFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbProyectos;
        private Label label1;
    }
}