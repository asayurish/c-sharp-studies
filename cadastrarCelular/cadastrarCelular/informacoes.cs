using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; //Biblioteca da conexão SQL
using MySql.Data.MySqlClient; //Biblioteca da conexão SQL
using System.Data;
namespace cadastrarCelular
{
    class informacoes : conexao
    {
        private string processador;
        private string preco;
        private string imei;
        private string armazenamento;


        //realizar o encapsulamento

        public void setProcessador(string processador)
        {
            this.processador = processador;
        }

        public string getProcessador()
        {
            return this.processador;
        }

        public void setPreco(string preco)
        {
            this.preco = preco;
        }

        public string getPreco()
        {
            return this.preco;
        }

        public void setImei(string imei)
        {
            this.imei = imei;
        }

        public string getImei()
        {
            return this.imei;
        }

        public void setArmazenamento(string armazenamento)
        {
            this.armazenamento = armazenamento;
        }

        public string getArmazenamento()
        {
            return this.armazenamento;
        }
        //criar metodo inserir()
        public void inserir()
        {
            string query = "insert into informacoes(processador_cel,preco_cel,imei_cel,armazenamento_cel) VALUES('" + getProcessador() + "','" + getPreco() + "','" + getImei() + "','" + getArmazenamento() + "')";


            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "Select * from informacoes";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharconexao();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
