using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; //Biblioteca da conexão SQL
using MySql.Data.MySqlClient; //Biblioteca da conexão SQL
namespace cadastrarCelular
{
    class conexao
    {//Criação da variaveis 
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public string senha;

        public conexao()
        {
            inicializar();
        }
        public void inicializar()
        {
            servidor = "127.0.0.1";
            database = "cadastrocelular";
            usuario = "root";
            senha = "";
            string conexaostring;
            conexaostring = "SERVER=" + servidor + ";" + "DATABASE=" +
                database + ";" + "UID=" + usuario + ";" + "PASSWORD=" + senha + ";";
            conectar = new MySqlConnection(conexaostring);
        }
        public bool abrirconexao()
        {
            try  //Tratamento de erro
            {
                conectar.Open(); //O que deseja executar
                return true;
            }
            catch (MySqlException ex)  //Messagem de erro caso nada funcione
            {
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não conectou");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Senha Invalida");
                        break;
                }
                return false;
            }
        }
        public bool fecharconexao()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}