using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContato
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        //Construtor.
        public Conexao()
        {
            con.ConnectionString = @"Data Source=TIAGOGALHOTO\SQLEXPRESS;
                                   Initial Catalog=AgendaContato;Integrated Security=True;Encrypt=False";
        }
        //método Conectar.
        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Método Desconectar.
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
