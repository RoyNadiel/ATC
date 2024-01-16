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
        private Principal FM1;
        public Toldos()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Toldo1 TD1 = new Toldo1();           
            TD1.ShowDialog();
            //FM1.AbrirForm(new Toldo1());
        }

    }
}