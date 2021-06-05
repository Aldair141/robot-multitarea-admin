
namespace AdminBuhito
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupTipoProceso = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupPropiedades = new System.Windows.Forms.GroupBox();
            this.chkTodosLosDias = new System.Windows.Forms.CheckBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.lblhora = new System.Windows.Forms.Label();
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.groupGenerales = new System.Windows.Forms.GroupBox();
            this.lblNomProceso = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.rbtDiasSemana = new System.Windows.Forms.RadioButton();
            this.rbtFechaEspecifico = new System.Windows.Forms.RadioButton();
            this.rbtNDias = new System.Windows.Forms.RadioButton();
            this.rbtNMinutos = new System.Windows.Forms.RadioButton();
            this.tsOpciones = new System.Windows.Forms.ToolStrip();
            this.sbNuevo = new System.Windows.Forms.ToolStripButton();
            this.sbEditar = new System.Windows.Forms.ToolStripButton();
            this.sbEliminar = new System.Windows.Forms.ToolStripButton();
            this.sbCancelar = new System.Windows.Forms.ToolStripButton();
            this.sbGuardar = new System.Windows.Forms.ToolStripButton();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.groupTipoProceso.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupPropiedades.SuspendLayout();
            this.groupGenerales.SuspendLayout();
            this.tsOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTipoProceso
            // 
            this.groupTipoProceso.Controls.Add(this.rbtNMinutos);
            this.groupTipoProceso.Controls.Add(this.rbtNDias);
            this.groupTipoProceso.Controls.Add(this.rbtFechaEspecifico);
            this.groupTipoProceso.Controls.Add(this.rbtDiasSemana);
            this.groupTipoProceso.Location = new System.Drawing.Point(12, 28);
            this.groupTipoProceso.Name = "groupTipoProceso";
            this.groupTipoProceso.Size = new System.Drawing.Size(175, 158);
            this.groupTipoProceso.TabIndex = 0;
            this.groupTipoProceso.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 344);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(765, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupPropiedades
            // 
            this.groupPropiedades.Controls.Add(this.txtMinutos);
            this.groupPropiedades.Controls.Add(this.lblMinutos);
            this.groupPropiedades.Controls.Add(this.lblDias);
            this.groupPropiedades.Controls.Add(this.txtDias);
            this.groupPropiedades.Controls.Add(this.dtpFecha);
            this.groupPropiedades.Controls.Add(this.lblfecha);
            this.groupPropiedades.Controls.Add(this.chkTodosLosDias);
            this.groupPropiedades.Controls.Add(this.dtpHora);
            this.groupPropiedades.Controls.Add(this.lblhora);
            this.groupPropiedades.Controls.Add(this.chkDomingo);
            this.groupPropiedades.Controls.Add(this.chkSabado);
            this.groupPropiedades.Controls.Add(this.chkViernes);
            this.groupPropiedades.Controls.Add(this.chkJueves);
            this.groupPropiedades.Controls.Add(this.chkMiercoles);
            this.groupPropiedades.Controls.Add(this.chkMartes);
            this.groupPropiedades.Controls.Add(this.chkLunes);
            this.groupPropiedades.Location = new System.Drawing.Point(193, 95);
            this.groupPropiedades.Name = "groupPropiedades";
            this.groupPropiedades.Size = new System.Drawing.Size(590, 91);
            this.groupPropiedades.TabIndex = 4;
            this.groupPropiedades.TabStop = false;
            // 
            // chkTodosLosDias
            // 
            this.chkTodosLosDias.AutoSize = true;
            this.chkTodosLosDias.Location = new System.Drawing.Point(259, 59);
            this.chkTodosLosDias.Name = "chkTodosLosDias";
            this.chkTodosLosDias.Size = new System.Drawing.Size(96, 17);
            this.chkTodosLosDias.TabIndex = 9;
            this.chkTodosLosDias.Tag = "DIAS_SEMANA";
            this.chkTodosLosDias.Text = "Todos los días";
            this.chkTodosLosDias.UseVisualStyleBackColor = true;
            this.chkTodosLosDias.CheckedChanged += new System.EventHandler(this.chkTodosLosDias_CheckedChanged);
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(116, 57);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(116, 20);
            this.dtpHora.TabIndex = 8;
            this.dtpHora.Tag = "DIAS_SEMANA|FECHA_ESPECIFICA|NUM_DIAS";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(77, 60);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(33, 13);
            this.lblhora.TabIndex = 7;
            this.lblhora.Tag = "DIAS_SEMANA|FECHA_ESPECIFICA|NUM_DIAS";
            this.lblhora.Text = "Hora:";
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.Location = new System.Drawing.Point(481, 24);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(68, 17);
            this.chkDomingo.TabIndex = 6;
            this.chkDomingo.Tag = "DIAS_SEMANA";
            this.chkDomingo.Text = "Domingo";
            this.chkDomingo.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(412, 24);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(63, 17);
            this.chkSabado.TabIndex = 5;
            this.chkSabado.Tag = "DIAS_SEMANA";
            this.chkSabado.Text = "Sábado";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Location = new System.Drawing.Point(345, 24);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(61, 17);
            this.chkViernes.TabIndex = 4;
            this.chkViernes.Tag = "DIAS_SEMANA";
            this.chkViernes.Text = "Viernes";
            this.chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Location = new System.Drawing.Point(279, 24);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(60, 17);
            this.chkJueves.TabIndex = 3;
            this.chkJueves.Tag = "DIAS_SEMANA";
            this.chkJueves.Text = "Jueves";
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.Location = new System.Drawing.Point(202, 24);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(71, 17);
            this.chkMiercoles.TabIndex = 2;
            this.chkMiercoles.Tag = "DIAS_SEMANA";
            this.chkMiercoles.Text = "Miércoles";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Location = new System.Drawing.Point(141, 24);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(58, 17);
            this.chkMartes.TabIndex = 1;
            this.chkMartes.Tag = "DIAS_SEMANA";
            this.chkMartes.Text = "Martes";
            this.chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Location = new System.Drawing.Point(80, 24);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(55, 17);
            this.chkLunes.TabIndex = 0;
            this.chkLunes.Tag = "DIAS_SEMANA";
            this.chkLunes.Text = "Lunes";
            this.chkLunes.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(116, 21);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(116, 20);
            this.dtpFecha.TabIndex = 11;
            this.dtpFecha.Tag = "FECHA_ESPECIFICA";
            this.dtpFecha.Visible = false;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(77, 24);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(40, 13);
            this.lblfecha.TabIndex = 10;
            this.lblfecha.Tag = "FECHA_ESPECIFICA";
            this.lblfecha.Text = "Fecha:";
            this.lblfecha.Visible = false;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(116, 21);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(116, 20);
            this.txtDias.TabIndex = 12;
            this.txtDias.Tag = "NUM_DIAS";
            this.txtDias.Visible = false;
            this.txtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(19, 24);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(93, 13);
            this.lblDias.TabIndex = 13;
            this.lblDias.Tag = "NUM_DIAS";
            this.lblDias.Text = "Cantidad de Días:";
            this.lblDias.Visible = false;
            // 
            // groupGenerales
            // 
            this.groupGenerales.Controls.Add(this.txtDescripcion);
            this.groupGenerales.Controls.Add(this.lblDescripcion);
            this.groupGenerales.Controls.Add(this.txtNombre);
            this.groupGenerales.Controls.Add(this.lblNomProceso);
            this.groupGenerales.Location = new System.Drawing.Point(193, 28);
            this.groupGenerales.Name = "groupGenerales";
            this.groupGenerales.Size = new System.Drawing.Size(590, 70);
            this.groupGenerales.TabIndex = 5;
            this.groupGenerales.TabStop = false;
            // 
            // lblNomProceso
            // 
            this.lblNomProceso.AutoSize = true;
            this.lblNomProceso.Location = new System.Drawing.Point(20, 16);
            this.lblNomProceso.Name = "lblNomProceso";
            this.lblNomProceso.Size = new System.Drawing.Size(89, 13);
            this.lblNomProceso.TabIndex = 16;
            this.lblNomProceso.Tag = "";
            this.lblNomProceso.Text = "Nombre Proceso:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(115, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(43, 42);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Tag = "";
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(116, 39);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(453, 20);
            this.txtDescripcion.TabIndex = 19;
            // 
            // rbtDiasSemana
            // 
            this.rbtDiasSemana.AutoSize = true;
            this.rbtDiasSemana.Location = new System.Drawing.Point(28, 36);
            this.rbtDiasSemana.Name = "rbtDiasSemana";
            this.rbtDiasSemana.Size = new System.Drawing.Size(105, 17);
            this.rbtDiasSemana.TabIndex = 0;
            this.rbtDiasSemana.TabStop = true;
            this.rbtDiasSemana.Text = "Días de Semana";
            this.rbtDiasSemana.UseVisualStyleBackColor = true;
            this.rbtDiasSemana.CheckedChanged += new System.EventHandler(this.rbtDiasSemana_CheckedChanged);
            // 
            // rbtFechaEspecifico
            // 
            this.rbtFechaEspecifico.AutoSize = true;
            this.rbtFechaEspecifico.Location = new System.Drawing.Point(28, 59);
            this.rbtFechaEspecifico.Name = "rbtFechaEspecifico";
            this.rbtFechaEspecifico.Size = new System.Drawing.Size(124, 17);
            this.rbtFechaEspecifico.TabIndex = 1;
            this.rbtFechaEspecifico.TabStop = true;
            this.rbtFechaEspecifico.Text = "Fecha en Específico";
            this.rbtFechaEspecifico.UseVisualStyleBackColor = true;
            this.rbtFechaEspecifico.CheckedChanged += new System.EventHandler(this.rbtFechaEspecifico_CheckedChanged);
            // 
            // rbtNDias
            // 
            this.rbtNDias.AutoSize = true;
            this.rbtNDias.Location = new System.Drawing.Point(28, 82);
            this.rbtNDias.Name = "rbtNDias";
            this.rbtNDias.Size = new System.Drawing.Size(93, 17);
            this.rbtNDias.TabIndex = 2;
            this.rbtNDias.TabStop = true;
            this.rbtNDias.Text = "Cada \"n\" días";
            this.rbtNDias.UseVisualStyleBackColor = true;
            this.rbtNDias.CheckedChanged += new System.EventHandler(this.rbtNDias_CheckedChanged);
            // 
            // rbtNMinutos
            // 
            this.rbtNMinutos.AutoSize = true;
            this.rbtNMinutos.Location = new System.Drawing.Point(28, 105);
            this.rbtNMinutos.Name = "rbtNMinutos";
            this.rbtNMinutos.Size = new System.Drawing.Size(108, 17);
            this.rbtNMinutos.TabIndex = 3;
            this.rbtNMinutos.TabStop = true;
            this.rbtNMinutos.Text = "Cada \"n\" minutos";
            this.rbtNMinutos.UseVisualStyleBackColor = true;
            this.rbtNMinutos.CheckedChanged += new System.EventHandler(this.rbtNMinutos_CheckedChanged);
            // 
            // tsOpciones
            // 
            this.tsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbNuevo,
            this.sbEditar,
            this.sbEliminar,
            this.sbGuardar,
            this.sbCancelar});
            this.tsOpciones.Location = new System.Drawing.Point(0, 0);
            this.tsOpciones.Name = "tsOpciones";
            this.tsOpciones.Size = new System.Drawing.Size(795, 25);
            this.tsOpciones.TabIndex = 6;
            this.tsOpciones.Text = "toolStrip1";
            // 
            // sbNuevo
            // 
            this.sbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("sbNuevo.Image")));
            this.sbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbNuevo.Name = "sbNuevo";
            this.sbNuevo.Size = new System.Drawing.Size(23, 22);
            this.sbNuevo.Text = "Nuevo";
            this.sbNuevo.Click += new System.EventHandler(this.sbNuevo_Click);
            // 
            // sbEditar
            // 
            this.sbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbEditar.Enabled = false;
            this.sbEditar.Image = ((System.Drawing.Image)(resources.GetObject("sbEditar.Image")));
            this.sbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbEditar.Name = "sbEditar";
            this.sbEditar.Size = new System.Drawing.Size(23, 22);
            this.sbEditar.Text = "Editar";
            // 
            // sbEliminar
            // 
            this.sbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbEliminar.Enabled = false;
            this.sbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("sbEliminar.Image")));
            this.sbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbEliminar.Name = "sbEliminar";
            this.sbEliminar.Size = new System.Drawing.Size(23, 22);
            this.sbEliminar.Text = "Eliminar";
            // 
            // sbCancelar
            // 
            this.sbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbCancelar.Enabled = false;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(23, 22);
            this.sbCancelar.Text = "Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // sbGuardar
            // 
            this.sbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbGuardar.Enabled = false;
            this.sbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("sbGuardar.Image")));
            this.sbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbGuardar.Name = "sbGuardar";
            this.sbGuardar.Size = new System.Drawing.Size(23, 22);
            this.sbGuardar.Text = "Guardar";
            this.sbGuardar.Click += new System.EventHandler(this.sbGuardar_Click);
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(19, 25);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(92, 13);
            this.lblMinutos.TabIndex = 14;
            this.lblMinutos.Tag = "NUM_MINUTOS";
            this.lblMinutos.Text = "Cantidad Minutos:";
            this.lblMinutos.Visible = false;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(116, 22);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(116, 20);
            this.txtMinutos.TabIndex = 15;
            this.txtMinutos.Tag = "NUM_MINUTOS";
            this.txtMinutos.Visible = false;
            this.txtMinutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 540);
            this.Controls.Add(this.tsOpciones);
            this.Controls.Add(this.groupGenerales);
            this.Controls.Add(this.groupPropiedades);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupTipoProceso);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Procesos";
            this.groupTipoProceso.ResumeLayout(false);
            this.groupTipoProceso.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupPropiedades.ResumeLayout(false);
            this.groupPropiedades.PerformLayout();
            this.groupGenerales.ResumeLayout(false);
            this.groupGenerales.PerformLayout();
            this.tsOpciones.ResumeLayout(false);
            this.tsOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTipoProceso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupPropiedades;
        private System.Windows.Forms.CheckBox chkTodosLosDias;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkLunes;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.GroupBox groupGenerales;
        private System.Windows.Forms.Label lblNomProceso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rbtNMinutos;
        private System.Windows.Forms.RadioButton rbtNDias;
        private System.Windows.Forms.RadioButton rbtFechaEspecifico;
        private System.Windows.Forms.RadioButton rbtDiasSemana;
        private System.Windows.Forms.ToolStrip tsOpciones;
        private System.Windows.Forms.ToolStripButton sbNuevo;
        private System.Windows.Forms.ToolStripButton sbEditar;
        private System.Windows.Forms.ToolStripButton sbEliminar;
        private System.Windows.Forms.ToolStripButton sbCancelar;
        private System.Windows.Forms.ToolStripButton sbGuardar;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Label lblMinutos;
    }
}

