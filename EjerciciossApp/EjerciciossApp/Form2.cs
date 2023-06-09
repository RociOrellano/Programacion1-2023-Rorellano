﻿using ClasessApp;
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
    public partial class Form2 : Form
    {
        private List<Carrito> miCarrito = new List<Carrito>();
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        /*    string elElegido = comboBox1.SelectedItem.ToString();

            if (elElegido == "Seguro")
            { 
                label2.Text = "numPoliza:";
            }else
            {if (elElegido == "Producto") 
                {
                    label2.Text = "Marca:";
                }else { label2.Text = "Nombre: ";};

            } // MessageBox.Show("Me seleccionaste: " + elElegido);*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           /* comboBox1.Items.Add("Producto");
            comboBox1.Items.Add("Servicio");
            comboBox1.Items.Add("Seguro");*/
           List<MarcaCelular> LaListaParaElCombo = MarcaCelular.dameMarca();
            comboBox1.Items.AddRange(LaListaParaElCombo.ToArray());
            comboBox1.DisplayMember = "nameMarca";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vamos a probar si el combo funciona bien

            string elElegido = comboBox1.SelectedItem.ToString();

            if (elElegido == "Seguro")
            {
                Seguro mSeg  = new Seguro();
                mSeg.numeroPoliza = int.Parse(textBox1.Text);
                mSeg.Premio = double.Parse(textBox1.Text);
                miCarrito.Add(mSeg);
            }
            else
            {
                if (elElegido == "Producto")
                {
                    Producto miProd = new Producto();
                    miProd.Marca_producto = textBox1.Text;
                    miProd.Precio_producto = double.Parse(textBox1.Text);
                    miCarrito.Add(miProd);
                }
                else { Servicio miServicio = new Servicio();
                    miServicio.Nombre_servicio = textBox1.Text;
                    miServicio.Importe = double.Parse(textBox1.Text);

                };

            }
    }

        private void Pagar_Click(object sender, EventArgs e)
        {
            double costoAPagar = 0;

            foreach (Carrito miProd in miCarrito)
            {
                costoAPagar = costoAPagar + miProd.dameCosto();
            }
            MessageBox.Show("Debe pagar " + costoAPagar + ". Gracias ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Celular miCel = new Celular();
            List<MarcaCelular> laLista = MarcaCelular.dameMarca();

            miCel.precio = int.Parse(textBox1.Text);
            miCel.numero = textBox2.Text;
            miCel.marca = (MarcaCelular)comboBox1.SelectedItem;

            MessageBox.Show("se acaba de generar un celu de marca: " + miCel.marca.nameMarca);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ingrese");

            comboBox1.Items.AddRange(MarcaCelular.dameMarca().ToArray());
            //para probarlo voy a meter una marca
            MarcaCelular unaMas = new MarcaCelular();
            unaMas.nameMarca = "LG";

            MarcaCelular.dameMarca().Add(unaMas);

            MessageBox.Show("chau");
        }
    }
    }
