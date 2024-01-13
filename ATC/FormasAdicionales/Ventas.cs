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
            string rutaDirectory = @"C:\Users\Roy Nadiel\Documents\TOLDOS\";

            Directory.CreateDirectory(rutaDirectory);

            string rutaArchivo = rutaDirectory + "Toldo #" + txtbToldo.Text.ToString() + ".txt";

            if (int.Parse(txtbToldo.Text) <= 0)
            {
                MessageBox.Show("Ingrese el numero de Toldo");
            }
            else
            {
                if (File.Exists(rutaArchivo))
                {
                    rutaArchivo = rutaDirectory + "Toldo #" + txtbToldo.Text.ToString() + ".txt";
                }
            }         

            using (StreamWriter sw = new StreamWriter(@rutaArchivo, true))
            {
                sw.WriteLine("→ " + txtbProducto.Text);
                txtbProducto.Text = "";
                txtbToldo.Text = "";
            }
        }
    }
}
