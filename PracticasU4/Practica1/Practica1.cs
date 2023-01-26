using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class f1 : Form
    {
        public f1()
        {
            InitializeComponent();
        }

        private void f1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Estas listo para el duelo Maxi botón?");
        }

        private void f1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Perdiste Maxi botón");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos f = new Datos();
            f.ShowDialog();
        }
    }
}
