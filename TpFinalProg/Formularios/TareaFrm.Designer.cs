﻿namespace TpFinalProg {
    partial class TareaFrm {
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
            txtDescripcion = new TextBox();
            dgvTarea = new DataGridView();
            PROYECTO = new DataGridViewTextBoxColumn();
            NUMERO = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            HORAESTIMADA = new DataGridViewTextBoxColumn();
            COSTOESTIMADO = new DataGridViewTextBoxColumn();
            HORAREAL = new DataGridViewTextBoxColumn();
            COSTOREAL = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtCostoReal = new TextBox();
            label7 = new Label();
            txtHoraReal = new TextBox();
            label8 = new Label();
            txtHoraEstimada = new TextBox();
            txtCostoEstimado = new TextBox();
            txtNumero = new TextBox();
            cbProyecto = new ComboBox();
            btnModificar = new Button();
            btnBaja = new Button();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTarea).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(175, 111);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(477, 88);
            txtDescripcion.TabIndex = 45;
            // 
            // dgvTarea
            // 
            dgvTarea.AllowUserToAddRows = false;
            dgvTarea.AllowUserToDeleteRows = false;
            dgvTarea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarea.Columns.AddRange(new DataGridViewColumn[] { PROYECTO, NUMERO, id, baja, HORAESTIMADA, COSTOESTIMADO, HORAREAL, COSTOREAL });
            dgvTarea.Location = new Point(30, 389);
            dgvTarea.Name = "dgvTarea";
            dgvTarea.ReadOnly = true;
            dgvTarea.RowTemplate.Height = 25;
            dgvTarea.Size = new Size(645, 271);
            dgvTarea.TabIndex = 43;
            // 
            // PROYECTO
            // 
            PROYECTO.Frozen = true;
            PROYECTO.HeaderText = "PROYECTO";
            PROYECTO.Name = "PROYECTO";
            PROYECTO.ReadOnly = true;
            // 
            // NUMERO
            // 
            NUMERO.Frozen = true;
            NUMERO.HeaderText = "NUMERO";
            NUMERO.Name = "NUMERO";
            NUMERO.ReadOnly = true;
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
            // HORAESTIMADA
            // 
            HORAESTIMADA.Frozen = true;
            HORAESTIMADA.HeaderText = "HORA ESTIMADA";
            HORAESTIMADA.Name = "HORAESTIMADA";
            HORAESTIMADA.ReadOnly = true;
            // 
            // COSTOESTIMADO
            // 
            COSTOESTIMADO.Frozen = true;
            COSTOESTIMADO.HeaderText = "COSTO ESTIMADO";
            COSTOESTIMADO.Name = "COSTOESTIMADO";
            COSTOESTIMADO.ReadOnly = true;
            // 
            // HORAREAL
            // 
            HORAREAL.Frozen = true;
            HORAREAL.HeaderText = "HORA REAL";
            HORAREAL.Name = "HORAREAL";
            HORAREAL.ReadOnly = true;
            // 
            // COSTOREAL
            // 
            COSTOREAL.Frozen = true;
            COSTOREAL.HeaderText = "COSTO REAL";
            COSTOREAL.Name = "COSTOREAL";
            COSTOREAL.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 280);
            label5.Name = "label5";
            label5.Size = new Size(183, 15);
            label5.TabIndex = 40;
            label5.Text = "COSTO ESTIMADO (TOTAL CREO):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 239);
            label4.Name = "label4";
            label4.Size = new Size(182, 15);
            label4.TabIndex = 39;
            label4.Text = "HORAS ESTIMADAS (UNITARIAS):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 239);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 38;
            label3.Text = "HORAS REALES:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 157);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 37;
            label2.Text = "DESCRIPCION:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 71);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 36;
            label1.Text = "NUMERO ORDEN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 280);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 47;
            label6.Text = "COSTO REAL:";
            // 
            // txtCostoReal
            // 
            txtCostoReal.Location = new Point(534, 277);
            txtCostoReal.Name = "txtCostoReal";
            txtCostoReal.Size = new Size(118, 23);
            txtCostoReal.TabIndex = 46;
            txtCostoReal.TextChanged += txtCostoReal_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 35);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 49;
            label7.Text = "PROYECTO:";
            // 
            // txtHoraReal
            // 
            txtHoraReal.Location = new Point(534, 236);
            txtHoraReal.Name = "txtHoraReal";
            txtHoraReal.Size = new Size(118, 23);
            txtHoraReal.TabIndex = 34;
            txtHoraReal.TextChanged += txtHoraReal_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(368, 214);
            label8.Name = "label8";
            label8.Size = new Size(52, 86);
            label8.TabIndex = 51;
            label8.Text = "|";
            // 
            // txtHoraEstimada
            // 
            txtHoraEstimada.Location = new Point(230, 236);
            txtHoraEstimada.Name = "txtHoraEstimada";
            txtHoraEstimada.Size = new Size(129, 23);
            txtHoraEstimada.TabIndex = 52;
            txtHoraEstimada.TextChanged += txtHoraEstimada_TextChanged;
            // 
            // txtCostoEstimado
            // 
            txtCostoEstimado.Location = new Point(230, 277);
            txtCostoEstimado.Name = "txtCostoEstimado";
            txtCostoEstimado.Size = new Size(129, 23);
            txtCostoEstimado.TabIndex = 53;
            txtCostoEstimado.TextChanged += txtCostoEstimado_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(175, 68);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(477, 23);
            txtNumero.TabIndex = 54;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // cbProyecto
            // 
            cbProyecto.FormattingEnabled = true;
            cbProyecto.Location = new Point(175, 32);
            cbProyecto.Name = "cbProyecto";
            cbProyecto.Size = new Size(477, 23);
            cbProyecto.TabIndex = 55;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Transparent;
            btnModificar.BackgroundImageLayout = ImageLayout.None;
            btnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(175, 333);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(110, 30);
            btnModificar.TabIndex = 163;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.Transparent;
            btnBaja.BackgroundImageLayout = ImageLayout.None;
            btnBaja.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaja.Location = new Point(407, 333);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(110, 30);
            btnBaja.TabIndex = 162;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(523, 333);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 30);
            btnLimpiar.TabIndex = 161;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Transparent;
            btnBorrar.BackgroundImageLayout = ImageLayout.None;
            btnBorrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.Location = new Point(291, 333);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(110, 30);
            btnBorrar.TabIndex = 160;
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(59, 333);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 159;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // TareaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(714, 688);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            Controls.Add(cbProyecto);
            Controls.Add(txtNumero);
            Controls.Add(txtCostoEstimado);
            Controls.Add(txtHoraEstimada);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtCostoReal);
            Controls.Add(txtDescripcion);
            Controls.Add(dgvTarea);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHoraReal);
            Name = "TareaFrm";
            Text = "Tarea";
            ((System.ComponentModel.ISupportInitialize)dgvTarea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private TextBox txtTelefono;
        private DataGridView dgvTarea;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtContacto;
        private TextBox txtRazonSocial;
        private Label label6;
        private TextBox txtCostoReal;
        private Label label7;
        private TextBox txtHoraReal;
        private Label label8;
        private TextBox txtHoraEstimada;
        private TextBox txtCostoEstimado;
        private TextBox txtNumero;
        private ComboBox cbProyecto;
        private DataGridViewTextBoxColumn PROYECTO;
        private DataGridViewTextBoxColumn NUMERO;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn baja;
        private DataGridViewTextBoxColumn HORAESTIMADA;
        private DataGridViewTextBoxColumn COSTOESTIMADO;
        private DataGridViewTextBoxColumn HORAREAL;
        private DataGridViewTextBoxColumn COSTOREAL;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnLimpiar;
        private Button btnBorrar;
        private Button btnGuardar;
    }
}