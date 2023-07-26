﻿namespace TpFinalProg.Formularios.Listados {
    partial class ListadoProyectoFrm {
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
            dgvTerminados = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            CostoEstimado = new DataGridViewTextBoxColumn();
            CostoReal = new DataGridViewTextBoxColumn();
            Desvio = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            dvgNoTerminados = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            btnBuscar = new Button();
            label3 = new Label();
            lbl = new Label();
            lblAvance = new Label();
            lblDesvio = new Label();
            label5 = new Label();
            id_proyecto = new DataGridViewTextBoxColumn();
            nombre_proyecto = new DataGridViewTextBoxColumn();
            nombre_empresa = new DataGridViewTextBoxColumn();
            monto_estimado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTerminados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgNoTerminados).BeginInit();
            SuspendLayout();
            // 
            // dgvTerminados
            // 
            dgvTerminados.AllowUserToAddRows = false;
            dgvTerminados.AllowUserToDeleteRows = false;
            dgvTerminados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerminados.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Empresa, CostoEstimado, CostoReal, Desvio, baja });
            dgvTerminados.Location = new Point(60, 111);
            dgvTerminados.Name = "dgvTerminados";
            dgvTerminados.ReadOnly = true;
            dgvTerminados.RowTemplate.Height = 25;
            dgvTerminados.Size = new Size(686, 150);
            dgvTerminados.TabIndex = 0;
            // 
            // id
            // 
            id.DataPropertyName = "id_proyecto";
            id.Frozen = true;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "nombre_proyecto";
            Nombre.Frozen = true;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 180;
            // 
            // Empresa
            // 
            Empresa.DataPropertyName = "empresa";
            Empresa.Frozen = true;
            Empresa.HeaderText = "Empresa";
            Empresa.Name = "Empresa";
            Empresa.ReadOnly = true;
            Empresa.Width = 160;
            // 
            // CostoEstimado
            // 
            CostoEstimado.DataPropertyName = "costo_estimado";
            CostoEstimado.Frozen = true;
            CostoEstimado.HeaderText = "Costo Estimado";
            CostoEstimado.Name = "CostoEstimado";
            CostoEstimado.ReadOnly = true;
            // 
            // CostoReal
            // 
            CostoReal.DataPropertyName = "costo_real";
            CostoReal.Frozen = true;
            CostoReal.HeaderText = "Costo Real";
            CostoReal.Name = "CostoReal";
            CostoReal.ReadOnly = true;
            // 
            // Desvio
            // 
            Desvio.DataPropertyName = "desvio";
            Desvio.Frozen = true;
            Desvio.HeaderText = "Desvio";
            Desvio.Name = "Desvio";
            Desvio.ReadOnly = true;
            // 
            // baja
            // 
            baja.DataPropertyName = "baja";
            baja.Frozen = true;
            baja.HeaderText = "baja";
            baja.Name = "baja";
            baja.ReadOnly = true;
            baja.Visible = false;
            // 
            // dvgNoTerminados
            // 
            dvgNoTerminados.AllowUserToAddRows = false;
            dvgNoTerminados.AllowUserToDeleteRows = false;
            dvgNoTerminados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgNoTerminados.Columns.AddRange(new DataGridViewColumn[] { id_proyecto, nombre_proyecto, nombre_empresa, monto_estimado });
            dvgNoTerminados.Location = new Point(60, 311);
            dvgNoTerminados.Name = "dvgNoTerminados";
            dvgNoTerminados.ReadOnly = true;
            dvgNoTerminados.RowTemplate.Height = 25;
            dvgNoTerminados.Size = new Size(686, 242);
            dvgNoTerminados.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 36);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(323, 287);
            label4.Name = "label4";
            label4.Size = new Size(144, 21);
            label4.TabIndex = 5;
            label4.Text = "NO TERMINADOS";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(272, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(251, 23);
            txtNombre.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(529, 33);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(26, 23);
            btnBuscar.TabIndex = 183;
            btnBuscar.Text = "🔍︎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(334, 87);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 4;
            label3.Text = "TERMINADOS";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(772, 311);
            lbl.Name = "lbl";
            lbl.Size = new Size(187, 15);
            lbl.TabIndex = 184;
            lbl.Text = "% Avance proyecto seleccionado: ";
            // 
            // lblAvance
            // 
            lblAvance.AutoSize = true;
            lblAvance.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvance.Location = new Point(835, 335);
            lblAvance.Name = "lblAvance";
            lblAvance.Size = new Size(55, 30);
            lblAvance.TabIndex = 185;
            lblAvance.Text = "50%";
            // 
            // lblDesvio
            // 
            lblDesvio.AutoSize = true;
            lblDesvio.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesvio.Location = new Point(817, 126);
            lblDesvio.Name = "lblDesvio";
            lblDesvio.Size = new Size(73, 30);
            lblDesvio.TabIndex = 187;
            lblDesvio.Text = "50004";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(772, 111);
            label5.Name = "label5";
            label5.Size = new Size(170, 15);
            label5.TabIndex = 186;
            label5.Text = "Desvío proyecto seleccionado: ";
            // 
            // id_proyecto
            // 
            id_proyecto.DataPropertyName = "id_proyecto";
            id_proyecto.Frozen = true;
            id_proyecto.HeaderText = "idProyecto";
            id_proyecto.Name = "id_proyecto";
            id_proyecto.ReadOnly = true;
            id_proyecto.Visible = false;
            // 
            // nombre_proyecto
            // 
            nombre_proyecto.DataPropertyName = "nombre_proyecto";
            nombre_proyecto.Frozen = true;
            nombre_proyecto.HeaderText = "Nombre";
            nombre_proyecto.Name = "nombre_proyecto";
            nombre_proyecto.ReadOnly = true;
            nombre_proyecto.Width = 160;
            // 
            // nombre_empresa
            // 
            nombre_empresa.DataPropertyName = "nombre_empresa";
            nombre_empresa.Frozen = true;
            nombre_empresa.HeaderText = "Empresa";
            nombre_empresa.Name = "nombre_empresa";
            nombre_empresa.ReadOnly = true;
            nombre_empresa.Width = 180;
            // 
            // monto_estimado
            // 
            monto_estimado.DataPropertyName = "monto_estimado";
            monto_estimado.Frozen = true;
            monto_estimado.HeaderText = "Costo Estimado";
            monto_estimado.Name = "monto_estimado";
            monto_estimado.ReadOnly = true;
            // 
            // ListadoProyectoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1376, 581);
            Controls.Add(lblDesvio);
            Controls.Add(label5);
            Controls.Add(lblAvance);
            Controls.Add(lbl);
            Controls.Add(btnBuscar);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dvgNoTerminados);
            Controls.Add(dgvTerminados);
            Name = "ListadoProyectoFrm";
            Text = "ListadoProyectoFrm";
            ((System.ComponentModel.ISupportInitialize)dgvTerminados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgNoTerminados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTerminados;
        private DataGridView dvgNoTerminados;
        private Label label1;
        private Label label4;
        private TextBox txtNombre;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Empresa;
        private DataGridViewTextBoxColumn CostoEstimado;
        private DataGridViewTextBoxColumn CostoReal;
        private DataGridViewTextBoxColumn Desvio;
        private DataGridViewTextBoxColumn baja;
        private Label label3;
        private Label lbl;
        private Label lblAvance;
        private Label lblDesvio;
        private Label label5;
        private DataGridViewTextBoxColumn id_proyecto;
        private DataGridViewTextBoxColumn nombre_proyecto;
        private DataGridViewTextBoxColumn nombre_empresa;
        private DataGridViewTextBoxColumn monto_estimado;
    }
}