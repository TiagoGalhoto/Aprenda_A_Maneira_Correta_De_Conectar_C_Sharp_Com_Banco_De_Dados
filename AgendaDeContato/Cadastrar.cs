using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContato
{
    public class Cadastrar
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String Mensagem = "";
        public Cadastrar(String nome, String telefone)
        {
            //Comando Sql --SqlCommand.
            cmd.CommandText = "insert into Contato (nome, telefone) values (@nome,@telefone)";
            //Parametro.
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            try
            {
                //Conectar com banco -- Conexão.
                cmd.Connection = conexao.Conectar();
                //Executar comando.
                cmd.ExecuteNonQuery();
                //Desconectar.
                conexao.Desconectar();
                //Mostrar mensagem de erro ou sucesso -- Variável.
                this.Mensagem = "Cadastrado Com Sucesso !...";
            }
            catch (SqlException e)
            {
                this.Mensagem = "Erro ao se conectar com o banco de Dedos";
            }
        }
    }
}
