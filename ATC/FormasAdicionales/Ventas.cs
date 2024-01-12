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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rutaArchivo = @"C:\Users\Roy Nadiel\Documents\" + lblToldo.Text.ToString() + txtbToldo.Text.ToString() + ".txt";

            if (File.Exists(rutaArchivo))
            {
                rutaArchivo = @"C:\Users\Roy Nadiel\Documents\" + lblToldo.Text.ToString() + txtbToldo.Text.ToString() + ".txt";
            }

            using (StreamWriter sw = new StreamWriter(@rutaArchivo))
            {                
                sw.WriteLine(txtbProducto.Text);
            }
        }
    }
}
