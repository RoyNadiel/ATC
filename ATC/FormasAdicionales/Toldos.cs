using ATC.FormasAdicionales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC
{
    public partial class Toldos : Form
    {
        private Form forms;
        private object panelContenedor;

        public Toldos()
        {
            InitializeComponent();
        }

        //public void AbrirForm(Form formurlario)
        //{
        //    if (forms != null && !forms.IsDisposed)
        //    {
        //        forms.Close();
        //    }
        //    forms = formurlario;
        //    forms.TopLevel = false;
        //    forms.FormBorderStyle = FormBorderStyle.None;
        //    forms.Dock = DockStyle.None;
        //    panelContenedor.Controls.Add(forms);
        //    forms.Show();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Toldo1 TD = new Toldo1();
        //    AbrirForm(TD);
        //}
    }
}
