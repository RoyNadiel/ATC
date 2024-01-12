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

            //cbxServicio.Checked = Properties.Settings.Default.CheckBoxEstado;
        }

        private void Toldo1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Properties.Settings.Default.CheckBoxEstado = cbxServicio.Checked;
            //Properties.Settings.Default.Save();
        }
    }
}
