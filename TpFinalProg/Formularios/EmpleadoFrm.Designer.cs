namespace TpFinalProg
{
    partial class EmpleadoFrm
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
            Label label2;
            Label label3;
            Label label4;
            Label label5;
            Label label7;
            label6 = new Label();
            label1 = new Label();
            txtLegajo = new TextBox();
            txtNombreEmp = new TextBox();
            txtApellidoEmp = new TextBox();
            txtEmailEmp = new TextBox();
            txtTelefonoEmp = new TextBox();
            dgvEmpleado = new DataGridView();
            LEGAJO = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDO = new DataGridViewTextBoxColumn();
            FECHAINGRESO = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            dateFechaIngreso = new DateTimePicker();
            btnBuscar = new Button();
            btnObservacion = new Button();
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
            label2.Location = new Point(430, 94);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 38;
            label2.Text = "EMAIL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 93);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 39;
            label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 133);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 40;
            label4.Text = "APELLIDO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 137);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 43;
            label5.Text = "TELEFONO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(377, 51);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 44;
            label7.Text = "FECHA INGRESO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 35;
            label6.Text = "ABM EMPLEADOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(50, 55);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 36;
            label1.Text = "LEGAJO:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(108, 51);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(199, 23);
            txtLegajo.TabIndex = 37;
            // 
            // txtNombreEmp
            // 
            txtNombreEmp.Location = new Point(108, 89);
            txtNombreEmp.Name = "txtNombreEmp";
            txtNombreEmp.Size = new Size(199, 23);
            txtNombreEmp.TabIndex = 41;
            // 
            // txtApellidoEmp
            // 
            txtApellidoEmp.Location = new Point(108, 129);
            txtApellidoEmp.Name = "txtApellidoEmp";
            txtApellidoEmp.Size = new Size(199, 23);
            txtApellidoEmp.TabIndex = 42;
            // 
            // txtEmailEmp
            // 
            txtEmailEmp.Location = new Point(481, 90);
            txtEmailEmp.Name = "txtEmailEmp";
            txtEmailEmp.Size = new Size(217, 23);
            txtEmailEmp.TabIndex = 45;
            // 
            // txtTelefonoEmp
            // 
            txtTelefonoEmp.Location = new Point(481, 133);
            txtTelefonoEmp.Name = "txtTelefonoEmp";
            txtTelefonoEmp.Size = new Size(217, 23);
            txtTelefonoEmp.TabIndex = 46;
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Columns.AddRange(new DataGridViewColumn[] { LEGAJO, NOMBRE, APELLIDO, FECHAINGRESO, EMAIL, TELEFONO });
            dgvEmpleado.Location = new Point(25, 236);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.RowTemplate.Height = 25;
            dgvEmpleado.Size = new Size(650, 202);
            dgvEmpleado.TabIndex = 47;
            // 
            // LEGAJO
            // 
            LEGAJO.HeaderText = "LEGAJO";
            LEGAJO.Name = "LEGAJO";
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
            // btnGuardar
            // 
            btnGuardar.Location = new Point(698, 267);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 33);
            btnGuardar.TabIndex = 49;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(698, 323);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 35);
            btnModificar.TabIndex = 50;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(698, 379);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(90, 34);
            btnBorrar.TabIndex = 51;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // dateFechaIngreso
            // 
            dateFechaIngreso.Format = DateTimePickerFormat.Short;
            dateFechaIngreso.Location = new Point(481, 47);
            dateFechaIngreso.Name = "dateFechaIngreso";
            dateFechaIngreso.Size = new Size(217, 23);
            dateFechaIngreso.TabIndex = 52;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(313, 49);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(29, 27);
            btnBuscar.TabIndex = 53;
            btnBuscar.Text = "🔍︎";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnObservacion
            // 
            btnObservacion.Location = new Point(638, 176);
            btnObservacion.Name = "btnObservacion";
            btnObservacion.Size = new Size(119, 34);
            btnObservacion.TabIndex = 54;
            btnObservacion.Text = "OBSERVACION";
            btnObservacion.UseVisualStyleBackColor = true;
            btnObservacion.Click += btnObservacion_Click;
            // 
            // EmpleadoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnObservacion);
            Controls.Add(btnBuscar);
            Controls.Add(dateFechaIngreso);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
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
            Controls.Add(label6);
            Name = "EmpleadoFrm";
            Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private TextBox txtLegajo;
        private TextBox txtNombreEmp;
        private TextBox txtApellidoEmp;
        private TextBox txtEmailEmp;
        private TextBox txtTelefonoEmp;
        private DataGridView dgvEmpleado;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnBorrar;
        private DateTimePicker dateFechaIngreso;
        private DataGridViewTextBoxColumn LEGAJO;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn FECHAINGRESO;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn TELEFONO;
        private Button btnBuscar;
        private Button btnObservacion;
    }
}