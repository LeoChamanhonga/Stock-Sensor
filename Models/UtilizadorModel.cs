using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Stock_Sensor.Models
{
    public class UtilizadorModel
    {
        public static bool ValidarUtilizador(string login, string senha)
        {
            var ret = false;
            using (var conexao = new SqlConnection())
            {
                //criar a coneccao *String de conexao*
                conexao.ConnectionString = @"Data Source=DSKMPTT\CI_2014;Initial Catalog=stock;User Id=admin;Password=123";
                conexao.Open();
                //Abrir a conexao
                using (var comando = new SqlCommand())
                {
                    //Associar a conexa
                    comando.Connection = conexao;
                    //Definir o comando *Qery*
                    comando.CommandText = string.Format(
                        "select count(*) from utilizador where login='{0}' and senha='{1}'", login, senha);
                    ret = (int)comando.ExecuteScalar() > 0;
                }
            }
            return ret;
        }
    }
}