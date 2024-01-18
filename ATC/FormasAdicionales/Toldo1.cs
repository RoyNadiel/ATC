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
    }
}