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
    public partial class f2 : Form
    {
        public f2()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparo el evento Click", "Atención");
            btnPrueba.BackColor = Color.AliceBlue; // Si quiero cambiar el boton solo
            this.BackColor = Color.AliceBlue; // Si quiero cambiar el fondo del form
        }

        private void f2_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("IZQUIERDO PA");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("LA LECHERA PA");
            else
                MessageBox.Show("POR EL MEDIO PAI");
        }
    }
}
