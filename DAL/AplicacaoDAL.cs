using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telzir_Tel.DTO;
using Telzir_Tel.BLL;
using Telzir.UtilsDAL;
using Telzir_App;

namespace Telzir_Tel.DAL
{
    class AplicacaoDAL
    {
        // Criar um objeto do tipo lista
        public List<AplicacaoDTO> consulta = new List<AplicacaoDTO>();


       public List<AplicacaoDTO> GetdadosAplicacao (AplicacaoDTO aplicacaoDTO)
        {
            
            try // tenta executar

            {
                MySqlConnection conn = UtilsDAL.GetConnection();

                // Teste de Conexão

                if (conn.State == ConnectionState.Open)
                {
                    var sql = "SELECT * " +
                        " FROM Planos WHERE Origem='" + aplicacaoDTO.origem + "' AND Destino='" + aplicacaoDTO.destino + "'";
                    var retorno = new MySqlCommand(sql, conn);
                    // Envia o CommandText para o Connection e cria um SqlDataReader.
                    var reader = retorno.ExecuteReader();
                    if (reader.Read())
                    {
                        // fecha a conexão com o banaco de dados
                        conn.Close();
                    }
                }
            }
            catch (System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            return consulta;

        }

    }

}

        
        
 