namespace TpFinalProg {
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            txtCostoReal = new TextBox();
            label7 = new Label();
            txtHoraReal = new TextBox();
            label8 = new Label();
            txtHoraEstimada = new TextBox();
            txtCostoEstimado = new TextBox();
            cbProyecto = new ComboBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            label9 = new Label();
            txtHoraAvance = new TextBox();
            label10 = new Label();
            txtNroTarea = new TextBox();
            label1 = new Label();
            PROYECTO = new DataGridViewTextBoxColumn();
            nombre_proyecto = new DataGridViewTextBoxColumn();
            NUMERO = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            HORAESTIMADA = new DataGridViewTextBoxColumn();
            COSTOESTIMADO = new DataGridViewTextBoxColumn();
            HORAREAL = new DataGridViewTextBoxColumn();
            COSTOREAL = new DataGridViewTextBoxColumn();
            fecha_final = new DataGridViewTextBoxColumn();
            horas_avance = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTarea).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(310, 83);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(394, 116);
            txtDescripcion.TabIndex = 45;
            // 
            // dgvTarea
            // 
            dgvTarea.AllowUserToDeleteRows = false;
            dgvTarea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarea.Columns.AddRange(new DataGridViewColumn[] { PROYECTO, nombre_proyecto, NUMERO, descripcion, HORAESTIMADA, COSTOESTIMADO, HORAREAL, COSTOREAL, fecha_final, horas_avance, id, baja });
            dgvTarea.Location = new Point(12, 389);
            dgvTarea.Name = "dgvTarea";
            dgvTarea.ReadOnly = true;
            dgvTarea.RowTemplate.Height = 25;
            dgvTarea.Size = new Size(946, 271);
            dgvTarea.TabIndex = 43;
            dgvTarea.RowHeaderMouseClick += dgvTarea_RowHeaderMouseClick;
            dgvTarea.RowHeaderMouseDoubleClick += dgvTarea_RowHeaderMouseDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 287);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 40;
            label5.Text = "Costo Estimado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 246);
            label4.Name = "label4";
            label4.Size = new Size(154, 15);
            label4.TabIndex = 39;
            label4.Text = "Horas Estimadas (Unitarias):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(691, 246);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 38;
            label3.Text = "Horas reales:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 132);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 37;
            label2.Text = "Descripción:";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(693, 287);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 47;
            label6.Text = "Costo Real:";
            // 
            // txtCostoReal
            // 
            txtCostoReal.Location = new Point(777, 284);
            txtCostoReal.Name = "txtCostoReal";
            txtCostoReal.Size = new Size(118, 23);
            txtCostoReal.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(225, 33);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 49;
            label7.Text = "Proyecto:";
            // 
            // txtHoraReal
            // 
            txtHoraReal.Location = new Point(777, 243);
            txtHoraReal.Name = "txtHoraReal";
            txtHoraReal.Size = new Size(118, 23);
            txtHoraReal.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(334, 221);
            label8.Name = "label8";
            label8.Size = new Size(52, 86);
            label8.TabIndex = 51;
            label8.Text = "|";
            // 
            // txtHoraEstimada
            // 
            txtHoraEstimada.Location = new Point(196, 243);
            txtHoraEstimada.Name = "txtHoraEstimada";
            txtHoraEstimada.Size = new Size(129, 23);
            txtHoraEstimada.TabIndex = 52;
            // 
            // txtCostoEstimado
            // 
            txtCostoEstimado.Location = new Point(196, 284);
            txtCostoEstimado.Name = "txtCostoEstimado";
            txtCostoEstimado.Size = new Size(129, 23);
            txtCostoEstimado.TabIndex = 53;
            // 
            // cbProyecto
            // 
            cbProyecto.FormattingEnabled = true;
            cbProyecto.Location = new Point(310, 30);
            cbProyecto.Name = "cbProyecto";
            cbProyecto.Size = new Size(394, 23);
            cbProyecto.TabIndex = 55;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(582, 337);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 30);
            btnLimpiar.TabIndex = 161;
            btnLimpiar.Text = "Reiniciar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(466, 337);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 30);
            btnEliminar.TabIndex = 160;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(350, 337);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 159;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(466, 247);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 163;
            label9.Text = "Horas Avance";
            // 
            // txtHoraAvance
            // 
            txtHoraAvance.Location = new Point(427, 275);
            txtHoraAvance.Name = "txtHoraAvance";
            txtHoraAvance.Size = new Size(164, 23);
            txtHoraAvance.TabIndex = 162;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(636, 221);
            label10.Name = "label10";
            label10.Size = new Size(52, 86);
            label10.TabIndex = 164;
            label10.Text = "|";
            // 
            // txtNroTarea
            // 
            txtNroTarea.Location = new Point(79, 33);
            txtNroTarea.Name = "txtNroTarea";
            txtNroTarea.Size = new Size(45, 23);
            txtNroTarea.TabIndex = 165;
            txtNroTarea.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 15);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 166;
            label1.Text = "No borrar, sirva para nro tarea";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // PROYECTO
            // 
            PROYECTO.DataPropertyName = "id_proyecto";
            PROYECTO.Frozen = true;
            PROYECTO.HeaderText = "id_proyecto";
            PROYECTO.Name = "PROYECTO";
            PROYECTO.ReadOnly = true;
            PROYECTO.Visible = false;
            // 
            // nombre_proyecto
            // 
            nombre_proyecto.DataPropertyName = "proyecto";
            nombre_proyecto.Frozen = true;
            nombre_proyecto.HeaderText = "Proyecto";
            nombre_proyecto.Name = "nombre_proyecto";
            nombre_proyecto.ReadOnly = true;
            // 
            // NUMERO
            // 
            NUMERO.DataPropertyName = "nro_tarea";
            NUMERO.Frozen = true;
            NUMERO.HeaderText = "Numero";
            NUMERO.Name = "NUMERO";
            NUMERO.ReadOnly = true;
            NUMERO.Width = 50;
            // 
            // descripcion
            // 
            descripcion.DataPropertyName = "descripcion";
            descripcion.Frozen = true;
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 150;
            // 
            // HORAESTIMADA
            // 
            HORAESTIMADA.DataPropertyName = "horas_estimadas";
            HORAESTIMADA.Frozen = true;
            HORAESTIMADA.HeaderText = "Hora Estimada";
            HORAESTIMADA.Name = "HORAESTIMADA";
            HORAESTIMADA.ReadOnly = true;
            // 
            // COSTOESTIMADO
            // 
            COSTOESTIMADO.DataPropertyName = "costo_estimado";
            COSTOESTIMADO.Frozen = true;
            COSTOESTIMADO.HeaderText = "Costo Estimado";
            COSTOESTIMADO.Name = "COSTOESTIMADO";
            COSTOESTIMADO.ReadOnly = true;
            // 
            // HORAREAL
            // 
            HORAREAL.DataPropertyName = "horas_reales";
            HORAREAL.Frozen = true;
            HORAREAL.HeaderText = "Hora Real";
            HORAREAL.Name = "HORAREAL";
            HORAREAL.ReadOnly = true;
            // 
            // COSTOREAL
            // 
            COSTOREAL.DataPropertyName = "costo_real";
            COSTOREAL.Frozen = true;
            COSTOREAL.HeaderText = "Costo Real";
            COSTOREAL.Name = "COSTOREAL";
            COSTOREAL.ReadOnly = true;
            // 
            // fecha_final
            // 
            fecha_final.DataPropertyName = "fecha_final";
            fecha_final.Frozen = true;
            fecha_final.HeaderText = "Fecha Final";
            fecha_final.Name = "fecha_final";
            fecha_final.ReadOnly = true;
            // 
            // horas_avance
            // 
            horas_avance.DataPropertyName = "horas_avance";
            horas_avance.Frozen = true;
            horas_avance.HeaderText = "Horas Avance";
            horas_avance.Name = "horas_avance";
            horas_avance.ReadOnly = true;
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
            baja.DataPropertyName = "baja";
            baja.Frozen = true;
            baja.HeaderText = "baja";
            baja.Name = "baja";
            baja.ReadOnly = true;
            baja.Visible = false;
            // 
            // TareaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(978, 688);
            Controls.Add(label1);
            Controls.Add(txtNroTarea);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtHoraAvance);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(cbProyecto);
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
        private TextBox txtContacto;
        private TextBox txtRazonSocial;
        private Label label6;
        private TextBox txtCostoReal;
        private Label label7;
        private TextBox txtHoraReal;
        private Label label8;
        private TextBox txtHoraEstimada;
        private TextBox txtCostoEstimado;
        private ComboBox cbProyecto;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Label label9;
        private TextBox txtHoraAvance;
        private Label label10;
        private TextBox txtNroTarea;
        private Label label1;
        private DataGridViewTextBoxColumn PROYECTO;
        private DataGridViewTextBoxColumn nombre_proyecto;
        private DataGridViewTextBoxColumn NUMERO;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn HORAESTIMADA;
        private DataGridViewTextBoxColumn COSTOESTIMADO;
        private DataGridViewTextBoxColumn HORAREAL;
        private DataGridViewTextBoxColumn COSTOREAL;
        private DataGridViewTextBoxColumn fecha_final;
        private DataGridViewTextBoxColumn horas_avance;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn baja;
    }
}