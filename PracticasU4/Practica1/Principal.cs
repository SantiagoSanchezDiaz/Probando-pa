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
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string texto1 = "Apellido y Nombre: " + tbApellido.Text.ToUpper() + ", " + tbNombre.Text.ToUpper();
            string texto2 = "Edad: " + tbEdad.Text;
            string texto3 = "Direccion: " + tbDireccion.Text.ToUpper();
            lw1.Items.Clear();
            lw1.Items.Add(texto1);
            lw1.Items.Add("");
            lw1.Items.Add(texto2);
            lw1.Items.Add("");
            lw1.Items.Add(texto3);
        }

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chau pa");
            this.Close();
        }
    }
}
