using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastrarCelular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        informacoes info = new informacoes();
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try //o que esta dentro do try é o que deseja ser executado
            {
                info.setProcessador(txt_processador.Text);
                info.setPreco(txt_preco.Text);
                info.setImei(txt_imei.Text);
                info.setArmazenamento(txt_armazenamento.Text);
                info.inserir();
            }
            finally //apos a execução do que deseja ser executado, mostrar uma frase afirmativa
            {
                MessageBox.Show("Cadastro do celular realizado com sucesso");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = info.Consultar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
