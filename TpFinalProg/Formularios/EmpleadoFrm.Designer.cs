namespace TpFinalProg {
    partial class EmpleadoFrm {
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
            Label label2;
            Label label3;
            Label label4;
            Label label5;
            Label label7;
            label1 = new Label();
            txtLegajo = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtCelular = new TextBox();
            dateFechaIngreso = new DateTimePicker();
            label8 = new Label();
            btnReiniciar = new Button();
            btnObesrvacion = new Button();
            btnGuardar = new Button();
            dgvEmpleado = new DataGridView();
            legajo = new DataGridViewTextBoxColumn();
            fecha_ingreso = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            celular = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 113);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 38;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 74);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 39;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 114);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 40;
            label4.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 74);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 43;
            label5.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(415, 32);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 44;
            label7.Text = "Fecha Ingreso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(111, 36);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 36;
            label1.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            txtLegajo.Enabled = false;
            txtLegajo.Location = new Point(169, 32);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(199, 23);
            txtLegajo.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(199, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(169, 110);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(199, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(504, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(217, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(504, 70);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(217, 23);
            txtCelular.TabIndex = 3;
            // 
            // dateFechaIngreso
            // 
            dateFechaIngreso.Format = DateTimePickerFormat.Short;
            dateFechaIngreso.Location = new Point(504, 28);
            dateFechaIngreso.Name = "dateFechaIngreso";
            dateFechaIngreso.Size = new Size(217, 23);
            dateFechaIngreso.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(300, -13);
            label8.Name = "label8";
            label8.Size = new Size(0, 19);
            label8.TabIndex = 55;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Transparent;
            btnReiniciar.BackgroundImageLayout = ImageLayout.None;
            btnReiniciar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReiniciar.Location = new Point(426, 167);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(110, 30);
            btnReiniciar.TabIndex = 7;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnObesrvacion
            // 
            btnObesrvacion.BackColor = Color.Transparent;
            btnObesrvacion.BackgroundImageLayout = ImageLayout.None;
            btnObesrvacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnObesrvacion.Location = new Point(542, 167);
            btnObesrvacion.Name = "btnObesrvacion";
            btnObesrvacion.Size = new Size(110, 30);
            btnObesrvacion.TabIndex = 60;
            btnObesrvacion.Text = "Observacion";
            btnObesrvacion.UseVisualStyleBackColor = false;
            btnObesrvacion.Click += btnObesrvacion_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(190, 167);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Columns.AddRange(new DataGridViewColumn[] { legajo, fecha_ingreso, nombre, apellido, celular, email, baja });
            dgvEmpleado.Location = new Point(32, 223);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.ReadOnly = true;
            dgvEmpleado.RowTemplate.Height = 25;
            dgvEmpleado.Size = new Size(774, 204);
            dgvEmpleado.TabIndex = 153;
            dgvEmpleado.RowHeaderMouseClick += dgvEmpleado_RowHeaderMouseClick;
            dgvEmpleado.RowHeaderMouseDoubleClick += dgvEmpleado_RowHeaderMouseDoubleClick;
            // 
            // legajo
            // 
            legajo.DataPropertyName = "legajo";
            legajo.Frozen = true;
            legajo.HeaderText = "Legajo";
            legajo.Name = "legajo";
            legajo.ReadOnly = true;
            legajo.Width = 80;
            // 
            // fecha_ingreso
            // 
            fecha_ingreso.DataPropertyName = "fecha_ingreso";
            fecha_ingreso.Frozen = true;
            fecha_ingreso.HeaderText = "Fecha Ingreso";
            fecha_ingreso.Name = "fecha_ingreso";
            fecha_ingreso.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.Frozen = true;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 150;
            // 
            // apellido
            // 
            apellido.DataPropertyName = "apellido";
            apellido.Frozen = true;
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Width = 150;
            // 
            // celular
            // 
            celular.DataPropertyName = "celular";
            celular.Frozen = true;
            celular.HeaderText = "Celular";
            celular.Name = "celular";
            celular.ReadOnly = true;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.Frozen = true;
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 150;
            // 
            // baja
            // 
            baja.DataPropertyName = "baja";
            baja.Frozen = true;
            baja.HeaderText = "baja";
            baja.Name = "baja";
            baja.ReadOnly = true;
            baja.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(306, 167);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 30);
            btnEliminar.TabIndex = 154;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // EmpleadoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(840, 441);
            Controls.Add(btnEliminar);
            Controls.Add(dgvEmpleado);
            Controls.Add(btnGuardar);
            Controls.Add(btnObesrvacion);
            Controls.Add(btnReiniciar);
            Controls.Add(label8);
            Controls.Add(dateFechaIngreso);
            Controls.Add(txtCelular);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLegajo);
            Controls.Add(label1);
            Name = "EmpleadoFrm";
            Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtLegajo;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtCelular;
        private DateTimePicker dateFechaIngreso;
        private Label label8;
        private Button btnReiniciar;
        private Button btnObesrvacion;
        private Button btnGuardar;
        private DataGridView dgvEmpleado;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn legajo;
        private DataGridViewTextBoxColumn fecha_ingreso;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn celular;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn baja;
    }
}