using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2 {
    public class Cadastro {

        Conexao Conexao = new Conexao();
        SqlCommand Cmd = new SqlCommand();
        public string Mensagem = "";

        public Cadastro(string Nome, string Valor) {

            Cmd.CommandText = "insert into produto (nome, valor) values (@Nome, @Valor)";
            Cmd.Parameters.AddWithValue("@Nome", Nome);
            Cmd.Parameters.AddWithValue("@Valor", Valor);

            try {
                Cmd.Connection = Conexao.Conectar();
                Cmd.ExecuteNonQuery();
                Conexao.Desconectar();
                this.Mensagem = "Cadastrado com sucesso";
            }
            catch (SqlException) {
                this.Mensagem = "Erro ao tentar se conectar ao Banco";
                Console.WriteLine(this.Mensagem);
            }
        }
    }
}
