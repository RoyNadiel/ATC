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
    public partial class Form1 : Form
    {
        private Form forms;
        
        public Form1()
        {
            InitializeComponent();
            Properties.Settings.Default.Save();
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
            //Toldos TD = new Toldos();
            AbrirForm(new Toldos());
        }       

        private void btnToldos_Click(object sender, EventArgs e)
        {
            //Toldos TD = new Toldos();
            AbrirForm(new Toldos());
            //TD.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //Ventas VT = new Ventas();
            AbrirForm(new Ventas());
            //VT.ShowDialog();
        }    
        
    }
}
