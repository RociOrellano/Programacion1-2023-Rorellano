using Clasess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circulo micirculo = new Circulo();
            //necesito el valor de radio que puso el usuario
            //pero como es un textbox que tiene string, tengo que cambiarlo a double
            micirculo.radio = double.Parse(textBox2.Text);
            //ahora si, con mi radio de tipo double puedo mandarlo a la propiedad del objeto
            micirculo.Nombre = textBox1.Text;
            label3.Text = micirculo.DecimeQuienSos();
            //MessageBox.Show(micirculo.DecimeQuienSos());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
