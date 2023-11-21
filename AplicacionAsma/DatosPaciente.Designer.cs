namespace AplicacionAsma
{
    partial class DatosPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosPaciente));
            this.DatosContacto = new System.Windows.Forms.TabControl();
            this.tbcDatosPrincipales = new System.Windows.Forms.TabPage();
            this.tbcDatosContacto = new System.Windows.Forms.TabPage();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.lblNIdentificacion = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNIdentificacion = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbTidentificacion = new System.Windows.Forms.ComboBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.rdbSoltero = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbUnionLibre = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.DatosContacto.SuspendLayout();
            this.tbcDatosPrincipales.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatosContacto
            // 
            this.DatosContacto.Controls.Add(this.tbcDatosPrincipales);
            this.DatosContacto.Controls.Add(this.tbcDatosContacto);
            this.DatosContacto.Location = new System.Drawing.Point(12, 28);
            this.DatosContacto.Name = "DatosContacto";
            this.DatosContacto.SelectedIndex = 0;
            this.DatosContacto.Size = new System.Drawing.Size(776, 362);
            this.DatosContacto.TabIndex = 0;
            // 
            // tbcDatosPrincipales
            // 
            this.tbcDatosPrincipales.Controls.Add(this.rdbUnionLibre);
            this.tbcDatosPrincipales.Controls.Add(this.rdbCasado);
            this.tbcDatosPrincipales.Controls.Add(this.rdbSoltero);
            this.tbcDatosPrincipales.Controls.Add(this.rdbNoBinario);
            this.tbcDatosPrincipales.Controls.Add(this.rdbFemenino);
            this.tbcDatosPrincipales.Controls.Add(this.rdbMasculino);
            this.tbcDatosPrincipales.Controls.Add(this.cbTidentificacion);
            this.tbcDatosPrincipales.Controls.Add(this.dtpNacimiento);
            this.tbcDatosPrincipales.Controls.Add(this.txtNIdentificacion);
            this.tbcDatosPrincipales.Controls.Add(this.txtApellidos);
            this.tbcDatosPrincipales.Controls.Add(this.txtNombres);
            this.tbcDatosPrincipales.Controls.Add(this.lblEstado);
            this.tbcDatosPrincipales.Controls.Add(this.lblGenero);
            this.tbcDatosPrincipales.Controls.Add(this.lblNacimiento);
            this.tbcDatosPrincipales.Controls.Add(this.lblNIdentificacion);
            this.tbcDatosPrincipales.Controls.Add(this.lblTipoIdentificacion);
            this.tbcDatosPrincipales.Controls.Add(this.lblApellidos);
            this.tbcDatosPrincipales.Controls.Add(this.lblNombres);
            this.tbcDatosPrincipales.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcDatosPrincipales.Location = new System.Drawing.Point(4, 22);
            this.tbcDatosPrincipales.Name = "tbcDatosPrincipales";
            this.tbcDatosPrincipales.Padding = new System.Windows.Forms.Padding(3);
            this.tbcDatosPrincipales.Size = new System.Drawing.Size(768, 336);
            this.tbcDatosPrincipales.TabIndex = 0;
            this.tbcDatosPrincipales.Text = "Datos Principales";
            this.tbcDatosPrincipales.UseVisualStyleBackColor = true;
            // 
            // tbcDatosContacto
            // 
            this.tbcDatosContacto.Location = new System.Drawing.Point(4, 22);
            this.tbcDatosContacto.Name = "tbcDatosContacto";
            this.tbcDatosContacto.Padding = new System.Windows.Forms.Padding(3);
            this.tbcDatosContacto.Size = new System.Drawing.Size(768, 304);
            this.tbcDatosContacto.TabIndex = 1;
            this.tbcDatosContacto.Text = "Datos de Contacto";
            this.tbcDatosContacto.UseVisualStyleBackColor = true;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(46, 26);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(70, 16);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(46, 59);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(72, 16);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(46, 103);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(162, 16);
            this.lblTipoIdentificacion.TabIndex = 4;
            this.lblTipoIdentificacion.Text = "Tipo de Identificación";
            // 
            // lblNIdentificacion
            // 
            this.lblNIdentificacion.AutoSize = true;
            this.lblNIdentificacion.Location = new System.Drawing.Point(46, 146);
            this.lblNIdentificacion.Name = "lblNIdentificacion";
            this.lblNIdentificacion.Size = new System.Drawing.Size(187, 16);
            this.lblNIdentificacion.TabIndex = 6;
            this.lblNIdentificacion.Text = "Número de Identificación";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(46, 186);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(156, 16);
            this.lblNacimiento.TabIndex = 8;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(46, 231);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(59, 16);
            this.lblGenero.TabIndex = 10;
            this.lblGenero.Text = "Género";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(46, 272);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(92, 16);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado Civil";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(255, 20);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(374, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(255, 59);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(374, 22);
            this.txtApellidos.TabIndex = 3;
            // 
            // txtNIdentificacion
            // 
            this.txtNIdentificacion.Location = new System.Drawing.Point(255, 143);
            this.txtNIdentificacion.Name = "txtNIdentificacion";
            this.txtNIdentificacion.Size = new System.Drawing.Size(374, 22);
            this.txtNIdentificacion.TabIndex = 7;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(255, 186);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(374, 22);
            this.dtpNacimiento.TabIndex = 9;
            // 
            // cbTidentificacion
            // 
            this.cbTidentificacion.FormattingEnabled = true;
            this.cbTidentificacion.Location = new System.Drawing.Point(255, 100);
            this.cbTidentificacion.Name = "cbTidentificacion";
            this.cbTidentificacion.Size = new System.Drawing.Size(374, 24);
            this.cbTidentificacion.TabIndex = 5;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(255, 229);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(95, 20);
            this.rdbMasculino.TabIndex = 11;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(392, 229);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(94, 20);
            this.rdbFemenino.TabIndex = 12;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbNoBinario
            // 
            this.rdbNoBinario.AutoSize = true;
            this.rdbNoBinario.Location = new System.Drawing.Point(530, 227);
            this.rdbNoBinario.Name = "rdbNoBinario";
            this.rdbNoBinario.Size = new System.Drawing.Size(99, 20);
            this.rdbNoBinario.TabIndex = 13;
            this.rdbNoBinario.TabStop = true;
            this.rdbNoBinario.Text = "No Binario";
            this.rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbSoltero
            // 
            this.rdbSoltero.AutoSize = true;
            this.rdbSoltero.Location = new System.Drawing.Point(255, 268);
            this.rdbSoltero.Name = "rdbSoltero";
            this.rdbSoltero.Size = new System.Drawing.Size(77, 20);
            this.rdbSoltero.TabIndex = 15;
            this.rdbSoltero.TabStop = true;
            this.rdbSoltero.Text = "Soltero";
            this.rdbSoltero.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(392, 270);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(79, 20);
            this.rdbCasado.TabIndex = 16;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbUnionLibre
            // 
            this.rdbUnionLibre.AutoSize = true;
            this.rdbUnionLibre.Location = new System.Drawing.Point(530, 270);
            this.rdbUnionLibre.Name = "rdbUnionLibre";
            this.rdbUnionLibre.Size = new System.Drawing.Size(107, 20);
            this.rdbUnionLibre.TabIndex = 17;
            this.rdbUnionLibre.TabStop = true;
            this.rdbUnionLibre.Text = "Unión Libre";
            this.rdbUnionLibre.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(0, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(800, 49);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIngresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIngresar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(0, 445);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(800, 47);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // DatosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.DatosContacto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatosPaciente";
            this.Text = "DatosPaciente";
            this.DatosContacto.ResumeLayout(false);
            this.tbcDatosPrincipales.ResumeLayout(false);
            this.tbcDatosPrincipales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DatosContacto;
        private System.Windows.Forms.TabPage tbcDatosPrincipales;
        private System.Windows.Forms.TabPage tbcDatosContacto;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblNIdentificacion;
        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNIdentificacion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.RadioButton rdbUnionLibre;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbSoltero;
        private System.Windows.Forms.RadioButton rdbNoBinario;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.ComboBox cbTidentificacion;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresar;
    }
}