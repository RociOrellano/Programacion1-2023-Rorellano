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
    public partial class PruebaProyect : Form
    {
        public PruebaProyect() 
        {
           InitializeComponent();
        }
       
           List<Carrito> listmiCarrito = new List<Carrito>();
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Producto miProducto = new Producto();
            miProducto.Marca_producto = txtMarca.Text;
            miProducto.Precio_producto = double.Parse(txtPrecio.Text);

            listmiCarrito.Add(miProducto);

            MessageBox.Show("se ha agregado ese producto");
        //vamos a limpiar los textos para pedir el que sigue

             txtMarca.Text = "";
             txtPrecio.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double costoAPagar = 0;

            foreach (Carrito miProd in listmiCarrito)
            {
                costoAPagar = costoAPagar + miProd.dameCosto();
            }
            MessageBox.Show("Debe pagar " + costoAPagar + ". Gracias ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Servicio mSer = new Servicio();
            mSer.Nombre_servicio = txtNombre.Text;
            mSer.Importe = int.Parse(txtimporte.Text);

            listmiCarrito.Add(mSer);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Seguro miSeg = new Seguro();
            miSeg.numeroPoliza = int.Parse(txtnroPoliza.Text);
            miSeg.Premio = double.Parse(txtPremio.Text);

            listmiCarrito.Add(miSeg);
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
