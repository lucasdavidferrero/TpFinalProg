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
            // txtCuit
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 42);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 164;
            label2.Text = "CUIT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 37);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 168;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Cuit, RazonSocial, Telefono, Email, Contacto, baja });
            dataGridView1.Location = new Point(42, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(693, 150);
            dataGridView1.TabIndex = 169;
            // 
            // id
            // 
            id.DataPropertyName = "id_propietario";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // Cuit
            // 
            Cuit.DataPropertyName = "cuit";
            Cuit.HeaderText = "Cuit";
            Cuit.Name = "Cuit";
            Cuit.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.DataPropertyName = "razon_social";
            RazonSocial.HeaderText = "RazonSocial";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            RazonSocial.Width = 150;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // Contacto
            // 
            Contacto.DataPropertyName = "persona_contacto";
            Contacto.HeaderText = "Contacto";
            Contacto.Name = "Contacto";
            Contacto.ReadOnly = true;
            Contacto.Width = 150;
            // 
            // baja
            // 
            baja.DataPropertyName = "baja";
            baja.HeaderText = "baja";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarRazonSocial;
        private DataGridView dgvPropietario;
        private TextBox txtRazonSocial;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Cuit;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Contacto;
        private DataGridViewTextBoxColumn baja;
        private Label label1;
        private Label label3;
        private TextBox txtCuit;
        private Button btnBuscarCuit;
    }
}