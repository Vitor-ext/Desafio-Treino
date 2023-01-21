using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telzir.DTO;
using Telzir.DAL;
using Telzir.UtilsDAL;

namespace Telzir_crud.BLL

{

    class LoginBLL
    {
        public bool Login (LoginDTO loginDTO)
        {
            // Validar se os campos não estão preenchidos
            if (loginDTO.Email != "" || loginDTO.Senha != "")
            {
                return false;
            }

                // Encaminhar solicitação para DAL
                LoginDal loginDal = new LoginDal();

                var login = loginDal.GetDadosLogin(loginDTO);

                {

                    // Retorno do DAl tratamento 

                    if (login)
                    {
                        return true;
                    }
                    return false;
                }
        }
    }
}



