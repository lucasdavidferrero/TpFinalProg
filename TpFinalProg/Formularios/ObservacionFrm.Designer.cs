namespace TpFinalProg {
    partial class ObservacionFrm {
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
            label1 = new Label();
            txtLegajo = new TextBox();
            txtObservacion = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            fecha = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            BAJA = new DataGridViewTextBoxColumn();
            OBSERVACION = new DataGridViewTextBoxColumn();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnModificar = new Button();
            btnBaja = new Button();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 22);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 35;
            label1.Text = "LEGAJO:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(187, 18);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(110, 23);
            txtLegajo.TabIndex = 36;
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(187, 70);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(342, 123);
            txtObservacion.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 122);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 47;
            label2.Text = "OBSERVACION:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fecha, ID, BAJA, OBSERVACION });
            dataGridView1.Location = new Point(62, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(594, 180);
            dataGridView1.TabIndex = 49;
            // 
            // fecha
            // 
            fecha.HeaderText = "FECHA";
            fecha.Name = "fecha";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // BAJA
            // 
            BAJA.HeaderText = "BAJA";
            BAJA.Name = "BAJA";
            BAJA.Visible = false;
            // 
            // OBSERVACION
            // 
            OBSERVACION.HeaderText = "OBSERVACION";
            OBSERVACION.Name = "OBSERVACION";
            OBSERVACION.Width = 450;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 21);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 50;
            label4.Text = "FECHA:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(419, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(110, 23);
            dateTimePicker1.TabIndex = 51;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Transparent;
            btnModificar.BackgroundImageLayout = ImageLayout.None;
            btnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(187, 213);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(110, 30);
            btnModificar.TabIndex = 158;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.Transparent;
            btnBaja.BackgroundImageLayout = ImageLayout.None;
            btnBaja.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaja.Location = new Point(419, 213);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(110, 30);
            btnBaja.TabIndex = 157;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(535, 213);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 30);
            btnLimpiar.TabIndex = 156;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Transparent;
            btnBorrar.BackgroundImageLayout = ImageLayout.None;
            btnBorrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.Location = new Point(303, 213);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(110, 30);
            btnBorrar.TabIndex = 155;
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(71, 213);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 154;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // ObservacionFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 461);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(txtObservacion);
            Controls.Add(txtLegajo);
            Controls.Add(label1);
            Name = "ObservacionFrm";
            Text = "Observacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtLegajo;
        private TextBox txtObservacion;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BAJA;
        private DataGridViewTextBoxColumn OBSERVACION;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnLimpiar;
        private Button btnBorrar;
        private Button btnGuardar;
    }
}