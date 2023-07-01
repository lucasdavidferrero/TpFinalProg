namespace TpFinalProg {
    partial class PropietarioFrm {
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
            btnEliminar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtContacto = new TextBox();
            txtEmail = new TextBox();
            btnGuardar = new Button();
            txtRazonSocial = new TextBox();
            txtTelefono = new TextBox();
            txtCuit = new TextBox();
            dgvPropietario = new DataGridView();
            id_propietario = new DataGridViewTextBoxColumn();
            razon_social = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            cuit = new DataGridViewTextBoxColumn();
            persona_contacto = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(639, 125);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 30);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 125);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 25;
            label5.Text = "Teléfono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 81);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 24;
            label4.Text = "Persona de Contacto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 39);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 23;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 78);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 22;
            label2.Text = "CUIT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 39);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 21;
            label1.Text = "Razón Social:";
            label1.Click += label1_Click;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(583, 78);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(282, 23);
            txtContacto.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(583, 36);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 23);
            txtEmail.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(515, 125);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(134, 36);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(206, 23);
            txtRazonSocial.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(134, 122);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(206, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(134, 75);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(206, 23);
            txtCuit.TabIndex = 1;
            // 
            // dgvPropietario
            // 
            dgvPropietario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropietario.Columns.AddRange(new DataGridViewColumn[] { id_propietario, razon_social, telefono, email, cuit, persona_contacto, baja });
            dgvPropietario.DataMember = "ListarPropietarios";
            dgvPropietario.Location = new Point(30, 199);
            dgvPropietario.Name = "dgvPropietario";
            dgvPropietario.RowTemplate.Height = 25;
            dgvPropietario.Size = new Size(944, 196);
            dgvPropietario.TabIndex = 34;
            dgvPropietario.RowHeaderMouseClick += dgvPropietario_RowHeaderMouseClick;
            dgvPropietario.RowHeaderMouseDoubleClick += dgvPropietario_RowHeaderMouseDoubleClick;
            // 
            // id_propietario
            // 
            id_propietario.DataPropertyName = "id_propietario";
            id_propietario.HeaderText = "Id";
            id_propietario.Name = "id_propietario";
            id_propietario.Visible = false;
            // 
            // razon_social
            // 
            razon_social.DataPropertyName = "razon_social";
            razon_social.HeaderText = "Razón Social";
            razon_social.Name = "razon_social";
            razon_social.Width = 150;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            telefono.Width = 150;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.Name = "email";
            email.Width = 200;
            // 
            // cuit
            // 
            cuit.DataPropertyName = "cuit";
            cuit.HeaderText = "CUIT";
            cuit.Name = "cuit";
            cuit.Width = 200;
            // 
            // persona_contacto
            // 
            persona_contacto.DataPropertyName = "persona_contacto";
            persona_contacto.HeaderText = "Persona Contacto";
            persona_contacto.Name = "persona_contacto";
            persona_contacto.Width = 200;
            // 
            // baja
            // 
            baja.DataPropertyName = "baja";
            baja.HeaderText = "Baja";
            baja.Name = "baja";
            baja.Visible = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(755, 125);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 30);
            btnLimpiar.TabIndex = 35;
            btnLimpiar.Text = "Reiniciar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // PropietarioFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 418);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvPropietario);
            Controls.Add(txtCuit);
            Controls.Add(txtTelefono);
            Controls.Add(btnEliminar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContacto);
            Controls.Add(txtEmail);
            Controls.Add(btnGuardar);
            Controls.Add(txtRazonSocial);
            Name = "PropietarioFrm";
            Text = "Propietario";
            Load += Propietario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn MONTOESTIMADO;
        private DataGridViewTextBoxColumn TIEMPOESTIMADO;
        private DataGridViewTextBoxColumn RESPONSABLE;
        private Button btnEliminar;
        private ComboBox cbResponsable;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtContacto;
        private TextBox txtEmail;
        private TextBox txtPropietario;
        private Button btnGuardar;
        private TextBox txtRazonSocial;
        private TextBox txtTelefono;
        private TextBox txtCuit;
        private Button btnBuscarPro;
        private DataGridView dgvPropietario;
        private Button btnLimpiar;
        private DataGridViewTextBoxColumn id_propietario;
        private DataGridViewTextBoxColumn razon_social;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn cuit;
        private DataGridViewTextBoxColumn persona_contacto;
        private DataGridViewTextBoxColumn baja;
    }
}