namespace TpFinalProg.Formularios {
    partial class MenuPersonasFrm {
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
            btnPropietario = new Button();
            btnEmpleado = new Button();
            SuspendLayout();
            // 
            // btnPropietario
            // 
            btnPropietario.BackColor = Color.Transparent;
            btnPropietario.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnPropietario.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnPropietario.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPropietario.Location = new Point(48, 184);
            btnPropietario.Name = "btnPropietario";
            btnPropietario.Size = new Size(189, 68);
            btnPropietario.TabIndex = 19;
            btnPropietario.Text = "PROPIETARIO";
            btnPropietario.UseVisualStyleBackColor = false;
            btnPropietario.Click += btnPropietario_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackColor = Color.Transparent;
            btnEmpleado.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnEmpleado.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmpleado.Location = new Point(48, 84);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(189, 68);
            btnEmpleado.TabIndex = 18;
            btnEmpleado.Text = "EMPLEADO";
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // MenuPersonasFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(280, 327);
            Controls.Add(btnPropietario);
            Controls.Add(btnEmpleado);
            Name = "MenuPersonasFrm";
            Text = "MenuPersonasFrm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPropietario;
        private Button btnEmpleado;
    }
}