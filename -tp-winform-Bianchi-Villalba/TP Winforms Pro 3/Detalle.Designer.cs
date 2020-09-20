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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.pbDetalle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(404, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(348, 12);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(189, 20);
            this.tbBuscar.TabIndex = 1;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(12, 67);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(866, 60);
            this.dgvDetalle.TabIndex = 3;
            // 
            // pbDetalle
            // 
            this.pbDetalle.BackgroundImage = global::TP_Winforms_Pro_3.Properties.Resources.fondo_negro_en_nuevayork;
            this.pbDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDetalle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbDetalle.Location = new System.Drawing.Point(325, 133);
            this.pbDetalle.Name = "pbDetalle";
            this.pbDetalle.Size = new System.Drawing.Size(245, 212);
            this.pbDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDetalle.TabIndex = 10;
            this.pbDetalle.TabStop = false;
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(890, 357);
            this.Controls.Add(this.pbDetalle);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Detalle";
            this.Text = "Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.PictureBox pbDetalle;
    }
}