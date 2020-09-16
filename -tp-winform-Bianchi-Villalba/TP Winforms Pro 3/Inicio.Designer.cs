namespace TP_Winforms_Pro_3
{
    partial class Inicio
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
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.Descripcion = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.Label();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Location = new System.Drawing.Point(326, 9);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.Size = new System.Drawing.Size(483, 340);
            this.dgvArticulo.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(12, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 49);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            this.btnAgregar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAgregar_MouseMove);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Location = new System.Drawing.Point(212, 85);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 49);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickModificar);
            this.btnModificar.MouseLeave += new System.EventHandler(this.btnModificar_MouseLeave);
            this.btnModificar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnModificar_MouseMove);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(12, 85);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 49);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseMove);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusqueda.Location = new System.Drawing.Point(112, 85);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(94, 49);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "Busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.MouseLeave += new System.EventHandler(this.btnBusqueda_MouseLeave);
            this.btnBusqueda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBusqueda_MouseMove);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Location = new System.Drawing.Point(212, 30);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(94, 49);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            this.btnListar.MouseLeave += new System.EventHandler(this.btnListar_MouseLeave);
            this.btnListar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnListar_MouseMove);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalle.Location = new System.Drawing.Point(112, 30);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(94, 49);
            this.btnDetalle.TabIndex = 6;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.MouseLeave += new System.EventHandler(this.btnDetalle_MouseLeave);
            this.btnDetalle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDetalle_MouseMove);
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(122, 9);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(84, 13);
            this.Descripcion.TabIndex = 7;
            this.Descripcion.Text = "Elija una Opción";
            // 
            // textEstado
            // 
            this.textEstado.AutoSize = true;
            this.textEstado.Location = new System.Drawing.Point(61, 349);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(70, 13);
            this.textEstado.TabIndex = 8;
            this.textEstado.Text = "estadoServer";
            // 
            // pbArticulo
            // 
            this.pbArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbArticulo.Location = new System.Drawing.Point(12, 140);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(294, 209);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 9;
            this.pbArticulo.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(-3, 349);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 13);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "EstadoBD:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 361);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulo);
            this.MinimumSize = new System.Drawing.Size(660, 400);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label textEstado;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.DataGridView dgvArticulo;
    }
}

