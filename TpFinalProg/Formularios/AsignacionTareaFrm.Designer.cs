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
            id_proyecto = new DataGridViewTextBoxColumn();
            nombre_proyecto = new DataGridViewTextBoxColumn();
            id_tarea = new DataGridViewTextBoxColumn();
            legajo = new DataGridViewTextBoxColumn();
            nombre_empleado = new DataGridViewTextBoxColumn();
            id_funcion_fk = new DataGridViewTextBoxColumn();
            nombre_funcion = new DataGridViewTextBoxColumn();
            BAJA = new DataGridViewTextBoxColumn();
            cbFuncion = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cbProyecto = new ComboBox();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
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
            dgvTarea.Columns.AddRange(new DataGridViewColumn[] { id_proyecto, nombre_proyecto, id_tarea, legajo, nombre_empleado, id_funcion_fk, nombre_funcion, BAJA });
            dgvTarea.Location = new Point(39, 275);
            dgvTarea.Name = "dgvTarea";
            dgvTarea.RowTemplate.Height = 25;
            dgvTarea.Size = new Size(604, 150);
            dgvTarea.TabIndex = 7;
            dgvTarea.CellContentClick += dgvTarea_CellContentClick;
            dgvTarea.CellFormatting += dgvTarea_CellFormatting;
            dgvTarea.SelectionChanged += dgvTarea_SelectionChanged;
            // 
            // id_proyecto
            // 
            id_proyecto.DataPropertyName = "id_proyecto";
            id_proyecto.HeaderText = "id_proyecto";
            id_proyecto.Name = "id_proyecto";
            id_proyecto.Visible = false;
            id_proyecto.Width = 120;
            // 
            // nombre_proyecto
            // 
            nombre_proyecto.DataPropertyName = "proyecto";
            nombre_proyecto.HeaderText = "Proyecto";
            nombre_proyecto.Name = "nombre_proyecto";
            // 
            // id_tarea
            // 
            id_tarea.DataPropertyName = "id_tarea";
            id_tarea.HeaderText = "Tarea";
            id_tarea.Name = "id_tarea";
            // 
            // legajo
            // 
            legajo.DataPropertyName = "legajo";
            legajo.HeaderText = "legajo_empleado";
            legajo.Name = "legajo";
            legajo.Visible = false;
            legajo.Width = 120;
            // 
            // nombre_empleado
            // 
            nombre_empleado.DataPropertyName = "empleado";
            nombre_empleado.HeaderText = "Empleado";
            nombre_empleado.Name = "nombre_empleado";
            // 
            // id_funcion_fk
            // 
            id_funcion_fk.DataPropertyName = "id_funcion_fk";
            id_funcion_fk.HeaderText = "id_funcion";
            id_funcion_fk.Name = "id_funcion_fk";
            id_funcion_fk.Visible = false;
            // 
            // nombre_funcion
            // 
            nombre_funcion.DataPropertyName = "funcion";
            nombre_funcion.HeaderText = "Funcion";
            nombre_funcion.Name = "nombre_funcion";
            // 
            // BAJA
            // 
            BAJA.DataPropertyName = "baja";
            BAJA.HeaderText = "Baja";
            BAJA.Name = "BAJA";
            BAJA.Visible = false;
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
            btnLimpiar.Text = "Resetear ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
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
            // btnModificar
            // 
            btnModificar.BackColor = Color.Transparent;
            btnModificar.BackgroundImageLayout = ImageLayout.None;
            btnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(472, 226);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(110, 30);
            btnModificar.TabIndex = 159;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnFinalizacion_Click;
            // 
            // AsignacionTareaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(680, 450);
            Controls.Add(btnModificar);
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
        private Button btnModificar;
        private DataGridViewTextBoxColumn id_proyecto;
        private DataGridViewTextBoxColumn nombre_proyecto;
        private DataGridViewTextBoxColumn id_tarea;
        private DataGridViewTextBoxColumn legajo;
        private DataGridViewTextBoxColumn nombre_empleado;
        private DataGridViewTextBoxColumn id_funcion_fk;
        private DataGridViewTextBoxColumn nombre_funcion;
        private DataGridViewTextBoxColumn BAJA;
    }
}