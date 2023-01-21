using System;
using System.Collections.Generic;
using System.Text;
using Telzir_Tel.DTO;
using Telzir_Tel.DAL;
using Telzir.UtilsDAL;
using System.Linq;

namespace Telzir_Tel.BLL
{
    class AplicacaoBLL
    {
        public bool AppBLL (AplicacaoDTO aplicacaoDTO)
        {

            // Encaminhar solicitação para DAL
            AplicacaoDAL aplicacaoDAL = new AplicacaoDAL();

            var Lista = aplicacaoDAL.GetdadosAplicacao(aplicacaoDTO);

            foreach (var item in Lista)
            {
                if (aplicacaoDTO.origem == item.origem && aplicacaoDTO.destino == item.destino) 
                {
                    return true;
                }

            }

            return false;
        }

    }
}
