using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        empregado em = new empregado();
        private void btn_enviar_Click(object sender, EventArgs e)
        {
    
            try
            {
                em.setCpf(txt_cpf.Text);
                em.setNome(txt_nome.Text);
                em.setSobrenome(txt_sobrenome.Text);
                em.inserir();
                dataGridView1.DataSource = em.Consultar();
            }
            catch
            {
                MessageBox.Show("Erro na conexão com o Banco de Dados");
            }
            finally
            {
                MessageBox.Show("Informações enviadas com sucesso");
            }

        }





        public void exibirregistro ( int i  )
        {
            txt_cpf.Text = "" + dataGridView1[3, i].Value;
            txt_nome.Text = "" + dataGridView1[1, i].Value;
            txt_codigo.Text = "" + dataGridView1[0, i].Value;
            txt_sobrenome.Text = "" + dataGridView1[2, i].Value;
        }




        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = em.Consultar();
            //Personalizar as colunas do DataGrid View

            dataGridView1.Columns["nome_empregado"].HeaderText = "Nome";
            dataGridView1.Columns["codigo_empregado"].HeaderText = "Código";
            dataGridView1.Columns["sobrenome_empregado"].HeaderText = "SobreNome";
            dataGridView1.Columns["cpf_empregado"].HeaderText = "CPF";

        }

        private void txt_sobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibirregistro(dataGridView1.CurrentRow.Index);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_cpf.Text = "";
            txt_nome.Text = "";
            txt_sobrenome.Text = "";
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try {
                em.setCodigo(txt_codigo.Text);
                em.excluir();
                dataGridView1.DataSource = em.Consultar();
            }

            finally
            {
                MessageBox.Show("Informações excluidas com sucesso");
            }
        }
    }
}
