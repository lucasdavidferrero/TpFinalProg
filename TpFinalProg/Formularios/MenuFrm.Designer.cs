﻿namespace TpFinalProg
{
    partial class MenuFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEmpleados = new Button();
            btnPropietarios = new Button();
            btnProyectos = new Button();
            btnTareas = new Button();
            btnListado = new Button();
            btnAsigTarea = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnEmpleados
            // 
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnEmpleados.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmpleados.Location = new Point(64, 49);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(147, 71);
            btnEmpleados.TabIndex = 0;
            btnEmpleados.Text = "EMPLEADOS";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnPropietarios
            // 
            btnPropietarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnPropietarios.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPropietarios.Location = new Point(245, 49);
            btnPropietarios.Name = "btnPropietarios";
            btnPropietarios.Size = new Size(147, 71);
            btnPropietarios.TabIndex = 1;
            btnPropietarios.Text = "PROPIETARIO";
            btnPropietarios.UseVisualStyleBackColor = true;
            btnPropietarios.Click += btnPropietarios_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnProyectos.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProyectos.Location = new Point(423, 49);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(147, 71);
            btnProyectos.TabIndex = 2;
            btnProyectos.Text = "PROYECTOS";
            btnProyectos.UseVisualStyleBackColor = true;
            btnProyectos.Click += btnProyectos_Click;
            // 
            // btnTareas
            // 
            btnTareas.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnTareas.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTareas.Location = new Point(423, 141);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(147, 71);
            btnTareas.TabIndex = 3;
            btnTareas.Text = "TAREAS";
            btnTareas.UseVisualStyleBackColor = true;
            btnTareas.Click += btnTareas_Click;
            // 
            // btnListado
            // 
            btnListado.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnListado.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnListado.Location = new Point(64, 141);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(149, 73);
            btnListado.TabIndex = 4;
            btnListado.Text = "LISTADOS";
            btnListado.UseVisualStyleBackColor = true;
            btnListado.Click += btnListado_Click;
            // 
            // btnAsigTarea
            // 
            btnAsigTarea.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnAsigTarea.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnAsigTarea.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsigTarea.Location = new Point(245, 140);
            btnAsigTarea.Name = "btnAsigTarea";
            btnAsigTarea.Size = new Size(147, 73);
            btnAsigTarea.TabIndex = 5;
            btnAsigTarea.Text = "ASIGNACIÓN TAREAS";
            btnAsigTarea.UseVisualStyleBackColor = true;
            btnAsigTarea.Click += btnAsigTarea_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 302);
            label2.Name = "label2";
            label2.Size = new Size(346, 15);
            label2.TabIndex = 23;
            label2.Text = "ME OLVIDE DOWNDE IBA OBSERVACIONES JEJEJEJEJE, FALTA ESA";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 457);
            Controls.Add(label2);
            Controls.Add(btnAsigTarea);
            Controls.Add(btnListado);
            Controls.Add(btnTareas);
            Controls.Add(btnProyectos);
            Controls.Add(btnPropietarios);
            Controls.Add(btnEmpleados);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmpleados;
        private Button btnPropietarios;
        private Button btnProyectos;
        private Button btnTareas;
        private Button btnListado;
        private Button btnAsigTarea;
        private Label label2;
    }
}