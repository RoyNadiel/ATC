
namespace ATC
{
    partial class Principal
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnToldos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnResetearVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelContenedor.Location = new System.Drawing.Point(124, 62);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(697, 299);
            this.panelContenedor.TabIndex = 0;
            // 
            // btnToldos
            // 
            this.btnToldos.Location = new System.Drawing.Point(12, 62);
            this.btnToldos.Name = "btnToldos";
            this.btnToldos.Size = new System.Drawing.Size(78, 33);
            this.btnToldos.TabIndex = 0;
            this.btnToldos.Text = "Toldos";
            this.btnToldos.UseVisualStyleBackColor = true;
            this.btnToldos.Click += new System.EventHandler(this.btnToldos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(12, 101);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(78, 33);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnResetearVentas
            // 
            this.btnResetearVentas.Location = new System.Drawing.Point(12, 368);
            this.btnResetearVentas.Name = "btnResetearVentas";
            this.btnResetearVentas.Size = new System.Drawing.Size(78, 36);
            this.btnResetearVentas.TabIndex = 2;
            this.btnResetearVentas.Text = "Resetear \r\nVentas";
            this.btnResetearVentas.UseVisualStyleBackColor = true;
            this.btnResetearVentas.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(846, 416);
            this.Controls.Add(this.btnResetearVentas);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnToldos);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Principal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnToldos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnResetearVentas;
    }
}

