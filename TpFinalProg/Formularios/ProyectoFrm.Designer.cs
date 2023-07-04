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
            txtMonto = new TextBox();
            txtTiempo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbResponsable = new ComboBox();
            dgvProyecto = new DataGridView();
            NOMBRE = new DataGridViewTextBoxColumn();
            id_propietario = new DataGridViewTextBoxColumn();
            id_proyect = new DataGridViewTextBoxColumn();
            legajo = new DataGridViewTextBoxColumn();
            razon_social = new DataGridViewTextBoxColumn();
            RESPONSABLE = new DataGridViewTextBoxColumn();
            MONTO_ESTIMADO = new DataGridViewTextBoxColumn();
            tiempo_estimado = new DataGridViewTextBoxColumn();
            baj = new DataGridViewTextBoxColumn();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            cbPropietario = new ComboBox();
            id_proyecto = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            txtid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(555, 30);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(180, 23);
            txtMonto.TabIndex = 4;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(555, 80);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(180, 23);
            txtTiempo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 31);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 80);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 7;
            label2.Text = "Propietario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 33);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 8;
            label3.Text = "Monto Estimado ($):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 83);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 9;
            label4.Text = "Tiempo Estimado (hs):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 128);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 10;
            label5.Text = "Responsable:";
            // 
            // cbResponsable
            // 
            cbResponsable.FormattingEnabled = true;
            cbResponsable.Location = new Point(155, 125);
            cbResponsable.Name = "cbResponsable";
            cbResponsable.Size = new Size(223, 23);
            cbResponsable.TabIndex = 11;
            // 
            // dgvProyecto
            // 
            dgvProyecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyecto.Columns.AddRange(new DataGridViewColumn[] { NOMBRE, id_propietario, id_proyect, legajo, razon_social, RESPONSABLE, MONTO_ESTIMADO, tiempo_estimado, baj });
            dgvProyecto.Location = new Point(51, 189);
            dgvProyecto.Name = "dgvProyecto";
            dgvProyecto.ReadOnly = true;
            dgvProyecto.RowTemplate.Height = 25;
            dgvProyecto.Size = new Size(735, 256);
            dgvProyecto.TabIndex = 14;
            dgvProyecto.RowHeaderMouseClick += dgvProyecto_RowHeaderMouseClick;
            dgvProyecto.RowHeaderMouseDoubleClick += dgvProyecto_RowHeaderMouseDoubleClick;
            // 
            // NOMBRE
            // 
            NOMBRE.DataPropertyName = "nombre";
            NOMBRE.Frozen = true;
            NOMBRE.HeaderText = "Nombre";
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            NOMBRE.Resizable = DataGridViewTriState.True;
            NOMBRE.Width = 150;
            // 
            // id_propietario
            // 
            id_propietario.DataPropertyName = "id_propietario";
            id_propietario.Frozen = true;
            id_propietario.HeaderText = "Id Propietario";
            id_propietario.Name = "id_propietario";
            id_propietario.ReadOnly = true;
            id_propietario.Visible = false;
            // 
            // id_proyect
            // 
            id_proyect.DataPropertyName = "id_proyecto";
            id_proyect.Frozen = true;
            id_proyect.HeaderText = "id_proyecto";
            id_proyect.Name = "id_proyect";
            id_proyect.ReadOnly = true;
            id_proyect.Visible = false;
            // 
            // legajo
            // 
            legajo.DataPropertyName = "legajo";
            legajo.Frozen = true;
            legajo.HeaderText = "Legajo Responsable";
            legajo.Name = "legajo";
            legajo.ReadOnly = true;
            legajo.Visible = false;
            // 
            // razon_social
            // 
            razon_social.DataPropertyName = "razon_social";
            razon_social.Frozen = true;
            razon_social.HeaderText = "Propietario";
            razon_social.Name = "razon_social";
            razon_social.ReadOnly = true;
            razon_social.Width = 150;
            // 
            // RESPONSABLE
            // 
            RESPONSABLE.DataPropertyName = "Column1";
            RESPONSABLE.Frozen = true;
            RESPONSABLE.HeaderText = "Responsable";
            RESPONSABLE.Name = "RESPONSABLE";
            RESPONSABLE.ReadOnly = true;
            RESPONSABLE.Width = 150;
            // 
            // MONTO_ESTIMADO
            // 
            MONTO_ESTIMADO.DataPropertyName = "monto_estimado";
            MONTO_ESTIMADO.Frozen = true;
            MONTO_ESTIMADO.HeaderText = "Monto Estimado";
            MONTO_ESTIMADO.Name = "MONTO_ESTIMADO";
            MONTO_ESTIMADO.ReadOnly = true;
            MONTO_ESTIMADO.Width = 120;
            // 
            // tiempo_estimado
            // 
            tiempo_estimado.DataPropertyName = "tiempo_estimado";
            tiempo_estimado.Frozen = true;
            tiempo_estimado.HeaderText = "Tiempo Estimado";
            tiempo_estimado.Name = "tiempo_estimado";
            tiempo_estimado.ReadOnly = true;
            tiempo_estimado.Width = 120;
            // 
            // baj
            // 
            baj.DataPropertyName = "baja";
            baj.Frozen = true;
            baj.HeaderText = "baja";
            baj.Name = "baj";
            baj.ReadOnly = true;
            baj.Visible = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(656, 128);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 30);
            btnLimpiar.TabIndex = 156;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(540, 128);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 30);
            btnEliminar.TabIndex = 155;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(424, 128);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 154;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbPropietario
            // 
            cbPropietario.FormattingEnabled = true;
            cbPropietario.Location = new Point(155, 77);
            cbPropietario.Name = "cbPropietario";
            cbPropietario.Size = new Size(223, 23);
            cbPropietario.TabIndex = 159;
            // 
            // id_proyecto
            // 
            id_proyecto.DataPropertyName = "id_proyecto";
            id_proyecto.Frozen = true;
            id_proyecto.HeaderText = "id";
            id_proyecto.Name = "id_proyecto";
            id_proyecto.Visible = false;
            // 
            // baja
            // 
            baja.DataPropertyName = "baja";
            baja.Frozen = true;
            baja.HeaderText = "baja";
            baja.Name = "baja";
            baja.Visible = false;
            // 
            // txtid
            // 
            txtid.Location = new Point(780, 48);
            txtid.Name = "txtid";
            txtid.Size = new Size(34, 23);
            txtid.TabIndex = 160;
            txtid.Visible = false;
            // 
            // ProyectoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(835, 468);
            Controls.Add(txtid);
            Controls.Add(cbPropietario);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvProyecto);
            Controls.Add(cbResponsable);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTiempo);
            Controls.Add(txtMonto);
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
        private TextBox txtMonto;
        private TextBox txtTiempo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbResponsable;
        private DataGridView dgvProyecto;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnGuardar;
        private ComboBox cbPropietario;
        private DataGridViewTextBoxColumn id_proyecto;
        private DataGridViewTextBoxColumn baja;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn id_propietario;
        private DataGridViewTextBoxColumn id_proyect;
        private DataGridViewTextBoxColumn legajo;
        private DataGridViewTextBoxColumn razon_social;
        private DataGridViewTextBoxColumn RESPONSABLE;
        private DataGridViewTextBoxColumn MONTO_ESTIMADO;
        private DataGridViewTextBoxColumn tiempo_estimado;
        private DataGridViewTextBoxColumn baj;
        private TextBox txtid;
    }
}