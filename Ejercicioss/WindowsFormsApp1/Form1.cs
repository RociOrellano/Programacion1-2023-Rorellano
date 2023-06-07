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
        private List<Animal> animalitos = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circulo micirculo = new Circulo();
            //necesito el valor de radio que puso el usuarioc
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
            comboBox1.Items.Add("Perro");
            comboBox1.Items.Add("Gato");
            comboBox1.Items.Add("Vaca");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string laOpcion = comboBox1.SelectedItem.ToString();

            if (laOpcion == "Perro")
            {
                Perro miPerro = new Perro();
                animalitos.Add(new Perro());
            }
            else
            {
                if (laOpcion == "Gato")
                {

                    Gato migato = new Gato();
                    animalitos.Add(new Gato());
                }
                else
                {
                    Vaca mivaca = new Vaca();
                    animalitos.Add(new Vaca());
                }
    }

    
            }

        private void label5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Perro")
            {
                label5.Text = 
            }
        }
    }


    }
 

