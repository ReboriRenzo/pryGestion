using System;

namespace pryGestion
{
    partial class frmRegistrar
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.mrcReunion = new System.Windows.Forms.GroupBox();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDetalleActidad = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lista = new System.Windows.Forms.ListBox();
            this.cmdCargarVector = new System.Windows.Forms.Button();
            this.cmdVerVector = new System.Windows.Forms.Button();
            this.cmdVerVector2 = new System.Windows.Forms.Button();
            this.cmdVector3 = new System.Windows.Forms.Button();
            this.mrcReunion.SuspendLayout();
            this.mrcTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Yu Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(6, 63);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 19);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(68, 63);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(302, 28);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Black;
            this.lblTipo.Location = new System.Drawing.Point(27, 102);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(18, 136);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(57, 20);
            this.lblDetalle.TabIndex = 4;
            this.lblDetalle.Text = "Detalle";
            this.lblDetalle.Click += new System.EventHandler(this.label3_Click);
            // 
            // mrcReunion
            // 
            this.mrcReunion.Controls.Add(this.optSi);
            this.mrcReunion.Controls.Add(this.optNo);
            this.mrcReunion.Font = new System.Drawing.Font("Yu Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcReunion.Location = new System.Drawing.Point(7, 202);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Size = new System.Drawing.Size(115, 77);
            this.mrcReunion.TabIndex = 6;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Reunion";
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.Font = new System.Drawing.Font("Yu Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.optSi.Location = new System.Drawing.Point(15, 36);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(37, 21);
            this.optSi.TabIndex = 1;
            this.optSi.TabStop = true;
            this.optSi.Text = "Si";
            this.optSi.UseVisualStyleBackColor = true;
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.optNo.Location = new System.Drawing.Point(55, 36);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(43, 21);
            this.optNo.TabIndex = 0;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // mrcTareas
            // 
            this.mrcTareas.Controls.Add(this.chkNotasReunion);
            this.mrcTareas.Controls.Add(this.chkDebate);
            this.mrcTareas.Controls.Add(this.chkInvestigacion);
            this.mrcTareas.Controls.Add(this.chkRepositorio);
            this.mrcTareas.Font = new System.Drawing.Font("Yu Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTareas.Location = new System.Drawing.Point(10, 295);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Size = new System.Drawing.Size(238, 97);
            this.mrcTareas.TabIndex = 7;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            this.mrcTareas.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotasReunion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkNotasReunion.Location = new System.Drawing.Point(11, 63);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(113, 21);
            this.chkNotasReunion.TabIndex = 3;
            this.chkNotasReunion.Text = "Notas reunion";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDebate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkDebate.Location = new System.Drawing.Point(126, 62);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(71, 21);
            this.chkDebate.TabIndex = 2;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvestigacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkInvestigacion.Location = new System.Drawing.Point(126, 35);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(106, 21);
            this.chkInvestigacion.TabIndex = 1;
            this.chkInvestigacion.Text = "Investigacion";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepositorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkRepositorio.Location = new System.Drawing.Point(12, 35);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(95, 21);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(136, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDetalleActidad
            // 
            this.txtDetalleActidad.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleActidad.Location = new System.Drawing.Point(94, 133);
            this.txtDetalleActidad.Multiline = true;
            this.txtDetalleActidad.Name = "txtDetalleActidad";
            this.txtDetalleActidad.Size = new System.Drawing.Size(183, 58);
            this.txtDetalleActidad.TabIndex = 9;
            // 
            // cboTipo
            // 
            this.cboTipo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Tarea 1",
            "Tarea 2",
            "Tarea 3",
            "Tarea 4",
            "Tarea 5"});
            this.cboTipo.Location = new System.Drawing.Point(94, 97);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(183, 25);
            this.cboTipo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Registra tu Actividad";
            // 
            // Lista
            // 
            this.Lista.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(272, 252);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(210, 160);
            this.Lista.TabIndex = 12;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // cmdCargarVector
            // 
            this.cmdCargarVector.Location = new System.Drawing.Point(383, 63);
            this.cmdCargarVector.Name = "cmdCargarVector";
            this.cmdCargarVector.Size = new System.Drawing.Size(118, 35);
            this.cmdCargarVector.TabIndex = 13;
            this.cmdCargarVector.Text = "Cargar Vector";
            this.cmdCargarVector.UseVisualStyleBackColor = true;
            this.cmdCargarVector.Click += new System.EventHandler(this.cmdCargarVector_Click);
            // 
            // cmdVerVector
            // 
            this.cmdVerVector.Location = new System.Drawing.Point(383, 104);
            this.cmdVerVector.Name = "cmdVerVector";
            this.cmdVerVector.Size = new System.Drawing.Size(118, 35);
            this.cmdVerVector.TabIndex = 14;
            this.cmdVerVector.Text = "Ver Vector";
            this.cmdVerVector.UseVisualStyleBackColor = true;
            this.cmdVerVector.Click += new System.EventHandler(this.cmdVerVector_Click);
            // 
            // cmdVerVector2
            // 
            this.cmdVerVector2.Location = new System.Drawing.Point(383, 145);
            this.cmdVerVector2.Name = "cmdVerVector2";
            this.cmdVerVector2.Size = new System.Drawing.Size(118, 35);
            this.cmdVerVector2.TabIndex = 15;
            this.cmdVerVector2.Text = "Ver vector Array";
            this.cmdVerVector2.UseVisualStyleBackColor = true;
            this.cmdVerVector2.Click += new System.EventHandler(this.cmdVerVector2_Click);
            // 
            // cmdVector3
            // 
            this.cmdVector3.Location = new System.Drawing.Point(383, 186);
            this.cmdVector3.Name = "cmdVector3";
            this.cmdVector3.Size = new System.Drawing.Size(118, 35);
            this.cmdVector3.TabIndex = 16;
            this.cmdVector3.Text = "Ver Vector for";
            this.cmdVector3.UseVisualStyleBackColor = true;
            this.cmdVector3.Click += new System.EventHandler(this.cmdVector3_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 436);
            this.Controls.Add(this.cmdVector3);
            this.Controls.Add(this.cmdVerVector2);
            this.Controls.Add(this.cmdVerVector);
            this.Controls.Add(this.cmdCargarVector);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtDetalleActidad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mrcTareas);
            this.Controls.Add(this.mrcReunion);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrate";
            this.Load += new System.EventHandler(this.Registrar_Load);
            this.mrcReunion.ResumeLayout(false);
            this.mrcReunion.PerformLayout();
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.GroupBox mrcReunion;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDetalleActidad;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button cmdCargarVector;
        private System.Windows.Forms.Button cmdVerVector;
        private System.Windows.Forms.Button cmdVerVector2;
        private System.Windows.Forms.Button cmdVector3;
    }
}