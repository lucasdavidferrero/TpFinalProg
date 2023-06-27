namespace TpFinalProg
{
    partial class PropietarioFrm
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
            dgvPropietario = new DataGridView();
            RAZONSOCIAL = new DataGridViewTextBoxColumn();
            CUIT = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            CONTACTO = new DataGridViewTextBoxColumn();
            btnBorrar = new Button();
            btnBuscar = new Button();
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
            btnModificar = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).BeginInit();
            SuspendLayout();
            // 
            // dgvPropietario
            // 
            dgvPropietario.AllowUserToAddRows = false;
            dgvPropietario.AllowUserToDeleteRows = false;
            dgvPropietario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropietario.Columns.AddRange(new DataGridViewColumn[] { RAZONSOCIAL, CUIT, TELEFONO, EMAIL, CONTACTO });
            dgvPropietario.Location = new Point(117, 227);
            dgvPropietario.Name = "dgvPropietario";
            dgvPropietario.ReadOnly = true;
            dgvPropietario.RowTemplate.Height = 25;
            dgvPropietario.Size = new Size(545, 271);
            dgvPropietario.TabIndex = 29;
            // 
            // RAZONSOCIAL
            // 
            RAZONSOCIAL.Frozen = true;
            RAZONSOCIAL.HeaderText = "RAZON SOCIAL";
            RAZONSOCIAL.Name = "RAZONSOCIAL";
            RAZONSOCIAL.ReadOnly = true;
            // 
            // CUIT
            // 
            CUIT.Frozen = true;
            CUIT.HeaderText = "CUIT";
            CUIT.Name = "CUIT";
            CUIT.ReadOnly = true;
            // 
            // TELEFONO
            // 
            TELEFONO.Frozen = true;
            TELEFONO.HeaderText = "TELEFONO";
            TELEFONO.Name = "TELEFONO";
            TELEFONO.ReadOnly = true;
            // 
            // EMAIL
            // 
            EMAIL.Frozen = true;
            EMAIL.HeaderText = "EMAIL";
            EMAIL.Name = "EMAIL";
            EMAIL.ReadOnly = true;
            // 
            // CONTACTO
            // 
            CONTACTO.Frozen = true;
            CONTACTO.HeaderText = "PERS. CONTACTO";
            CONTACTO.Name = "CONTACTO";
            CONTACTO.ReadOnly = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(719, 390);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(91, 30);
            btnBorrar.TabIndex = 28;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(329, 98);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(35, 25);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "🔍︎";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 150);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 25;
            label5.Text = "TELÉFONO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(426, 108);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 24;
            label4.Text = "PERSONA DE CONTACTO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 69);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 23;
            label3.Text = "EMAIL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 103);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 22;
            label2.Text = "CUIT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 64);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 21;
            label1.Text = "RAZON SOCIAL:";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(575, 103);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(282, 23);
            txtContacto.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(575, 61);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 23);
            txtEmail.TabIndex = 19;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(719, 344);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(91, 30);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(117, 61);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(206, 23);
            txtRazonSocial.TabIndex = 16;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(117, 147);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(206, 23);
            txtTelefono.TabIndex = 30;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(117, 100);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(206, 23);
            txtCuit.TabIndex = 31;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(719, 299);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(91, 30);
            btnModificar.TabIndex = 32;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(23, 9);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 33;
            label6.Text = "ABM PROPIETARIO";
            // 
            // PropietarioFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 510);
            Controls.Add(label6);
            Controls.Add(btnModificar);
            Controls.Add(txtCuit);
            Controls.Add(txtTelefono);
            Controls.Add(dgvPropietario);
            Controls.Add(btnBorrar);
            Controls.Add(btnBuscar);
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

        private DataGridView dgvPropietario;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn MONTOESTIMADO;
        private DataGridViewTextBoxColumn TIEMPOESTIMADO;
        private DataGridViewTextBoxColumn RESPONSABLE;
        private Button btnBorrar;
        private Button btnBuscar;
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
        private DataGridViewTextBoxColumn RAZONSOCIAL;
        private DataGridViewTextBoxColumn CUIT;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn CONTACTO;
        private TextBox txtTelefono;
        private TextBox txtCuit;
        private Button btnBuscarPro;
        private Button btnModificar;
        private Label label6;
    }
}