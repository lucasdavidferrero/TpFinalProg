namespace TpFinalProg {
    partial class AsignacionTareaFrm {
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Proyecto = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            BAJA = new DataGridViewTextBoxColumn();
            Tarea = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            FUNCION = new DataGridViewTextBoxColumn();
            Avance = new DataGridViewTextBoxColumn();
            comboBox3 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox4 = new ComboBox();
            btnModificar = new Button();
            btnBaja = new Button();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            btnGuardar = new Button();
            btnFinalizacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 96);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(266, 56);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(164, 23);
            comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 59);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Tarea";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 178);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 6;
            label3.Text = "Horas Diarias";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Proyecto, ID, BAJA, Tarea, Empleado, FUNCION, Avance });
            dataGridView1.Location = new Point(39, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(604, 150);
            dataGridView1.TabIndex = 7;
            // 
            // Proyecto
            // 
            Proyecto.HeaderText = "PROYECTO";
            Proyecto.Name = "Proyecto";
            Proyecto.Width = 120;
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
            // Tarea
            // 
            Tarea.HeaderText = "TAREA";
            Tarea.Name = "Tarea";
            Tarea.Width = 120;
            // 
            // Empleado
            // 
            Empleado.HeaderText = "EMPLEADO";
            Empleado.Name = "Empleado";
            Empleado.Width = 120;
            // 
            // FUNCION
            // 
            FUNCION.HeaderText = "FUNCION";
            FUNCION.Name = "FUNCION";
            // 
            // Avance
            // 
            Avance.HeaderText = "AVANCE";
            Avance.Name = "Avance";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(266, 134);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(164, 23);
            comboBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 137);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Funcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 22);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "Proyecto";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(266, 19);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(164, 23);
            comboBox4.TabIndex = 10;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Transparent;
            btnModificar.BackgroundImageLayout = ImageLayout.None;
            btnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(167, 227);
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
            btnBaja.Location = new Point(399, 227);
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
            btnLimpiar.Location = new Point(515, 227);
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
            btnBorrar.Location = new Point(283, 227);
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
            btnGuardar.Location = new Point(51, 227);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 30);
            btnGuardar.TabIndex = 154;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnFinalizacion
            // 
            btnFinalizacion.BackColor = Color.Transparent;
            btnFinalizacion.BackgroundImageLayout = ImageLayout.None;
            btnFinalizacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinalizacion.Location = new Point(489, 96);
            btnFinalizacion.Name = "btnFinalizacion";
            btnFinalizacion.Size = new Size(110, 30);
            btnFinalizacion.TabIndex = 159;
            btnFinalizacion.Text = "FINALIZACION";
            btnFinalizacion.UseVisualStyleBackColor = false;
            // 
            // AsignacionTareaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(680, 450);
            Controls.Add(btnFinalizacion);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AsignacionTareaFrm";
            Text = "AsignacionTarea";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private ComboBox comboBox3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox4;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnLimpiar;
        private Button btnBorrar;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn Proyecto;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BAJA;
        private DataGridViewTextBoxColumn Tarea;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewTextBoxColumn FUNCION;
        private DataGridViewTextBoxColumn Avance;
        private Button btnFinalizacion;
    }
}