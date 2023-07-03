namespace TpFinalProg {
    partial class AsignacionTareaFrm {
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
            label1 = new Label();
            textBox1 = new TextBox();
            cbEmpleado = new ComboBox();
            cbTarea = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dgvTarea = new DataGridView();
            Proyecto = new DataGridViewTextBoxColumn();
            BAJA = new DataGridViewTextBoxColumn();
            Tarea = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            FUNCION = new DataGridViewTextBoxColumn();
            cbFuncion = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cbProyecto = new ComboBox();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            btnGuardar = new Button();
            btnFinalizacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTarea).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 93);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 2;
            // 
            // cbEmpleado
            // 
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(266, 93);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(164, 23);
            cbEmpleado.TabIndex = 3;
            // 
            // cbTarea
            // 
            cbTarea.FormattingEnabled = true;
            cbTarea.Location = new Point(266, 56);
            cbTarea.Name = "cbTarea";
            cbTarea.Size = new Size(164, 23);
            cbTarea.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 59);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Tarea";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 178);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 6;
            label3.Text = "Horas Diarias";
            // 
            // dgvTarea
            // 
            dgvTarea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarea.Columns.AddRange(new DataGridViewColumn[] { Proyecto, BAJA, Tarea, Empleado, FUNCION });
            dgvTarea.Location = new Point(39, 279);
            dgvTarea.Name = "dgvTarea";
            dgvTarea.RowTemplate.Height = 25;
            dgvTarea.Size = new Size(604, 150);
            dgvTarea.TabIndex = 7;
            // 
            // Proyecto
            // 
            Proyecto.DataPropertyName = "id_proyecto";
            Proyecto.HeaderText = "Proyecto";
            Proyecto.Name = "Proyecto";
            Proyecto.Width = 120;
            // 
            // BAJA
            // 
            BAJA.DataPropertyName = "baja";
            BAJA.HeaderText = "Baja";
            BAJA.Name = "BAJA";
            BAJA.Visible = false;
            // 
            // Tarea
            // 
            Tarea.DataPropertyName = "id_tarea";
            Tarea.HeaderText = "Tarea";
            Tarea.Name = "Tarea";
            Tarea.Width = 120;
            // 
            // Empleado
            // 
            Empleado.DataPropertyName = "legajo";
            Empleado.HeaderText = "Empleado";
            Empleado.Name = "Empleado";
            Empleado.Width = 120;
            // 
            // FUNCION
            // 
            FUNCION.DataPropertyName = "id_funcion_fk";
            FUNCION.HeaderText = "Funcion";
            FUNCION.Name = "FUNCION";
            // 
            // cbFuncion
            // 
            cbFuncion.FormattingEnabled = true;
            cbFuncion.Location = new Point(266, 134);
            cbFuncion.Name = "cbFuncion";
            cbFuncion.Size = new Size(164, 23);
            cbFuncion.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 137);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Funcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 22);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "Proyecto";
            // 
            // cbProyecto
            // 
            cbProyecto.FormattingEnabled = true;
            cbProyecto.Location = new Point(266, 19);
            cbProyecto.Name = "cbProyecto";
            cbProyecto.Size = new Size(164, 23);
            cbProyecto.TabIndex = 10;
            cbProyecto.SelectedIndexChanged += cbProyecto_SelectedIndexChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(356, 226);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 30);
            btnLimpiar.TabIndex = 156;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Transparent;
            btnBorrar.BackgroundImageLayout = ImageLayout.None;
            btnBorrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.Location = new Point(240, 226);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(110, 30);
            btnBorrar.TabIndex = 155;
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(124, 226);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 154;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnFinalizacion
            // 
            btnFinalizacion.BackColor = Color.Transparent;
            btnFinalizacion.BackgroundImageLayout = ImageLayout.None;
            btnFinalizacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinalizacion.Location = new Point(472, 226);
            btnFinalizacion.Name = "btnFinalizacion";
            btnFinalizacion.Size = new Size(110, 30);
            btnFinalizacion.TabIndex = 159;
            btnFinalizacion.Text = "Finalizacion";
            btnFinalizacion.UseVisualStyleBackColor = false;
            // 
            // AsignacionTareaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(680, 450);
            Controls.Add(btnFinalizacion);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(cbProyecto);
            Controls.Add(cbFuncion);
            Controls.Add(label4);
            Controls.Add(dgvTarea);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbTarea);
            Controls.Add(cbEmpleado);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AsignacionTareaFrm";
            Text = "AsignacionTarea";
            ((System.ComponentModel.ISupportInitialize)dgvTarea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox cbEmpleado;
        private ComboBox cbTarea;
        private Label label2;
        private Label label3;
        private DataGridView dgvTarea;
        private ComboBox cbFuncion;
        private Label label4;
        private Label label5;
        private ComboBox cbProyecto;
        private Button btnLimpiar;
        private Button btnBorrar;
        private Button btnGuardar;
        private Button btnFinalizacion;
        private DataGridViewTextBoxColumn Proyecto;
        private DataGridViewTextBoxColumn BAJA;
        private DataGridViewTextBoxColumn Tarea;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewTextBoxColumn FUNCION;
    }
}