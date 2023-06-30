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
            btnBorrar = new Button();
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
            btnBaja = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Transparent;
            btnBorrar.BackgroundImageLayout = ImageLayout.None;
            btnBorrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.Location = new Point(609, 125);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(110, 30);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 125);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 25;
            label5.Text = "TELÉFONO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 83);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 24;
            label4.Text = "PERSONA DE CONTACTO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 44);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 23;
            label3.Text = "EMAIL:";
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
            label1.Location = new Point(40, 39);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 21;
            label1.Text = "RAZON SOCIAL:";
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
            btnGuardar.Location = new Point(377, 125);
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
            dgvPropietario.RowHeaderMouseDoubleClick += dgvPropietario_RowHeaderMouseDoubleClick;
            // 
            // id_propietario
            // 
            id_propietario.DataPropertyName = "id_propietario";
            id_propietario.HeaderText = "ID";
            id_propietario.Name = "id_propietario";
            id_propietario.Visible = false;
            // 
            // razon_social
            // 
            razon_social.DataPropertyName = "razon_social";
            razon_social.HeaderText = "RAZON SOCIAL";
            razon_social.Name = "razon_social";
            razon_social.Width = 150;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "TELEFONO";
            telefono.Name = "telefono";
            telefono.Width = 150;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "EMAIL";
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
            persona_contacto.HeaderText = "PERSONA CONTACTO";
            persona_contacto.Name = "persona_contacto";
            persona_contacto.Width = 200;
            // 
            // baja
            // 
            baja.DataPropertyName = "baja";
            baja.HeaderText = "BAJA";
            baja.Name = "baja";
            baja.Visible = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(841, 125);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 30);
            btnLimpiar.TabIndex = 35;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.Transparent;
            btnBaja.BackgroundImageLayout = ImageLayout.None;
            btnBaja.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaja.Location = new Point(725, 125);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(110, 30);
            btnBaja.TabIndex = 36;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Transparent;
            btnModificar.BackgroundImageLayout = ImageLayout.None;
            btnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(493, 125);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(110, 30);
            btnModificar.TabIndex = 153;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // PropietarioFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 418);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvPropietario);
            Controls.Add(txtCuit);
            Controls.Add(txtTelefono);
            Controls.Add(btnBorrar);
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
        private Button btnBorrar;
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
        private Button btnBaja;
        private DataGridViewTextBoxColumn id_propietario;
        private DataGridViewTextBoxColumn razon_social;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn cuit;
        private DataGridViewTextBoxColumn persona_contacto;
        private DataGridViewTextBoxColumn baja;
        private Button btnModificar;
    }
}