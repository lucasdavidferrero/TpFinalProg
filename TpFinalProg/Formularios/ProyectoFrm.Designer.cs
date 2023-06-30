namespace TpFinalProg {
    partial class ProyectoFrm {
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
            txtNombre = new TextBox();
            txtPropietario = new TextBox();
            txtMonto = new TextBox();
            txtTiempo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbResponsable = new ComboBox();
            btnBuscar = new Button();
            dgvProyecto = new DataGridView();
            NOMBRE = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            PROPIETARIO = new DataGridViewTextBoxColumn();
            MONTOESTIMADO = new DataGridViewTextBoxColumn();
            TIEMPOESTIMADO = new DataGridViewTextBoxColumn();
            RESPONSABLE = new DataGridViewTextBoxColumn();
            btnModificar = new Button();
            btnBaja = new Button();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtPropietario
            // 
            txtPropietario.Location = new Point(112, 81);
            txtPropietario.Name = "txtPropietario";
            txtPropietario.Size = new Size(223, 23);
            txtPropietario.TabIndex = 3;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(566, 34);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(180, 23);
            txtMonto.TabIndex = 4;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(566, 84);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(180, 23);
            txtTiempo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 6;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 84);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 7;
            label2.Text = "PROPIETARIO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 37);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 8;
            label3.Text = "MONTO ESTIMADO ($):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 87);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 9;
            label4.Text = "TIEMPO ESTIMADO (hs):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 132);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 10;
            label5.Text = "RESPONSABLE:";
            // 
            // cbResponsable
            // 
            cbResponsable.FormattingEnabled = true;
            cbResponsable.Location = new Point(112, 129);
            cbResponsable.Name = "cbResponsable";
            cbResponsable.Size = new Size(223, 23);
            cbResponsable.TabIndex = 11;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(352, 32);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(35, 23);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "🔍︎";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProyecto
            // 
            dgvProyecto.AllowUserToAddRows = false;
            dgvProyecto.AllowUserToDeleteRows = false;
            dgvProyecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyecto.Columns.AddRange(new DataGridViewColumn[] { NOMBRE, id, baja, PROPIETARIO, MONTOESTIMADO, TIEMPOESTIMADO, RESPONSABLE });
            dgvProyecto.Location = new Point(52, 222);
            dgvProyecto.Name = "dgvProyecto";
            dgvProyecto.ReadOnly = true;
            dgvProyecto.RowTemplate.Height = 25;
            dgvProyecto.Size = new Size(733, 271);
            dgvProyecto.TabIndex = 14;
            // 
            // NOMBRE
            // 
            NOMBRE.Frozen = true;
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            NOMBRE.Width = 150;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // baja
            // 
            baja.Frozen = true;
            baja.HeaderText = "baja";
            baja.Name = "baja";
            baja.ReadOnly = true;
            baja.Visible = false;
            // 
            // PROPIETARIO
            // 
            PROPIETARIO.Frozen = true;
            PROPIETARIO.HeaderText = "PROPIETARIO";
            PROPIETARIO.Name = "PROPIETARIO";
            PROPIETARIO.ReadOnly = true;
            PROPIETARIO.Width = 150;
            // 
            // MONTOESTIMADO
            // 
            MONTOESTIMADO.Frozen = true;
            MONTOESTIMADO.HeaderText = "MONTO ESTIMADO";
            MONTOESTIMADO.Name = "MONTOESTIMADO";
            MONTOESTIMADO.ReadOnly = true;
            MONTOESTIMADO.Width = 120;
            // 
            // TIEMPOESTIMADO
            // 
            TIEMPOESTIMADO.Frozen = true;
            TIEMPOESTIMADO.HeaderText = "TIEMPO ESTIMADO";
            TIEMPOESTIMADO.Name = "TIEMPOESTIMADO";
            TIEMPOESTIMADO.ReadOnly = true;
            TIEMPOESTIMADO.Width = 120;
            // 
            // RESPONSABLE
            // 
            RESPONSABLE.Frozen = true;
            RESPONSABLE.HeaderText = "RESPONSABLE";
            RESPONSABLE.Name = "RESPONSABLE";
            RESPONSABLE.ReadOnly = true;
            RESPONSABLE.Width = 150;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Transparent;
            btnModificar.BackgroundImageLayout = ImageLayout.None;
            btnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(249, 175);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(110, 30);
            btnModificar.TabIndex = 158;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.Transparent;
            btnBaja.BackgroundImageLayout = ImageLayout.None;
            btnBaja.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaja.Location = new Point(481, 175);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(110, 30);
            btnBaja.TabIndex = 157;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(597, 175);
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
            btnBorrar.Location = new Point(365, 175);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(110, 30);
            btnBorrar.TabIndex = 155;
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(133, 175);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 154;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // ProyectoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(835, 518);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvProyecto);
            Controls.Add(btnBuscar);
            Controls.Add(cbResponsable);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTiempo);
            Controls.Add(txtMonto);
            Controls.Add(txtPropietario);
            Controls.Add(txtNombre);
            Name = "ProyectoFrm";
            Text = "Proyecto";
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarPro;
        private TextBox txtNombre;
        private TextBox txtPropietario;
        private TextBox txtMonto;
        private TextBox txtTiempo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbResponsable;
        private Button btnBuscar;
        private DataGridView dgvProyecto;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnLimpiar;
        private Button btnBorrar;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn baja;
        private DataGridViewTextBoxColumn PROPIETARIO;
        private DataGridViewTextBoxColumn MONTOESTIMADO;
        private DataGridViewTextBoxColumn TIEMPOESTIMADO;
        private DataGridViewTextBoxColumn RESPONSABLE;
    }
}