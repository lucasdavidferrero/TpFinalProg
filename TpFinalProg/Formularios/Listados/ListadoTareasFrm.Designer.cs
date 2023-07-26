namespace TpFinalProg.Formularios.Listados {
    partial class ListadoTareasFrm {
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
            cbProyectos = new ComboBox();
            label1 = new Label();
            dgvTareasEnCurso = new DataGridView();
            nro_tarea = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            horas_estimadas = new DataGridViewTextBoxColumn();
            costo_estimado = new DataGridViewTextBoxColumn();
            horas_avance = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dgvTareasFinalizadas = new DataGridView();
            label3 = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            horas_reales = new DataGridViewTextBoxColumn();
            costo_real = new DataGridViewTextBoxColumn();
            desvio = new DataGridViewTextBoxColumn();
            fecha_final = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTareasEnCurso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTareasFinalizadas).BeginInit();
            SuspendLayout();
            // 
            // cbProyectos
            // 
            cbProyectos.FormattingEnabled = true;
            cbProyectos.Location = new Point(360, 12);
            cbProyectos.Name = "cbProyectos";
            cbProyectos.Size = new Size(311, 23);
            cbProyectos.TabIndex = 0;
            cbProyectos.TextChanged += cbProyectos_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Proyecto";
            // 
            // dgvTareasEnCurso
            // 
            dgvTareasEnCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareasEnCurso.Columns.AddRange(new DataGridViewColumn[] { nro_tarea, descripcion, horas_estimadas, costo_estimado, horas_avance });
            dgvTareasEnCurso.Location = new Point(12, 54);
            dgvTareasEnCurso.Name = "dgvTareasEnCurso";
            dgvTareasEnCurso.RowTemplate.Height = 25;
            dgvTareasEnCurso.Size = new Size(940, 170);
            dgvTareasEnCurso.TabIndex = 2;
            // 
            // nro_tarea
            // 
            nro_tarea.DataPropertyName = "nro_tarea";
            nro_tarea.HeaderText = "Nro. Tarea";
            nro_tarea.Name = "nro_tarea";
            nro_tarea.ReadOnly = true;
            nro_tarea.Width = 50;
            // 
            // descripcion
            // 
            descripcion.DataPropertyName = "descripcion";
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 160;
            // 
            // horas_estimadas
            // 
            horas_estimadas.DataPropertyName = "horas_estimadas";
            horas_estimadas.HeaderText = "Hs. Estimadas";
            horas_estimadas.Name = "horas_estimadas";
            horas_estimadas.ReadOnly = true;
            horas_estimadas.Width = 160;
            // 
            // costo_estimado
            // 
            costo_estimado.DataPropertyName = "costo_estimado";
            costo_estimado.HeaderText = "Costo Estimado";
            costo_estimado.Name = "costo_estimado";
            costo_estimado.ReadOnly = true;
            costo_estimado.Width = 160;
            // 
            // horas_avance
            // 
            horas_avance.DataPropertyName = "horas_avance";
            horas_avance.HeaderText = "Hs. Avance";
            horas_avance.Name = "horas_avance";
            horas_avance.ReadOnly = true;
            horas_avance.Width = 160;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "En curso";
            // 
            // dgvTareasFinalizadas
            // 
            dgvTareasFinalizadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareasFinalizadas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, horas_reales, costo_real, desvio, fecha_final });
            dgvTareasFinalizadas.Location = new Point(12, 257);
            dgvTareasFinalizadas.Name = "dgvTareasFinalizadas";
            dgvTareasFinalizadas.RowTemplate.Height = 25;
            dgvTareasFinalizadas.Size = new Size(940, 181);
            dgvTareasFinalizadas.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 239);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Finalizadas";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "nro_tarea";
            dataGridViewTextBoxColumn1.HeaderText = "Nro.Tarea";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "descripcion";
            dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "horas_estimadas";
            dataGridViewTextBoxColumn3.HeaderText = "Hs.Estimadas";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "costo_estimado";
            dataGridViewTextBoxColumn4.HeaderText = "Costo estimado";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "horas_avance";
            dataGridViewTextBoxColumn5.HeaderText = "Hs.Avance";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // horas_reales
            // 
            horas_reales.DataPropertyName = "horas_reales";
            horas_reales.HeaderText = "Hs.Reales";
            horas_reales.Name = "horas_reales";
            horas_reales.ReadOnly = true;
            // 
            // costo_real
            // 
            costo_real.DataPropertyName = "costo_real";
            costo_real.HeaderText = "Costo real";
            costo_real.Name = "costo_real";
            costo_real.ReadOnly = true;
            // 
            // desvio
            // 
            desvio.DataPropertyName = "desvio";
            desvio.HeaderText = "Desvio";
            desvio.Name = "desvio";
            desvio.ReadOnly = true;
            // 
            // fecha_final
            // 
            fecha_final.DataPropertyName = "fecha_final";
            fecha_final.HeaderText = "Fecha Final";
            fecha_final.Name = "fecha_final";
            fecha_final.ReadOnly = true;
            // 
            // ListadoTareasFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(964, 450);
            Controls.Add(label3);
            Controls.Add(dgvTareasFinalizadas);
            Controls.Add(label2);
            Controls.Add(dgvTareasEnCurso);
            Controls.Add(label1);
            Controls.Add(cbProyectos);
            Name = "ListadoTareasFrm";
            Text = "ListadoTareasFrm";
            ((System.ComponentModel.ISupportInitialize)dgvTareasEnCurso).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTareasFinalizadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbProyectos;
        private Label label1;
        private DataGridView dgvTareasEnCurso;
        private Label label2;
        private DataGridView dgvTareasFinalizadas;
        private Label label3;
        private DataGridViewTextBoxColumn nro_tarea;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn horas_estimadas;
        private DataGridViewTextBoxColumn costo_estimado;
        private DataGridViewTextBoxColumn horas_avance;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn horas_reales;
        private DataGridViewTextBoxColumn costo_real;
        private DataGridViewTextBoxColumn desvio;
        private DataGridViewTextBoxColumn fecha_final;
    }
}