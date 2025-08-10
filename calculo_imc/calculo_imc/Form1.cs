using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            double peso, altura, imc;
            peso = double.Parse(txt_peso.Text);
            altura = double.Parse(txt_altura.Text);
            imc = peso / (altura*altura);
            txt_resultado.Text = imc.ToString();

            if (imc < 16)
            {
                txt_categoria.Text = "Baixo Peso Grau III!";
            }
            else if (imc >= 16 && imc <= 16.99)
            {
                txt_categoria.Text = "Baixo Peso Grau II!";
            }

            else if (imc >= 17 && imc <= 18.49)
            {
                txt_categoria.Text = "Baixo Peso Grau I!";
            }

            else if (imc >= 18.5 && imc <= 24.99)
            {
                txt_categoria.Text = "Peso saudável!";
            }

            else if (imc >= 25 && imc <= 29.99)
            {
                txt_categoria.Text = "Sobrepeso!";
            }

            else if (imc >= 30 && imc <= 34.99)
            {
                txt_categoria.Text = "Obesidade Grau I!";
            }

            else if (imc >= 35 && imc <= 39.99)
            {
                txt_categoria.Text = "Obesidade Grau II!";
            }
            else if (imc >= 40)
            {
                txt_categoria.Text = "Obesidade Grau III!";
            }
            else
            {
                MessageBox.Show("Digite valores válidos!");
            }

        }
    }
}
