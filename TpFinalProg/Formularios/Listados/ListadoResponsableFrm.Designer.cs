namespace TpFinalProg.Formularios.Listados {
    partial class ListadoResponsableFrm {
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
            btnBuscar = new Button();
            label1 = new Label();
            dgvExterno = new DataGridView();
            NombreP = new DataGridViewTextBoxColumn();
            dgvInterno = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            cbResponsable = new ComboBox();
            NombreT = new DataGridViewTextBoxColumn();
            legajo = new DataGridViewTextBoxColumn();
            id_proyecto = new DataGridViewTextBoxColumn();
            id_tarea = new DataGridViewTextBoxColumn();
            id_funcion_fk = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            id_trabaja = new DataGridViewTextBoxColumn();
            FuncionT = new DataGridViewTextBoxColumn();
            Tarea = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvExterno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInterno).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(432, 48);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(26, 23);
            btnBuscar.TabIndex = 184;
            btnBuscar.Text = "🔍︎";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 52);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 185;
            label1.Text = "Nombre";
            // 
            // dgvExterno
            // 
            dgvExterno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExterno.Columns.AddRange(new DataGridViewColumn[] { NombreP });
            dgvExterno.Location = new Point(50, 115);
            dgvExterno.Name = "dgvExterno";
            dgvExterno.ReadOnly = true;
            dgvExterno.RowTemplate.Height = 25;
            dgvExterno.Size = new Size(547, 139);
            dgvExterno.TabIndex = 187;
            // 
            // NombreP
            // 
            NombreP.DataPropertyName = "nombre";
            NombreP.HeaderText = "Responsable del Proyecto";
            NombreP.Name = "NombreP";
            NombreP.ReadOnly = true;
            NombreP.Width = 500;
            // 
            // dgvInterno
            // 
            dgvInterno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInterno.Columns.AddRange(new DataGridViewColumn[] { NombreT, legajo, id_proyecto, id_tarea, id_funcion_fk, baja, id_trabaja, FuncionT, Tarea });
            dgvInterno.Location = new Point(50, 308);
            dgvInterno.Name = "dgvInterno";
            dgvInterno.ReadOnly = true;
            dgvInterno.RowTemplate.Height = 25;
            dgvInterno.Size = new Size(547, 270);
            dgvInterno.TabIndex = 188;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 290);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 189;
            label2.Text = "Interno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 97);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 190;
            label3.Text = "Externo";
            // 
            // cbResponsable
            // 
            cbResponsable.FormattingEnabled = true;
            cbResponsable.Location = new Point(214, 49);
            cbResponsable.Name = "cbResponsable";
            cbResponsable.Size = new Size(212, 23);
            cbResponsable.TabIndex = 191;
            // 
            // NombreT
            // 
            NombreT.DataPropertyName = "nombre";
            NombreT.HeaderText = "Nombre Proyecto";
            NombreT.Name = "NombreT";
            NombreT.ReadOnly = true;
            NombreT.Width = 170;
            // 
            // legajo
            // 
            legajo.DataPropertyName = "legajo";
            legajo.HeaderText = "legajo";
            legajo.Name = "legajo";
            legajo.ReadOnly = true;
            legajo.Visible = false;
            // 
            // id_proyecto
            // 
            id_proyecto.DataPropertyName = "id_proyecto";
            id_proyecto.HeaderText = "id_proyecto";
            id_proyecto.Name = "id_proyecto";
            id_proyecto.ReadOnly = true;
            id_proyecto.Visible = false;
            // 
            // id_tarea
            // 
            id_tarea.DataPropertyName = "id_tarea";
            id_tarea.HeaderText = "idTarea";
            id_tarea.Name = "id_tarea";
            id_tarea.ReadOnly = true;
            id_tarea.Visible = false;
            // 
            // id_funcion_fk
            // 
            id_funcion_fk.DataPropertyName = "id_funcion_fk";
            id_funcion_fk.HeaderText = "Column1";
            id_funcion_fk.Name = "id_funcion_fk";
            id_funcion_fk.ReadOnly = true;
            id_funcion_fk.Visible = false;
            // 
            // baja
            // 
            baja.DataPropertyName = "baja";
            baja.HeaderText = "baja";
            baja.Name = "baja";
            baja.ReadOnly = true;
            baja.Visible = false;
            // 
            // id_trabaja
            // 
            id_trabaja.DataPropertyName = "id_trabaja";
            id_trabaja.HeaderText = "idTrabaja";
            id_trabaja.Name = "id_trabaja";
            id_trabaja.ReadOnly = true;
            id_trabaja.Visible = false;
            // 
            // FuncionT
            // 
            FuncionT.DataPropertyName = "descripcionFuncion";
            FuncionT.HeaderText = "Funcion Asignada";
            FuncionT.Name = "FuncionT";
            FuncionT.ReadOnly = true;
            FuncionT.Width = 150;
            // 
            // Tarea
            // 
            Tarea.DataPropertyName = "descripcionTarea";
            Tarea.HeaderText = "Tarea";
            Tarea.Name = "Tarea";
            Tarea.ReadOnly = true;
            Tarea.Width = 180;
            // 
            // ListadoResponsableFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(685, 646);
            Controls.Add(cbResponsable);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvInterno);
            Controls.Add(dgvExterno);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Name = "ListadoResponsableFrm";
            Text = "ListadoResponsablesFrm";
            ((System.ComponentModel.ISupportInitialize)dgvExterno).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInterno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Label label1;
        private DataGridView dgvExterno;
        private DataGridView dgvInterno;
        private Label label2;
        private Label label3;
        private ComboBox cbResponsable;
        private DataGridViewTextBoxColumn NombreP;
        private DataGridViewTextBoxColumn NombreT;
        private DataGridViewTextBoxColumn legajo;
        private DataGridViewTextBoxColumn id_proyecto;
        private DataGridViewTextBoxColumn id_tarea;
        private DataGridViewTextBoxColumn id_funcion_fk;
        private DataGridViewTextBoxColumn baja;
        private DataGridViewTextBoxColumn id_trabaja;
        private DataGridViewTextBoxColumn FuncionT;
        private DataGridViewTextBoxColumn Tarea;
    }
}