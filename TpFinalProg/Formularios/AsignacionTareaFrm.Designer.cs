namespace TpFinalProg
{
    partial class AsignacionTareaFrm
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
            label1 = new Label();
            butGuardar = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Proyecto = new DataGridViewTextBoxColumn();
            Tarea = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            Avance = new DataGridViewTextBoxColumn();
            comboBox3 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox4 = new ComboBox();
            label6 = new Label();
            btnBuscar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 96);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleado";
            // 
            // butGuardar
            // 
            butGuardar.Location = new Point(373, 175);
            butGuardar.Name = "butGuardar";
            butGuardar.Size = new Size(75, 23);
            butGuardar.TabIndex = 1;
            butGuardar.Text = "Guardar";
            butGuardar.UseVisualStyleBackColor = true;
            butGuardar.Click += butGuardar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(147, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(147, 56);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(164, 23);
            comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 59);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Tarea";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 178);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 6;
            label3.Text = "Horas Diarias";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Proyecto, Tarea, Empleado, Avance });
            dataGridView1.Location = new Point(40, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(451, 150);
            dataGridView1.TabIndex = 7;
            // 
            // Proyecto
            // 
            Proyecto.HeaderText = "Proyecto";
            Proyecto.Name = "Proyecto";
            // 
            // Tarea
            // 
            Tarea.HeaderText = "Tarea";
            Tarea.Name = "Tarea";
            // 
            // Empleado
            // 
            Empleado.HeaderText = "Empleado";
            Empleado.Name = "Empleado";
            // 
            // Avance
            // 
            Avance.HeaderText = "Avance";
            Avance.Name = "Avance";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(147, 134);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(164, 23);
            comboBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 137);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Funcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 22);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "Proyecto";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(147, 19);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(164, 23);
            comboBox4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(339, 101);
            label6.Name = "label6";
            label6.Size = new Size(449, 15);
            label6.TabIndex = 12;
            label6.Text = "AGREGAR EN LA BASE UN CAMPO HORAS_ABANCE DONDE SE SUMEN LAS HORAS";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(327, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(25, 23);
            btnBuscar.TabIndex = 54;
            btnBuscar.Text = "🔍︎";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(486, 178);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 55;
            button1.Text = "fINALIZADO";
            button1.UseVisualStyleBackColor = true;
            // 
            // AsignacionTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnBuscar);
            Controls.Add(label6);
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
            Controls.Add(butGuardar);
            Controls.Add(label1);
            Name = "AsignacionTarea";
            Text = "AsignacionTarea";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button butGuardar;
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
        private DataGridViewTextBoxColumn Proyecto;
        private DataGridViewTextBoxColumn Tarea;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewTextBoxColumn Avance;
        private Label label6;
        private Button btnBuscar;
        private Button button1;
    }
}