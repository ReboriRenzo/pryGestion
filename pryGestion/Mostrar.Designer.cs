namespace pryGestion
{
    partial class frmMostrar
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
            this.lblActividad = new System.Windows.Forms.Label();
            this.dgvGrillaActividades = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reunion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActividad.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblActividad.Location = new System.Drawing.Point(176, 9);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(228, 27);
            this.lblActividad.TabIndex = 1;
            this.lblActividad.Text = "Registro de Actividades";
            // 
            // dgvGrillaActividades
            // 
            this.dgvGrillaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Tareas,
            this.Detalles,
            this.Reunion,
            this.Tarea});
            this.dgvGrillaActividades.Location = new System.Drawing.Point(12, 39);
            this.dgvGrillaActividades.Name = "dgvGrillaActividades";
            this.dgvGrillaActividades.Size = new System.Drawing.Size(546, 238);
            this.dgvGrillaActividades.TabIndex = 2;
            this.dgvGrillaActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrillaActividades_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Tareas
            // 
            this.Tareas.HeaderText = "Tipo de tarea";
            this.Tareas.Name = "Tareas";
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Name = "Detalles";
            // 
            // Reunion
            // 
            this.Reunion.HeaderText = "Reunion";
            this.Reunion.Name = "Reunion";
            // 
            // Tarea
            // 
            this.Tarea.HeaderText = "Tareas";
            this.Tarea.Name = "Tarea";
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 316);
            this.Controls.Add(this.dgvGrillaActividades);
            this.Controls.Add(this.lblActividad);
            this.Name = "frmMostrar";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.frmMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.DataGridView dgvGrillaActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reunion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarea;
    }
}