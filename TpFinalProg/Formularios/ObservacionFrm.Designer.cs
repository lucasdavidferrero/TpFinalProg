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
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            btnGuardar = new Button();
            btnBuscar = new Button();
            fecha = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            BAJA = new DataGridViewTextBoxColumn();
            OBSERVACION = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 22);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 35;
            label1.Text = "Legajo:";
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
            label2.Location = new Point(98, 122);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 47;
            label2.Text = "Observacion:";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 21);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 50;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(419, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(110, 23);
            dateTimePicker1.TabIndex = 51;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(419, 213);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 30);
            btnLimpiar.TabIndex = 156;
            btnLimpiar.Text = "Reiniciar";
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
            btnGuardar.Location = new Point(187, 213);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 154;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(303, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(30, 23);
            btnBuscar.TabIndex = 159;
            btnBuscar.Text = " 🔎";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
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
            OBSERVACION.HeaderText = "Observacion";
            OBSERVACION.Name = "OBSERVACION";
            OBSERVACION.Width = 450;
            // 
            // ObservacionFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 461);
            Controls.Add(btnBuscar);
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
        private Button btnLimpiar;
        private Button btnBorrar;
        private Button btnGuardar;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BAJA;
        private DataGridViewTextBoxColumn OBSERVACION;
    }
}