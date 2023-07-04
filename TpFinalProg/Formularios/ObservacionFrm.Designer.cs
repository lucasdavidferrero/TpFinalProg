namespace TpFinalProg {
    partial class ObservacionFrm {
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
            txtObservacion = new TextBox();
            label2 = new Label();
            dgvObservacion = new DataGridView();
            column1 = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            BAJA = new DataGridViewTextBoxColumn();
            OBSERVACION = new DataGridViewTextBoxColumn();
            legajo = new DataGridViewTextBoxColumn();
            label4 = new Label();
            date = new DateTimePicker();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            cbEmpleado = new ComboBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvObservacion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 22);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 35;
            label1.Text = "Empleado:";
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(187, 70);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(360, 123);
            txtObservacion.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 122);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 47;
            label2.Text = "Observacion:";
            // 
            // dgvObservacion
            // 
            dgvObservacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObservacion.Columns.AddRange(new DataGridViewColumn[] { column1, fecha, ID, BAJA, OBSERVACION, legajo });
            dgvObservacion.Location = new Point(57, 259);
            dgvObservacion.Name = "dgvObservacion";
            dgvObservacion.ReadOnly = true;
            dgvObservacion.RowTemplate.Height = 25;
            dgvObservacion.Size = new Size(594, 180);
            dgvObservacion.TabIndex = 49;
            dgvObservacion.RowHeaderMouseClick += dgvObservacion_RowHeaderMouseClick;
            dgvObservacion.RowHeaderMouseDoubleClick += dgvObservacion_RowHeaderMouseDoubleClick;
            // 
            // column1
            // 
            column1.DataPropertyName = "column1";
            column1.HeaderText = "Nombre";
            column1.Name = "column1";
            column1.ReadOnly = true;
            // 
            // fecha
            // 
            fecha.DataPropertyName = "fecha";
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // ID
            // 
            ID.DataPropertyName = "id_observacion";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // BAJA
            // 
            BAJA.DataPropertyName = "baja";
            BAJA.HeaderText = "BAJA";
            BAJA.Name = "BAJA";
            BAJA.ReadOnly = true;
            BAJA.Visible = false;
            // 
            // OBSERVACION
            // 
            OBSERVACION.DataPropertyName = "observacion";
            OBSERVACION.HeaderText = "Observacion";
            OBSERVACION.Name = "OBSERVACION";
            OBSERVACION.ReadOnly = true;
            OBSERVACION.Width = 350;
            // 
            // legajo
            // 
            legajo.DataPropertyName = "legajo_FK";
            legajo.HeaderText = "Legajo";
            legajo.Name = "legajo";
            legajo.ReadOnly = true;
            legajo.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 22);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 50;
            label4.Text = "Fecha:";
            // 
            // date
            // 
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(437, 18);
            date.Name = "date";
            date.Size = new Size(110, 23);
            date.TabIndex = 51;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(426, 213);
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
            btnEliminar.Location = new Point(310, 213);
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
            btnGuardar.Location = new Point(194, 213);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 154;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbEmpleado
            // 
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(187, 18);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(148, 23);
            cbEmpleado.TabIndex = 157;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(341, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(26, 23);
            btnBuscar.TabIndex = 158;
            btnBuscar.Text = "🔍︎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ObservacionFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 461);
            Controls.Add(btnBuscar);
            Controls.Add(cbEmpleado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(date);
            Controls.Add(label4);
            Controls.Add(dgvObservacion);
            Controls.Add(label2);
            Controls.Add(txtObservacion);
            Controls.Add(label1);
            Name = "ObservacionFrm";
            Text = "Observacion";
            ((System.ComponentModel.ISupportInitialize)dgvObservacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtObservacion;
        private Label label2;
        private DataGridView dgvObservacion;
        private Label label4;
        private DateTimePicker date;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnGuardar;
        private ComboBox cbEmpleado;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BAJA;
        private DataGridViewTextBoxColumn OBSERVACION;
        private DataGridViewTextBoxColumn legajo;
    }
}