using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//Biblioteca de conexão do SQL 
using MySql.Data.MySqlClient; //Biblioteca de conexão do SQL 
using System.Data;//Biblioteca para a visualização de dados

namespace exemplo_CRUD
{
    class empregado:conexao
    {
        private string nome;
        private string sobrenome;
        private string cpf;
        private string codigo;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public string getCodigo()
        {
            return this.codigo;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public string getSobrenome()
        {
            return this.sobrenome;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return this.cpf;
        }

        public void inserir()
        {
            string query = "insert into empregado(nome_empregado,sobrenome_empregado,cpf_empregado)VALUES('" + getNome() + "','"+getSobrenome()+"','"+getCpf()+"')";
            if(this.abrirconexao()==true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable Consultar()
        {
            this.abrirconexao();

            string mSQL = "select* from empregado";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void excluir()
        {
            string query = "delete from empregado where codigo_empregado = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
