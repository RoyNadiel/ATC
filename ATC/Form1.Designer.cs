
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
            this.topBar = new System.Windows.Forms.Panel();
            this.menuBar = new System.Windows.Forms.Panel();
            this.contanerImg = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.btn_minimzar = new System.Windows.Forms.PictureBox();
            this.topBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimzar)).BeginInit();
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
            this.btnToldos.Location = new System.Drawing.Point(22, 65);
            this.btnToldos.Name = "btnToldos";
            this.btnToldos.Size = new System.Drawing.Size(78, 33);
            this.btnToldos.TabIndex = 0;
            this.btnToldos.Text = "Toldos";
            this.btnToldos.UseVisualStyleBackColor = true;
            this.btnToldos.Click += new System.EventHandler(this.btnToldos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(22, 104);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(78, 33);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnResetearVentas
            // 
            this.btnResetearVentas.Location = new System.Drawing.Point(22, 334);
            this.btnResetearVentas.Name = "btnResetearVentas";
            this.btnResetearVentas.Size = new System.Drawing.Size(78, 36);
            this.btnResetearVentas.TabIndex = 2;
            this.btnResetearVentas.Text = "Resetear \r\nVentas";
            this.btnResetearVentas.UseVisualStyleBackColor = true;
            this.btnResetearVentas.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topBar.Controls.Add(this.btn_minimzar);
            this.topBar.Controls.Add(this.btn_maximizar);
            this.topBar.Controls.Add(this.btn_exit);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(846, 34);
            this.topBar.TabIndex = 2;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            this.topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseMove);
            this.topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseUp);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBar.Controls.Add(this.btnResetearVentas);
            this.menuBar.Controls.Add(this.contanerImg);
            this.menuBar.Controls.Add(this.btnVentas);
            this.menuBar.Controls.Add(this.btnToldos);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuBar.Location = new System.Drawing.Point(0, 34);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(118, 382);
            this.menuBar.TabIndex = 3;
            // 
            // contanerImg
            // 
            this.contanerImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.contanerImg.Location = new System.Drawing.Point(0, 0);
            this.contanerImg.Name = "contanerImg";
            this.contanerImg.Size = new System.Drawing.Size(118, 59);
            this.contanerImg.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.Image = global::ATC.Properties.Resources.cerrar;
            this.btn_exit.Location = new System.Drawing.Point(819, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(27, 34);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 0;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_maximizar.Image = global::ATC.Properties.Resources.Maximizar;
            this.btn_maximizar.Location = new System.Drawing.Point(792, 0);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(27, 34);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 1;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // btn_minimzar
            // 
            this.btn_minimzar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimzar.Image = global::ATC.Properties.Resources.minimazar;
            this.btn_minimzar.Location = new System.Drawing.Point(765, 0);
            this.btn_minimzar.Name = "btn_minimzar";
            this.btn_minimzar.Size = new System.Drawing.Size(27, 34);
            this.btn_minimzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimzar.TabIndex = 2;
            this.btn_minimzar.TabStop = false;
            this.btn_minimzar.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(846, 416);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.panelContenedor);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topBar.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimzar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnToldos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnResetearVentas;
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Panel contanerImg;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_minimzar;
        private System.Windows.Forms.PictureBox btn_maximizar;
    }
}

