namespace TpFinalProg.Formularios {
    partial class MenuListadosFrm {
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
            btnListadoTareasPorProyecto = new Button();
            btnListadoProyectos = new Button();
            btnPropietariosPorProyecto = new Button();
            btnListadoPersonas = new Button();
            SuspendLayout();
            // 
            // btnListadoTareasPorProyecto
            // 
            btnListadoTareasPorProyecto.BackColor = Color.Transparent;
            btnListadoTareasPorProyecto.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnListadoTareasPorProyecto.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnListadoTareasPorProyecto.Location = new Point(78, 37);
            btnListadoTareasPorProyecto.Name = "btnListadoTareasPorProyecto";
            btnListadoTareasPorProyecto.Size = new Size(189, 75);
            btnListadoTareasPorProyecto.TabIndex = 13;
            btnListadoTareasPorProyecto.Text = "Tareas por Proyecto";
            btnListadoTareasPorProyecto.UseVisualStyleBackColor = false;
            btnListadoTareasPorProyecto.Click += btnListadoTareasPorProyecto_Click;
            // 
            // btnListadoProyectos
            // 
            btnListadoProyectos.BackColor = Color.Transparent;
            btnListadoProyectos.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnListadoProyectos.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnListadoProyectos.Location = new Point(78, 132);
            btnListadoProyectos.Name = "btnListadoProyectos";
            btnListadoProyectos.Size = new Size(189, 75);
            btnListadoProyectos.TabIndex = 14;
            btnListadoProyectos.Text = "Proyectos";
            btnListadoProyectos.UseVisualStyleBackColor = false;
            // 
            // btnPropietariosPorProyecto
            // 
            btnPropietariosPorProyecto.BackColor = Color.Transparent;
            btnPropietariosPorProyecto.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnPropietariosPorProyecto.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPropietariosPorProyecto.Location = new Point(78, 225);
            btnPropietariosPorProyecto.Name = "btnPropietariosPorProyecto";
            btnPropietariosPorProyecto.Size = new Size(189, 75);
            btnPropietariosPorProyecto.TabIndex = 15;
            btnPropietariosPorProyecto.Text = "Buscar Propietario";
            btnPropietariosPorProyecto.UseVisualStyleBackColor = false;
            btnPropietariosPorProyecto.Click += btnPropietariosPorProyecto_Click;
            // 
            // btnListadoPersonas
            // 
            btnListadoPersonas.BackColor = Color.Transparent;
            btnListadoPersonas.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnListadoPersonas.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnListadoPersonas.Location = new Point(78, 321);
            btnListadoPersonas.Name = "btnListadoPersonas";
            btnListadoPersonas.Size = new Size(189, 75);
            btnListadoPersonas.TabIndex = 16;
            btnListadoPersonas.Text = "Personas";
            btnListadoPersonas.UseVisualStyleBackColor = false;
            btnListadoPersonas.Click += btnListadoPersonas_Click;
            // 
            // MenuListadosFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(357, 434);
            Controls.Add(btnListadoPersonas);
            Controls.Add(btnPropietariosPorProyecto);
            Controls.Add(btnListadoProyectos);
            Controls.Add(btnListadoTareasPorProyecto);
            Name = "MenuListadosFrm";
            Text = "MenuListadosFrm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnListadoTareasPorProyecto;
        private Button btnListadoProyectos;
        private Button btnPropietariosPorProyecto;
        private Button btnListadoPersonas;
    }
}