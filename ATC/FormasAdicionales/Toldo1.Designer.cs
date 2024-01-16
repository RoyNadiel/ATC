
namespace ATC.FormasAdicionales
{
    partial class Toldo1
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
            this.lblCocteles = new System.Windows.Forms.Label();
            this.lblSnack = new System.Windows.Forms.Label();
            this.cbxSnack = new System.Windows.Forms.CheckBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.cbxServicio = new System.Windows.Forms.CheckBox();
            this.cbCocteles = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.btn_minimzar = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimzar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCocteles
            // 
            this.lblCocteles.AutoSize = true;
            this.lblCocteles.Location = new System.Drawing.Point(17, 109);
            this.lblCocteles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCocteles.Name = "lblCocteles";
            this.lblCocteles.Size = new System.Drawing.Size(74, 19);
            this.lblCocteles.TabIndex = 0;
            this.lblCocteles.Text = "Cocteles: ";
            // 
            // lblSnack
            // 
            this.lblSnack.AutoSize = true;
            this.lblSnack.Location = new System.Drawing.Point(32, 70);
            this.lblSnack.Name = "lblSnack";
            this.lblSnack.Size = new System.Drawing.Size(57, 19);
            this.lblSnack.TabIndex = 2;
            this.lblSnack.Text = "Snack: ";
            // 
            // cbxSnack
            // 
            this.cbxSnack.AutoSize = true;
            this.cbxSnack.Location = new System.Drawing.Point(95, 73);
            this.cbxSnack.Name = "cbxSnack";
            this.cbxSnack.Size = new System.Drawing.Size(15, 14);
            this.cbxSnack.TabIndex = 3;
            this.cbxSnack.UseVisualStyleBackColor = true;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(20, 37);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(71, 19);
            this.lblServicio.TabIndex = 4;
            this.lblServicio.Text = "Servicio: ";
            // 
            // cbxServicio
            // 
            this.cbxServicio.AutoSize = true;
            this.cbxServicio.Location = new System.Drawing.Point(95, 42);
            this.cbxServicio.Name = "cbxServicio";
            this.cbxServicio.Size = new System.Drawing.Size(15, 14);
            this.cbxServicio.TabIndex = 5;
            this.cbxServicio.UseVisualStyleBackColor = true;
            // 
            // cbCocteles
            // 
            this.cbCocteles.FormattingEnabled = true;
            this.cbCocteles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbCocteles.Location = new System.Drawing.Point(98, 101);
            this.cbCocteles.Name = "cbCocteles";
            this.cbCocteles.Size = new System.Drawing.Size(36, 27);
            this.cbCocteles.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(172, 148);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(80, 148);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topPanel.Controls.Add(this.btn_minimzar);
            this.topPanel.Controls.Add(this.btn_exit);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(259, 34);
            this.topPanel.TabIndex = 9;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.Image = global::ATC.Properties.Resources.cerrar;
            this.btn_exit.Location = new System.Drawing.Point(232, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(27, 34);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_minimzar
            // 
            this.btn_minimzar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimzar.Image = global::ATC.Properties.Resources.minimazar;
            this.btn_minimzar.Location = new System.Drawing.Point(205, 0);
            this.btn_minimzar.Name = "btn_minimzar";
            this.btn_minimzar.Size = new System.Drawing.Size(27, 34);
            this.btn_minimzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimzar.TabIndex = 3;
            this.btn_minimzar.TabStop = false;
            this.btn_minimzar.Click += new System.EventHandler(this.btn_minimzar_Click);
            // 
            // Toldo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 183);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbCocteles);
            this.Controls.Add(this.cbxServicio);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.cbxSnack);
            this.Controls.Add(this.lblSnack);
            this.Controls.Add(this.lblCocteles);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Toldo1";
            this.Text = "Toldo1";
            this.Load += new System.EventHandler(this.Toldo1_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimzar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCocteles;
        private System.Windows.Forms.Label lblSnack;
        private System.Windows.Forms.CheckBox cbxSnack;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.CheckBox cbxServicio;
        private System.Windows.Forms.ComboBox cbCocteles;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_minimzar;
    }
}