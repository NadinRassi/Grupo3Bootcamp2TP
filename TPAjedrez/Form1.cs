using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaAjedrez.Entidades;
using BibliotecaAjedrez.Entidades.BASE;

namespace TPAjedrez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarPeon_Click(object sender, EventArgs e)
        {
            Peon peon = new Peon();

            MessageBox.Show(peon.Mover());
        }

        private void btnCrearCaballo_Click(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo();

            MessageBox.Show(caballo.Mover());
        }

        private void btnCrearTorre_Click(object sender, EventArgs e)
        {
            Torre torre = new Torre();

            MessageBox.Show(torre.Mover());
        }
    }
}
