using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranscDeposito form = new TranscDeposito();
            form.Show();
            this.Hide();
        }

        private void transferirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void extraccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranscaExtraccion form = new TranscaExtraccion();
            form.Show();
            this.Hide();
        }

        private void pagarTarjetaCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoTarjeta form = new PagoTarjeta();
            form.Show();
            this.Hide();
        }
    }
}
