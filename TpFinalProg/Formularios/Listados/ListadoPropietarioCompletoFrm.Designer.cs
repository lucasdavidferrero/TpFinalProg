namespace TpFinalProg.Formularios.Listados {
    partial class ListadoPropietarioCompletoFrm {
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
            dgvPropietario = new DataGridView();
            id_propietario = new DataGridViewTextBoxColumn();
            cuit = new DataGridViewTextBoxColumn();
            razon_social = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            persona_contacto = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            txtRazonSocial = new TextBox();
            lblRazonSocial = new Label();
            btnBuscarRazonSocial = new Button();
            btnBuscarCuit = new Button();
            lblCuit = new Label();
            txtCuit = new TextBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).BeginInit();
            SuspendLayout();
            // 
            // dgvPropietario
            // 
            dgvPropietario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropietario.Columns.AddRange(new DataGridViewColumn[] { id_propietario, cuit, razon_social, telefono, email, persona_contacto, baja });
            dgvPropietario.Location = new Point(53, 124);
            dgvPropietario.Name = "dgvPropietario";
            dgvPropietario.ReadOnly = true;
            dgvPropietario.RowTemplate.Height = 25;
            dgvPropietario.Size = new Size(679, 228);
            dgvPropietario.TabIndex = 0;
            // 
            // id_propietario
            // 
            id_propietario.DataPropertyName = "id_propietario";
            id_propietario.HeaderText = "ID";
            id_propietario.Name = "id_propietario";
            id_propietario.ReadOnly = true;
            id_propietario.Visible = false;
            id_propietario.Width = 10;
            // 
            // cuit
            // 
            cuit.DataPropertyName = "cuit";
            cuit.HeaderText = "CUIT";
            cuit.Name = "cuit";
            cuit.ReadOnly = true;
            cuit.Width = 125;
            // 
            // razon_social
            // 
            razon_social.DataPropertyName = "razon_social";
            razon_social.HeaderText = "Razon Social";
            razon_social.Name = "razon_social";
            razon_social.ReadOnly = true;
            razon_social.Width = 125;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "Tel.";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 125;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 125;
            // 
            // persona_contacto
            // 
            persona_contacto.DataPropertyName = "persona_contacto";
            persona_contacto.HeaderText = "Per. Contacto";
            persona_contacto.Name = "persona_contacto";
            persona_contacto.ReadOnly = true;
            persona_contacto.Width = 125;
            // 
            // baja
            // 
            baja.DataPropertyName = "baja";
            baja.HeaderText = "baja";
            baja.Name = "baja";
            baja.ReadOnly = true;
            baja.Visible = false;
            baja.Width = 10;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(160, 35);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(171, 23);
            txtRazonSocial.TabIndex = 1;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(81, 38);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(73, 15);
            lblRazonSocial.TabIndex = 2;
            lblRazonSocial.Text = "Razon Social";
            // 
            // btnBuscarRazonSocial
            // 
            btnBuscarRazonSocial.Location = new Point(337, 35);
            btnBuscarRazonSocial.Name = "btnBuscarRazonSocial";
            btnBuscarRazonSocial.Size = new Size(33, 23);
            btnBuscarRazonSocial.TabIndex = 3;
            btnBuscarRazonSocial.Text = "🔍︎";
            btnBuscarRazonSocial.UseVisualStyleBackColor = true;
            btnBuscarRazonSocial.Click += btnBuscarRazonSocial_Click;
            // 
            // btnBuscarCuit
            // 
            btnBuscarCuit.Location = new Point(659, 38);
            btnBuscarCuit.Name = "btnBuscarCuit";
            btnBuscarCuit.Size = new Size(32, 23);
            btnBuscarCuit.TabIndex = 6;
            btnBuscarCuit.Text = "🔍︎";
            btnBuscarCuit.UseVisualStyleBackColor = true;
            btnBuscarCuit.Click += btnBuscarCuit_Click;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(444, 41);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(32, 15);
            lblCuit.TabIndex = 5;
            lblCuit.Text = "CUIT";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(482, 38);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(171, 23);
            txtCuit.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(355, 83);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 23);
            btnLimpiar.TabIndex = 181;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // ListadoPropietarioCompletoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 409);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscarCuit);
            Controls.Add(lblCuit);
            Controls.Add(txtCuit);
            Controls.Add(btnBuscarRazonSocial);
            Controls.Add(lblRazonSocial);
            Controls.Add(txtRazonSocial);
            Controls.Add(dgvPropietario);
            Name = "ListadoPropietarioCompletoFrm";
            Text = "ListadoPropietarioCompletoFrm";
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPropietario;
        private TextBox txtRazonSocial;
        private Label lblRazonSocial;
        private Button btnBuscarRazonSocial;
        private DataGridViewTextBoxColumn id_propietario;
        private DataGridViewTextBoxColumn cuit;
        private DataGridViewTextBoxColumn razon_social;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn persona_contacto;
        private DataGridViewTextBoxColumn baja;
        private Button btnBuscarCuit;
        private Label lblCuit;
        private TextBox txtCuit;
        private Button btnLimpiar;
    }
}