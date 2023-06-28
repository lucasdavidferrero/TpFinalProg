namespace TpFinalProg
{
    partial class ProyectoFrm
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
            txtNombre = new TextBox();
            btnGuardar = new Button();
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
            btnBorrar = new Button();
            dgvProyecto = new DataGridView();
            NOMBRE = new DataGridViewTextBoxColumn();
            PROPIETARIO = new DataGridViewTextBoxColumn();
            MONTOESTIMADO = new DataGridViewTextBoxColumn();
            TIEMPOESTIMADO = new DataGridViewTextBoxColumn();
            RESPONSABLE = new DataGridViewTextBoxColumn();
            btnModificar = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(666, 347);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(91, 30);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPropietario
            // 
            txtPropietario.Location = new Point(125, 107);
            txtPropietario.Name = "txtPropietario";
            txtPropietario.Size = new Size(223, 23);
            txtPropietario.TabIndex = 3;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(618, 54);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(180, 23);
            txtMonto.TabIndex = 4;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(618, 104);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(180, 23);
            txtTiempo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 61);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 6;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 110);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 7;
            label2.Text = "PROPIETARIO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 57);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 8;
            label3.Text = "MONTO ESTIMADO ($):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(474, 107);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 9;
            label4.Text = "TIEMPO ESTIMADO (hs):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 158);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 10;
            label5.Text = "RESPONSABLE:";
            // 
            // cbResponsable
            // 
            cbResponsable.FormattingEnabled = true;
            cbResponsable.Location = new Point(125, 155);
            cbResponsable.Name = "cbResponsable";
            cbResponsable.Size = new Size(223, 23);
            cbResponsable.TabIndex = 11;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(365, 58);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(35, 23);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "🔍︎";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(666, 392);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(91, 30);
            btnBorrar.TabIndex = 13;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // dgvProyecto
            // 
            dgvProyecto.AllowUserToAddRows = false;
            dgvProyecto.AllowUserToDeleteRows = false;
            dgvProyecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyecto.Columns.AddRange(new DataGridViewColumn[] { NOMBRE, PROPIETARIO, MONTOESTIMADO, TIEMPOESTIMADO, RESPONSABLE });
            dgvProyecto.Location = new Point(50, 221);
            dgvProyecto.Name = "dgvProyecto";
            dgvProyecto.ReadOnly = true;
            dgvProyecto.RowTemplate.Height = 25;
            dgvProyecto.Size = new Size(545, 271);
            dgvProyecto.TabIndex = 14;
            // 
            // NOMBRE
            // 
            NOMBRE.Frozen = true;
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            // 
            // PROPIETARIO
            // 
            PROPIETARIO.Frozen = true;
            PROPIETARIO.HeaderText = "PROPIETARIO";
            PROPIETARIO.Name = "PROPIETARIO";
            PROPIETARIO.ReadOnly = true;
            // 
            // MONTOESTIMADO
            // 
            MONTOESTIMADO.Frozen = true;
            MONTOESTIMADO.HeaderText = "MONTO ESTIMADO";
            MONTOESTIMADO.Name = "MONTOESTIMADO";
            MONTOESTIMADO.ReadOnly = true;
            // 
            // TIEMPOESTIMADO
            // 
            TIEMPOESTIMADO.Frozen = true;
            TIEMPOESTIMADO.HeaderText = "TIEMPO ESTIMADO";
            TIEMPOESTIMADO.Name = "TIEMPOESTIMADO";
            TIEMPOESTIMADO.ReadOnly = true;
            // 
            // RESPONSABLE
            // 
            RESPONSABLE.Frozen = true;
            RESPONSABLE.HeaderText = "RESPONSABLE";
            RESPONSABLE.Name = "RESPONSABLE";
            RESPONSABLE.ReadOnly = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(666, 299);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(91, 30);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(35, 20);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 34;
            label6.Text = "ABM PROYECTO";
            // 
            // ProyectoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 518);
            Controls.Add(label6);
            Controls.Add(btnModificar);
            Controls.Add(dgvProyecto);
            Controls.Add(btnBorrar);
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
            Controls.Add(btnGuardar);
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
        private Button btnGuardar;
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
        private Button btnBorrar;
        private DataGridView dgvProyecto;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn PROPIETARIO;
        private DataGridViewTextBoxColumn MONTOESTIMADO;
        private DataGridViewTextBoxColumn TIEMPOESTIMADO;
        private DataGridViewTextBoxColumn RESPONSABLE;
        private Button btnModificar;
        private Label label6;
    }
}