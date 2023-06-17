namespace TpFinalProg
{
    partial class TareaFrm
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
            txtDescripcion = new TextBox();
            dgvTarea = new DataGridView();
            PROYECTO = new DataGridViewTextBoxColumn();
            NUMERO = new DataGridViewTextBoxColumn();
            HORAESTIMADA = new DataGridViewTextBoxColumn();
            COSTOESTIMADO = new DataGridViewTextBoxColumn();
            HORAREAL = new DataGridViewTextBoxColumn();
            COSTOREAL = new DataGridViewTextBoxColumn();
            btnBorrar = new Button();
            btnBuscar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
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
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTarea).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(515, 76);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(446, 232);
            txtDescripcion.TabIndex = 45;
            // 
            // dgvTarea
            // 
            dgvTarea.AllowUserToAddRows = false;
            dgvTarea.AllowUserToDeleteRows = false;
            dgvTarea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarea.Columns.AddRange(new DataGridViewColumn[] { PROYECTO, NUMERO, HORAESTIMADA, COSTOESTIMADO, HORAREAL, COSTOREAL });
            dgvTarea.Location = new Point(95, 346);
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
            // btnBorrar
            // 
            btnBorrar.Location = new Point(820, 510);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(91, 30);
            btnBorrar.TabIndex = 42;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(402, 42);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(34, 23);
            btnBuscar.TabIndex = 41;
            btnBuscar.Text = "🔍︎";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 151);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 40;
            label5.Text = "COSTO ESTIMADO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 116);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 39;
            label4.Text = "HORAS ESTIMADAS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 220);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 38;
            label3.Text = "HORAS REALES:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 58);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 37;
            label2.Text = "DESCRIPCION:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 79);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 36;
            label1.Text = "NUMERO ORDEN:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(820, 458);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(91, 30);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 256);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 47;
            label6.Text = "COSTO REAL:";
            // 
            // txtCostoReal
            // 
            txtCostoReal.Location = new Point(148, 256);
            txtCostoReal.Name = "txtCostoReal";
            txtCostoReal.Size = new Size(118, 23);
            txtCostoReal.TabIndex = 46;
            txtCostoReal.TextChanged += txtCostoReal_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 45);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 49;
            label7.Text = "PROYECTO:";
            // 
            // txtHoraReal
            // 
            txtHoraReal.Location = new Point(148, 217);
            txtHoraReal.Name = "txtHoraReal";
            txtHoraReal.Size = new Size(118, 23);
            txtHoraReal.TabIndex = 34;
            txtHoraReal.TextChanged += txtHoraReal_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 189);
            label8.Name = "label8";
            label8.Size = new Size(297, 15);
            label8.TabIndex = 51;
            label8.Text = "----------------------------------------------------------";
            // 
            // txtHoraEstimada
            // 
            txtHoraEstimada.Location = new Point(148, 113);
            txtHoraEstimada.Name = "txtHoraEstimada";
            txtHoraEstimada.Size = new Size(118, 23);
            txtHoraEstimada.TabIndex = 52;
            txtHoraEstimada.TextChanged += txtHoraEstimada_TextChanged;
            // 
            // txtCostoEstimado
            // 
            txtCostoEstimado.Location = new Point(148, 148);
            txtCostoEstimado.Name = "txtCostoEstimado";
            txtCostoEstimado.Size = new Size(118, 23);
            txtCostoEstimado.TabIndex = 53;
            txtCostoEstimado.TextChanged += txtCostoEstimado_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(149, 76);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(117, 23);
            txtNumero.TabIndex = 54;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // cbProyecto
            // 
            cbProyecto.FormattingEnabled = true;
            cbProyecto.Location = new Point(148, 42);
            cbProyecto.Name = "cbProyecto";
            cbProyecto.Size = new Size(236, 23);
            cbProyecto.TabIndex = 55;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(820, 403);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(91, 30);
            btnModificar.TabIndex = 56;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(30, 9);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 57;
            label9.Text = "ABM TAREAS";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(284, 116);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 58;
            label10.Text = "UNITARIO";
            // 
            // Tarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 644);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnModificar);
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
            Controls.Add(btnBorrar);
            Controls.Add(btnBuscar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHoraReal);
            Controls.Add(btnGuardar);
            Name = "Tarea";
            Text = "Tarea";
            ((System.ComponentModel.ISupportInitialize)dgvTarea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private TextBox txtTelefono;
        private DataGridView dgvTarea;
        private Button btnBorrar;
        private Button btnBuscar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtContacto;
        private Button btnGuardar;
        private TextBox txtRazonSocial;
        private Label label6;
        private TextBox txtCostoReal;
        private DataGridViewTextBoxColumn PROYECTO;
        private DataGridViewTextBoxColumn NUMERO;
        private DataGridViewTextBoxColumn HORAESTIMADA;
        private DataGridViewTextBoxColumn COSTOESTIMADO;
        private DataGridViewTextBoxColumn HORAREAL;
        private DataGridViewTextBoxColumn COSTOREAL;
        private Label label7;
        private TextBox txtHoraReal;
        private Label label8;
        private TextBox txtHoraEstimada;
        private TextBox txtCostoEstimado;
        private TextBox txtNumero;
        private ComboBox cbProyecto;
        private Button btnModificar;
        private Label label9;
        private Label label10;
    }
}