namespace TpFinalProg.Formularios {
    partial class MenuListadoFrm {
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
            btnEmpleados = new Button();
            btnResponsable = new Button();
            btnProyecto = new Button();
            btnTarea = new Button();
            btnPropietarios = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.Transparent;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnEmpleados.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmpleados.Location = new Point(69, 38);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(189, 75);
            btnEmpleados.TabIndex = 13;
            btnEmpleados.Text = "EMPLEADOS";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnResponsable
            // 
            btnResponsable.BackColor = Color.Transparent;
            btnResponsable.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnResponsable.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnResponsable.Location = new Point(69, 223);
            btnResponsable.Name = "btnResponsable";
            btnResponsable.Size = new Size(189, 75);
            btnResponsable.TabIndex = 14;
            btnResponsable.Text = "RESPONSABLE PROYETO";
            btnResponsable.UseVisualStyleBackColor = false;
            btnResponsable.Click += btnResponsable_Click;
            // 
            // btnProyecto
            // 
            btnProyecto.BackColor = Color.Transparent;
            btnProyecto.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnProyecto.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProyecto.Location = new Point(69, 314);
            btnProyecto.Name = "btnProyecto";
            btnProyecto.Size = new Size(189, 75);
            btnProyecto.TabIndex = 15;
            btnProyecto.Text = "PROYECTOS";
            btnProyecto.UseVisualStyleBackColor = false;
            // 
            // btnTarea
            // 
            btnTarea.BackColor = Color.Transparent;
            btnTarea.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnTarea.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTarea.Location = new Point(69, 404);
            btnTarea.Name = "btnTarea";
            btnTarea.Size = new Size(189, 75);
            btnTarea.TabIndex = 16;
            btnTarea.Text = "TAREAS";
            btnTarea.UseVisualStyleBackColor = false;
            // 
            // btnPropietarios
            // 
            btnPropietarios.BackColor = Color.Transparent;
            btnPropietarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnPropietarios.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPropietarios.Location = new Point(69, 132);
            btnPropietarios.Name = "btnPropietarios";
            btnPropietarios.Size = new Size(189, 75);
            btnPropietarios.TabIndex = 17;
            btnPropietarios.Text = "PROPIETARIOS";
            btnPropietarios.UseVisualStyleBackColor = false;
            btnPropietarios.Click += btnPropietarios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(458, 223);
            label1.Name = "label1";
            label1.Size = new Size(789, 15);
            label1.TabIndex = 18;
            label1.Text = "PONEMOS DOS BOTENES? UNO DE ALTAS Y OTRO DE BAJAS, PARA BUSCAR LOS PROYECTOS DE ABAJAS O LO DEJASMOS SIN BUSCVAR LAS BAJAS?";
            // 
            // MenuListadoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1515, 505);
            Controls.Add(label1);
            Controls.Add(btnPropietarios);
            Controls.Add(btnTarea);
            Controls.Add(btnProyecto);
            Controls.Add(btnResponsable);
            Controls.Add(btnEmpleados);
            Name = "MenuListadoFrm";
            Text = "MenuListadoFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmpleados;
        private Button btnResponsable;
        private Button btnProyecto;
        private Button btnTarea;
        private Button btnPropietarios;
        private Label label1;
    }
}