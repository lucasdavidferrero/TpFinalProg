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
            label6 = new Label();
            label1 = new Label();
            txtLegajo = new TextBox();
            txtObservacion = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            fecha = new DataGridViewTextBoxColumn();
            observacion = new DataGridViewTextBoxColumn();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnAgregar = new Button();
            btnListar = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(24, 21);
            label6.Name = "label6";
            label6.Size = new Size(169, 20);
            label6.TabIndex = 34;
            label6.Text = "ABM OBSERVACIONES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 53);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 35;
            label1.Text = "LEGAJO:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(114, 49);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(100, 23);
            txtLegajo.TabIndex = 36;
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(114, 84);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(457, 116);
            txtObservacion.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 84);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 47;
            label2.Text = "OBSERVACION:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fecha, observacion });
            dataGridView1.Location = new Point(114, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(457, 150);
            dataGridView1.TabIndex = 49;
            // 
            // fecha
            // 
            fecha.HeaderText = "FECHA";
            fecha.Name = "fecha";
            // 
            // observacion
            // 
            observacion.HeaderText = "Observacion";
            observacion.Name = "observacion";
            observacion.Width = 250;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 53);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 50;
            label4.Text = "FECHA:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(298, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(99, 23);
            dateTimePicker1.TabIndex = 51;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(600, 259);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 26);
            btnAgregar.TabIndex = 52;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(600, 349);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 53;
            btnListar.Text = "Listar observaciones";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(600, 320);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 54;
            button1.Text = "Borrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(600, 291);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 55;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ObservacionFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 425);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnListar);
            Controls.Add(btnAgregar);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(txtObservacion);
            Controls.Add(txtLegajo);
            Controls.Add(label1);
            Controls.Add(label6);
            Name = "ObservacionFrm";
            Text = "Observacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private TextBox txtLegajo;
        private TextBox txtObservacion;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn observacion;
        private Button btnAgregar;
        private Button btnListar;
        private Button button1;
        private Button button2;
    }
}