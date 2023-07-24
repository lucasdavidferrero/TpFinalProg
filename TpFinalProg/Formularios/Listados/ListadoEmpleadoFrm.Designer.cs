namespace TpFinalProg.Formularios {
    partial class ListadoEmpleadoFrm {
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
            btnBuscar = new Button();
            txtid = new TextBox();
            btnLimpiar = new Button();
            label5 = new Label();
            dgvEmpleado = new DataGridView();
            legajo = new DataGridViewTextBoxColumn();
            fecha_ingreso = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            celular = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(509, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(26, 23);
            btnBuscar.TabIndex = 182;
            btnBuscar.Text = "🔍︎";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            txtid.Location = new Point(33, 26);
            txtid.Name = "txtid";
            txtid.Size = new Size(34, 23);
            txtid.TabIndex = 181;
            txtid.Visible = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(339, 81);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 30);
            btnLimpiar.TabIndex = 180;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(203, 33);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 177;
            label5.Text = "Empleado:";
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Columns.AddRange(new DataGridViewColumn[] { legajo, fecha_ingreso, nombre, apellido, celular, email, baja });
            dgvEmpleado.Location = new Point(14, 181);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.ReadOnly = true;
            dgvEmpleado.RowTemplate.Height = 25;
            dgvEmpleado.Size = new Size(774, 204);
            dgvEmpleado.TabIndex = 183;
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
            // textBox1
            // 
            textBox1.Location = new Point(272, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 184;
            // 
            // ListadoEmpleadoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 398);
            Controls.Add(textBox1);
            Controls.Add(dgvEmpleado);
            Controls.Add(btnBuscar);
            Controls.Add(txtid);
            Controls.Add(btnLimpiar);
            Controls.Add(label5);
            Name = "ListadoEmpleadoFrm";
            Text = "ListadoEmpleadoFrm";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtid;
        private Button btnLimpiar;
        private Label label5;
        private DataGridView dgvEmpleado;
        private DataGridViewTextBoxColumn legajo;
        private DataGridViewTextBoxColumn fecha_ingreso;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn celular;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn baja;
        private TextBox textBox1;
    }
}