using Microsoft.AspNetCore.Mvc;
using MinhaWebAPI.Models;
using System;

namespace MinhaWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        

        // POST api/values
        [HttpPost]
        [Route("registrarcliente")]
        public ReturnAllServices RegistrarCliente([FromBody] ClienteModel dados)
        {
            ReturnAllServices retorno = new ReturnAllServices();

            try
            {
                dados.RegistrarCliente();
                retorno.Result = true;
                retorno.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao tentar registrar um cliente: " + ex.Message;
            }

            return retorno;
        }

        // PUT api/values/5
        [HttpPut]
        [Route("atualizar/{id}")]
        public ReturnAllServices Atualizar(int id, [FromBody] ClienteModel dados)
        {
            ReturnAllServices retorno = new ReturnAllServices();

            try
            {
                dados.Id = id;
                dados.AtualizarCliente();
                retorno.Result = true;
                retorno.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao tentar atualizar um cliente: " + ex.Message;
            }

            return retorno;
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("excluir/{id}")]
        public void Excluir(int id)
        {
            new ClienteModel().Excluir(id);
        }


    }
}
