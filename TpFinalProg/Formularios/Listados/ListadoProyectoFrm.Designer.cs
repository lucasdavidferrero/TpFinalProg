namespace TpFinalProg.Formularios.Listados
{
    partial class ListadoProyectoFrm
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
            dgvTerminados = new DataGridView();
            idProyectoTerminado = new DataGridViewTextBoxColumn();
            nombreProyecto = new DataGridViewTextBoxColumn();
            nombreEmpresa = new DataGridViewTextBoxColumn();
            montoEstimado = new DataGridViewTextBoxColumn();
            dvgNoTerminados = new DataGridView();
            id_proyecto = new DataGridViewTextBoxColumn();
            nombre_proyecto = new DataGridViewTextBoxColumn();
            nombre_empresa = new DataGridViewTextBoxColumn();
            monto_estimado = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label3 = new Label();
            lbl = new Label();
            lblAvance = new Label();
            lblDesvio = new Label();
            label5 = new Label();
            lblCostoRealTotal = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTerminados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgNoTerminados).BeginInit();
            SuspendLayout();
            // 
            // dgvTerminados
            // 
            dgvTerminados.AllowUserToAddRows = false;
            dgvTerminados.AllowUserToDeleteRows = false;
            dgvTerminados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerminados.Columns.AddRange(new DataGridViewColumn[] { idProyectoTerminado, nombreProyecto, nombreEmpresa, montoEstimado });
            dgvTerminados.Location = new Point(60, 111);
            dgvTerminados.Name = "dgvTerminados";
            dgvTerminados.ReadOnly = true;
            dgvTerminados.RowTemplate.Height = 25;
            dgvTerminados.Size = new Size(686, 150);
            dgvTerminados.TabIndex = 0;
            dgvTerminados.RowHeaderMouseDoubleClick += dgvTerminados_RowHeaderMouseDoubleClick;
            // 
            // idProyectoTerminado
            // 
            idProyectoTerminado.DataPropertyName = "id_proyecto";
            idProyectoTerminado.Frozen = true;
            idProyectoTerminado.HeaderText = "idProyectoTerminado";
            idProyectoTerminado.Name = "idProyectoTerminado";
            idProyectoTerminado.ReadOnly = true;
            idProyectoTerminado.Visible = false;
            // 
            // nombreProyecto
            // 
            nombreProyecto.DataPropertyName = "nombre_proyecto";
            nombreProyecto.Frozen = true;
            nombreProyecto.HeaderText = "Nombre";
            nombreProyecto.Name = "nombreProyecto";
            nombreProyecto.ReadOnly = true;
            nombreProyecto.Width = 180;
            // 
            // nombreEmpresa
            // 
            nombreEmpresa.DataPropertyName = "nombre_empresa";
            nombreEmpresa.Frozen = true;
            nombreEmpresa.HeaderText = "Empresa";
            nombreEmpresa.Name = "nombreEmpresa";
            nombreEmpresa.ReadOnly = true;
            nombreEmpresa.Width = 160;
            // 
            // montoEstimado
            // 
            montoEstimado.DataPropertyName = "monto_estimado";
            montoEstimado.Frozen = true;
            montoEstimado.HeaderText = "Costo Estimado";
            montoEstimado.Name = "montoEstimado";
            montoEstimado.ReadOnly = true;
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
            dvgNoTerminados.RowHeaderMouseDoubleClick += dvgNoTerminados_RowHeaderMouseDoubleClick;
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
            lbl.Location = new Point(763, 329);
            lbl.Name = "lbl";
            lbl.Size = new Size(187, 15);
            lbl.TabIndex = 184;
            lbl.Text = "% Avance proyecto seleccionado: ";
            // 
            // lblAvance
            // 
            lblAvance.AutoSize = true;
            lblAvance.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvance.Location = new Point(826, 344);
            lblAvance.Name = "lblAvance";
            lblAvance.Size = new Size(22, 30);
            lblAvance.TabIndex = 185;
            lblAvance.Text = "-";
            // 
            // lblDesvio
            // 
            lblDesvio.AutoSize = true;
            lblDesvio.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesvio.Location = new Point(808, 207);
            lblDesvio.Name = "lblDesvio";
            lblDesvio.Size = new Size(22, 30);
            lblDesvio.TabIndex = 187;
            lblDesvio.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(763, 192);
            label5.Name = "label5";
            label5.Size = new Size(186, 15);
            label5.TabIndex = 186;
            label5.Text = "Desvío (costos de todas las tareas)";
            // 
            // lblCostoRealTotal
            // 
            lblCostoRealTotal.AutoSize = true;
            lblCostoRealTotal.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblCostoRealTotal.Location = new Point(808, 126);
            lblCostoRealTotal.Name = "lblCostoRealTotal";
            lblCostoRealTotal.Size = new Size(22, 30);
            lblCostoRealTotal.TabIndex = 189;
            lblCostoRealTotal.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(763, 111);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 188;
            label6.Text = "Costo Total Real";
            // 
            // ListadoProyectoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(985, 581);
            Controls.Add(lblCostoRealTotal);
            Controls.Add(label6);
            Controls.Add(lblDesvio);
            Controls.Add(label5);
            Controls.Add(lblAvance);
            Controls.Add(lbl);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label4;
        private Label label3;
        private Label lbl;
        private Label lblAvance;
        private Label lblDesvio;
        private Label label5;
        private DataGridViewTextBoxColumn id_proyecto;
        private DataGridViewTextBoxColumn nombre_proyecto;
        private DataGridViewTextBoxColumn nombre_empresa;
        private DataGridViewTextBoxColumn monto_estimado;
        private Label lblCostoRealTotal;
        private Label label6;
        private DataGridViewTextBoxColumn idProyectoTerminado;
        private DataGridViewTextBoxColumn nombreProyecto;
        private DataGridViewTextBoxColumn nombreEmpresa;
        private DataGridViewTextBoxColumn montoEstimado;
    }
}