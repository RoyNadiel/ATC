using ATC.FormasAdicionales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC
{
    public partial class Principal : Form
    {
        private Form forms;

        public EventHandler Toldo1_Load { get; }

        public Principal()
        {
            InitializeComponent();
        }
        //Se crean 3 valores tipo entero, para mover la ventana
        int m, mx, my;

        //Esta función es cuando se hace click en la barra y se activa con m1
        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        //En esta es mientras se presiona y se mueve el mouse
        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
        }

        //Y con esta para cuando se deja de hacer click en la barra
        private void topBar_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        public void AbrirForm(Form formurlario)
        {
            if (forms != null && !forms.IsDisposed)
            {
                forms.Close();
            }
            forms = formurlario;
            forms.TopLevel = false;
            forms.FormBorderStyle = FormBorderStyle.None;
            forms.Dock = DockStyle.None;
            panelContenedor.Controls.Add(forms);
            forms.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirForm(new Toldos());
        }

        private void btnToldos_Click(object sender, EventArgs e)
        {
            //Toldos TD = new Toldos();
            AbrirForm(new Toldos());
            //TD.ShowDialog();
        }

        //Btn_exit
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //Ventas VT = new Ventas();
            AbrirForm(new Ventas());
            //VT.ShowDialog();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            string rutaDirectory = @"C:\Users\Roy Nadiel\Documents\TOLDOS\";

            if (Directory.Exists(rutaDirectory))
            {
                Directory.Delete(rutaDirectory, true);
                MessageBox.Show("Reset Correcto");
            }
        }

    }
}
