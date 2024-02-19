namespace Biblioteca_Unimar
{
    partial class interfazMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interfazMenu));
            this.formMenu = new System.Windows.Forms.Button();
            this.verPrestamo = new System.Windows.Forms.Button();
            this.sancionados = new System.Windows.Forms.Button();
            this.renovacion = new System.Windows.Forms.Button();
            this.librosDisp = new System.Windows.Forms.Button();
            this.devolucion = new System.Windows.Forms.Button();
            this.ingresarLibro = new System.Windows.Forms.Button();
            this.solicitud = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formMenu
            // 
            this.formMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.formMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(127)))), ((int)(((byte)(155)))));
            this.formMenu.FlatAppearance.BorderSize = 0;
            this.formMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formMenu.ForeColor = System.Drawing.Color.White;
            this.formMenu.Location = new System.Drawing.Point(180, 179);
            this.formMenu.Name = "formMenu";
            this.formMenu.Size = new System.Drawing.Size(164, 29);
            this.formMenu.TabIndex = 2;
            this.formMenu.Text = "Registrar alumno";
            this.formMenu.UseVisualStyleBackColor = false;
            this.formMenu.Click += new System.EventHandler(this.registro_Click);
            // 
            // verPrestamo
            // 
            this.verPrestamo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.verPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(127)))), ((int)(((byte)(155)))));
            this.verPrestamo.FlatAppearance.BorderSize = 0;
            this.verPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.verPrestamo.ForeColor = System.Drawing.Color.White;
            this.verPrestamo.Location = new System.Drawing.Point(180, 249);
            this.verPrestamo.Name = "verPrestamo";
            this.verPrestamo.Size = new System.Drawing.Size(164, 29);
            this.verPrestamo.TabIndex = 2;
            this.verPrestamo.Text = "Ver préstamos activos";
            this.verPrestamo.UseVisualStyleBackColor = false;
            this.verPrestamo.Click += new System.EventHandler(this.verPrestamo_Click);
            // 
            // sancionados
            // 
            this.sancionados.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sancionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(127)))), ((int)(((byte)(155)))));
            this.sancionados.FlatAppearance.BorderSize = 0;
            this.sancionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sancionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.sancionados.ForeColor = System.Drawing.Color.White;
            this.sancionados.Location = new System.Drawing.Point(350, 179);
            this.sancionados.Name = "sancionados";
            this.sancionados.Size = new System.Drawing.Size(167, 29);
            this.sancionados.TabIndex = 2;
            this.sancionados.Text = "Alumnos sancionados";
            this.sancionados.UseVisualStyleBackColor = false;
            this.sancionados.Click += new System.EventHandler(this.sancionados_Click);
            // 
            // renovacion
            // 
            this.renovacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.renovacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(127)))), ((int)(((byte)(155)))));
            this.renovacion.FlatAppearance.BorderSize = 0;
            this.renovacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renovacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.renovacion.ForeColor = System.Drawing.Color.White;
            this.renovacion.Location = new System.Drawing.Point(350, 214);
            this.renovacion.Name = "renovacion";
            this.renovacion.Size = new System.Drawing.Size(167, 29);
            this.renovacion.TabIndex = 2;
            this.renovacion.Text = "Renovar libro";
            this.renovacion.UseVisualStyleBackColor = false;
            this.renovacion.Click += new System.EventHandler(this.renovacion_Click);
            // 
            // librosDisp
            // 
            this.librosDisp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.librosDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(127)))), ((int)(((byte)(155)))));
            this.librosDisp.FlatAppearance.BorderSize = 0;
            this.librosDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.librosDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.librosDisp.ForeColor = System.Drawing.Color.White;
            this.librosDisp.Location = new System.Drawing.Point(180, 284);
            this.librosDisp.Name = "librosDisp";
            this.librosDisp.Size = new System.Drawing.Size(164, 29);
            this.librosDisp.TabIndex = 2;
            this.librosDisp.Text = "Libros disponibles";
            this.librosDisp.UseVisualStyleBackColor = false;
            this.librosDisp.Click += new System.EventHandler(this.librosDisp_Click);
            // 
            // devolucion
            // 
            this.devolucion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.devolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(127)))), ((int)(((byte)(155)))));
            this.devolucion.FlatAppearance.BorderSize = 0;
            this.devolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.devolucion.ForeColor = System.Drawing.Color.White;
            this.devolucion.Location = new System.Drawing.Point(350, 249);
            this.devolucion.Name = "devolucion";
            this.devolucion.Size = new System.Drawing.Size(167, 29);
            this.devolucion.TabIndex = 2;
            this.devolucion.Text = "Devolución";
            this.devolucion.UseVisualStyleBackColor = false;
            this.devolucion.Click += new System.EventHandler(this.devolucion_Click);
            // 
            // ingresarLibro
            // 
            this.ingresarLibro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ingresarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(127)))), ((int)(((byte)(155)))));
            this.ingresarLibro.FlatAppearance.BorderSize = 0;
            this.ingresarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ingresarLibro.ForeColor = System.Drawing.Color.White;
            this.ingresarLibro.Location = new System.Drawing.Point(350, 284);
            this.ingresarLibro.Name = "ingresarLibro";
            this.ingresarLibro.Size = new System.Drawing.Size(167, 29);
            this.ingresarLibro.TabIndex = 2;
            this.ingresarLibro.Text = "Ingresar nuevo libro";
            this.ingresarLibro.UseVisualStyleBackColor = false;
            this.ingresarLibro.Click += new System.EventHandler(this.ingresarLibro_Click);
            // 
            // solicitud
            // 
            this.solicitud.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.solicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(127)))), ((int)(((byte)(155)))));
            this.solicitud.FlatAppearance.BorderSize = 0;
            this.solicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.solicitud.ForeColor = System.Drawing.Color.White;
            this.solicitud.Location = new System.Drawing.Point(180, 214);
            this.solicitud.Name = "solicitud";
            this.solicitud.Size = new System.Drawing.Size(164, 29);
            this.solicitud.TabIndex = 2;
            this.solicitud.Text = "Solicitar préstamo";
            this.solicitud.UseVisualStyleBackColor = false;
            this.solicitud.Click += new System.EventHandler(this.solicitud_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(127)))), ((int)(((byte)(155)))));
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Location = new System.Drawing.Point(268, 319);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(155, 29);
            this.btncerrar.TabIndex = 2;
            this.btncerrar.Text = "Cerrar sistema";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // interfazMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Biblioteca_Unimar.Properties.Resources.inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 461);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.ingresarLibro);
            this.Controls.Add(this.devolucion);
            this.Controls.Add(this.renovacion);
            this.Controls.Add(this.solicitud);
            this.Controls.Add(this.librosDisp);
            this.Controls.Add(this.sancionados);
            this.Controls.Add(this.verPrestamo);
            this.Controls.Add(this.formMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "interfazMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Unimar";
            this.Load += new System.EventHandler(this.InterfazMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button formMenu;
        private System.Windows.Forms.Button verPrestamo;
        private System.Windows.Forms.Button sancionados;
        private System.Windows.Forms.Button renovacion;
        private System.Windows.Forms.Button librosDisp;
        private System.Windows.Forms.Button devolucion;
        private System.Windows.Forms.Button ingresarLibro;
        private System.Windows.Forms.Button solicitud;
        private System.Windows.Forms.Button btncerrar;
    }
}

