using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo2_OO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        aluno a = new aluno();

        private void btn_set_Click(object sender, EventArgs e)
        {
            a.setNome(txt_nome.Text);

            a.setSobrenome(txt_sobrenome.Text);

            a.setProfessor(txt_professor.Text);

            a.setIdade(int.Parse(txt_idade.Text));



            //qnd o atributo for inteiro ou double, é necessário converter -> int.Parse(txt_nome.Text);
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            lbl_mostrar.Text = a.getNome();
            lbl_mostrarsobrenome.Text = a.getSobrenome();
            lbl_mostraridade.Text = a.getIdade().ToString();
            lbl_mostrarprofessor.Text = a.getProfessor();


            //quando o atributo for inteiro ou double, é necessário converter de inteiro para string -> a.getNome().ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_sobrenome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
