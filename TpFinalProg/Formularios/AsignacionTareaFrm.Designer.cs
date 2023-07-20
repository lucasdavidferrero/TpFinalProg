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
            cbEmpleado = new ComboBox();
            cbTarea = new ComboBox();
            label2 = new Label();
            dgvTarea = new DataGridView();
            id_trabaja = new DataGridViewTextBoxColumn();
            id_proyecto = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            id_tarea = new DataGridViewTextBoxColumn();
            descripcionTarea = new DataGridViewTextBoxColumn();
            legajo = new DataGridViewTextBoxColumn();
            nombreCompleto = new DataGridViewTextBoxColumn();
            id_funcion = new DataGridViewTextBoxColumn();
            descripcionFuncion = new DataGridViewTextBoxColumn();
            BAJA = new DataGridViewTextBoxColumn();
            cbFuncion = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cbProyecto = new ComboBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            txtIdTrabaja = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTarea).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 102);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleado";
            // 
            // cbEmpleado
            // 
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(247, 102);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(222, 23);
            cbEmpleado.TabIndex = 3;
            // 
            // cbTarea
            // 
            cbTarea.FormattingEnabled = true;
            cbTarea.Location = new Point(247, 65);
            cbTarea.Name = "cbTarea";
            cbTarea.Size = new Size(222, 23);
            cbTarea.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 68);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Tarea";
            // 
            // dgvTarea
            // 
            dgvTarea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarea.Columns.AddRange(new DataGridViewColumn[] { id_trabaja, id_proyecto, nombre, id_tarea, descripcionTarea, legajo, nombreCompleto, id_funcion, descripcionFuncion, BAJA });
            dgvTarea.Location = new Point(37, 242);
            dgvTarea.Name = "dgvTarea";
            dgvTarea.ReadOnly = true;
            dgvTarea.RowTemplate.Height = 25;
            dgvTarea.Size = new Size(684, 298);
            dgvTarea.TabIndex = 7;
            dgvTarea.RowHeaderMouseClick += dgvTarea_RowHeaderMouseClick;
            dgvTarea.RowHeaderMouseDoubleClick += dgvTarea_RowHeaderMouseDoubleClick;
            // 
            // id_trabaja
            // 
            id_trabaja.DataPropertyName = "id_trabaja";
            id_trabaja.HeaderText = "id_trabaja";
            id_trabaja.Name = "id_trabaja";
            id_trabaja.ReadOnly = true;
            id_trabaja.Visible = false;
            // 
            // id_proyecto
            // 
            id_proyecto.DataPropertyName = "id_proyecto";
            id_proyecto.HeaderText = "id_proyecto";
            id_proyecto.Name = "id_proyecto";
            id_proyecto.ReadOnly = true;
            id_proyecto.Visible = false;
            id_proyecto.Width = 120;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Proyecto";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 150;
            // 
            // id_tarea
            // 
            id_tarea.DataPropertyName = "id_tarea";
            id_tarea.HeaderText = "TareaId";
            id_tarea.Name = "id_tarea";
            id_tarea.ReadOnly = true;
            id_tarea.Visible = false;
            // 
            // descripcionTarea
            // 
            descripcionTarea.DataPropertyName = "descripcionTarea";
            descripcionTarea.HeaderText = "Tarea";
            descripcionTarea.Name = "descripcionTarea";
            descripcionTarea.ReadOnly = true;
            descripcionTarea.Width = 180;
            // 
            // legajo
            // 
            legajo.DataPropertyName = "legajo";
            legajo.HeaderText = "legajo_empleado";
            legajo.Name = "legajo";
            legajo.ReadOnly = true;
            legajo.Visible = false;
            legajo.Width = 120;
            // 
            // nombreCompleto
            // 
            nombreCompleto.DataPropertyName = "nombreCompleto";
            nombreCompleto.HeaderText = "Empleado";
            nombreCompleto.Name = "nombreCompleto";
            nombreCompleto.ReadOnly = true;
            nombreCompleto.Width = 150;
            // 
            // id_funcion
            // 
            id_funcion.DataPropertyName = "id_funcion_fk";
            id_funcion.HeaderText = "id_funcion";
            id_funcion.Name = "id_funcion";
            id_funcion.ReadOnly = true;
            id_funcion.Visible = false;
            // 
            // descripcionFuncion
            // 
            descripcionFuncion.DataPropertyName = "descripcionFuncion";
            descripcionFuncion.HeaderText = "Funcion";
            descripcionFuncion.Name = "descripcionFuncion";
            descripcionFuncion.ReadOnly = true;
            descripcionFuncion.Width = 150;
            // 
            // BAJA
            // 
            BAJA.DataPropertyName = "baja";
            BAJA.HeaderText = "Baja";
            BAJA.Name = "BAJA";
            BAJA.ReadOnly = true;
            BAJA.Visible = false;
            // 
            // cbFuncion
            // 
            cbFuncion.FormattingEnabled = true;
            cbFuncion.Location = new Point(247, 143);
            cbFuncion.Name = "cbFuncion";
            cbFuncion.Size = new Size(222, 23);
            cbFuncion.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 146);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Funcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 31);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "Proyecto";
            // 
            // cbProyecto
            // 
            cbProyecto.FormattingEnabled = true;
            cbProyecto.Location = new Point(247, 28);
            cbProyecto.Name = "cbProyecto";
            cbProyecto.Size = new Size(222, 23);
            cbProyecto.TabIndex = 10;
            cbProyecto.SelectedIndexChanged += cbProyecto_SelectedIndexChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(420, 191);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 30);
            btnLimpiar.TabIndex = 156;
            btnLimpiar.Text = "Reiniciar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(304, 191);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 30);
            btnEliminar.TabIndex = 155;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnBorrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(185, 191);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 154;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtIdTrabaja
            // 
            txtIdTrabaja.Location = new Point(66, 31);
            txtIdTrabaja.Name = "txtIdTrabaja";
            txtIdTrabaja.Size = new Size(54, 23);
            txtIdTrabaja.TabIndex = 160;
            txtIdTrabaja.Visible = false;
            // 
            // AsignacionTareaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 586);
            Controls.Add(txtIdTrabaja);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(cbProyecto);
            Controls.Add(cbFuncion);
            Controls.Add(label4);
            Controls.Add(dgvTarea);
            Controls.Add(label2);
            Controls.Add(cbTarea);
            Controls.Add(cbEmpleado);
            Controls.Add(label1);
            Name = "AsignacionTareaFrm";
            Text = "AsignacionTarea";
            ((System.ComponentModel.ISupportInitialize)dgvTarea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbEmpleado;
        private ComboBox cbTarea;
        private Label label2;
        private DataGridView dgvTarea;
        private ComboBox cbFuncion;
        private Label label4;
        private Label label5;
        private ComboBox cbProyecto;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnGuardar;
        private TextBox txtIdTrabaja;
        private DataGridViewTextBoxColumn id_trabaja;
        private DataGridViewTextBoxColumn id_proyecto;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn id_tarea;
        private DataGridViewTextBoxColumn descripcionTarea;
        private DataGridViewTextBoxColumn legajo;
        private DataGridViewTextBoxColumn nombreCompleto;
        private DataGridViewTextBoxColumn id_funcion;
        private DataGridViewTextBoxColumn descripcionFuncion;
        private DataGridViewTextBoxColumn BAJA;
    }
}