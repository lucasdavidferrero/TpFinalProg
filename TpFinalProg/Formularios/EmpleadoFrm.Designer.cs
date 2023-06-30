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
            txtNombreEmp = new TextBox();
            txtApellidoEmp = new TextBox();
            txtEmailEmp = new TextBox();
            txtTelefonoEmp = new TextBox();
            dgvEmpleado = new DataGridView();
            LEGAJO = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Baja = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDO = new DataGridViewTextBoxColumn();
            FECHAINGRESO = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            dateFechaIngreso = new DateTimePicker();
            btnBuscar = new Button();
            label8 = new Label();
            btnBaja = new Button();
            btnReiniciar = new Button();
            btnBorrar = new Button();
            btnObesrvacion = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
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
            label2.Location = new Point(423, 70);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 38;
            label2.Text = "EMAIL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 69);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 39;
            label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 109);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 40;
            label4.Text = "APELLIDO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 113);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 43;
            label5.Text = "TELEFONO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 27);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 44;
            label7.Text = "FECHA INGRESO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(43, 31);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 36;
            label1.Text = "LEGAJO:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(101, 27);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(199, 23);
            txtLegajo.TabIndex = 37;
            // 
            // txtNombreEmp
            // 
            txtNombreEmp.Location = new Point(101, 65);
            txtNombreEmp.Name = "txtNombreEmp";
            txtNombreEmp.Size = new Size(199, 23);
            txtNombreEmp.TabIndex = 41;
            // 
            // txtApellidoEmp
            // 
            txtApellidoEmp.Location = new Point(101, 105);
            txtApellidoEmp.Name = "txtApellidoEmp";
            txtApellidoEmp.Size = new Size(199, 23);
            txtApellidoEmp.TabIndex = 42;
            // 
            // txtEmailEmp
            // 
            txtEmailEmp.Location = new Point(474, 66);
            txtEmailEmp.Name = "txtEmailEmp";
            txtEmailEmp.Size = new Size(217, 23);
            txtEmailEmp.TabIndex = 45;
            // 
            // txtTelefonoEmp
            // 
            txtTelefonoEmp.Location = new Point(474, 109);
            txtTelefonoEmp.Name = "txtTelefonoEmp";
            txtTelefonoEmp.Size = new Size(217, 23);
            txtTelefonoEmp.TabIndex = 46;
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Columns.AddRange(new DataGridViewColumn[] { LEGAJO, ID, Baja, NOMBRE, APELLIDO, FECHAINGRESO, EMAIL, TELEFONO });
            dgvEmpleado.Location = new Point(36, 217);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.RowTemplate.Height = 25;
            dgvEmpleado.Size = new Size(655, 202);
            dgvEmpleado.TabIndex = 47;
            // 
            // LEGAJO
            // 
            LEGAJO.HeaderText = "LEGAJO";
            LEGAJO.Name = "LEGAJO";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // Baja
            // 
            Baja.HeaderText = "baja";
            Baja.Name = "Baja";
            Baja.Visible = false;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDO
            // 
            APELLIDO.HeaderText = "APELLIDO";
            APELLIDO.Name = "APELLIDO";
            // 
            // FECHAINGRESO
            // 
            FECHAINGRESO.HeaderText = "FECHA INGRESO";
            FECHAINGRESO.Name = "FECHAINGRESO";
            // 
            // EMAIL
            // 
            EMAIL.HeaderText = "EMAIL";
            EMAIL.Name = "EMAIL";
            // 
            // TELEFONO
            // 
            TELEFONO.HeaderText = "TELEFONO";
            TELEFONO.Name = "TELEFONO";
            // 
            // dateFechaIngreso
            // 
            dateFechaIngreso.Format = DateTimePickerFormat.Short;
            dateFechaIngreso.Location = new Point(474, 23);
            dateFechaIngreso.Name = "dateFechaIngreso";
            dateFechaIngreso.Size = new Size(217, 23);
            dateFechaIngreso.TabIndex = 150;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(306, 25);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(29, 27);
            btnBuscar.TabIndex = 53;
            btnBuscar.Text = "🔍︎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
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
            // btnBaja
            // 
            btnBaja.BackColor = Color.Transparent;
            btnBaja.BackgroundImageLayout = ImageLayout.None;
            btnBaja.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaja.Location = new Point(371, 159);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(110, 30);
            btnBaja.TabIndex = 59;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = false;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Transparent;
            btnReiniciar.BackgroundImageLayout = ImageLayout.None;
            btnReiniciar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReiniciar.Location = new Point(487, 159);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(110, 30);
            btnReiniciar.TabIndex = 58;
            btnReiniciar.Text = "Limpiar";
            btnReiniciar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Transparent;
            btnBorrar.BackgroundImageLayout = ImageLayout.None;
            btnBorrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.Location = new Point(255, 159);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(110, 30);
            btnBorrar.TabIndex = 57;
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnObesrvacion
            // 
            btnObesrvacion.BackColor = Color.Transparent;
            btnObesrvacion.BackgroundImageLayout = ImageLayout.None;
            btnObesrvacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnObesrvacion.Location = new Point(603, 159);
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
            btnGuardar.Location = new Point(23, 159);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 151;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Transparent;
            btnModificar.BackgroundImageLayout = ImageLayout.None;
            btnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(139, 159);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(110, 30);
            btnModificar.TabIndex = 152;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // EmpleadoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(735, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnObesrvacion);
            Controls.Add(btnBaja);
            Controls.Add(btnReiniciar);
            Controls.Add(btnBorrar);
            Controls.Add(label8);
            Controls.Add(btnBuscar);
            Controls.Add(dateFechaIngreso);
            Controls.Add(dgvEmpleado);
            Controls.Add(txtTelefonoEmp);
            Controls.Add(txtEmailEmp);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtApellidoEmp);
            Controls.Add(txtNombreEmp);
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
        private TextBox txtNombreEmp;
        private TextBox txtApellidoEmp;
        private TextBox txtEmailEmp;
        private TextBox txtTelefonoEmp;
        private DataGridView dgvEmpleado;
        private DateTimePicker dateFechaIngreso;
        private Button btnBuscar;
        private Label label8;
        private Button btnBaja;
        private Button btnReiniciar;
        private Button btnBorrar;
        private Button btnObesrvacion;
        private DataGridViewTextBoxColumn LEGAJO;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Baja;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn FECHAINGRESO;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn TELEFONO;
        private Button btnGuardar;
        private Button btnModificar;
    }
}