using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{    

    // Funcion para el seno
    


    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            //Numero 0
            tbDisplay.Text = tbDisplay.Text  + "0";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            //Numero 1
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            //Numero 2
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            //Numero 3
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            //Numero 4
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            //Numero 5
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            //Numero 6
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            //Numero 7
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            //Numero 8
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            //Numero 9
            tbDisplay.Text = tbDisplay.Text + "9";
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminar un Dato
            tbDisplay.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //Boton de Punto
            tbDisplay.Text = tbDisplay.Text + ".";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Boton Suma
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //Boton Resta
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton Division
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //Boton Igual
            valor2 = Convert.ToDouble(tbDisplay.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
            }

            tbDisplay.Text = resultado.ToString();
        }

    }
}
