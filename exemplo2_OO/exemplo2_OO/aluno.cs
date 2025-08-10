using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo2_OO
{
    class aluno
    {
        /*uma classe é composta de três partes: nome, atributo e método
        Criar atributo */

        private string nome;
        private string sobrenome;
        private string professor;
        private int idade;


        //private e a visibilidade do atributo; 

        /*encapsulamento -> para cada atributo criado é necessário criar 
        dois métodos set e get, sendo assim o atributo fica na classe e 
        os métodos ficam no restante do projeto.
        
        Os métodos tem dois tipos, com retorno e sem retorno
        
        Criação do método sem retorno*/

        public void setNome(string nome)
        {
            this.nome = nome;
            //this serve para diferenciar o que é atributo do que é um parametro de forma automática!!!
        }

        /*todos os métodos sem retorno possuem a palavra void.
        O nome do método deverá ser set + o nome do atributo com a letra em maiúsculo (setNome)
        Método set serve para receber valores digitados pelo usuário.
        Os valores digitados pelo usuário é armazenado no parametro (string nome) e repassado ao atributo*/

        //Método com retorno

        public string getNome()
        {
            return this.nome;
        }
        /* método com retorno o tipo do método dever ser o mesmo tipo do atributo que está ligado ao mesmo.
        O nome do método deve ser get + o nome do atributo com a primeira letra em maiúsculo (getNome)
        Método get serve  pra mostrar valores ao usuário armazenado dentro do método set.*/

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public string getSobrenome()
        {
            return this.sobrenome;
        }



        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setProfessor(string professor)
        {
            this.professor = professor;
        }

        public string getProfessor()
        {
            return this.professor;
        }
    }
}
