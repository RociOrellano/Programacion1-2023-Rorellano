using ClasessApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciossApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void hacemeElalta()
        {
            MarcaCelular laNueva = new MarcaCelular();
            laNueva.idMarca = int.Parse(txtid.Text);
            laNueva.paisOrigen = txtpais.Text;
            laNueva.modelo = txtmodelo.Text;
            laNueva.nameMarca = txtnombre.Text;

            MarcaCelular.dameMarca().Add(laNueva);
        }
        private void button1_Click(object sender, EventArgs e)
        {
           hacemeElalta();
           this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hacemeElalta();
            MessageBox.Show("Listo, quedo agredado ");
            //vamos a limpiar para el que sigue

            txtid.Text = "";
            txtpais.Text = "";
            txtmodelo.Text = "";
            txtnombre.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALTO")
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
