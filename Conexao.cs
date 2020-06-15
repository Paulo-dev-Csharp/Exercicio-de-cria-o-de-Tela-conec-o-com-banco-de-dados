using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2 {
    public class Conexao {

        SqlConnection con = new SqlConnection();
        public Conexao() {
            con.ConnectionString = @"Data Source=.;Initial Catalog=DB_merdadosegundo;Integrated Security=True;Pooling=False;Password=486255;";
        }
        public SqlConnection Conectar() {
            if (con.State == System.Data.ConnectionState.Closed) {
                con.Open();
            }
            return con;
        }
        public void Desconectar() {
            if (con.State == System.Data.ConnectionState.Open) {
                con.Close();
            }
        }
    }
}
