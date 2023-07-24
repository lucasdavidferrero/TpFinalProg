namespace TpFinalProg.Formularios {
    partial class ListadoPropietarioFrm {
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
            btnBuscarRazonSocial = new Button();
            dgvPropietario = new DataGridView();
            id_propietario = new DataGridViewTextBoxColumn();
            cuit = new DataGridViewTextBoxColumn();
            razon_social = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            persona_contacto = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            txtRazonSocial = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtCuit = new TextBox();
            btnBuscarCuit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarRazonSocial
            // 
            btnBuscarRazonSocial.Location = new Point(342, 27);
            btnBuscarRazonSocial.Name = "btnBuscarRazonSocial";
            btnBuscarRazonSocial.Size = new Size(26, 23);
            btnBuscarRazonSocial.TabIndex = 166;
            btnBuscarRazonSocial.Text = "🔍︎";
            btnBuscarRazonSocial.UseVisualStyleBackColor = true;
            btnBuscarRazonSocial.Click += btnBuscar_Click;
            // 
            // dgvPropietario
            // 
            dgvPropietario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropietario.Columns.AddRange(new DataGridViewColumn[] { id_propietario, cuit, razon_social, telefono, email, persona_contacto, baja });
            dgvPropietario.DataMember = "ListarPropietarios";
            dgvPropietario.Location = new Point(50, 78);
            dgvPropietario.Name = "dgvPropietario";
            dgvPropietario.ReadOnly = true;
            dgvPropietario.RowTemplate.Height = 25;
            dgvPropietario.Size = new Size(693, 343);
            dgvPropietario.TabIndex = 165;
            // 
            // id_propietario
            // 
            id_propietario.DataPropertyName = "id_propietario";
            id_propietario.HeaderText = "Id";
            id_propietario.Name = "id_propietario";
            id_propietario.ReadOnly = true;
            id_propietario.Visible = false;
            // 
            // cuit
            // 
            cuit.DataPropertyName = "cuit";
            cuit.HeaderText = "CUIT";
            cuit.Name = "cuit";
            cuit.ReadOnly = true;
            // 
            // razon_social
            // 
            razon_social.DataPropertyName = "razon_social";
            razon_social.HeaderText = "Razón Social";
            razon_social.Name = "razon_social";
            razon_social.ReadOnly = true;
            razon_social.Width = 150;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 150;
            // 
            // persona_contacto
            // 
            persona_contacto.DataPropertyName = "persona_contacto";
            persona_contacto.HeaderText = "Persona Contacto";
            persona_contacto.Name = "persona_contacto";
            persona_contacto.ReadOnly = true;
            persona_contacto.Width = 150;
            // 
            // baja
            // 
            baja.DataPropertyName = "baja";
            baja.HeaderText = "Baja";
            baja.Name = "baja";
            baja.ReadOnly = true;
            baja.Visible = false;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(130, 27);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(206, 23);
            txtRazonSocial.TabIndex = 161;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 31);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 164;
            label2.Text = "Razón social";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 27);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 168;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 30);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 169;
            label3.Text = "CUIT";
            label3.Click += label3_Click;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(505, 27);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(206, 23);
            txtCuit.TabIndex = 170;
            // 
            // btnBuscarCuit
            // 
            btnBuscarCuit.Location = new Point(717, 27);
            btnBuscarCuit.Name = "btnBuscarCuit";
            btnBuscarCuit.Size = new Size(26, 23);
            btnBuscarCuit.TabIndex = 171;
            btnBuscarCuit.Text = "🔍︎";
            btnBuscarCuit.UseVisualStyleBackColor = true;
            btnBuscarCuit.Click += btnBuscarCuit_Click;
            // 
            // ListadoPropietarioFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(781, 448);
            Controls.Add(btnBuscarCuit);
            Controls.Add(txtCuit);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnBuscarRazonSocial);
            Controls.Add(dgvPropietario);
            Controls.Add(txtRazonSocial);
            Controls.Add(label2);
            Name = "ListadoPropietarioFrm";
            Text = "ListadoPropietarioFrm";
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarRazonSocial;
        private DataGridView dgvPropietario;
        private TextBox txtRazonSocial;
        private Label label2;
        private DataGridViewTextBoxColumn id_propietario;
        private DataGridViewTextBoxColumn cuit;
        private DataGridViewTextBoxColumn razon_social;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn persona_contacto;
        private DataGridViewTextBoxColumn baja;
        private Label label1;
        private Label label3;
        private TextBox txtCuit;
        private Button btnBuscarCuit;
    }
}