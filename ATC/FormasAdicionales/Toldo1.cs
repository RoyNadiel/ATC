using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC.FormasAdicionales
{
    public partial class Toldo1 : Form
    {
        public Toldo1()
        {
            InitializeComponent(); 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckBoxState = cbxServicio.Checked;
            Properties.Settings.Default.Save();
            Close();
        }

        private void Toldo1_Load(object sender, EventArgs e)
        {
            cbxServicio.Checked = Properties.Settings.Default.CheckBoxState;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_minimzar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int m, mx, my;
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}