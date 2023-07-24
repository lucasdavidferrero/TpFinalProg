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
            btnLimpiar = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            legajo = new DataGridViewTextBoxColumn();
            FechaIngreso = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            cbEmpleado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(456, 52);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(26, 23);
            btnBuscar.TabIndex = 182;
            btnBuscar.Text = "🔍︎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(515, 52);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 23);
            btnLimpiar.TabIndex = 180;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 55);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 177;
            label5.Text = "Empleado:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { legajo, FechaIngreso, Nombre, Apellido, Celular, Email, baja });
            dataGridView1.Location = new Point(37, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(714, 150);
            dataGridView1.TabIndex = 185;
            // 
            // legajo
            // 
            legajo.DataPropertyName = "legajo";
            legajo.HeaderText = "Legajo";
            legajo.Name = "legajo";
            legajo.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            FechaIngreso.DataPropertyName = "fecha_ingreso";
            FechaIngreso.HeaderText = "Fecha Ingreso";
            FechaIngreso.Name = "FechaIngreso";
            FechaIngreso.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 120;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 120;
            // 
            // Celular
            // 
            Celular.DataPropertyName = "celular";
            Celular.HeaderText = "Celular";
            Celular.Name = "Celular";
            Celular.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 130;
            // 
            // baja
            // 
            baja.DataPropertyName = "baja";
            baja.HeaderText = "baja";
            baja.Name = "baja";
            baja.ReadOnly = true;
            baja.Visible = false;
            // 
            // cbEmpleado
            // 
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(219, 52);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(231, 23);
            cbEmpleado.TabIndex = 186;
            // 
            // ListadoEmpleadoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 296);
            Controls.Add(cbEmpleado);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(label5);
            Name = "ListadoEmpleadoFrm";
            Text = "ListadoEmpleadoFrm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnLimpiar;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn legajo;
        private DataGridViewTextBoxColumn FechaIngreso;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn baja;
        private ComboBox cbEmpleado;
    }
}