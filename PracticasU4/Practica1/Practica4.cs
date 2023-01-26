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
    public partial class f4 : Form
    {
        public f4()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.LightPink;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtPrueba_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("El TextBox tiene " + txtPrueba.Text.Length + " caracteres.");
        }
    }
}
