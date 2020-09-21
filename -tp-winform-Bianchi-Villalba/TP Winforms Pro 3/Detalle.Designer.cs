namespace TP_Winforms_Pro_3
{
    partial class Detalle
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
            this.pbDetalle = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblImaUrl = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbCat = new System.Windows.Forms.TextBox();
            this.tbImagenURL = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDetalle
            // 
            this.pbDetalle.BackgroundImage = global::TP_Winforms_Pro_3.Properties.Resources.fondo_negro_en_nuevayork;
            this.pbDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDetalle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbDetalle.Location = new System.Drawing.Point(12, 235);
            this.pbDetalle.Name = "pbDetalle";
            this.pbDetalle.Size = new System.Drawing.Size(270, 208);
            this.pbDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDetalle.TabIndex = 10;
            this.pbDetalle.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCod.Location = new System.Drawing.Point(12, 35);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 12;
            this.lblCod.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(12, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDesc.Location = new System.Drawing.Point(12, 98);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(66, 13);
            this.lblDesc.TabIndex = 14;
            this.lblDesc.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarca.Location = new System.Drawing.Point(12, 122);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCat.Location = new System.Drawing.Point(12, 154);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(57, 13);
            this.lblCat.TabIndex = 16;
            this.lblCat.Text = "Categoría:";
            // 
            // lblImaUrl
            // 
            this.lblImaUrl.AutoSize = true;
            this.lblImaUrl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImaUrl.Location = new System.Drawing.Point(12, 180);
            this.lblImaUrl.Name = "lblImaUrl";
            this.lblImaUrl.Size = new System.Drawing.Size(67, 13);
            this.lblImaUrl.TabIndex = 17;
            this.lblImaUrl.Text = "ImagenURL:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecio.Location = new System.Drawing.Point(12, 212);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "Precio:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(105, 6);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(175, 20);
            this.tbID.TabIndex = 19;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(105, 64);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(175, 20);
            this.tbNombre.TabIndex = 20;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(105, 93);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ReadOnly = true;
            this.tbDesc.Size = new System.Drawing.Size(175, 20);
            this.tbDesc.TabIndex = 21;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(105, 122);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.ReadOnly = true;
            this.tbMarca.Size = new System.Drawing.Size(175, 20);
            this.tbMarca.TabIndex = 22;
            // 
            // tbCat
            // 
            this.tbCat.Location = new System.Drawing.Point(105, 151);
            this.tbCat.Name = "tbCat";
            this.tbCat.ReadOnly = true;
            this.tbCat.Size = new System.Drawing.Size(175, 20);
            this.tbCat.TabIndex = 23;
            // 
            // tbImagenURL
            // 
            this.tbImagenURL.Location = new System.Drawing.Point(105, 180);
            this.tbImagenURL.Name = "tbImagenURL";
            this.tbImagenURL.ReadOnly = true;
            this.tbImagenURL.Size = new System.Drawing.Size(175, 20);
            this.tbImagenURL.TabIndex = 24;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(105, 35);
            this.tbCod.Name = "tbCod";
            this.tbCod.ReadOnly = true;
            this.tbCod.Size = new System.Drawing.Size(175, 20);
            this.tbCod.TabIndex = 25;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(105, 209);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.ReadOnly = true;
            this.tbPrecio.Size = new System.Drawing.Size(175, 20);
            this.tbPrecio.TabIndex = 26;
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(293, 451);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbImagenURL);
            this.Controls.Add(this.tbCat);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImaUrl);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pbDetalle);
            this.Name = "Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle Articulo";
            this.Load += new System.EventHandler(this.Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbDetalle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblImaUrl;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbCat;
        private System.Windows.Forms.TextBox tbImagenURL;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbPrecio;
    }
}