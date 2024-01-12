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
        private Form1 FM1;
        public Toldos()
        {
            InitializeComponent();
        }
        public Toldos(Form1 form1)
        {
            FM1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toldo1 TD1 = new Toldo1();           
            TD1.ShowDialog();
            //FM1.AbrirForm(new Toldo1());
        }
    }
}