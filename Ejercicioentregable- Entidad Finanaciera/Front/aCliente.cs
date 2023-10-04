using Back;
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
    public partial class aCliente : Form
    {
        Principal principal = new Principal();
        public aCliente()
        {
            InitializeComponent();
        }

        private void butgregar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.nombre = txtnombre.Text;
            nuevoCliente.apellido = txtapell.Text;
            nuevoCliente.dni = int.Parse(txtdni.Text);

            principal.AgregarCliente(nuevoCliente);
        }
    }
}
