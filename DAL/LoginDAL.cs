using Telzir.DTO;
using Telzir_crud.BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using Telzir.UtilsDAL;



namespace Telzir.DAL
{
    class LoginDal
    {

        public bool GetDadosLogin(LoginDTO loginDTO)
        {
            try // tenta executar 
            {
                // conecta com o banco
                MySqlConnection conn = Telzir.UtilsDAL.UtilsDAL.GetConnection();



                // verifica se conexão esta ok
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Sucesso");
                    var sql = "SELECT * " +
                        " FROM usuarios WHERE email='" + loginDTO.Email + "' AND senha='" + loginDTO.Senha + "'";
                    var retorno = new MySqlCommand(sql, conn);
                    // Envia o CommandText para o Connection e cria um SqlDataReader.
                    var reader = retorno.ExecuteReader();
                    if (reader.Read())
                    {
                        // fecha a conexão com o banaco de dados
                        conn.Close();
                        return true;
                    }
                }
            }
            catch (System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            return false;
        }
    }
}