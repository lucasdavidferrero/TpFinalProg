namespace TpFinalProg.Formularios {
    partial class MenuTareaFrm {
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
            btnABM = new Button();
            btnAsignacionTarea = new Button();
            btnListados = new Button();
            SuspendLayout();
            // 
            // btnABM
            // 
            btnABM.BackColor = Color.Transparent;
            btnABM.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnABM.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnABM.Location = new Point(67, 53);
            btnABM.Name = "btnABM";
            btnABM.Size = new Size(189, 73);
            btnABM.TabIndex = 16;
            btnABM.Text = "ABM";
            btnABM.UseVisualStyleBackColor = false;
            btnABM.Click += btnABM_Click;
            // 
            // btnAsignacionTarea
            // 
            btnAsignacionTarea.BackColor = Color.Transparent;
            btnAsignacionTarea.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnAsignacionTarea.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnAsignacionTarea.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignacionTarea.Location = new Point(67, 153);
            btnAsignacionTarea.Name = "btnAsignacionTarea";
            btnAsignacionTarea.Size = new Size(189, 73);
            btnAsignacionTarea.TabIndex = 17;
            btnAsignacionTarea.Text = "ASIGNACIÓN TAREAS";
            btnAsignacionTarea.UseVisualStyleBackColor = false;
            btnAsignacionTarea.Click += btnAsignacionTarea_Click;
            // 
            // btnListados
            // 
            btnListados.BackColor = Color.Transparent;
            btnListados.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnListados.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnListados.Location = new Point(67, 256);
            btnListados.Name = "btnListados";
            btnListados.Size = new Size(189, 73);
            btnListados.TabIndex = 18;
            btnListados.Text = "LISTADOS";
            btnListados.UseVisualStyleBackColor = false;
            btnListados.Click += btnListados_Click;
            // 
            // MenuTareaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(314, 385);
            Controls.Add(btnListados);
            Controls.Add(btnAsignacionTarea);
            Controls.Add(btnABM);
            Name = "MenuTareaFrm";
            Text = "MenuTareaFrm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnABM;
        private Button btnAsignacionTarea;
        private Button btnListados;
    }
}