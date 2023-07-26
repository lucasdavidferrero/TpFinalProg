namespace TpFinalProg.Formularios.Listados {
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
            dvgNoTerminados = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            btnBuscar = new Button();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            CostoEstimado = new DataGridViewTextBoxColumn();
            CostoReal = new DataGridViewTextBoxColumn();
            Desvio = new DataGridViewTextBoxColumn();
            baja = new DataGridViewTextBoxColumn();
            idnt = new DataGridViewTextBoxColumn();
            Nombrent = new DataGridViewTextBoxColumn();
            Empresant = new DataGridViewTextBoxColumn();
            GradoAvancent = new DataGridViewTextBoxColumn();
            CostoEstimadont = new DataGridViewTextBoxColumn();
            CostoParcialnt = new DataGridViewTextBoxColumn();
            bajant = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTerminados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgNoTerminados).BeginInit();
            SuspendLayout();
            // 
            // dgvTerminados
            // 
            dgvTerminados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerminados.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Empresa, CostoEstimado, CostoReal, Desvio, baja });
            dgvTerminados.Location = new Point(60, 111);
            dgvTerminados.Name = "dgvTerminados";
            dgvTerminados.ReadOnly = true;
            dgvTerminados.RowTemplate.Height = 25;
            dgvTerminados.Size = new Size(686, 150);
            dgvTerminados.TabIndex = 0;
            // 
            // dvgNoTerminados
            // 
            dvgNoTerminados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgNoTerminados.Columns.AddRange(new DataGridViewColumn[] { idnt, Nombrent, Empresant, GradoAvancent, CostoEstimadont, CostoParcialnt, bajant });
            dvgNoTerminados.Location = new Point(60, 311);
            dvgNoTerminados.Name = "dvgNoTerminados";
            dvgNoTerminados.ReadOnly = true;
            dvgNoTerminados.RowTemplate.Height = 25;
            dvgNoTerminados.Size = new Size(686, 150);
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
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // Nombre
            // 
            Nombre.Frozen = true;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 180;
            // 
            // Empresa
            // 
            Empresa.Frozen = true;
            Empresa.HeaderText = "Empresa";
            Empresa.Name = "Empresa";
            Empresa.ReadOnly = true;
            Empresa.Width = 160;
            // 
            // CostoEstimado
            // 
            CostoEstimado.Frozen = true;
            CostoEstimado.HeaderText = "Costo Estimado";
            CostoEstimado.Name = "CostoEstimado";
            CostoEstimado.ReadOnly = true;
            // 
            // CostoReal
            // 
            CostoReal.Frozen = true;
            CostoReal.HeaderText = "Costo Real";
            CostoReal.Name = "CostoReal";
            CostoReal.ReadOnly = true;
            // 
            // Desvio
            // 
            Desvio.Frozen = true;
            Desvio.HeaderText = "Desvio";
            Desvio.Name = "Desvio";
            Desvio.ReadOnly = true;
            // 
            // baja
            // 
            baja.Frozen = true;
            baja.HeaderText = "baja";
            baja.Name = "baja";
            baja.ReadOnly = true;
            baja.Visible = false;
            // 
            // idnt
            // 
            idnt.Frozen = true;
            idnt.HeaderText = "idnt";
            idnt.Name = "idnt";
            idnt.ReadOnly = true;
            idnt.Visible = false;
            // 
            // Nombrent
            // 
            Nombrent.Frozen = true;
            Nombrent.HeaderText = "Nombre";
            Nombrent.Name = "Nombrent";
            Nombrent.ReadOnly = true;
            Nombrent.Width = 160;
            // 
            // Empresant
            // 
            Empresant.Frozen = true;
            Empresant.HeaderText = "Empresa";
            Empresant.Name = "Empresant";
            Empresant.ReadOnly = true;
            Empresant.Width = 180;
            // 
            // GradoAvancent
            // 
            GradoAvancent.Frozen = true;
            GradoAvancent.HeaderText = "Grado Avance";
            GradoAvancent.Name = "GradoAvancent";
            GradoAvancent.ReadOnly = true;
            // 
            // CostoEstimadont
            // 
            CostoEstimadont.Frozen = true;
            CostoEstimadont.HeaderText = "Costo Estimado";
            CostoEstimadont.Name = "CostoEstimadont";
            CostoEstimadont.ReadOnly = true;
            // 
            // CostoParcialnt
            // 
            CostoParcialnt.Frozen = true;
            CostoParcialnt.HeaderText = "Costo Parcial";
            CostoParcialnt.Name = "CostoParcialnt";
            CostoParcialnt.ReadOnly = true;
            // 
            // bajant
            // 
            bajant.Frozen = true;
            bajant.HeaderText = "baja";
            bajant.Name = "bajant";
            bajant.ReadOnly = true;
            bajant.Visible = false;
            // 
            // ListadoProyectoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 491);
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
        private Label label3;
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
        private DataGridViewTextBoxColumn idnt;
        private DataGridViewTextBoxColumn Nombrent;
        private DataGridViewTextBoxColumn Empresant;
        private DataGridViewTextBoxColumn GradoAvancent;
        private DataGridViewTextBoxColumn CostoEstimadont;
        private DataGridViewTextBoxColumn CostoParcialnt;
        private DataGridViewTextBoxColumn bajant;
    }
}