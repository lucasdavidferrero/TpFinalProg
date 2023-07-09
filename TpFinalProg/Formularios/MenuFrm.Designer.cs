namespace TpFinalProg {
    partial class MenuFrm {
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
            btnTareas = new Button();
            btnProyectos = new Button();
            btnPropietarios = new Button();
            btnEmpleados = new Button();
            btnListados = new Button();
            SuspendLayout();
            // 
            // btnTareas
            // 
            btnTareas.BackColor = Color.Transparent;
            btnTareas.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnTareas.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTareas.Location = new Point(72, 320);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(189, 73);
            btnTareas.TabIndex = 15;
            btnTareas.Text = "TAREAS";
            btnTareas.UseVisualStyleBackColor = false;
            btnTareas.Click += btnTareas_Click_1;
            // 
            // btnProyectos
            // 
            btnProyectos.BackColor = Color.Transparent;
            btnProyectos.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnProyectos.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProyectos.Location = new Point(72, 226);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(189, 73);
            btnProyectos.TabIndex = 14;
            btnProyectos.Text = "ABM PROYECTOS";
            btnProyectos.UseVisualStyleBackColor = false;
            btnProyectos.Click += btnProyectos_Click_1;
            // 
            // btnPropietarios
            // 
            btnPropietarios.BackColor = Color.Transparent;
            btnPropietarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnPropietarios.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPropietarios.Location = new Point(72, 133);
            btnPropietarios.Name = "btnPropietarios";
            btnPropietarios.Size = new Size(189, 73);
            btnPropietarios.TabIndex = 13;
            btnPropietarios.Text = "ABM PROPIETARIO";
            btnPropietarios.UseVisualStyleBackColor = false;
            btnPropietarios.Click += btnPropietarios_Click_1;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.Transparent;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnEmpleados.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmpleados.Location = new Point(72, 38);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(189, 75);
            btnEmpleados.TabIndex = 12;
            btnEmpleados.Text = "ABM EMPLEADOS";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click_1;
            // 
            // btnListados
            // 
            btnListados.BackColor = Color.Transparent;
            btnListados.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnListados.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnListados.Location = new Point(72, 414);
            btnListados.Name = "btnListados";
            btnListados.Size = new Size(189, 73);
            btnListados.TabIndex = 19;
            btnListados.Text = "LISTADOS";
            btnListados.UseVisualStyleBackColor = false;
            btnListados.Click += btnListados_Click;
            // 
            // MenuFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(342, 529);
            Controls.Add(btnListados);
            Controls.Add(btnTareas);
            Controls.Add(btnProyectos);
            Controls.Add(btnPropietarios);
            Controls.Add(btnEmpleados);
            Name = "MenuFrm";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion
        private Button btnTareas;
        private Button btnProyectos;
        private Button btnPropietarios;
        private Button btnEmpleados;
        private Button btnListados;
    }
}