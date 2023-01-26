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
    public partial class f3 : Form
    {
        public f3()
        {
            InitializeComponent();
        }

        private void lb1_MouseMove(object sender, MouseEventArgs e)
        {
            lb1.BackColor = Color.DimGray;
            lb1.Cursor = Cursors.Hand;
        }

        private void lb1_MouseLeave(object sender, EventArgs e)
        {
            lb1.BackColor = System.Drawing.SystemColors.Control;
            lb1.Cursor = Cursors.Arrow;
        }
    }
}
