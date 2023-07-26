﻿namespace TpFinalProg.Formularios.Listados {
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
            dataGridView2 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTareasEnCurso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // cbProyectos
            // 
            cbProyectos.FormattingEnabled = true;
            cbProyectos.Location = new Point(243, 12);
            cbProyectos.Name = "cbProyectos";
            cbProyectos.Size = new Size(311, 23);
            cbProyectos.TabIndex = 0;
            cbProyectos.TextChanged += cbProyectos_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 15);
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
            dgvTareasEnCurso.Size = new Size(776, 170);
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 257);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(776, 181);
            dataGridView2.TabIndex = 4;
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
            // ListadoTareasFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(dgvTareasEnCurso);
            Controls.Add(label1);
            Controls.Add(cbProyectos);
            Name = "ListadoTareasFrm";
            Text = "ListadoTareasFrm";
            ((System.ComponentModel.ISupportInitialize)dgvTareasEnCurso).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbProyectos;
        private Label label1;
        private DataGridView dgvTareasEnCurso;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label3;
        private DataGridViewTextBoxColumn nro_tarea;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn horas_estimadas;
        private DataGridViewTextBoxColumn costo_estimado;
        private DataGridViewTextBoxColumn horas_avance;
    }
}